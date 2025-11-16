namespace CollabPlaylist
{
    partial class InviteCollaborator
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
            this.textBox_InviteUsername = new System.Windows.Forms.TextBox();
            this.button_SendInvite = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_Playlist = new System.Windows.Forms.Label();
            this.label_InviteUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Title2
            // 
            this.label_Title2.AutoSize = true;
            this.label_Title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label_Title2.Location = new System.Drawing.Point(111, 25);
            this.label_Title2.Name = "label_Title2";
            this.label_Title2.Size = new System.Drawing.Size(235, 31);
            this.label_Title2.TabIndex = 2;
            this.label_Title2.Text = "Invite Collaborator";
            // 
            // comboBox_PlaylistSelect
            // 
            this.comboBox_PlaylistSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBox_PlaylistSelect.FormattingEnabled = true;
            this.comboBox_PlaylistSelect.Location = new System.Drawing.Point(143, 105);
            this.comboBox_PlaylistSelect.Name = "comboBox_PlaylistSelect";
            this.comboBox_PlaylistSelect.Size = new System.Drawing.Size(160, 28);
            this.comboBox_PlaylistSelect.TabIndex = 3;
            // 
            // textBox_InviteUsername
            // 
            this.textBox_InviteUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_InviteUsername.Location = new System.Drawing.Point(143, 160);
            this.textBox_InviteUsername.Name = "textBox_InviteUsername";
            this.textBox_InviteUsername.Size = new System.Drawing.Size(160, 26);
            this.textBox_InviteUsername.TabIndex = 4;
            // 
            // button_SendInvite
            // 
            this.button_SendInvite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_SendInvite.Location = new System.Drawing.Point(106, 218);
            this.button_SendInvite.Name = "button_SendInvite";
            this.button_SendInvite.Size = new System.Drawing.Size(103, 29);
            this.button_SendInvite.TabIndex = 5;
            this.button_SendInvite.Text = "Send Invite";
            this.button_SendInvite.UseVisualStyleBackColor = true;
            this.button_SendInvite.Click += new System.EventHandler(this.button_SendInvite_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_Cancel.Location = new System.Drawing.Point(217, 218);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(103, 29);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label_Playlist
            // 
            this.label_Playlist.AutoSize = true;
            this.label_Playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_Playlist.Location = new System.Drawing.Point(43, 108);
            this.label_Playlist.Name = "label_Playlist";
            this.label_Playlist.Size = new System.Drawing.Size(68, 20);
            this.label_Playlist.TabIndex = 7;
            this.label_Playlist.Text = "Playlist:";
            // 
            // label_InviteUser
            // 
            this.label_InviteUser.AutoSize = true;
            this.label_InviteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_InviteUser.Location = new System.Drawing.Point(43, 163);
            this.label_InviteUser.Name = "label_InviteUser";
            this.label_InviteUser.Size = new System.Drawing.Size(94, 20);
            this.label_InviteUser.TabIndex = 8;
            this.label_InviteUser.Text = "Invite User:";
            // 
            // InviteCollaborator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 273);
            this.Controls.Add(this.label_InviteUser);
            this.Controls.Add(this.label_Playlist);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_SendInvite);
            this.Controls.Add(this.textBox_InviteUsername);
            this.Controls.Add(this.comboBox_PlaylistSelect);
            this.Controls.Add(this.label_Title2);
            this.Name = "InviteCollaborator";
            this.Text = "InviteCollaborator";
            this.Load += new System.EventHandler(this.InviteCollaborator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title2;
        private System.Windows.Forms.ComboBox comboBox_PlaylistSelect;
        private System.Windows.Forms.TextBox textBox_InviteUsername;
        private System.Windows.Forms.Button button_SendInvite;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label_Playlist;
        private System.Windows.Forms.Label label_InviteUser;
    }
}