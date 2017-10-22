using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konzole.HealthCareAssistSystem.Providers.Interface;
using Konzole.HealthCareAssistSystem.Web.Models;

namespace Konzole.HealthCareAssistSystem.Providers
{
    public class LoggingProvider : BaseProvider, ILoggingProvider
    {
        public LoggingProvider(ApplicationDbContext context)
        {
            this._db = context;
        }

        public void LogMessage(EntryTypes entryType, string message)
        {
            this._db.LogMessage.Add(new LogMessage()
            {
                Id = Guid.NewGuid(),
                EntryType = entryType,
                LogTime = DateTime.Now,
                Message = message
            });

            this._db.SaveChanges();
        }

        public void LogError(Exception ex, string message)
        {
            StringBuilder sb = new StringBuilder();
            //MembershipUser user = Membership.GetUser();
            //var requestInfo = string.Format("User: {0} - LastLoginDate: {1} {2}", user.UserName, user.LastLoginDate.ToShortDateString(), user.LastLoginDate.ToShortTimeString());
            //sb.AppendFormat("Error encountered for {0}\r\nMessage: {1}\r\nException: {2}", requestInfo, message, ex.ToString());

            //this._db.LogMessage.Add(new LogMessage()
            //{
            //    Id = Guid.NewGuid(),
            //    EntryType = EntryTypes.Error,
            //    LogTime = DateTime.Now,
            //    Message = sb.ToString()
            //});

            this._db.SaveChanges();
        }

        private void SendErrorEmail(LogMessage logMessage)
        {

        }
    }
}
