using EventManagementAndTicketingAPI;
using EventManagementAndTicketingAPI.Controllers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementAndTicketingUserApp
{
    public partial class EventForm : Form
    {
        private List<Event> listmusicevents = new List<Event>();
        private readonly JwtSecurityToken token;
        private List<Ticket> listtickets = new List<Ticket>();
        public EventForm(JwtSecurityToken tokenS, List<Event> musicevents, List<Ticket> tickets)
        {
            token = tokenS;
            listmusicevents = musicevents;
            listtickets = tickets;
            InitializeComponent();
        }

        private void btn_AddEvent_Click(object sender, EventArgs e)
        {
            try
            {
                Event musicevent = new Event
                {
                    Name = tbx_eventName.Text,
                    Date = DateTime.Now,
                    Venue = tbx_venue.Text,
                    Genre = tbx_genre.Text,
                    AvailableTickets = Convert.ToInt32(tbx_available_tickets.Text)
                };
                EventsController eventsController = new()
                {
                    _musicevents = listmusicevents,
                    jwt = token
                };
                Message(eventsController.AddNewMusicEvent(musicevent));
                listmusicevents = eventsController.Getlistevent();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
        private void btn_getlists_Click(object sender, EventArgs e)
        {
            try
            {
                EventsController eventsController = new()
                {
                    _musicevents = listmusicevents,
                    jwt = token
                };
                Message(eventsController.ListAllUpcomingEvents());
                listBox_getevents.Items.Clear();
                listmusicevents = eventsController.Getlistevent();
                for (int i = 0; i < listmusicevents.Count; i++)
                {
                    listBox_getevents.Items.Add("EventID: " + i + ":");
                    listBox_getevents.Items.Add("Name: " + listmusicevents[i].Name);
                    listBox_getevents.Items.Add("Date: " + listmusicevents[i].Date);
                    listBox_getevents.Items.Add("Venue: " + listmusicevents[i].Venue);
                    listBox_getevents.Items.Add("Genre: " + listmusicevents[i].Genre);
                    listBox_getevents.Items.Add("Available Tickets: " + listmusicevents[i].AvailableTickets);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
        private void btn_tickets_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm(token, listmusicevents, listtickets);
            ticketForm.Show();
            this.Hide();
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
