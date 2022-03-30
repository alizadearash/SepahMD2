using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SepahMD.Core.ViewModels;

namespace SepahMD.Core.Services
{
    public interface ICity
    {
        int AddNewCity(CityViewModel _CityViewModel);
    }
}
