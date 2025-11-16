namespace CollabPlaylist
{
    partial class Voting
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
            this.dataGridView_Songs = new System.Windows.Forms.DataGridView();
            this.SongId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Votes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vote = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_RefreshVotes = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Songs)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title2
            // 
            this.label_Title2.AutoSize = true;
            this.label_Title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label_Title2.Location = new System.Drawing.Point(162, 35);
            this.label_Title2.Name = "label_Title2";
            this.label_Title2.Size = new System.Drawing.Size(193, 31);
            this.label_Title2.TabIndex = 2;
            this.label_Title2.Text = "Vote for Songs";
            // 
            // dataGridView_Songs
            // 
            this.dataGridView_Songs.AllowUserToAddRows = false;
            this.dataGridView_Songs.AllowUserToDeleteRows = false;
            this.dataGridView_Songs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Songs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Songs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SongId,
            this.Title,
            this.Artist,
            this.Votes,
            this.Vote});
            this.dataGridView_Songs.Location = new System.Drawing.Point(12, 97);
            this.dataGridView_Songs.Name = "dataGridView_Songs";
            this.dataGridView_Songs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Songs.Size = new System.Drawing.Size(511, 246);
            this.dataGridView_Songs.TabIndex = 4;
            this.dataGridView_Songs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Songs_CellContentClick);
            // 
            // SongId
            // 
            this.SongId.HeaderText = "Song ID";
            this.SongId.Name = "SongId";
            this.SongId.ReadOnly = true;
            this.SongId.Visible = false;
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
            // Vote
            // 
            this.Vote.HeaderText = "Vote";
            this.Vote.Name = "Vote";
            this.Vote.ReadOnly = true;
            this.Vote.UseColumnTextForButtonValue = true;
            // 
            // button_RefreshVotes
            // 
            this.button_RefreshVotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_RefreshVotes.Location = new System.Drawing.Point(117, 376);
            this.button_RefreshVotes.Name = "button_RefreshVotes";
            this.button_RefreshVotes.Size = new System.Drawing.Size(128, 29);
            this.button_RefreshVotes.TabIndex = 5;
            this.button_RefreshVotes.Text = "Refresh Votes";
            this.button_RefreshVotes.UseVisualStyleBackColor = true;
            this.button_RefreshVotes.Click += new System.EventHandler(this.button_RefreshVotes_Click);
            // 
            // button_Close
            // 
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_Close.Location = new System.Drawing.Point(263, 376);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(128, 29);
            this.button_Close.TabIndex = 6;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // Voting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 440);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_RefreshVotes);
            this.Controls.Add(this.dataGridView_Songs);
            this.Controls.Add(this.label_Title2);
            this.Name = "Voting";
            this.Text = "Voting";
            this.Load += new System.EventHandler(this.Voting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Songs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title2;
        private System.Windows.Forms.DataGridView dataGridView_Songs;
        private System.Windows.Forms.Button button_RefreshVotes;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Votes;
        private System.Windows.Forms.DataGridViewButtonColumn Vote;
    }
}