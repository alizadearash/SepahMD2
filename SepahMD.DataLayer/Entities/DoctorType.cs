using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepahMD.DataLayer.Entities
{
    public class DoctorType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DoctorTypeID { get; set; }
        public string DoctorTypeName { get; set; }

      
    }
}
