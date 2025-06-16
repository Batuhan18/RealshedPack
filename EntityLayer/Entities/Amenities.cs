using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Amenities
    {
        [Key]
        public int AmenetiesId { get; set; }
        public string Amenity { get; set; }
    }
}
