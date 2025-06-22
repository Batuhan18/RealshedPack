using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.PropertiesDto
{
    public class CreatePropertiesDto
    {
        public string? Title { get; set; }
        public string? Slug_Seo { get; set; }
        public string? Description { get; set; }
        public string PropertyId { get; set; }
        public decimal Price { get; set; }
        public int Size { get; set; }
        public string? Garage_Size { get; set; }
        public string? Bedrooms { get; set; }
        public string? Bathrooms { get; set; }
        public string? Rooms { get; set; }
        public string? Garage_Count { get; set; }
        public string? Build_Year { get; set; }
        public string? Property_Type { get; set; }
        public string? Status { get; set; }
        public int AgentsId { get; set; }
        public Agents Agents { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? Zip_Code { get; set; }
        public DateTime Created_Time { get; set; }
        public string? MainPicture { get; set; }
        public string? Picture1 { get; set; }
        public string? Picture2 { get; set; }
        public string? Picture3 { get; set; }
        public string? Picture4 { get; set; }
        public string? Picture5 { get; set; }
        public string? Picture6 { get; set; }
        public string? Picture7 { get; set; }
        public string? Picture8 { get; set; }
        public string? Picture9 { get; set; }
    }
}
