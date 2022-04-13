using getster_attendance_app.Getster_DbContext;
using getster_attendance_app.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace getster_attendance_app.Repository.Userapp_Work_Shift_Changeover_Schedule
{
    public class UserappWorkShiftChangeoverScheduleRepository : IUserappWorkShiftChangeoverScheduleRepository
    {
        public Response AddUserappWorkShiftChangeoverSchedule(userapp_work_shift_changeover_schedule obj_userapp_work_shift_changeover_schedule)
        {
            Response response = new Response();
            try
            {
                GetSetDatabase getSetDatabase = new GetSetDatabase();
                var result = getSetDatabase.AddUserappWorkShiftChangeoverSchedule(obj_userapp_work_shift_changeover_schedule);
                response = result;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = "Error!";
            }
            return response;
        }



        public Response UpdateUserappWorkShiftChangeoverSchedule(userapp_work_shift_changeover_schedule obj_userapp_work_shift_changeover_schedule)
        {
            Response response = new Response();
            try
            {
                GetSetDatabase getSetDatabase = new GetSetDatabase();
                var result = getSetDatabase.UpdateUserappWorkShiftChangeoverSchedule(obj_userapp_work_shift_changeover_schedule);
                response = result;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = "Error!";
            }
            return response;
        }



        public Response GetAllUserappWorkShiftChangeoveSchedule(int UserId)
        {
            Response response = new Response();
            try
            {
                DataTable dset = new DataTable();

                GetSetDatabase Obj_getsetdb = new GetSetDatabase();
                dset = Obj_getsetdb.GetAllUserappWorkShiftChangeoveSchedule(UserId);
                string JSONresult;
                JSONresult = JsonConvert.SerializeObject(dset);
    
                response.Data = JSONresult;
                response.Message = "Userapp work shift changeove schedule  get successfully !!";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = ex.Message;
            }
            return response;
        }


        public Response DeleteUserappWorkShiftChangeoverSchedule(int UserId, int ScheduleCategoryId)
        {
            Response response = new Response();
            try
            {
                DataTable dset = new DataTable();
                GetSetDatabase getSetDatabase = new GetSetDatabase();
                var result = getSetDatabase.DeleteUserappWorkShiftChangeoverSchedule(UserId, ScheduleCategoryId);
     
                response.Message = "Userapp work shift changeove schedule  delete successfully !!";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = ex.Message;
            }
            return response;
        }



        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }


        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }

    }
}
