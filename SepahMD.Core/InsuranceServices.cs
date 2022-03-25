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
    public class InsuranceServices : IInsurance
    {
        private Refahi_db database;
        public InsuranceServices(Refahi_db _db)
        {
            database=_db;
        }
        public int NewInsurance(InuranceViewModel _InsuranceViewModel)
        {
            Insurance insurance = new Insurance();
            insurance.InsuranceName = _InsuranceViewModel.InsuranceName;
            insurance.InsuranceDesc=_InsuranceViewModel.InsuranceDesc;
            database.tblInsurance.Add(insurance);
            database.SaveChanges();
            return insurance.InsuranceID;
            
        }
    }
}
