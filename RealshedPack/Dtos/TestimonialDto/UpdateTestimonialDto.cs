using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealshedPack.Dtos.TestimonialDto
{
    public class UpdateTestimonialDto
    {
        public int TestimonialsId { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }
}
