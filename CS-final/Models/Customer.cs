using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CS_final.Models {
    public class Customer {
        [Key]
        public long CustomerId { get; set; }
        
        [Column(TypeName="nvarchar(100)")]
        public string Full_name { get; set; }

        [Column(TypeName="nvarchar(100)")]
        public string Email { get; set; }

        [Column(TypeName="nvarchar(13)")]
        public string PhoneNumber { get; set; }

        public int Rating { get; set; }
    }
}
