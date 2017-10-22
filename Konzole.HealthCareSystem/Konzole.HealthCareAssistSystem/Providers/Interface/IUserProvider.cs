using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konzole.HealthCareAssistSystem.Entities;

namespace Konzole.HealthCareAssistSystem.Providers.Interface
{
    public interface IUserProvider
    {
        User GetByUserId(int userid);
        List<User> GetList();
        bool Save(User customer);
        bool RemoveById(int id);
    }
}
