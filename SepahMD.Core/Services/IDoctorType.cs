﻿using SepahMD.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepahMD.Core.Services
{
    public interface IDoctorType
    {
        int NewDoctorType(DoctorTypeViewModel _DoctorTypeViewModel);
    }
}
