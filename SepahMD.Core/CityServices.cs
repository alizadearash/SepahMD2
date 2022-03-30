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
   
    public class CityServices:ICity
    {
        private Refahi_db database;
        public CityServices(Refahi_db _db)
        {
            database = _db;
        }

        public int AddNewCity(CityViewModel _CityViewModel)
        {
            City city = new City();
            city.CityName = _CityViewModel.CityName;
            
            city.ProvinceName = _CityViewModel.ProvinceName;
            city.Precode = _CityViewModel.Precode;
            database.tblCity.Add(city);
            database.SaveChanges();
            return city.CityID;
            
        }
    }
}
