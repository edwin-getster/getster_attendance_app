using getster_attendance_app.Models;
using getster_attendance_app.Repository.Userapp_Work_Break_Timings_Master_Data;
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
    public class UserappWorkBreakTimingsMasterDataController : ControllerBase
    {
        public readonly IUserappWorkBreakTimingsMasterDataRepository _userappWorkBreakTimingsMasterDataRepository;

        public UserappWorkBreakTimingsMasterDataController(IUserappWorkBreakTimingsMasterDataRepository userappWorkBreakTimingsMasterDataRepository)
        {
            _userappWorkBreakTimingsMasterDataRepository = userappWorkBreakTimingsMasterDataRepository;
        }

        [HttpPost]
        [Route("api/AddUserappWorkBreakTimingsMasterData")]
        public IActionResult AddUserappWorkBreakTimingsMasterData(userapp_work_break_timings_master_data obj_userapp_work_break_timings_master_data)
        {
            try
            {
                var messages = _userappWorkBreakTimingsMasterDataRepository.AddUserappWorkBreakTimingsMasterData(obj_userapp_work_break_timings_master_data);
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
        [Route("api/UpdateUserappWorkBreakTimingsMasterData")]
        public IActionResult UpdateUserappWorkBreakTimingsMasterData(userapp_work_break_timings_master_data obj_userapp_work_break_timings_master_data)
        {
            try
            {
                var messages = _userappWorkBreakTimingsMasterDataRepository.UpdateUserappWorkBreakTimingsMasterData(obj_userapp_work_break_timings_master_data);
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
        [Route("api/GetAllUserappWorkBreakTmingsMasterData")]
        public IActionResult GetAllUserappWorkBreakTmingsMasterData(int UserId)
        {
            try
            {
                var messages = _userappWorkBreakTimingsMasterDataRepository.GetAllUserappWorkBreakTmingsMasterData(UserId);
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
        [Route("api/DeleteUserappWorkBreakTimingsMasterData")]
        public IActionResult  DeleteUserappWorkBreakTimingsMasterData(int UserId, int BreakTimeId)
        {
            try
            {
                var messages = _userappWorkBreakTimingsMasterDataRepository.DeleteUserappWorkBreakTimingsMasterData(UserId, BreakTimeId);
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
