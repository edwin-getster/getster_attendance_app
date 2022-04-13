using getster_attendance_app.Getster_DbContext;
using getster_attendance_app.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace getster_attendance_app.Repository.Userapp_Work_Break_Timings_Master_Data
{
    public class UserappWorkBreakTimingsMasterDataRepository : IUserappWorkBreakTimingsMasterDataRepository
    {
        public Response AddUserappWorkBreakTimingsMasterData(userapp_work_break_timings_master_data obj_userapp_work_break_timings_master_data)
        {
            Response response = new Response();
            try
            {
                GetSetDatabase getSetDatabase = new GetSetDatabase();
                var result = getSetDatabase.AddUserappWorkBreakTimingsMasterData(obj_userapp_work_break_timings_master_data);
                response = result;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = "Error!";
            }
            return response;
        }



        public Response UpdateUserappWorkBreakTimingsMasterData(userapp_work_break_timings_master_data obj_userapp_work_break_timings_master_data)
        {
            Response response = new Response();
            try
            {
                GetSetDatabase getSetDatabase = new GetSetDatabase();
                var result = getSetDatabase.UpdateUserappWorkBreakTimingsMasterData(obj_userapp_work_break_timings_master_data);
                response = result;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = "Error!";
            }
            return response;
        }



        public Response GetAllUserappWorkBreakTmingsMasterData(int UserId)
        {
            Response response = new Response();
            try
            {
                DataTable dset = new DataTable();

                GetSetDatabase Obj_getsetdb = new GetSetDatabase();
                dset = Obj_getsetdb.GetAllUserappWorkBreakTmingsMasterData(UserId);
                string JSONresult;
                JSONresult = JsonConvert.SerializeObject(dset);

                response.Data = JSONresult;
                response.Message = "Userapp work break tmings master data get successfully !!";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = ex.Message;
            }
            return response;
        }




        public Response DeleteUserappWorkBreakTimingsMasterData(int UserId, int BreakTimeId)
        {
            Response response = new Response();
            try
            {
                DataTable dset = new DataTable();

                GetSetDatabase Obj_getsetdb = new GetSetDatabase();
                dset = Obj_getsetdb.DeleteUserappWorkBreakTimingsMasterData(UserId, BreakTimeId);
            

                response.Data = "";
                response.Message = "User app work break timings master data delete successfully !!";
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
