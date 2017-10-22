using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konzole.HealthCareAssistSystem.Entities;
using Konzole.HealthCareAssistSystem.Providers.Interface;
using Konzole.HealthCareAssistSystem.Web.Models;

namespace Konzole.HealthCareAssistSystem.Providers
{
    public class UserProvider:BaseProvider, IUserProvider
    {
        public UserProvider(ApplicationDbContext context, ILoggingProvider loggingProvider)
        {
            this._db = context;
            this._loggingProvider = loggingProvider;
        }

        public User GetByUserId(int id)
        {
            User user = new User();
            try
            {
                user = _db.Users.Find(id);
            }
            catch (Exception ex)
            {
                _loggingProvider.LogError(ex, string.Format("Failed to get a User by ID: {0}", id));
            }

            if (user == null)
            {
                user = new User();
            }
            return user;
        }

        public List<User> GetList()
        {
            List<User> userList = null;

            try
            {
                userList = (from user in _db.Users
                                select user).ToList();
            }
            catch (Exception ex)
            {
                _loggingProvider.LogError(ex, "Failed to get a user list");
            }

            if (userList == null)
            {
                userList = new List<User>();
            }

            return userList;
        }

        public bool RemoveById(int id)
        {
            int returnvalue = 0;

            User user = _db.Users.Find(id);
            try
            {
                _db.Users.Remove(user);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                _loggingProvider.LogError(ex, string.Format("Failed to remove a user - ID: {0}", user.Id));
            }
            return (returnvalue > 0);
        }

        public bool Save(User user)
        {
            int returnvalue = 0;

            try
            {
                if (user.Id == 0)
                {
                    _db.Users.Add(user);
                }
                else
                {
                    _db.Entry(user).State = EntityState.Modified;
                }
                returnvalue = _db.SaveChanges();
            }
            catch (Exception ex)
            {
                _loggingProvider.LogError(ex, string.Format("Failed to save a customer - ID: {0}",user.Id));
            }
            return (returnvalue > 0);
        }
    }
}
