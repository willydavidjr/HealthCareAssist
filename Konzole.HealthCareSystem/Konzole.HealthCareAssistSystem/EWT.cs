﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzole.InventorySystem
{
    [Table("EWT", Schema = "IV")]
    public class EWT
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
