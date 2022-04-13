using getster_attendance_app.Models;
using getster_attendance_app.Repository.Userapp_Work_Holidays_Master_Data;
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
    public class UserappWorkHolidaysMasterDataController : ControllerBase
    {
        public IUserappWorkHolidaysMasterDataRepository _userappWorkHolidaysMasterDataRepository;
        public UserappWorkHolidaysMasterDataController(IUserappWorkHolidaysMasterDataRepository userappWorkHolidaysMasterDataRepository)
        {
            _userappWorkHolidaysMasterDataRepository = userappWorkHolidaysMasterDataRepository;
        }

        [HttpPost]
        [Route("api/AddUserappWorkHolidaysMasterData")]
        public IActionResult AddUserappWorkHolidaysMasterData(userapp_work_holidays_master_data obj_userapp_work_holidays_master_data)
        {
            try
            {
                var messages = _userappWorkHolidaysMasterDataRepository.AddUserappWorkHolidaysMasterData(obj_userapp_work_holidays_master_data);
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
        [Route("api/UpdateUserappWorkHolidaysMasterData")]
        public IActionResult UpdateUserappWorkHolidaysMasterData(userapp_work_holidays_master_data obj_userapp_work_holidays_master_data)
        {
            try
            {
                var messages = _userappWorkHolidaysMasterDataRepository.UpdateUserappWorkHolidaysMasterData(obj_userapp_work_holidays_master_data);
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
        [Route("api/GetAllUserappWorkHolidaysMasterData")]
        public IActionResult GetAllUserappWorkHolidaysMasterData(int UserId)
        {
            try
            {
                var messages = _userappWorkHolidaysMasterDataRepository.GetAllUserappWorkHolidaysMasterData(UserId);
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
        [Route("api/DeleteUserappWorkHolidaysMasterData")]
        public IActionResult DeleteUserappWorkHolidaysMasterData(int UserId, int HolidayId)
        {
            try
            {
                var messages = _userappWorkHolidaysMasterDataRepository.DeleteUserappWorkHolidaysMasterData(UserId, HolidayId);
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
