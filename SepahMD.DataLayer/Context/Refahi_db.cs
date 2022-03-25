using Microsoft.EntityFrameworkCore;
using SepahMD.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SepahMD.DataLayer.Context
{
    public class Refahi_db:DbContext

    {
        public Refahi_db(DbContextOptions<Refahi_db> options):base(options)
        {

        }
        public DbSet<Doctors> tblDoctors { get; set; }
        public DbSet<DoctorType> tblDoctorType { get; set; }    
        public DbSet<City> tblCity { get; set; }
        public DbSet<Insurance> tblInsurance { get; set; }    

    }
}
