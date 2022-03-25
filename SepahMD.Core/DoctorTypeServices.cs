using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SepahMD.Core.Services;
using SepahMD.Core.ViewModels;
using SepahMD.DataLayer.Context;
using SepahMD.DataLayer.Entities;

namespace SepahMD.Core
{
    public class DoctorTypeServices:IDoctorType
    {
        private Refahi_db database;
        public DoctorTypeServices(Refahi_db _db)
        {
            database = _db;
        }

        public int NewDoctorType(DoctorTypeViewModel _DoctorTypeViewModel)
        {
            DoctorType doctorType = new DoctorType();
            doctorType.DoctorTypeName = _DoctorTypeViewModel.DoctorTypeName;
            database.tblDoctorType.Add(doctorType);
            database.SaveChanges();
            return doctorType.DoctorTypeID;
            
        }
    }
}
