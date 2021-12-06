using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CS_final.Models {
    public class Location {
        [Key]
        public long LocationID { get; set; }

        [Column(TypeName="nvarchar(50)")]
        public string Name { get; set; }

        public int MaxPlayers { get; set; }

        public decimal Price { get; set; }
    }
}
