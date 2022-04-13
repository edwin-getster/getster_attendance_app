using getster_attendance_app.Getster_DbContext;
using getster_attendance_app.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace getster_attendance_app.Repository.Userapp_Work_Holidays_Master_Data
{
    public class UserappWorkHolidaysMasterDataRepository : IUserappWorkHolidaysMasterDataRepository
    {
        public Response AddUserappWorkHolidaysMasterData(userapp_work_holidays_master_data obj_userapp_work_holidays_master_data)
        {
            Response response = new Response();
            try
            {
                GetSetDatabase getSetDatabase = new GetSetDatabase();
                var result = getSetDatabase.AddUserappWorkHolidaysMasterData(obj_userapp_work_holidays_master_data);
                response = result;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = "Error!";
            }
            return response;
        }


        public Response UpdateUserappWorkHolidaysMasterData(userapp_work_holidays_master_data obj_userapp_work_holidays_master_data)
        {
            Response response = new Response();
            try
            {
                GetSetDatabase getSetDatabase = new GetSetDatabase();
                var result = getSetDatabase.UpdateUserappWorkHolidaysMasterData(obj_userapp_work_holidays_master_data);
                response = result;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = "Error!";
            }
            return response;
        }

        public Response GetAllUserappWorkHolidaysMasterData(int UserId)
        {
            Response response = new Response();
            try
            {
                DataTable dset = new DataTable();

                GetSetDatabase Obj_getsetdb = new GetSetDatabase();
                dset = Obj_getsetdb.GetAllUserappWorkHolidaysMasterData(UserId);
                string JSONresult;
                JSONresult = JsonConvert.SerializeObject(dset);
           
                response.Data = JSONresult;
                response.Message = "User app work holiday master data get successfully !!";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = ex.Message;
            }
            return response;
        }



        public Response DeleteUserappWorkHolidaysMasterData(int UserId, int HolidayId)
        {
            Response response = new Response();
            try
            {
                GetSetDatabase getSetDatabase = new GetSetDatabase();
                var result = getSetDatabase.DeleteUserappWorkHolidaysMasterData(UserId, HolidayId);
                response = result;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = "Error!";
            }
            return response;
        }



    }
}
