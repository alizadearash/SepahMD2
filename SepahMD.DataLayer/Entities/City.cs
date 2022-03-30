using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepahMD.DataLayer.Entities
{
    public class City
    {
        [Key]
        public int CityID { get; set; }
        public string ProvinceName { get; set; }
        public string CityName { get; set; }
        public string Precode { get; set; }

        
    }
}
