using EventManagementAndTicketingAPI;
using EventManagementAndTicketingAPI.Controllers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using static EventManagementAndTicketingAPI.Controllers.UsersController;
using static System.Net.WebRequestMethods;

namespace EventManagementAndTicketingUserApp
{
    public partial class UserForm : Form
    {
        private List<User> listusers = new List<User>();
        private List<Event> listmusicevents = new List<Event>();
        private List<Ticket> listtickets = new List<Ticket>();
        public UserForm()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User
                {
                    Name = tbx_name.Text,
                    Password = tbx_password.Text,
                    Email = tbx_email.Text,
                    Role = tbx_role.Text,
                };
                UsersController usersController = new()
                {
                    _users = listusers
                };

                Message(usersController.Register(user));

                listusers = usersController.Getlistuser();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User
                {
                    Name = tbx_name.Text,
                    Password = tbx_password.Text,
                    Email = tbx_email.Text,
                    Role = tbx_role.Text,
                };
                AuthController authController = new()
                {
                    _users = listusers
                };
                listusers = authController.Getlistuser();
                Message(authController.Login(user));
                var token = authController.GetTokenString();
                if (token != "")
                {
                    var handler = new JwtSecurityTokenHandler();
                    var jwtsecuritytoken = handler.ReadJwtToken(token);
                    var tokenS = jwtsecuritytoken as JwtSecurityToken;
                    EventForm eventForm = new EventForm(tokenS, listmusicevents, listtickets);
                    eventForm.Show();
                    this.Hide();
                }
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
