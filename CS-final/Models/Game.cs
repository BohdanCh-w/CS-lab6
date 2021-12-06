using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CS_final.Models {
    public class Game {
        [Key]
        public long GameID { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public int LocationID { get; set; }
        public Location Location { get; set; }

        public int PlayersCount { get; set; }
    }
}
