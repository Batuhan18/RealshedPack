using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Agents
    {
        [Key]
        public int AgentsId { get; set; }
        public string AgentName { get; set; }
        public string AgentSurname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Profile_Image { get; set; }
        public string Address { get; set; }
        public string Bio { get; set; }
        public string Created_Time { get; set; }
    }
}
