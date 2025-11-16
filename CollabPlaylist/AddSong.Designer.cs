namespace CollabPlaylist
{
    partial class AddSong
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
            this.label_Title2 = new System.Windows.Forms.Label();
            this.comboBox_PlaylistSelect = new System.Windows.Forms.ComboBox();
            this.label_Playlist = new System.Windows.Forms.Label();
            this.textBox_SongTitle = new System.Windows.Forms.TextBox();
            this.textBox_Artist = new System.Windows.Forms.TextBox();
            this.textBox_Genre = new System.Windows.Forms.TextBox();
            this.textBox_Duration = new System.Windows.Forms.TextBox();
            this.button_AddSong = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_SongTitle = new System.Windows.Forms.Label();
            this.label_Artist = new System.Windows.Forms.Label();
            this.label_Genre = new System.Windows.Forms.Label();
            this.label_Duration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Title2
            // 
            this.label_Title2.AutoSize = true;
            this.label_Title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label_Title2.Location = new System.Drawing.Point(63, 24);
            this.label_Title2.Name = "label_Title2";
            this.label_Title2.Size = new System.Drawing.Size(256, 31);
            this.label_Title2.TabIndex = 2;
            this.label_Title2.Text = "Add Song to Playlist";
            // 
            // comboBox_PlaylistSelect
            // 
            this.comboBox_PlaylistSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBox_PlaylistSelect.FormattingEnabled = true;
            this.comboBox_PlaylistSelect.Location = new System.Drawing.Point(120, 103);
            this.comboBox_PlaylistSelect.Name = "comboBox_PlaylistSelect";
            this.comboBox_PlaylistSelect.Size = new System.Drawing.Size(181, 28);
            this.comboBox_PlaylistSelect.TabIndex = 3;
            // 
            // label_Playlist
            // 
            this.label_Playlist.AutoSize = true;
            this.label_Playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_Playlist.Location = new System.Drawing.Point(26, 106);
            this.label_Playlist.Name = "label_Playlist";
            this.label_Playlist.Size = new System.Drawing.Size(68, 20);
            this.label_Playlist.TabIndex = 4;
            this.label_Playlist.Text = "Playlist:";
            // 
            // textBox_SongTitle
            // 
            this.textBox_SongTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_SongTitle.Location = new System.Drawing.Point(120, 167);
            this.textBox_SongTitle.Name = "textBox_SongTitle";
            this.textBox_SongTitle.Size = new System.Drawing.Size(181, 26);
            this.textBox_SongTitle.TabIndex = 5;
            // 
            // textBox_Artist
            // 
            this.textBox_Artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_Artist.Location = new System.Drawing.Point(120, 229);
            this.textBox_Artist.Name = "textBox_Artist";
            this.textBox_Artist.Size = new System.Drawing.Size(181, 26);
            this.textBox_Artist.TabIndex = 6;
            // 
            // textBox_Genre
            // 
            this.textBox_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_Genre.Location = new System.Drawing.Point(120, 286);
            this.textBox_Genre.Name = "textBox_Genre";
            this.textBox_Genre.Size = new System.Drawing.Size(181, 26);
            this.textBox_Genre.TabIndex = 7;
            // 
            // textBox_Duration
            // 
            this.textBox_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_Duration.Location = new System.Drawing.Point(120, 348);
            this.textBox_Duration.Name = "textBox_Duration";
            this.textBox_Duration.Size = new System.Drawing.Size(110, 26);
            this.textBox_Duration.TabIndex = 8;
            this.textBox_Duration.Text = "MM : SS";
            this.textBox_Duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_AddSong
            // 
            this.button_AddSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_AddSong.Location = new System.Drawing.Point(79, 401);
            this.button_AddSong.Name = "button_AddSong";
            this.button_AddSong.Size = new System.Drawing.Size(91, 27);
            this.button_AddSong.TabIndex = 9;
            this.button_AddSong.Text = "Add Song";
            this.button_AddSong.UseVisualStyleBackColor = true;
            this.button_AddSong.Click += new System.EventHandler(this.button_AddSong_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_Cancel.Location = new System.Drawing.Point(224, 401);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(91, 27);
            this.button_Cancel.TabIndex = 10;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label_SongTitle
            // 
            this.label_SongTitle.AutoSize = true;
            this.label_SongTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_SongTitle.Location = new System.Drawing.Point(26, 170);
            this.label_SongTitle.Name = "label_SongTitle";
            this.label_SongTitle.Size = new System.Drawing.Size(89, 20);
            this.label_SongTitle.TabIndex = 11;
            this.label_SongTitle.Text = "Song Title:";
            // 
            // label_Artist
            // 
            this.label_Artist.AutoSize = true;
            this.label_Artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_Artist.Location = new System.Drawing.Point(26, 232);
            this.label_Artist.Name = "label_Artist";
            this.label_Artist.Size = new System.Drawing.Size(54, 20);
            this.label_Artist.TabIndex = 12;
            this.label_Artist.Text = "Artist:";
            // 
            // label_Genre
            // 
            this.label_Genre.AutoSize = true;
            this.label_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_Genre.Location = new System.Drawing.Point(26, 289);
            this.label_Genre.Name = "label_Genre";
            this.label_Genre.Size = new System.Drawing.Size(60, 20);
            this.label_Genre.TabIndex = 13;
            this.label_Genre.Text = "Genre:";
            // 
            // label_Duration
            // 
            this.label_Duration.AutoSize = true;
            this.label_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_Duration.Location = new System.Drawing.Point(26, 351);
            this.label_Duration.Name = "label_Duration";
            this.label_Duration.Size = new System.Drawing.Size(78, 20);
            this.label_Duration.TabIndex = 14;
            this.label_Duration.Text = "Duration:";
            // 
            // AddSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 449);
            this.Controls.Add(this.label_Duration);
            this.Controls.Add(this.label_Genre);
            this.Controls.Add(this.label_Artist);
            this.Controls.Add(this.label_SongTitle);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_AddSong);
            this.Controls.Add(this.textBox_Duration);
            this.Controls.Add(this.textBox_Genre);
            this.Controls.Add(this.textBox_Artist);
            this.Controls.Add(this.textBox_SongTitle);
            this.Controls.Add(this.label_Playlist);
            this.Controls.Add(this.comboBox_PlaylistSelect);
            this.Controls.Add(this.label_Title2);
            this.Name = "AddSong";
            this.Text = "AddSong";
            this.Load += new System.EventHandler(this.AddSong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title2;
        private System.Windows.Forms.ComboBox comboBox_PlaylistSelect;
        private System.Windows.Forms.Label label_Playlist;
        private System.Windows.Forms.TextBox textBox_SongTitle;
        private System.Windows.Forms.TextBox textBox_Artist;
        private System.Windows.Forms.TextBox textBox_Genre;
        private System.Windows.Forms.TextBox textBox_Duration;
        private System.Windows.Forms.Button button_AddSong;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label_SongTitle;
        private System.Windows.Forms.Label label_Artist;
        private System.Windows.Forms.Label label_Genre;
        private System.Windows.Forms.Label label_Duration;
    }
}