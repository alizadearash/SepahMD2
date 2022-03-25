using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepahMD.DataLayer.Entities
{
    public class Doctors
    {
        #region مشخصات هر مرکز درمانی
        [Key]
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public string DoctorTell { get; set; }
        public string DoctorAddress { get; set; }
        #endregion
        #region زیر جداول نوع ،شهرستان و نوع بیمه هر مرکز درمانی 
        public City city { get; set; }
        public Insurance insurance { get; set; }
        public DoctorType doctorType { get; set; }  
        #endregion
    }

}
