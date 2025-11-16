namespace EventManagementAndTicketingUserApp
{
    partial class EventForm
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
            lbl_event_management = new Label();
            btn_AddEvent = new Button();
            tbx_eventName = new TextBox();
            lbl_Name = new Label();
            lbl_venue = new Label();
            tbx_venue = new TextBox();
            lbl_genre = new Label();
            tbx_genre = new TextBox();
            lbl_available_tickets = new Label();
            tbx_available_tickets = new TextBox();
            btn_tickets = new Button();
            btn_getlists = new Button();
            listBox_getevents = new ListBox();
            SuspendLayout();
            // 
            // lbl_event_management
            // 
            lbl_event_management.AutoSize = true;
            lbl_event_management.Location = new Point(555, 24);
            lbl_event_management.Name = "lbl_event_management";
            lbl_event_management.Size = new Size(165, 25);
            lbl_event_management.TabIndex = 13;
            lbl_event_management.Text = "Event Management";
            // 
            // btn_AddEvent
            // 
            btn_AddEvent.Location = new Point(441, 153);
            btn_AddEvent.Name = "btn_AddEvent";
            btn_AddEvent.Size = new Size(137, 63);
            btn_AddEvent.TabIndex = 15;
            btn_AddEvent.Text = "Add Event";
            btn_AddEvent.UseVisualStyleBackColor = true;
            btn_AddEvent.Click += btn_AddEvent_Click;
            // 
            // tbx_eventName
            // 
            tbx_eventName.Location = new Point(188, 79);
            tbx_eventName.Name = "tbx_eventName";
            tbx_eventName.Size = new Size(223, 31);
            tbx_eventName.TabIndex = 14;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Location = new Point(23, 79);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(63, 25);
            lbl_Name.TabIndex = 16;
            lbl_Name.Text = "Name:";
            // 
            // lbl_venue
            // 
            lbl_venue.AutoSize = true;
            lbl_venue.Location = new Point(23, 153);
            lbl_venue.Name = "lbl_venue";
            lbl_venue.Size = new Size(64, 25);
            lbl_venue.TabIndex = 18;
            lbl_venue.Text = "Venue:";
            // 
            // tbx_venue
            // 
            tbx_venue.Location = new Point(188, 153);
            tbx_venue.Name = "tbx_venue";
            tbx_venue.Size = new Size(223, 31);
            tbx_venue.TabIndex = 17;
            // 
            // lbl_genre
            // 
            lbl_genre.AutoSize = true;
            lbl_genre.Location = new Point(23, 228);
            lbl_genre.Name = "lbl_genre";
            lbl_genre.Size = new Size(62, 25);
            lbl_genre.TabIndex = 20;
            lbl_genre.Text = "Genre:";
            // 
            // tbx_genre
            // 
            tbx_genre.Location = new Point(188, 222);
            tbx_genre.Name = "tbx_genre";
            tbx_genre.Size = new Size(223, 31);
            tbx_genre.TabIndex = 19;
            // 
            // lbl_available_tickets
            // 
            lbl_available_tickets.AutoSize = true;
            lbl_available_tickets.Location = new Point(23, 304);
            lbl_available_tickets.Name = "lbl_available_tickets";
            lbl_available_tickets.Size = new Size(145, 25);
            lbl_available_tickets.TabIndex = 22;
            lbl_available_tickets.Text = "Available Tickets:";
            // 
            // tbx_available_tickets
            // 
            tbx_available_tickets.Location = new Point(188, 304);
            tbx_available_tickets.Name = "tbx_available_tickets";
            tbx_available_tickets.Size = new Size(223, 31);
            tbx_available_tickets.TabIndex = 21;
            // 
            // btn_tickets
            // 
            btn_tickets.Location = new Point(968, 98);
            btn_tickets.Name = "btn_tickets";
            btn_tickets.Size = new Size(137, 63);
            btn_tickets.TabIndex = 23;
            btn_tickets.Text = "Go To Tickets";
            btn_tickets.UseVisualStyleBackColor = true;
            btn_tickets.Click += btn_tickets_Click;
            // 
            // btn_getlists
            // 
            btn_getlists.Location = new Point(441, 449);
            btn_getlists.Name = "btn_getlists";
            btn_getlists.Size = new Size(137, 63);
            btn_getlists.TabIndex = 25;
            btn_getlists.Text = "Display all events";
            btn_getlists.UseVisualStyleBackColor = true;
            btn_getlists.Click += btn_getlists_Click;
            // 
            // listBox_getevents
            // 
            listBox_getevents.FormattingEnabled = true;
            listBox_getevents.ItemHeight = 25;
            listBox_getevents.Location = new Point(598, 211);
            listBox_getevents.Name = "listBox_getevents";
            listBox_getevents.Size = new Size(690, 429);
            listBox_getevents.TabIndex = 27;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 658);
            Controls.Add(listBox_getevents);
            Controls.Add(btn_getlists);
            Controls.Add(btn_tickets);
            Controls.Add(lbl_available_tickets);
            Controls.Add(tbx_available_tickets);
            Controls.Add(lbl_genre);
            Controls.Add(tbx_genre);
            Controls.Add(lbl_venue);
            Controls.Add(tbx_venue);
            Controls.Add(lbl_Name);
            Controls.Add(btn_AddEvent);
            Controls.Add(tbx_eventName);
            Controls.Add(lbl_event_management);
            Name = "EventForm";
            Text = "EventForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_event_management;
        private Button btn_AddEvent;
        private TextBox tbx_eventName;
        private Label lbl_Name;
        private Label lbl_venue;
        private TextBox tbx_venue;
        private Label lbl_genre;
        private TextBox tbx_genre;
        private Label lbl_available_tickets;
        private TextBox tbx_available_tickets;
        private Button btn_tickets;
        private Button btn_getlists;
        private ListBox listBox_getevents;
    }

}