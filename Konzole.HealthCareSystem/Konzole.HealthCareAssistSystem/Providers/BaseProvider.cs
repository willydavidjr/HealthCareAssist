using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konzole.HealthCareAssistSystem.Providers.Interface;
using Konzole.HealthCareAssistSystem.Web.Models;

namespace Konzole.HealthCareAssistSystem.Providers
{
    public abstract class BaseProvider:IDisposable
    {
        private bool _disposed = false;
        protected ApplicationDbContext _db = null;
        protected ILoggingProvider _loggingProvider;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                    Console.WriteLine("Object disposed.");
                }

                _disposed = true;
            }
        }

    }
}
