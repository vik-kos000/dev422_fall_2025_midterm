namespace EventManagementAndTicketingUserApp
{
    partial class TicketForm
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
            lbl_ticketing = new Label();
            btn_events = new Button();
            btn_BookTicket = new Button();
            tbx_eventID = new TextBox();
            lbl_event_ID = new Label();
            btn_getuserbookedID = new Button();
            listBox_getusersbookedtickets = new ListBox();
            btn_updatebookedticket = new Button();
            lbl_status = new Label();
            tbx_status = new TextBox();
            SuspendLayout();
            // 
            // lbl_ticketing
            // 
            lbl_ticketing.AutoSize = true;
            lbl_ticketing.Location = new Point(600, 39);
            lbl_ticketing.Name = "lbl_ticketing";
            lbl_ticketing.Size = new Size(82, 25);
            lbl_ticketing.TabIndex = 14;
            lbl_ticketing.Text = "Ticketing";
            // 
            // btn_events
            // 
            btn_events.Location = new Point(896, 114);
            btn_events.Name = "btn_events";
            btn_events.Size = new Size(137, 63);
            btn_events.TabIndex = 24;
            btn_events.Text = "Go To Events";
            btn_events.UseVisualStyleBackColor = true;
            btn_events.Click += btn_events_Click;
            // 
            // btn_BookTicket
            // 
            btn_BookTicket.Location = new Point(578, 129);
            btn_BookTicket.Name = "btn_BookTicket";
            btn_BookTicket.Size = new Size(137, 63);
            btn_BookTicket.TabIndex = 25;
            btn_BookTicket.Text = "Book Ticket";
            btn_BookTicket.UseVisualStyleBackColor = true;
            btn_BookTicket.Click += btn_BookTicket_Click;
            // 
            // tbx_eventID
            // 
            tbx_eventID.Location = new Point(185, 146);
            tbx_eventID.Name = "tbx_eventID";
            tbx_eventID.Size = new Size(268, 31);
            tbx_eventID.TabIndex = 26;
            // 
            // lbl_event_ID
            // 
            lbl_event_ID.AutoSize = true;
            lbl_event_ID.Location = new Point(88, 146);
            lbl_event_ID.Name = "lbl_event_ID";
            lbl_event_ID.Size = new Size(78, 25);
            lbl_event_ID.TabIndex = 27;
            lbl_event_ID.Text = "Event ID";
            // 
            // btn_getuserbookedID
            // 
            btn_getuserbookedID.Location = new Point(568, 454);
            btn_getuserbookedID.Name = "btn_getuserbookedID";
            btn_getuserbookedID.Size = new Size(175, 63);
            btn_getuserbookedID.TabIndex = 30;
            btn_getuserbookedID.Text = "Get User's Booked Tickets";
            btn_getuserbookedID.UseVisualStyleBackColor = true;
            btn_getuserbookedID.Click += btn_getuserbookedID_Click;
            // 
            // listBox_getusersbookedtickets
            // 
            listBox_getusersbookedtickets.FormattingEnabled = true;
            listBox_getusersbookedtickets.ItemHeight = 25;
            listBox_getusersbookedtickets.Location = new Point(785, 211);
            listBox_getusersbookedtickets.Name = "listBox_getusersbookedtickets";
            listBox_getusersbookedtickets.Size = new Size(508, 429);
            listBox_getusersbookedtickets.TabIndex = 31;
            // 
            // btn_updatebookedticket
            // 
            btn_updatebookedticket.Location = new Point(578, 225);
            btn_updatebookedticket.Name = "btn_updatebookedticket";
            btn_updatebookedticket.Size = new Size(175, 63);
            btn_updatebookedticket.TabIndex = 32;
            btn_updatebookedticket.Text = "Update Book Ticket";
            btn_updatebookedticket.UseVisualStyleBackColor = true;
            btn_updatebookedticket.Click += btn_updatebookedticket_Click;
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Location = new Point(88, 241);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(60, 25);
            lbl_status.TabIndex = 34;
            lbl_status.Text = "Status";
            // 
            // tbx_status
            // 
            tbx_status.Location = new Point(185, 241);
            tbx_status.Name = "tbx_status";
            tbx_status.Size = new Size(268, 31);
            tbx_status.TabIndex = 33;
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 652);
            Controls.Add(lbl_status);
            Controls.Add(tbx_status);
            Controls.Add(btn_updatebookedticket);
            Controls.Add(listBox_getusersbookedtickets);
            Controls.Add(btn_getuserbookedID);
            Controls.Add(lbl_event_ID);
            Controls.Add(tbx_eventID);
            Controls.Add(btn_BookTicket);
            Controls.Add(btn_events);
            Controls.Add(lbl_ticketing);
            Name = "TicketForm";
            Text = "TicketForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ticketing;
        private Button btn_events;
        private Button btn_BookTicket;
        private TextBox tbx_eventID;
        private Label lbl_event_ID;
        private Button btn_getuserbookedID;
        private ListBox listBox_getusersbookedtickets;
        private Button btn_updatebookedticket;
        private Label lbl_status;
        private TextBox tbx_status;
    }

}