using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzole.HealthCareAssistSystem.Entities
{
    [Table("UserRole", Schema = "IV")]
    public class UserRole
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ModuleId { get; set; }
        public string RecUser { get; set; }
        public DateTime Recdate { get; set; }
        public string ModUser { get; set; }
        public DateTime? Moddate { get; set; }
        public bool WithPermission { get; set; }
      
    }
}
