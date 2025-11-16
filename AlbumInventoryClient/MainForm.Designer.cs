using System.Drawing;
using System.Windows.Forms;

namespace AlbumInventoryClient
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
            this.dgvAlbums = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.button_Return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlbums
            // 
            this.dgvAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbums.Location = new System.Drawing.Point(348, 19);
            this.dgvAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAlbums.Name = "dgvAlbums";
            this.dgvAlbums.RowHeadersWidth = 62;
            this.dgvAlbums.Size = new System.Drawing.Size(915, 370);
            this.dgvAlbums.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(440, 430);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 53);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(664, 430);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 53);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(881, 430);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(132, 53);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(1111, 430);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(132, 53);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblId.Location = new System.Drawing.Point(31, 77);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 30);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTitle.Location = new System.Drawing.Point(31, 129);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(59, 30);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblArtist.Location = new System.Drawing.Point(31, 180);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(68, 30);
            this.lblArtist.TabIndex = 2;
            this.lblArtist.Text = "Artist:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblGenre.Location = new System.Drawing.Point(31, 239);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(77, 30);
            this.lblGenre.TabIndex = 2;
            this.lblGenre.Text = "Genre:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblYear.Location = new System.Drawing.Point(31, 303);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(59, 30);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(180, 76);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(135, 26);
            this.txtId.TabIndex = 3;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(180, 129);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(135, 26);
            this.txtTitle.TabIndex = 3;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(180, 179);
            this.txtArtist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(135, 26);
            this.txtArtist.TabIndex = 3;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(180, 238);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(135, 26);
            this.txtGenre.TabIndex = 3;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(180, 302);
            this.txtYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(135, 26);
            this.txtYear.TabIndex = 3;
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkAvailable.Location = new System.Drawing.Point(120, 369);
            this.chkAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(118, 32);
            this.chkAvailable.TabIndex = 4;
            this.chkAvailable.Text = "Available";
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblStatus.Location = new System.Drawing.Point(50, 412);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 30);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status:";
            // 
            // button_Return
            // 
            this.button_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button_Return.Location = new System.Drawing.Point(13, 19);
            this.button_Return.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(58, 55);
            this.button_Return.TabIndex = 51;
            this.button_Return.Text = "←";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 542);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.chkAvailable);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvAlbums);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvAlbums;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btn_Delete;
        private Button btn_Refresh;
        private Label lblId;
        private Label lblTitle;
        private Label lblArtist;
        private Label lblGenre;
        private Label lblYear;
        private TextBox txtId;
        private TextBox txtTitle;
        private TextBox txtArtist;
        private TextBox txtGenre;
        private TextBox txtYear;
        private CheckBox chkAvailable;
        private Label lblStatus;
        private Button button_Return;
    }
}