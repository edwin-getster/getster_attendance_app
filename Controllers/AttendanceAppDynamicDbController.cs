using getster_attendance_app.Models;
using getster_attendance_app.Repository.Attendance_App_Dynamic_Db;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getster_attendance_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceAppDynamicDbController : ControllerBase
    {
        public readonly IAttendanceAppDynamicDbRepository _attendanceAppDynamicDbRepository;

        public AttendanceAppDynamicDbController(IAttendanceAppDynamicDbRepository attendanceAppDynamicDbRepository)
        {
            _attendanceAppDynamicDbRepository = attendanceAppDynamicDbRepository;
        }



        [HttpPost]
        [Route("api/AddAttendanceAppDyanmicDb")]
        public IActionResult AddChatAppDyanmicDb(attendance_app_dynamic_db obj_attendance_app_dyanmic_db)
        {
            try
            {
                var messages = _attendanceAppDynamicDbRepository.AddAttendanceAppDyanmicDb(obj_attendance_app_dyanmic_db);
                if (messages == null)
                {
                    return NotFound();
                }

                return Ok(messages);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }
    }
}
