namespace CollabPlaylist
{
    partial class Rankings
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
            this.label_PlaylistSelect = new System.Windows.Forms.Label();
            this.comboBox_PlaylistSelect = new System.Windows.Forms.ComboBox();
            this.dataGridView_Rankings = new System.Windows.Forms.DataGridView();
            this.button_RefreshRankings = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Votes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rankings)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title2
            // 
            this.label_Title2.AutoSize = true;
            this.label_Title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label_Title2.Location = new System.Drawing.Point(154, 43);
            this.label_Title2.Name = "label_Title2";
            this.label_Title2.Size = new System.Drawing.Size(222, 31);
            this.label_Title2.TabIndex = 2;
            this.label_Title2.Text = "Playlist Rankings";
            // 
            // label_PlaylistSelect
            // 
            this.label_PlaylistSelect.AutoSize = true;
            this.label_PlaylistSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_PlaylistSelect.Location = new System.Drawing.Point(86, 118);
            this.label_PlaylistSelect.Name = "label_PlaylistSelect";
            this.label_PlaylistSelect.Size = new System.Drawing.Size(68, 20);
            this.label_PlaylistSelect.TabIndex = 3;
            this.label_PlaylistSelect.Text = "Playlist:";
            // 
            // comboBox_PlaylistSelect
            // 
            this.comboBox_PlaylistSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBox_PlaylistSelect.FormattingEnabled = true;
            this.comboBox_PlaylistSelect.Location = new System.Drawing.Point(160, 115);
            this.comboBox_PlaylistSelect.Name = "comboBox_PlaylistSelect";
            this.comboBox_PlaylistSelect.Size = new System.Drawing.Size(216, 28);
            this.comboBox_PlaylistSelect.TabIndex = 4;
            // 
            // dataGridView_Rankings
            // 
            this.dataGridView_Rankings.AllowUserToAddRows = false;
            this.dataGridView_Rankings.AllowUserToDeleteRows = false;
            this.dataGridView_Rankings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Rankings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Rankings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rank,
            this.Title,
            this.Artist,
            this.Votes});
            this.dataGridView_Rankings.Location = new System.Drawing.Point(45, 164);
            this.dataGridView_Rankings.Name = "dataGridView_Rankings";
            this.dataGridView_Rankings.ReadOnly = true;
            this.dataGridView_Rankings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Rankings.Size = new System.Drawing.Size(445, 210);
            this.dataGridView_Rankings.TabIndex = 5;
            // 
            // button_RefreshRankings
            // 
            this.button_RefreshRankings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_RefreshRankings.Location = new System.Drawing.Point(79, 395);
            this.button_RefreshRankings.Name = "button_RefreshRankings";
            this.button_RefreshRankings.Size = new System.Drawing.Size(153, 29);
            this.button_RefreshRankings.TabIndex = 6;
            this.button_RefreshRankings.Text = "Refresh Rankings";
            this.button_RefreshRankings.UseVisualStyleBackColor = true;
            this.button_RefreshRankings.Click += new System.EventHandler(this.button_RefreshRankings_Click);
            // 
            // button_Close
            // 
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_Close.Location = new System.Drawing.Point(283, 395);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(153, 29);
            this.button_Close.TabIndex = 7;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // Rank
            // 
            this.Rank.HeaderText = "Rank";
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Song Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Artist
            // 
            this.Artist.HeaderText = "Artist";
            this.Artist.Name = "Artist";
            this.Artist.ReadOnly = true;
            // 
            // Votes
            // 
            this.Votes.HeaderText = "Votes";
            this.Votes.Name = "Votes";
            this.Votes.ReadOnly = true;
            // 
            // Rankings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 457);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_RefreshRankings);
            this.Controls.Add(this.dataGridView_Rankings);
            this.Controls.Add(this.comboBox_PlaylistSelect);
            this.Controls.Add(this.label_PlaylistSelect);
            this.Controls.Add(this.label_Title2);
            this.Name = "Rankings";
            this.Text = "Rankings";
            this.Load += new System.EventHandler(this.Rankings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rankings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title2;
        private System.Windows.Forms.Label label_PlaylistSelect;
        private System.Windows.Forms.ComboBox comboBox_PlaylistSelect;
        private System.Windows.Forms.DataGridView dataGridView_Rankings;
        private System.Windows.Forms.Button button_RefreshRankings;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Votes;
    }
}