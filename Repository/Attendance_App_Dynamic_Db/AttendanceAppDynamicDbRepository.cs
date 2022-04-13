using getster_attendance_app.Getster_DbContext;
using getster_attendance_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getster_attendance_app.Repository.Attendance_App_Dynamic_Db
{
    public class AttendanceAppDynamicDbRepository : IAttendanceAppDynamicDbRepository
    {

        public Response AddAttendanceAppDyanmicDb(attendance_app_dynamic_db obj_attendance_app_dyanmic_db)
        {
            Response response = new Response();
            try
            {
                GetSetDatabase getSetDatabase = new GetSetDatabase();
                var result = getSetDatabase.AddAttendanceAppDyanmicDb(obj_attendance_app_dyanmic_db);
                response = result;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = "Error! While Creting Dynamic Database !!";
            }
            return response;
        }
    }
}
