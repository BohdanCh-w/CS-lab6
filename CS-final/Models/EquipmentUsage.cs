using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CS_final.Models {
    public class EquipmentUsage {
        [Key]
        public long EquipmentUsageId { get; set; }

        public long GameId { get; set; }

        public long EquipmentId { get; set; }
        public Equipment Equipment { get; set; }

        public int Number { get; set; }

        public decimal SnapPrice { get; set; }
    }
}
