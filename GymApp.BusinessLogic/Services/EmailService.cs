

using GymApp.BusinessLogic.Interfaces;
using GymApp.DataAccess.Data;
using System.Net;
using System.Net.Mail;

namespace GymApp.BusinessLogic.Services
{
    public class EmailService : IEmailService
    {
        private readonly GymAppContext _dbContext;
        public EmailService(GymAppContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void EmailTest()
        {
            var clients = _dbContext.Clients.Where(b => b.BirthDay.Date.Day == DateTime.Now.Date.Day 
            && b.BirthDay.Date.Month == DateTime.Now.Date.Month).ToList();

            SmtpClient smtp = new SmtpClient("smtp.gmail.com")
            {
                Credentials = new NetworkCredential("alexandr.masliy23.1@gmail.com", "mwot kptv ppot sruf"),
                EnableSsl = true
            };

            MailAddress from = new MailAddress("artem.grishnev03@gmail.com", "Test");

            foreach (var c in clients)
            {

                MailAddress to = new MailAddress(c.Email);

                MailMessage m = new MailMessage(from, to);

                m.Subject = "С др";

                m.Body = "<h2>C Др</h2>";

                m.IsBodyHtml = true;
                
                smtp.Send(m);
            }
        }
    }
}
