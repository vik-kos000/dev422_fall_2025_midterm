namespace CollabPlaylist
{
    partial class Form1
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
            this.label_Title1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlbumInventoryMicroservice = new System.Windows.Forms.Button();
            this.button_rentAnAlbum = new System.Windows.Forms.Button();
            this.button_EventTicketing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Title1
            // 
            this.label_Title1.AutoSize = true;
            this.label_Title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label_Title1.Location = new System.Drawing.Point(484, 34);
            this.label_Title1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Title1.Name = "label_Title1";
            this.label_Title1.Size = new System.Drawing.Size(187, 47);
            this.label_Title1.TabIndex = 1;
            this.label_Title1.Text = "VibeHive";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(484, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "VibeHive";
            // 
            // btnAlbumInventoryMicroservice
            // 
            this.btnAlbumInventoryMicroservice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAlbumInventoryMicroservice.Location = new System.Drawing.Point(804, 122);
            this.btnAlbumInventoryMicroservice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlbumInventoryMicroservice.Name = "btnAlbumInventoryMicroservice";
            this.btnAlbumInventoryMicroservice.Size = new System.Drawing.Size(296, 125);
            this.btnAlbumInventoryMicroservice.TabIndex = 0;
            this.btnAlbumInventoryMicroservice.Text = "Album Inventory Microservice";
            this.btnAlbumInventoryMicroservice.UseVisualStyleBackColor = true;
            this.btnAlbumInventoryMicroservice.Click += new System.EventHandler(this.btnAlbumInventoryMicroservice_Click);
            // 
            // button_rentAnAlbum
            // 
            this.button_rentAnAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_rentAnAlbum.Location = new System.Drawing.Point(41, 122);
            this.button_rentAnAlbum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_rentAnAlbum.Name = "button_rentAnAlbum";
            this.button_rentAnAlbum.Size = new System.Drawing.Size(296, 125);
            this.button_rentAnAlbum.TabIndex = 2;
            this.button_rentAnAlbum.Text = "Rent an Album";
            this.button_rentAnAlbum.UseVisualStyleBackColor = true;
            this.button_rentAnAlbum.Click += new System.EventHandler(this.button_rentAnAlbum_Click);
            // 
            // button_EventTicketing
            // 
            this.button_EventTicketing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_EventTicketing.Location = new System.Drawing.Point(440, 122);
            this.button_EventTicketing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_EventTicketing.Name = "button_EventTicketing";
            this.button_EventTicketing.Size = new System.Drawing.Size(296, 125);
            this.button_EventTicketing.TabIndex = 3;
            this.button_EventTicketing.Text = "Collaborative Playlist Builder";
            this.button_EventTicketing.UseVisualStyleBackColor = true;
            this.button_EventTicketing.Click += new System.EventHandler(this.button_EventTicketing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 307);
            this.Controls.Add(this.button_EventTicketing);
            this.Controls.Add(this.button_rentAnAlbum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Title1);
            this.Controls.Add(this.btnAlbumInventoryMicroservice);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Title1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlbumInventoryMicroservice;
        private System.Windows.Forms.Button button_rentAnAlbum;
        private System.Windows.Forms.Button button_EventTicketing;
    }
}

