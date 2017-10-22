using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzole.InventorySystem
{

    [Table("VATType", Schema = "IV")]
    public class VATType
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
