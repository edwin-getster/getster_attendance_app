using getster_attendance_app.Getster_DbContext;
using getster_attendance_app.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace getster_attendance_app.Repository.Userapp_Work_Schedule_Categories_Master
{
    public class UserappWorkScheduleCategoriesMasterDataRepository : IUserappWorkScheduleCategoriesMasterDataRepository
    {
        public Response AddUserappWorkScheduleCategoriesMasterData(userapp_work_schedule_categories_master obj_userapp_work_schedule_categories_master)
        {
            Response response = new Response();
            try
            {
                GetSetDatabase getSetDatabase = new GetSetDatabase();
                var result = getSetDatabase.AddUserappWorkScheduleCategoriesMasterData(obj_userapp_work_schedule_categories_master);
                response = result;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = "Error!";
            }
            return response;
        }


        public Response UpdateWorkScheduleCategoriesMaster(userapp_work_schedule_categories_master obj_userapp_work_schedule_categories_master)
        {
            Response response = new Response();
            try
            {
                GetSetDatabase getSetDatabase = new GetSetDatabase();
                var result = getSetDatabase.UpdateWorkScheduleCategoriesMaster(obj_userapp_work_schedule_categories_master);
                response = result;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = "Error!";
            }
            return response;
        }


        public Response GetAllUserappWorkScheduleCategoriesMaster(int UserId)
        {

        
            Response response = new Response();
            try
            {
                DataTable dset = new DataTable();

                GetSetDatabase Obj_getsetdb = new GetSetDatabase();
                dset = Obj_getsetdb.GetAllUserappWorkScheduleCategoriesMaster(UserId);
                string JSONresult;
                JSONresult = JsonConvert.SerializeObject(dset);

                response.Data = JSONresult;
                response.Message = "User app work schedule categories get successfully !!";
                response.Status = true;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = ex.Message;
            }
            return response;
        }


        public Response DeleteUserappWorkScheduleCategoriesMaster(int UserId, int WorkScheduleCategoryId)
        {
            Response response = new Response();
            try
            {
                DataTable dset = new DataTable();

                GetSetDatabase Obj_getsetdb = new GetSetDatabase();
                dset = Obj_getsetdb.DeleteUserappWorkScheduleCategoriesMaster(UserId, WorkScheduleCategoryId);


                response.Data = "";
                response.Message = "User app work schedule master data delete successfully !!";
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
