using getster_attendance_app.Models;
using getster_attendance_app.Repository.Userapp_Work_Shift_Changeover_Schedule;
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
    public class UserappWorkShiftChangeoverScheduleController : ControllerBase
    {
        public readonly IUserappWorkShiftChangeoverScheduleRepository _userappWorkShiftChangeoverScheduleRepository;
        public UserappWorkShiftChangeoverScheduleController(IUserappWorkShiftChangeoverScheduleRepository userappWorkShiftChangeoverScheduleRepository)
        {
            _userappWorkShiftChangeoverScheduleRepository = userappWorkShiftChangeoverScheduleRepository;
        }


        [HttpPost]
        [Route("api/AddUserappWorkShiftChangeoverSchedule")]
        public IActionResult AddUserappWorkShiftChangeoverSchedule(userapp_work_shift_changeover_schedule obj_userapp_work_shift_changeover_schedule)
        {
            try
            {
                var messages = _userappWorkShiftChangeoverScheduleRepository.AddUserappWorkShiftChangeoverSchedule(obj_userapp_work_shift_changeover_schedule);
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




        [HttpPut]
        [Route("api/UpdateUserappWorkShiftChangeoverSchedule")]
        public IActionResult UpdateUserappWorkShiftChangeoverSchedule(userapp_work_shift_changeover_schedule obj_userapp_work_shift_changeover_schedule)
        {
            try
            {
                var messages = _userappWorkShiftChangeoverScheduleRepository.UpdateUserappWorkShiftChangeoverSchedule(obj_userapp_work_shift_changeover_schedule);
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




        [HttpGet]
        [Route("api/GetAllUserappWorkShiftChangeoveSchedule")]
        public IActionResult GetAllUserappWorkShiftChangeoveSchedule(int UserId)
        {
            try
            {
                var messages = _userappWorkShiftChangeoverScheduleRepository.GetAllUserappWorkShiftChangeoveSchedule(UserId);
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


        [HttpDelete]
        [Route("api/DeleteUserappWorkShiftChangeoverSchedule")]
        public IActionResult DeleteUserappWorkShiftChangeoverSchedule(int UserId, int ScheduleCategoryId)
        {
            try
            {
                var messages = _userappWorkShiftChangeoverScheduleRepository.DeleteUserappWorkShiftChangeoverSchedule(UserId, ScheduleCategoryId);
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
