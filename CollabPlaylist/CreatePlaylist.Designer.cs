namespace CollabPlaylist
{
    partial class CreatePlaylist
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
            this.label_PlaylistName = new System.Windows.Forms.Label();
            this.textBox_PlaylistName = new System.Windows.Forms.TextBox();
            this.checkBox_Collaborative = new System.Windows.Forms.CheckBox();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Title2
            // 
            this.label_Title2.AutoSize = true;
            this.label_Title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label_Title2.Location = new System.Drawing.Point(112, 18);
            this.label_Title2.Name = "label_Title2";
            this.label_Title2.Size = new System.Drawing.Size(252, 31);
            this.label_Title2.TabIndex = 1;
            this.label_Title2.Text = "Create New Playlist";
            // 
            // label_PlaylistName
            // 
            this.label_PlaylistName.AutoSize = true;
            this.label_PlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_PlaylistName.Location = new System.Drawing.Point(68, 102);
            this.label_PlaylistName.Name = "label_PlaylistName";
            this.label_PlaylistName.Size = new System.Drawing.Size(122, 20);
            this.label_PlaylistName.TabIndex = 2;
            this.label_PlaylistName.Text = "Playlist Name: ";
            // 
            // textBox_PlaylistName
            // 
            this.textBox_PlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox_PlaylistName.Location = new System.Drawing.Point(196, 99);
            this.textBox_PlaylistName.Name = "textBox_PlaylistName";
            this.textBox_PlaylistName.Size = new System.Drawing.Size(183, 26);
            this.textBox_PlaylistName.TabIndex = 3;
            // 
            // checkBox_Collaborative
            // 
            this.checkBox_Collaborative.AutoSize = true;
            this.checkBox_Collaborative.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.checkBox_Collaborative.Location = new System.Drawing.Point(71, 162);
            this.checkBox_Collaborative.Name = "checkBox_Collaborative";
            this.checkBox_Collaborative.Size = new System.Drawing.Size(184, 24);
            this.checkBox_Collaborative.TabIndex = 4;
            this.checkBox_Collaborative.Text = "Collaborative Playlist";
            this.checkBox_Collaborative.UseVisualStyleBackColor = true;
            // 
            // button_Create
            // 
            this.button_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_Create.Location = new System.Drawing.Point(90, 228);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(75, 28);
            this.button_Create.TabIndex = 5;
            this.button_Create.Text = "Create";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_Cancel.Location = new System.Drawing.Point(246, 228);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 28);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // CreatePlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 338);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.checkBox_Collaborative);
            this.Controls.Add(this.textBox_PlaylistName);
            this.Controls.Add(this.label_PlaylistName);
            this.Controls.Add(this.label_Title2);
            this.Name = "CreatePlaylist";
            this.Text = "CreatePlaylist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title2;
        private System.Windows.Forms.Label label_PlaylistName;
        private System.Windows.Forms.TextBox textBox_PlaylistName;
        private System.Windows.Forms.CheckBox checkBox_Collaborative;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_Cancel;
    }
}