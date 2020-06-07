using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CloneHeroExcel
{
    public partial class MainForm : Form
    {
        // Variables
        string strUserPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\LocalLow\\srylain Inc_\\Clone Hero\\scores.bin";
        string strSongPath;
        List<string[]> songMeta = new List<string[]>();

        public MainForm()
        {
            // Initialisation
            InitializeComponent();
            txtUserPath.Text = strUserPath;
        }



        public string getModifier(int value)
        {
            
            //  Get Modifier Property from Int16
            //  TODO Figure out modchart values
            string strModifiers = "";
            var dicModifiers = new Dictionary<string, int>
            {
                ["Co-Op"] = 0,
                ["NoMods"] = 1,
                ["AllStrums"] = 2,
                ["AllHopos"] = 4,
                ["AllTaps"] = 8,
                ["AllOpens"] = 16,
                ["MirrorMode"] = 32,
                ["NoteShuffle"] = 64,
                ["Hopos>Taps"] = 128
            };

            foreach (var mod in dicModifiers)
            {
                if (Convert.ToBoolean(mod.Value & value) == true)
                {
                    strModifiers = strModifiers + mod.Key;
                }
            }
            if (value == 0)
            {
                strModifiers = "Co-Op";
                return strModifiers;
            }
            else
            {
                return strModifiers;
            }
        }

        public string getInstrument(int value)
        {
            //  Get Instrument Property from Int16
            string strInstrument = "";
            var dicInstruments = new Dictionary<string, int>
            {
                ["Lead"] = 0,
                ["6Fret"] = 4,
                ["Co-Op"] = 8
            };

            foreach (var instrument in dicInstruments)
            {
                if (Convert.ToBoolean(instrument.Value & value) == true)
                {
                    strInstrument = strInstrument + instrument.Key;
                }
            }
            if (value == 0)
            {
                strInstrument = "Lead";
                return strInstrument;
            }
            else
            {
                return strInstrument;
            }
        }

        public string getDifficulty(int value)
        {
            string[] strDifficulties = { "Expert","Hard","Medium","Easy" };
            return strDifficulties[value];
        }

        static string getMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToUpper();
                }
            }
        }

        public void getMeta()
        {
            string[] directories = Directory.GetDirectories(strSongPath,"*", SearchOption.AllDirectories);

            foreach (var item in directories)
            {
                string songHash = "";
                string songName = "";
                string songArtist = "";
                string songCharter = "Unknown";

                if (File.Exists(item+"\\notes.mid"))
                {
                    songHash = getMD5(item + "\\notes.mid");
                }
                else if (File.Exists(item + "\\notes.chart"))
                {
                    songHash = getMD5(item + "\\notes.chart");
                }
                if (File.Exists(item + "\\song.ini"))
                {
                    string songData = File.ReadAllText(item + "\\song.ini");
                    string reSearch = @"name *= *(.*).*\n";
                    Match m = Regex.Match(songData, reSearch, RegexOptions.Multiline);
                    if (m.Success)
                    {
                        songName = m.Groups[1].Value;
                        songName = songName.Replace(Environment.NewLine, "");
                    }
                    reSearch = @"artist *= *(.*).*\n";
                    m = Regex.Match(songData, reSearch, RegexOptions.Multiline);
                    if (m.Success)
                    {
                        songArtist = m.Groups[1].Value;
                        songArtist = songArtist.Replace(Environment.NewLine, "");
                    }
                    reSearch = @"charter *= *(.*).*\n";
                    m = Regex.Match(songData, reSearch, RegexOptions.Multiline);
                    if (m.Success)
                    {
                        songCharter = m.Groups[1].Value;
                        songCharter = songCharter.Replace(Environment.NewLine, "");
                    }
                }

                string[] newEntry = { songHash, songName, songArtist, songCharter };
                songMeta.Add(newEntry);
            }
        }

        private void decodeBin()
        {
            // Get chunk index
            List<int> listIndex = new List<int>();
            int chIndex = 0;
            byte oldByte = 0x00;
            byte newByte = 0x00;
            byte[] scores = File.ReadAllBytes(strUserPath);
            foreach (var bit in scores)
            {
                oldByte = newByte;
                newByte = bit;
                chIndex += 1;
                if (oldByte == 0x00 && newByte == 0x20)
                {
                    listIndex.Add(chIndex);
                }
            }
            
            // Parse the chunks
            byte[] byteSongHash = new byte[32];
            byte[] buffer = new byte[2];
            byte[] byteScores = new byte[2];
            int intScores = 0;
            byte[] bytePlays = new byte[2];
            int intPlays = 0;
            byte[] byteInstrument = new byte[2];
            int intInstrument = 0;
            byte[] byteDifficulty = new byte[2];
            int intDifficulty = 0;
            byte[] bytePercent = new byte[2];
            int intPercent = 0;
            byte[] byteFullCombo = new byte[2];
            int intFullCombo = 0;
            byte[] byteSpeed = new byte[2];
            int intSpeed = 0;
            byte[] byteStars = new byte[2];
            int intStars = 0;
            byte[] byteModifiers = new byte[2];
            int intModifiers = 0;
            byte[] byteScore = new byte[4];
            int intScore = 0;

            string[] stringDifficulty = {"Expert","Hard","Medium","Easy"};

            using (Stream strm = new FileStream(strUserPath, FileMode.Open))
            {
                foreach (var intIndex in listIndex)
                {
                    strm.Seek(intIndex, 0);
                    strm.Read(byteSongHash, 0, 32);
                    strm.Read(byteScores, 0, 1);
                    intScores = BitConverter.ToInt16(byteScores, 0);
                    strm.Read(bytePlays, 0, 1);
                    intPlays = BitConverter.ToInt16(bytePlays, 0);

                    for (int i = 0; i < intScores; i++)
                    {
                        strm.Seek(intIndex + 36 + (13 * i), 0);
                        strm.Read(byteInstrument, 0, 1);
                        intInstrument = BitConverter.ToInt16(byteInstrument, 0);
                        strm.Read(buffer, 0, 1);
                        strm.Read(byteDifficulty, 0, 1);
                        intDifficulty = BitConverter.ToInt16(byteDifficulty, 0);
                        strm.Read(bytePercent, 0, 1);
                        intPercent = BitConverter.ToInt16(bytePercent, 0);
                        strm.Read(byteFullCombo, 0, 1);
                        intFullCombo = BitConverter.ToInt16(byteFullCombo, 0);
                        strm.Read(byteSpeed, 0, 1);
                        intSpeed = BitConverter.ToInt16(byteSpeed, 0);
                        strm.Read(buffer, 0, 1);
                        strm.Read(byteStars, 0, 1);
                        intStars = BitConverter.ToInt16(byteStars, 0);
                        strm.Read(byteModifiers, 0, 1);
                        intModifiers = BitConverter.ToInt16(byteModifiers, 0);
                        strm.Read(byteScore, 0, 3);
                        intScore = BitConverter.ToInt32(byteScore, 0);

                    }

                    foreach (var thing in songMeta)
                    {
                        if (thing.Contains(ASCIIEncoding.UTF8.GetString(byteSongHash)) == true)
                        {
                            gridTable.Rows.Add(thing[0],thing[2],thing[1],thing[3],intPercent,intFullCombo,intStars,intScore,getDifficulty(intDifficulty),getInstrument(intInstrument),intSpeed,getModifier(intModifiers),intPlays);
                        }
                    }
                }
            }
        }

        private void copyToClipboard()
        {
                gridTable.SelectAll();
                DataObject tableContents = gridTable.GetClipboardContent();
                Clipboard.SetDataObject(tableContents, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strUserPath = txtUserPath.Text;
            strSongPath = txtSongPath.Text;

            if (Directory.Exists(strSongPath) == false || File.Exists(strUserPath) == false)
            {
                MessageBox.Show("Check Directories!");
            }
            else
            {
                //  Clears the cache
                songMeta.Clear();
                gridTable.Rows.Clear();
                gridTable.Update();

                // Pulls score data into the table
                var LoadingForm = new LoadingForm();
                LoadingForm.Show();
                LoadingForm.lblStatus.Text = "(1/2) Collecting Meta";
                LoadingForm.Refresh();
                getMeta();      // (Hash, Title, Artist, Charter)
                LoadingForm.lblStatus.Text = "(2/2) Parsing Data";
                LoadingForm.Refresh();
                decodeBin();    // Do the Thing
                LoadingForm.Close();
            }
        }

        private void btnUserBrowse_Click(object sender, EventArgs e)
        {
            // Browse for scores Directory
            fileScores.Filter = "scores.bin | scores.bin";
            if (fileScores.ShowDialog() == DialogResult.OK)
            {
                strUserPath = fileScores.FileName;
                txtUserPath.Text = strUserPath;
            }
        }

        private void btnSongBrowse_Click(object sender, EventArgs e)
        {
            // Browse for songs Directory
            if (folderSongs.ShowDialog() == DialogResult.OK)
            {
                strSongPath = folderSongs.SelectedPath;
                txtSongPath.Text = strSongPath;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (gridTable.Rows.Count == 0)
            {
                MessageBox.Show("No data!");
            }
            else
            {
                var LoadingForm = new LoadingForm();
                LoadingForm.Show();
                LoadingForm.lblStatus.Text = "Copying...";
                LoadingForm.Refresh();
                copyToClipboard();
                LoadingForm.Close();
            }
        }
    }
}
