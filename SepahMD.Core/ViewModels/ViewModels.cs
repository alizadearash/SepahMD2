using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepahMD.Core.ViewModels
{
    public class ViewModels
    {
        
    }
    public class DoctorsViewModel
    {
        [Display(Name = "نام دکتر/مرکز درمانی")]
        [Required(ErrorMessage = "مقدار {0} نمیتواند خالی باشد")]
        public string DoctorName { get; set; }
        [Display(Name = "شماره تلفن تماس")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمائید")]
        public string DoctorTell { get; set; }
        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمائید")]
        public string DoctorAddress { get; set; }

        public int DoctorTypeID { get; set; }
        public int CityID { get; set; }
        public int InsuranceID { get; set; }
    }

    public class CityViewModel
    {   [Display(Name ="استان")][Required(ErrorMessage ="لطفا مقدار {0} را وارد نمائید")]
        public string ProvinceName { get; set; }
        [Display(Name ="نام شهر")][Required(ErrorMessage ="لطفا مقدار {0} را وارد نمائید")]
        public string CityName { get; set; }
        [Display(Name ="پیش شماره تلفن")][Required(ErrorMessage ="لطفا مقدار {0} را وارد نمائید")]
        public string Precode { get; set; }
    }
    
    public class InuranceViewModel
    {
        [Display(Name ="نام بیمه")][Required(ErrorMessage ="لطفا مقدار {0} را وارد نمائید")]
        public string InsuranceName { get; set; }
        [Display(Name ="توضیحات بیمه")][Required(ErrorMessage ="لطفا مقدار {0} را وارد نمائید")]
        public string InsuranceDesc { get; set; }
    }

    public class DoctorTypeViewModel
    {
        [Display(Name ="نوع مرکز درمانی ")][Required(ErrorMessage ="لطفا مقدار {0} را وارد نمائید")]
        public string DoctorTypeName { get; set; }
    }
    public class EditDoctorTypeViewModel
    {
        [Display(Name = "نوع مرکز درمانی ")]
        [Required(ErrorMessage = "لطفا مقدار {0} را وارد نمائید")]
        public string DoctorTypeName { get; set; }
    }
}
