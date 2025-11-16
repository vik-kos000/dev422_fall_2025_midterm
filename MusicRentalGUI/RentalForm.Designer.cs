namespace MusicRentalGUI
{
    partial class RentalForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_userID = new System.Windows.Forms.TextBox();
            this.textBox_albumTitle = new System.Windows.Forms.TextBox();
            this.textBox_albumID = new System.Windows.Forms.TextBox();
            this.textBox_albumArtist = new System.Windows.Forms.TextBox();
            this.button_returnAlbum = new System.Windows.Forms.Button();
            this.button_viewActiveRentals = new System.Windows.Forms.Button();
            this.button_rentAlbum = new System.Windows.Forms.Button();
            this.button_listAlbums = new System.Windows.Forms.Button();
            this.listBox_displayInformation = new System.Windows.Forms.ListBox();
            this.button_addAlbum = new System.Windows.Forms.Button();
            this.textBox_albumYear = new System.Windows.Forms.TextBox();
            this.textBox_albumGenre = new System.Windows.Forms.TextBox();
            this.button_deleteAlbum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.button_Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Album Information:";
            // 
            // textBox_userID
            // 
            this.textBox_userID.Location = new System.Drawing.Point(32, 178);
            this.textBox_userID.Name = "textBox_userID";
            this.textBox_userID.Size = new System.Drawing.Size(143, 26);
            this.textBox_userID.TabIndex = 39;
            // 
            // textBox_albumTitle
            // 
            this.textBox_albumTitle.Location = new System.Drawing.Point(32, 119);
            this.textBox_albumTitle.Name = "textBox_albumTitle";
            this.textBox_albumTitle.Size = new System.Drawing.Size(143, 26);
            this.textBox_albumTitle.TabIndex = 37;
            // 
            // textBox_albumID
            // 
            this.textBox_albumID.Location = new System.Drawing.Point(181, 178);
            this.textBox_albumID.Name = "textBox_albumID";
            this.textBox_albumID.Size = new System.Drawing.Size(143, 26);
            this.textBox_albumID.TabIndex = 36;
            // 
            // textBox_albumArtist
            // 
            this.textBox_albumArtist.Location = new System.Drawing.Point(181, 119);
            this.textBox_albumArtist.Name = "textBox_albumArtist";
            this.textBox_albumArtist.Size = new System.Drawing.Size(143, 26);
            this.textBox_albumArtist.TabIndex = 34;
            // 
            // button_returnAlbum
            // 
            this.button_returnAlbum.Location = new System.Drawing.Point(480, 174);
            this.button_returnAlbum.Name = "button_returnAlbum";
            this.button_returnAlbum.Size = new System.Drawing.Size(134, 35);
            this.button_returnAlbum.TabIndex = 31;
            this.button_returnAlbum.Text = "Return Album";
            this.button_returnAlbum.UseVisualStyleBackColor = true;
            this.button_returnAlbum.Click += new System.EventHandler(this.button_returnAlbum_Click);
            // 
            // button_viewActiveRentals
            // 
            this.button_viewActiveRentals.Location = new System.Drawing.Point(640, 321);
            this.button_viewActiveRentals.Name = "button_viewActiveRentals";
            this.button_viewActiveRentals.Size = new System.Drawing.Size(134, 52);
            this.button_viewActiveRentals.TabIndex = 30;
            this.button_viewActiveRentals.Text = "View Active Rentals";
            this.button_viewActiveRentals.UseVisualStyleBackColor = true;
            this.button_viewActiveRentals.Click += new System.EventHandler(this.button_viewActiveRentals_Click);
            // 
            // button_rentAlbum
            // 
            this.button_rentAlbum.Location = new System.Drawing.Point(340, 174);
            this.button_rentAlbum.Name = "button_rentAlbum";
            this.button_rentAlbum.Size = new System.Drawing.Size(134, 35);
            this.button_rentAlbum.TabIndex = 28;
            this.button_rentAlbum.Text = "Rent Album";
            this.button_rentAlbum.UseVisualStyleBackColor = true;
            this.button_rentAlbum.Click += new System.EventHandler(this.button_rentAlbum_Click);
            // 
            // button_listAlbums
            // 
            this.button_listAlbums.Location = new System.Drawing.Point(640, 245);
            this.button_listAlbums.Name = "button_listAlbums";
            this.button_listAlbums.Size = new System.Drawing.Size(134, 58);
            this.button_listAlbums.TabIndex = 27;
            this.button_listAlbums.Text = "List Avaliable Albums";
            this.button_listAlbums.UseVisualStyleBackColor = true;
            this.button_listAlbums.Click += new System.EventHandler(this.button_listAlbums_Click);
            // 
            // listBox_displayInformation
            // 
            this.listBox_displayInformation.FormattingEnabled = true;
            this.listBox_displayInformation.ItemHeight = 20;
            this.listBox_displayInformation.Location = new System.Drawing.Point(23, 229);
            this.listBox_displayInformation.Name = "listBox_displayInformation";
            this.listBox_displayInformation.Size = new System.Drawing.Size(591, 264);
            this.listBox_displayInformation.TabIndex = 26;
            // 
            // button_addAlbum
            // 
            this.button_addAlbum.Location = new System.Drawing.Point(640, 112);
            this.button_addAlbum.Name = "button_addAlbum";
            this.button_addAlbum.Size = new System.Drawing.Size(134, 33);
            this.button_addAlbum.TabIndex = 25;
            this.button_addAlbum.Text = "Add Album";
            this.button_addAlbum.UseVisualStyleBackColor = true;
            this.button_addAlbum.Click += new System.EventHandler(this.button_addAlbum_Click);
            // 
            // textBox_albumYear
            // 
            this.textBox_albumYear.Location = new System.Drawing.Point(479, 119);
            this.textBox_albumYear.Name = "textBox_albumYear";
            this.textBox_albumYear.Size = new System.Drawing.Size(143, 26);
            this.textBox_albumYear.TabIndex = 24;
            // 
            // textBox_albumGenre
            // 
            this.textBox_albumGenre.Location = new System.Drawing.Point(330, 119);
            this.textBox_albumGenre.Name = "textBox_albumGenre";
            this.textBox_albumGenre.Size = new System.Drawing.Size(143, 26);
            this.textBox_albumGenre.TabIndex = 41;
            this.textBox_albumGenre.TextChanged += new System.EventHandler(this.textBox_albumGenre_TextChanged);
            // 
            // button_deleteAlbum
            // 
            this.button_deleteAlbum.Location = new System.Drawing.Point(640, 176);
            this.button_deleteAlbum.Name = "button_deleteAlbum";
            this.button_deleteAlbum.Size = new System.Drawing.Size(134, 33);
            this.button_deleteAlbum.TabIndex = 42;
            this.button_deleteAlbum.Text = "Delete Album";
            this.button_deleteAlbum.UseVisualStyleBackColor = true;
            this.button_deleteAlbum.Click += new System.EventHandler(this.button_deleteAlbum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Album ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Artist";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Title";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label_Title.Location = new System.Drawing.Point(223, 10);
            this.label_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(296, 47);
            this.label_Title.TabIndex = 50;
            this.label_Title.Text = "Rent An Album";
            // 
            // button_Return
            // 
            this.button_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button_Return.Location = new System.Drawing.Point(7, 2);
            this.button_Return.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(58, 55);
            this.button_Return.TabIndex = 49;
            this.button_Return.Text = "←";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 526);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_deleteAlbum);
            this.Controls.Add(this.textBox_albumGenre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_userID);
            this.Controls.Add(this.textBox_albumTitle);
            this.Controls.Add(this.textBox_albumID);
            this.Controls.Add(this.textBox_albumArtist);
            this.Controls.Add(this.button_returnAlbum);
            this.Controls.Add(this.button_viewActiveRentals);
            this.Controls.Add(this.button_rentAlbum);
            this.Controls.Add(this.button_listAlbums);
            this.Controls.Add(this.listBox_displayInformation);
            this.Controls.Add(this.button_addAlbum);
            this.Controls.Add(this.textBox_albumYear);
            this.Name = "RentalForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_userID;
        private System.Windows.Forms.TextBox textBox_albumTitle;
        private System.Windows.Forms.TextBox textBox_albumID;
        private System.Windows.Forms.TextBox textBox_albumArtist;
        private System.Windows.Forms.Button button_returnAlbum;
        private System.Windows.Forms.Button button_viewActiveRentals;
        private System.Windows.Forms.Button button_rentAlbum;
        private System.Windows.Forms.Button button_listAlbums;
        private System.Windows.Forms.ListBox listBox_displayInformation;
        private System.Windows.Forms.Button button_addAlbum;
        private System.Windows.Forms.TextBox textBox_albumYear;
        private System.Windows.Forms.TextBox textBox_albumGenre;
        private System.Windows.Forms.Button button_deleteAlbum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button button_Return;
    }
}

