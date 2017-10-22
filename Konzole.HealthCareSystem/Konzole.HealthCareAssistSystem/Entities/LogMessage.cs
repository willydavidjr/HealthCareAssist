using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzole.HealthCareAssistSystem.Entities
{
    public class LogMessage
    {
        [Key, Required]
        public Guid Id { get; set; }

        //[Required, DataAnnotationsExtensions.IntegerAttribute]
        public int EntryTypeId { get; set; }

        [NotMapped]
        public EntryTypes EntryType
        {
            get { return (EntryTypes)this.EntryTypeId; }
            set { this.EntryTypeId = (int)value; }
        }

        [Required]
        public DateTime LogTime { get; set; }

        [Required, StringLength(2048)]
        public string Message { get; set; }

        public override string ToString()
        {
            return string.Format("ID: {0}\r\nType: {1}\r\nTime: {2}\r\nMessage: {3}\r\n", Id, EntryType.ToString(), LogTime, Message);
        }

    }
}
