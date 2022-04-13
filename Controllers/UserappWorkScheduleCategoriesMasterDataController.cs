using getster_attendance_app.Models;
using getster_attendance_app.Repository.Userapp_Work_Schedule_Categories_Master;
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
    public class UserappWorkScheduleCategoriesMasterDataController : ControllerBase
    {
        public readonly IUserappWorkScheduleCategoriesMasterDataRepository _userappWorkScheduleCategoriesMasterDataRepository;
        public UserappWorkScheduleCategoriesMasterDataController(IUserappWorkScheduleCategoriesMasterDataRepository userappWorkScheduleCategoriesMasterDataRepository)
        {
            _userappWorkScheduleCategoriesMasterDataRepository = userappWorkScheduleCategoriesMasterDataRepository;
        }

        [HttpPost]
        [Route("api/AddUserappWorkScheduleCategoriesMasterData")]
        public IActionResult AddUserappWorkScheduleCategoriesMasterData(userapp_work_schedule_categories_master obj_userapp_work_schedule_categories_master)
        {
            try
            {
                var messages = _userappWorkScheduleCategoriesMasterDataRepository.AddUserappWorkScheduleCategoriesMasterData(obj_userapp_work_schedule_categories_master);
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
        [Route("api/UpdateWorkScheduleCategoriesMaster")]
        public IActionResult UpdateWorkScheduleCategoriesMaster(userapp_work_schedule_categories_master obj_userapp_work_schedule_categories_master)
        {
            try
            {
                var messages = _userappWorkScheduleCategoriesMasterDataRepository.UpdateWorkScheduleCategoriesMaster(obj_userapp_work_schedule_categories_master);
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
        [Route("api/GetAllUserappWorkScheduleCategoriesMaster")]
        public IActionResult GetAllUserappWorkScheduleCategoriesMaster(int UserId)
        {
            try
            {
                var messages = _userappWorkScheduleCategoriesMasterDataRepository.GetAllUserappWorkScheduleCategoriesMaster(UserId);
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
        [Route("api/DeleteUserappWorkScheduleCategoriesMaster")]
        public IActionResult  DeleteUserappWorkScheduleCategoriesMaster(int UserId, int WorkScheduleCategoryId)
        {
            try
            {
                var messages = _userappWorkScheduleCategoriesMasterDataRepository.DeleteUserappWorkScheduleCategoriesMaster(UserId, WorkScheduleCategoryId);
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
