namespace CollabPlaylist
{
    partial class Form2_PlaylistBuilder
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
            this.label_Title = new System.Windows.Forms.Label();
            this.dataGridView_Playlists = new System.Windows.Forms.DataGridView();
            this.button_CreatePlaylist = new System.Windows.Forms.Button();
            this.button_AddSong = new System.Windows.Forms.Button();
            this.button_Invite = new System.Windows.Forms.Button();
            this.button_Vote = new System.Windows.Forms.Button();
            this.button_Rankings = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.label_LoggedInUser = new System.Windows.Forms.Label();
            this.button_Return = new System.Windows.Forms.Button();
            this.PlaylistId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaylistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCollaborative = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Playlists)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label_Title.Location = new System.Drawing.Point(231, 29);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(324, 31);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "VibeHive - Playlist Builder";
            // 
            // dataGridView_Playlists
            // 
            this.dataGridView_Playlists.AllowUserToAddRows = false;
            this.dataGridView_Playlists.AllowUserToDeleteRows = false;
            this.dataGridView_Playlists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Playlists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Playlists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlaylistId,
            this.PlaylistName,
            this.CreatedBy,
            this.SongCount,
            this.IsCollaborative});
            this.dataGridView_Playlists.Location = new System.Drawing.Point(169, 74);
            this.dataGridView_Playlists.MultiSelect = false;
            this.dataGridView_Playlists.Name = "dataGridView_Playlists";
            this.dataGridView_Playlists.ReadOnly = true;
            this.dataGridView_Playlists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Playlists.Size = new System.Drawing.Size(447, 221);
            this.dataGridView_Playlists.TabIndex = 1;
            // 
            // button_CreatePlaylist
            // 
            this.button_CreatePlaylist.Location = new System.Drawing.Point(52, 336);
            this.button_CreatePlaylist.Name = "button_CreatePlaylist";
            this.button_CreatePlaylist.Size = new System.Drawing.Size(178, 35);
            this.button_CreatePlaylist.TabIndex = 2;
            this.button_CreatePlaylist.Text = "Create Playlist";
            this.button_CreatePlaylist.UseVisualStyleBackColor = true;
            this.button_CreatePlaylist.Click += new System.EventHandler(this.button_CreatePlaylist_Click);
            // 
            // button_AddSong
            // 
            this.button_AddSong.Location = new System.Drawing.Point(309, 336);
            this.button_AddSong.Name = "button_AddSong";
            this.button_AddSong.Size = new System.Drawing.Size(178, 35);
            this.button_AddSong.TabIndex = 3;
            this.button_AddSong.Text = "Add Song";
            this.button_AddSong.UseVisualStyleBackColor = true;
            this.button_AddSong.Click += new System.EventHandler(this.button_AddSong_Click);
            // 
            // button_Invite
            // 
            this.button_Invite.Location = new System.Drawing.Point(548, 336);
            this.button_Invite.Name = "button_Invite";
            this.button_Invite.Size = new System.Drawing.Size(178, 35);
            this.button_Invite.TabIndex = 4;
            this.button_Invite.Text = "Invite Collaborator";
            this.button_Invite.UseVisualStyleBackColor = true;
            this.button_Invite.Click += new System.EventHandler(this.button_Invite_Click);
            // 
            // button_Vote
            // 
            this.button_Vote.Location = new System.Drawing.Point(52, 386);
            this.button_Vote.Name = "button_Vote";
            this.button_Vote.Size = new System.Drawing.Size(178, 35);
            this.button_Vote.TabIndex = 5;
            this.button_Vote.Text = "Vote on Songs";
            this.button_Vote.UseVisualStyleBackColor = true;
            this.button_Vote.Click += new System.EventHandler(this.button_Vote_Click);
            // 
            // button_Rankings
            // 
            this.button_Rankings.Location = new System.Drawing.Point(309, 386);
            this.button_Rankings.Name = "button_Rankings";
            this.button_Rankings.Size = new System.Drawing.Size(178, 35);
            this.button_Rankings.TabIndex = 6;
            this.button_Rankings.Text = "View Rankings";
            this.button_Rankings.UseVisualStyleBackColor = true;
            this.button_Rankings.Click += new System.EventHandler(this.button_Rankings_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(548, 386);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(178, 35);
            this.button_Refresh.TabIndex = 7;
            this.button_Refresh.Text = "Refresh List";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // label_LoggedInUser
            // 
            this.label_LoggedInUser.AutoSize = true;
            this.label_LoggedInUser.Location = new System.Drawing.Point(49, 441);
            this.label_LoggedInUser.Name = "label_LoggedInUser";
            this.label_LoggedInUser.Size = new System.Drawing.Size(71, 13);
            this.label_LoggedInUser.TabIndex = 8;
            this.label_LoggedInUser.Text = "Logged in as:";
            // 
            // button_Return
            // 
            this.button_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button_Return.Location = new System.Drawing.Point(12, 12);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(39, 36);
            this.button_Return.TabIndex = 9;
            this.button_Return.Text = "←";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // PlaylistId
            // 
            this.PlaylistId.HeaderText = "Playlist ID";
            this.PlaylistId.Name = "PlaylistId";
            this.PlaylistId.ReadOnly = true;
            this.PlaylistId.Visible = false;
            // 
            // PlaylistName
            // 
            this.PlaylistName.HeaderText = "Playlist Name";
            this.PlaylistName.Name = "PlaylistName";
            this.PlaylistName.ReadOnly = true;
            // 
            // CreatedBy
            // 
            this.CreatedBy.HeaderText = "Created By";
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.ReadOnly = true;
            // 
            // SongCount
            // 
            this.SongCount.HeaderText = "Song Count";
            this.SongCount.Name = "SongCount";
            this.SongCount.ReadOnly = true;
            // 
            // IsCollaborative
            // 
            this.IsCollaborative.HeaderText = "Collaborative";
            this.IsCollaborative.Name = "IsCollaborative";
            this.IsCollaborative.ReadOnly = true;
            this.IsCollaborative.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsCollaborative.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form2_PlaylistBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.label_LoggedInUser);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_Rankings);
            this.Controls.Add(this.button_Vote);
            this.Controls.Add(this.button_Invite);
            this.Controls.Add(this.button_AddSong);
            this.Controls.Add(this.button_CreatePlaylist);
            this.Controls.Add(this.dataGridView_Playlists);
            this.Controls.Add(this.label_Title);
            this.Name = "Form2_PlaylistBuilder";
            this.Text = "Form2_PlaylistBuilder";
            this.Load += new System.EventHandler(this.Form2_PlaylistBuilder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Playlists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.DataGridView dataGridView_Playlists;
        private System.Windows.Forms.Button button_CreatePlaylist;
        private System.Windows.Forms.Button button_AddSong;
        private System.Windows.Forms.Button button_Invite;
        private System.Windows.Forms.Button button_Vote;
        private System.Windows.Forms.Button button_Rankings;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Label label_LoggedInUser;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaylistId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaylistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsCollaborative;
    }
}