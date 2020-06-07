namespace CloneHeroExcel
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSongBrowse = new System.Windows.Forms.Button();
            this.btnUserBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSongPath = new System.Windows.Forms.TextBox();
            this.txtUserPath = new System.Windows.Forms.TextBox();
            this.folderSongs = new System.Windows.Forms.FolderBrowserDialog();
            this.fileScores = new System.Windows.Forms.OpenFileDialog();
            this.gridTable = new System.Windows.Forms.DataGridView();
            this.btnCopy = new System.Windows.Forms.Button();
            this.gridHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCharter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridFullCombo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridStars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridDifficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridInstrument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridModifiers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPlayCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(389, 18);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 47);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Grab\r\nScores";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSongBrowse);
            this.groupBox1.Controls.Add(this.btnUserBrowse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSongPath);
            this.groupBox1.Controls.Add(this.txtUserPath);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directories";
            // 
            // btnSongBrowse
            // 
            this.btnSongBrowse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSongBrowse.Location = new System.Drawing.Point(280, 69);
            this.btnSongBrowse.Name = "btnSongBrowse";
            this.btnSongBrowse.Size = new System.Drawing.Size(77, 23);
            this.btnSongBrowse.TabIndex = 5;
            this.btnSongBrowse.Text = "Browse";
            this.btnSongBrowse.UseVisualStyleBackColor = true;
            this.btnSongBrowse.Click += new System.EventHandler(this.btnSongBrowse_Click);
            // 
            // btnUserBrowse
            // 
            this.btnUserBrowse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUserBrowse.Location = new System.Drawing.Point(280, 30);
            this.btnUserBrowse.Name = "btnUserBrowse";
            this.btnUserBrowse.Size = new System.Drawing.Size(77, 23);
            this.btnUserBrowse.TabIndex = 4;
            this.btnUserBrowse.Text = "Browse";
            this.btnUserBrowse.UseVisualStyleBackColor = true;
            this.btnUserBrowse.Click += new System.EventHandler(this.btnUserBrowse_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Songs";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scores";
            // 
            // txtSongPath
            // 
            this.txtSongPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSongPath.Location = new System.Drawing.Point(9, 71);
            this.txtSongPath.Name = "txtSongPath";
            this.txtSongPath.Size = new System.Drawing.Size(262, 20);
            this.txtSongPath.TabIndex = 1;
            // 
            // txtUserPath
            // 
            this.txtUserPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUserPath.Location = new System.Drawing.Point(9, 32);
            this.txtUserPath.Name = "txtUserPath";
            this.txtUserPath.Size = new System.Drawing.Size(262, 20);
            this.txtUserPath.TabIndex = 0;
            // 
            // folderSongs
            // 
            this.folderSongs.ShowNewFolderButton = false;
            // 
            // fileScores
            // 
            this.fileScores.FileName = "openFileDialog1";
            // 
            // gridTable
            // 
            this.gridTable.AllowUserToAddRows = false;
            this.gridTable.AllowUserToDeleteRows = false;
            this.gridTable.AllowUserToOrderColumns = true;
            this.gridTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.gridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridHash,
            this.gridArtist,
            this.gridName,
            this.gridCharter,
            this.gridPercent,
            this.gridFullCombo,
            this.gridStars,
            this.gridScore,
            this.gridDifficulty,
            this.gridInstrument,
            this.gridSpeed,
            this.gridModifiers,
            this.gridPlayCount});
            this.gridTable.Location = new System.Drawing.Point(12, 121);
            this.gridTable.Name = "gridTable";
            this.gridTable.Size = new System.Drawing.Size(451, 346);
            this.gridTable.TabIndex = 2;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(389, 67);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 47);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy to\r\nClipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // gridHash
            // 
            this.gridHash.HeaderText = "Hash";
            this.gridHash.Name = "gridHash";
            // 
            // gridArtist
            // 
            this.gridArtist.HeaderText = "Artist";
            this.gridArtist.Name = "gridArtist";
            // 
            // gridName
            // 
            this.gridName.HeaderText = "Name";
            this.gridName.Name = "gridName";
            // 
            // gridCharter
            // 
            this.gridCharter.HeaderText = "Charter";
            this.gridCharter.Name = "gridCharter";
            // 
            // gridPercent
            // 
            this.gridPercent.HeaderText = "%";
            this.gridPercent.Name = "gridPercent";
            this.gridPercent.Width = 40;
            // 
            // gridFullCombo
            // 
            this.gridFullCombo.HeaderText = "FC";
            this.gridFullCombo.Name = "gridFullCombo";
            this.gridFullCombo.Width = 40;
            // 
            // gridStars
            // 
            this.gridStars.HeaderText = "*";
            this.gridStars.Name = "gridStars";
            this.gridStars.Width = 40;
            // 
            // gridScore
            // 
            this.gridScore.HeaderText = "Score";
            this.gridScore.Name = "gridScore";
            // 
            // gridDifficulty
            // 
            this.gridDifficulty.HeaderText = "Diff";
            this.gridDifficulty.Name = "gridDifficulty";
            this.gridDifficulty.Width = 40;
            // 
            // gridInstrument
            // 
            this.gridInstrument.HeaderText = "Instr";
            this.gridInstrument.Name = "gridInstrument";
            this.gridInstrument.Width = 40;
            // 
            // gridSpeed
            // 
            this.gridSpeed.HeaderText = "Speed";
            this.gridSpeed.Name = "gridSpeed";
            this.gridSpeed.Width = 40;
            // 
            // gridModifiers
            // 
            this.gridModifiers.HeaderText = "Mods";
            this.gridModifiers.Name = "gridModifiers";
            this.gridModifiers.Width = 40;
            // 
            // gridPlayCount
            // 
            this.gridPlayCount.HeaderText = "Plays";
            this.gridPlayCount.Name = "gridPlayCount";
            this.gridPlayCount.Width = 40;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 476);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.gridTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CloneHeroScoreExporter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSongPath;
        private System.Windows.Forms.TextBox txtUserPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSongBrowse;
        private System.Windows.Forms.Button btnUserBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderSongs;
        private System.Windows.Forms.OpenFileDialog fileScores;
        private System.Windows.Forms.DataGridView gridTable;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCharter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridFullCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridStars;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridDifficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridInstrument;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridModifiers;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPlayCount;
    }
}

