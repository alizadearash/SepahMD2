using SepahMD.Core.Services;
using SepahMD.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SepahMD.DataLayer.Context;
using SepahMD.DataLayer.Entities;

namespace SepahMD.Core
{
    public class DoctorServices : IDoctor
    {
        private Refahi_db database;
        public DoctorServices(Refahi_db _db)
        {
            database = _db;
        }
        public int NewDoctor(DoctorsViewModel _DoctorViewModel)
        {
            Doctors doctors = new Doctors();
            
            doctors.DoctorName = _DoctorViewModel.DoctorName;
            doctors.DoctorTell= _DoctorViewModel.DoctorTell;
            doctors.DoctorAddress= _DoctorViewModel.DoctorAddress;
            doctors.city.CityID = _DoctorViewModel.CityID;
            doctors.insurance.InsuranceID=_DoctorViewModel.InsuranceID;
            doctors.doctorType.DoctorTypeID = _DoctorViewModel.DoctorTypeID;
            database.tblDoctors.Add(doctors);
            database.SaveChanges();
            return doctors.DoctorID;
        }
    }
}
