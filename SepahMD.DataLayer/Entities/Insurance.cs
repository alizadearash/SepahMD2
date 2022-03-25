using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepahMD.DataLayer.Entities
{
    public class Insurance
    {
        [Key]
        public int InsuranceID { get; set; }
        public string InsuranceName { get; set; }
        public string InsuranceDesc { get; set; }

       

    }
}
