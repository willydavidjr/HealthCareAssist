using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzole.HealthCareAssistSystem.Providers.Interface
{
    public interface ILoggingProvider
    {
        void LogError(Exception ex, string message);
        void LogMessage(EntryTypes entrytype, string message);
    }
}
