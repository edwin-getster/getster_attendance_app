using getster_attendance_app.Models;
using getster_attendance_app.Repository.Userapp_Approval_Of_Over_Time;
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
    public class UserappApprovalOfOverTimeController : ControllerBase
    {
        public IUserappApprovalOfOverTimeRepository _UserappApprovalOfOverTimeRepository;
        public UserappApprovalOfOverTimeController(IUserappApprovalOfOverTimeRepository userappApprovalOfOverTimeRepository)
        {
            _UserappApprovalOfOverTimeRepository = userappApprovalOfOverTimeRepository;
        }



        [HttpPost]
        [Route("api/AddUserappApprovalOfOverTime")]
        public IActionResult AddUserappApprovalOfOverTime(userapp_approval_of_over_time obj_userapp_approval_of_over_time)
        {

            try
            {
                var messages = _UserappApprovalOfOverTimeRepository.AddUserappApprovalOfOverTime(obj_userapp_approval_of_over_time);
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
        [Route("api/UpdateUserappApprovalOfOverTime")]
        public IActionResult UpdateUserappApprovalOfOverTime(userapp_approval_of_over_time obj_userapp_approval_of_over_time)
        {

            try
            {
                var messages = _UserappApprovalOfOverTimeRepository.UpdateUserappApprovalOfOverTime(obj_userapp_approval_of_over_time);
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
        [Route("api/GetUserappApprovalOfOverTime")]
        public IActionResult GetAllUserappApprovalOfOverTime(int UserId)

        {

            try
            {
                var messages = _UserappApprovalOfOverTimeRepository.GetAllUserappApprovalOfOverTime(UserId);
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
        [Route("api/GetUserappApprovalOfOverTime")]
        public IActionResult DeleteUserAppApprovalvalOfOverTime(int UserId, int ForUserId)

        {

            try
            {
                var messages = _UserappApprovalOfOverTimeRepository.DeleteUserAppApprovalvalOfOverTime(UserId, ForUserId);
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
