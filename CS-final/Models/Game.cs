using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CS_final.Models {
    public class Game {
        [Key]
        public long GameId { get; set; }

        public long CustomerId { get; set; }
        public Customer Customer { get; set; }

        public long LocationId { get; set; }
        public Location Location { get; set; }

        public int PlayersCount { get; set; }

        public List<EquipmentUsage> EquipmentUsages { get; set; }
    }
}
