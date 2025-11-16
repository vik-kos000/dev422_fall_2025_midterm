using EventManagementAndTicketingAPI;
using EventManagementAndTicketingAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementAndTicketingUserApp
{
    public partial class TicketForm : Form
    {
        private List<Ticket> listtickets = new List<Ticket>();
        private readonly JwtSecurityToken token;
        private List<Event> listmusicevents = new List<Event>();
        public TicketForm(JwtSecurityToken tokenS, List<Event> musicevents, List<Ticket> tickets)
        {
            token = tokenS;
            listmusicevents = musicevents;
            listtickets = tickets;
            InitializeComponent();
        }
        private void btn_events_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm(token, listmusicevents, listtickets);
            eventForm.Show();
            this.Hide();
        }

        private void btn_BookTicket_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket ticket = new Ticket
                {
                    EventID = Convert.ToInt32(tbx_eventID.Text),
                    Status = tbx_status.Text
                };
                TicketsController ticketsController = new()
                {
                    _tickets = listtickets,
                    jwt = token,
                    _musicevents = listmusicevents
                };
                Message(ticketsController.BookTicketsForEvents(ticket));
                listtickets = ticketsController.Getlisttickets();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void btn_getuserbookedID_Click(object sender, EventArgs e)
        {
            try
            {
                TicketsController ticketsController = new()
                {
                    _tickets = listtickets,
                    jwt = token,
                    _musicevents = listmusicevents
                };
                Message(ticketsController.GetUsersBookedTickets());
                listtickets = ticketsController.Getlisttickets();
                var Idclaim = token.Claims.First(c => c.Type == "nameid").Value;
                listBox_getusersbookedtickets.Items.Clear();
                for (int i = 0; i < listtickets.Count; i++)
                {
                    if (listtickets[i].UserID == Convert.ToInt32(Idclaim))
                    {
                        listBox_getusersbookedtickets.Items.Add(i + ":");
                        listBox_getusersbookedtickets.Items.Add("EventID: " + listtickets[i].EventID);
                        listBox_getusersbookedtickets.Items.Add("UserID: " + listtickets[i].UserID);
                        listBox_getusersbookedtickets.Items.Add("Status: " + listtickets[i].Status);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void btn_updatebookedticket_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket ticket = new Ticket
                {
                    EventID = Convert.ToInt32(tbx_eventID.Text),
                    Status = tbx_status.Text
                };
                TicketsController ticketsController = new()
                {
                    _tickets = listtickets,
                    jwt = token,
                    _musicevents = listmusicevents
                };
                Message(ticketsController.AdjustBookedTicket(ticket));
                listtickets = ticketsController.Getlisttickets();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
        private void Message(object message)
        {
            if (message.GetType().ToString() == "Microsoft.AspNetCore.Mvc.OkObjectResult")
            {
                var result = message as OkObjectResult;
                MessageBox.Show($"{result.Value}");
            }
            if (message.GetType().ToString() == "Microsoft.AspNetCore.Mvc.BadRequestObjectResult")
            {
                var result = message as BadRequestObjectResult;
                MessageBox.Show($"{result.Value}");
            }
            if (message.GetType().ToString() == "Microsoft.AspNetCore.Mvc.UnauthorizedObjectResult")
            {
                var result = message as UnauthorizedObjectResult;
                MessageBox.Show($"{result.Value}");
            }
        }
    }

}
