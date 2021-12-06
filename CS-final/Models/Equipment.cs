using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CS_final.Models {
    public class Equipment {
        [Key]
        public long EquipmentID { get; set; }

        [Column(TypeName="nvarchar(100)")]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Amount { get; set; }
    }
}
