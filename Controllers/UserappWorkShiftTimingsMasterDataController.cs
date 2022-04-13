using getster_attendance_app.Models;
using getster_attendance_app.Repository.Userapp_Work_Shift_Timings_Master_Data;
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
    public class UserappWorkShiftTimingsMasterDataController : ControllerBase
    {
        public readonly IUserappWorkShiftTimingsMasterDataRepository _userappWorkShiftTimingsMasterDataRepository;
        public UserappWorkShiftTimingsMasterDataController(IUserappWorkShiftTimingsMasterDataRepository uerappWorkShiftTimingsMasterDataRepository)
        {

            _userappWorkShiftTimingsMasterDataRepository = uerappWorkShiftTimingsMasterDataRepository;
        }



        [HttpPost]
        [Route("api/AddUserappWorkShiftTimingsMasterData")]
        public IActionResult AddChatAppDyanmicDb(userapp_work_shift_timings_master_data obj_userapp_work_shift_timings_master_data)
        {
            try
            {
                var messages = _userappWorkShiftTimingsMasterDataRepository.AddUserappWorkShiftTimingsMasterData(obj_userapp_work_shift_timings_master_data);
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
        [Route("api/GetAllUserappWorkShiftTimingsMasterData")]
        public IActionResult GetAllUserappWorkShiftTimingsMasterData(int UserId)
        {
            try
            {
                var messages = _userappWorkShiftTimingsMasterDataRepository.GetAllUserappWorkShiftTimingsMasterData(UserId);
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
        [Route("api/UpdateUserappWorkShiftTimingsMasterData")]
        public IActionResult UpdateUserappWorkShiftTimingsMasterData(userapp_work_shift_timings_master_data obj_userapp_work_shift_timings_master_data)
        {
            try
            {
                var messages = _userappWorkShiftTimingsMasterDataRepository.UpdateUserappWorkShiftTimingsMasterData(obj_userapp_work_shift_timings_master_data);
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
        [Route("api/DeleteUserappWorkShiftTimingsMasterData")]
        public IActionResult  DeleteUserappWorkShiftTimingsMasterData(int UserId, int ShiftTimeId)
        {
            try
            {
                var messages = _userappWorkShiftTimingsMasterDataRepository.DeleteUserappWorkShiftTimingsMasterData(UserId, ShiftTimeId);
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
