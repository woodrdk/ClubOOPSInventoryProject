using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubOOPSInventoryProjectCore.Data
{
    /// <summary>
    /// This class exists to support a many-to-many relationship in EF Core 2
    /// </summary>
    public class ApplicationUserClub
    {
        public string ApplicationUserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int ClubID { get; set; }
        public Club Club { get; set; }
    }
}
