using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClubOOPSInventoryProjectCore.Data
{
    public class Club
    {
        [Key]
        public int ClubID { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<ApplicationUserClub> Users { get; set; }
        public virtual ICollection<InventoryItem> InventoryItems { get; set; }
    }
}
