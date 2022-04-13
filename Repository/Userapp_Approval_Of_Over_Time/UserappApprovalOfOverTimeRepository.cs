using getster_attendance_app.Getster_DbContext;
using getster_attendance_app.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace getster_attendance_app.Repository.Userapp_Approval_Of_Over_Time
{
    public class UserappApprovalOfOverTimeRepository : IUserappApprovalOfOverTimeRepository
    {
        public Response AddUserappApprovalOfOverTime(userapp_approval_of_over_time obj_userapp_approval_of_over_time)
        {
            Response response = new Response();
            try
            {
                GetSetDatabase getSetDatabase = new GetSetDatabase();
                var result = getSetDatabase.AddUserappApprovalOfOverTime(obj_userapp_approval_of_over_time);
                response = result;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = "Error!";
            }
            return response;
        }


        public Response UpdateUserappApprovalOfOverTime(userapp_approval_of_over_time obj_userapp_approval_of_over_time)
        {
            Response response = new Response();
            try
            {
                GetSetDatabase getSetDatabase = new GetSetDatabase();
                var result = getSetDatabase.UpdateUserappApprovalOfOverTime(obj_userapp_approval_of_over_time);
                response = result;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = "Error!";
            }
            return response;
        }


        public Response GetAllUserappApprovalOfOverTime(int UserId)
        {
            Response response = new Response();
            try
            {
                DataTable dset = new DataTable();

                GetSetDatabase Obj_getsetdb = new GetSetDatabase();
                dset = Obj_getsetdb.GetAllUserappApprovalOfOverTime(UserId);
                string JSONresult;
                JSONresult = JsonConvert.SerializeObject(dset);

                response.Data = JSONresult;
                response.Message = "User app get  approval of overtime successfully !!";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = ex.Message;
            }
            return response;
        }




        public Response DeleteUserAppApprovalvalOfOverTime(int UserId, int ForUserId)
        {
            Response response = new Response();
            try
            {
                GetSetDatabase getSetDatabase = new GetSetDatabase();
                var result = getSetDatabase.DeleteUserAppApprovalvalOfOverTime(UserId, ForUserId);
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

