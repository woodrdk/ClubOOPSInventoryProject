using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClubOOPSInventoryProject.Models
{
    public class InventoryItem
    {
        [Key]
        public int InventoryItemID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(400)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public DateTime LastUpdated { get; set; }

        public InventoryItemCondition Condition { get; set; }

        /// <summary>
        /// The User that an item is checked out to.
        /// If NULL, the item is not checked out to anyone.
        /// </summary>
        public virtual ApplicationUser CheckedOutTo { get; set; }

        public virtual Club Club { get; set; }
    }

    public enum InventoryItemCondition
    {
        New,
        Great,
        Good,
        Acceptable,
        Damaged,
        Broken
    }
}