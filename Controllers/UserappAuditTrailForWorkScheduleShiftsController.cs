using getster_attendance_app.Repository.Userapp_Audit_Trail_For_Work_Schedule_Shifts;
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
    public class UserappAuditTrailForWorkScheduleShiftsController : ControllerBase
    {
        public readonly IUserappAuditTrailForWorkScheduleShiftsRepository _userappAuditTrailForWorkScheduleShiftsRepository;
        public UserappAuditTrailForWorkScheduleShiftsController(IUserappAuditTrailForWorkScheduleShiftsRepository userappAuditTrailForWorkScheduleShiftsRepository)
        {
            _userappAuditTrailForWorkScheduleShiftsRepository = userappAuditTrailForWorkScheduleShiftsRepository;
        }


        [HttpGet]
        [Route("api/GetAllUserappAuditTrailForWorkScheduleShifts")]
        public IActionResult GetAllUserappAuditTrailForWorkScheduleShifts()
        {
            try
            {
                var messages = _userappAuditTrailForWorkScheduleShiftsRepository.GetAllUserappAuditTrailForWorkScheduleShifts();
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
