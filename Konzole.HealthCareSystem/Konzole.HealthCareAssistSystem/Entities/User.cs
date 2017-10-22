using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzole.HealthCareAssistSystem.Entities
{
    [Table("User", Schema = "IV")]
    public class User
    {
        public int Id { get; set; }
        public string UserCode { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public string Recuser { get; set; }
        public DateTime Recdate { get; set; }
        public string Moduser { get; set; }
        public DateTime? Moddate { get; set; }
        public DateTime LastPasswordChange { get; set; }
        public bool isActive { get; set; }
    }
}
