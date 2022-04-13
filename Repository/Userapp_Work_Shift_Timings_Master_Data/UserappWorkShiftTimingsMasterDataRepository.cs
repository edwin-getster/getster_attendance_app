using getster_attendance_app.Getster_DbContext;
using getster_attendance_app.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace getster_attendance_app.Repository.Userapp_Work_Shift_Timings_Master_Data
{
    public class UserappWorkShiftTimingsMasterDataRepository : IUserappWorkShiftTimingsMasterDataRepository
    {
        public Response AddUserappWorkShiftTimingsMasterData(userapp_work_shift_timings_master_data obj_userapp_work_shift_timings_master_data)
        {
            Response response = new Response();
            try
            {
                GetSetDatabase getSetDatabase = new GetSetDatabase();
                var result = getSetDatabase.AddUserappWorkShiftTimingsMasterData(obj_userapp_work_shift_timings_master_data);
                response = result;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = "Error!";
            }
            return response;
        }


        public Response GetAllUserappWorkShiftTimingsMasterData(int UserId)
        {
            Response response = new Response();
            try
            {
                DataTable dset = new DataTable();

                GetSetDatabase Obj_getsetdb = new GetSetDatabase();
                dset = Obj_getsetdb.GetAllUserappWorkShiftTimingsMasterData(UserId);
                string JSONresult;
                JSONresult = JsonConvert.SerializeObject(dset);
                //List<userapp_chat_id_users_list> obj_users_list = new List<userapp_chat_id_users_list>();
                //obj_users_list = ConvertDataTable<userapp_chat_id_users_list>(dset);

                //response.Data = (obj_users_list).ToList();
                response.Data = JSONresult;
                response.Message = "Userapp work shift timings master data get successfully !!";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = ex.Message;
            }
            return response;
        }


        public Response UpdateUserappWorkShiftTimingsMasterData(userapp_work_shift_timings_master_data obj_userapp_work_shift_timings_master_data)
        {
            Response response = new Response();
            try
            {
                GetSetDatabase getSetDatabase = new GetSetDatabase();
                var result = getSetDatabase.UpdateUserappWorkShiftTimingsMasterData(obj_userapp_work_shift_timings_master_data);
                response = result;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = "Error!";
            }
            return response;
        }




        public Response DeleteUserappWorkShiftTimingsMasterData( int UserId, int ShiftTimeId)
        {
            Response response = new Response();
            try
            {
                GetSetDatabase getSetDatabase = new GetSetDatabase();
                var result = getSetDatabase.DeleteUserappWorkShiftTimingsMasterData(UserId, ShiftTimeId);
                response = result;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = "Error!";
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
