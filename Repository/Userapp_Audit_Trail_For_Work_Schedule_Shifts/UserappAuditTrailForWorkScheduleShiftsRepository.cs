using getster_attendance_app.Getster_DbContext;
using getster_attendance_app.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace getster_attendance_app.Repository.Userapp_Audit_Trail_For_Work_Schedule_Shifts
{
    public class UserappAuditTrailForWorkScheduleShiftsRepository : IUserappAuditTrailForWorkScheduleShiftsRepository
    {
        public Response GetAllUserappAuditTrailForWorkScheduleShifts()
        {
            Response response = new Response();
            try
            {
                DataTable dset = new DataTable();

                GetSetDatabase Obj_getsetdb = new GetSetDatabase();
                dset = Obj_getsetdb.GetAllUserappAuditTrailForWorkScheduleShifts();
                string JSONresult;
                JSONresult = JsonConvert.SerializeObject(dset);

                response.Data = JSONresult;
                response.Message = "Userapp audit trail for work schedule shifts get successfully !!";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = ex.Message;
            }
            return response;
        }

    }
}
