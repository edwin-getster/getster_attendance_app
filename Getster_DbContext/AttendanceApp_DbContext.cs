using getster_attendance_app.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getster_attendance_app.Getster_DbContext
{
    public class AttendanceApp_DbContext : DbContext
    {
        public AttendanceApp_DbContext(DbContextOptions<AttendanceApp_DbContext>options) : base(options)
        {

        }
        
    }
}
