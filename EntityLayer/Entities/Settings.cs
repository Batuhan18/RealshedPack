﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Settings
    {
        [Key]
        public int SettingsId { get; set; }
        public string Site_Title { get; set; }
        public string Meta_Description { get; set; }
        public string Meta_Keywords { get; set; }
        public string Logo_Url { get; set; }
        public string Facebook_Url { get; set; }
        public string Instagram_Url { get; set; }
        public string Twitter_Url { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
