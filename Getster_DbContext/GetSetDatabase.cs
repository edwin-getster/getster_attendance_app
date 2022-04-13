using getster_attendance_app.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace getster_attendance_app.Getster_DbContext
{
    public class GetSetDatabase
    {
         //string connection = "Server=185.252.235.20;User ID=root;Password=GetBizMysqlDatabasePwd2021@;Database=attendanceappdb; Allow User Variables=true";
        string connection = "Server=localhost;User ID=root;Password=mysql;Database=attendanceappdb; Allow User Variables=true";

        public Response AddAttendanceAppDyanmicDb(attendance_app_dynamic_db obj_attendance_app_dyanmic_db)
        {
            Response response = new Response();
            DataSet ds = new DataSet();

            MySqlParameter[] param = new MySqlParameter[2];

            using MySqlConnection con = new MySqlConnection(connection);
            try
            {
                param[0] = new MySqlParameter("p_cust_id", MySqlDbType.VarChar);
                param[0].Value = obj_attendance_app_dyanmic_db.cust_id;

                param[1] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                param[1].Value = obj_attendance_app_dyanmic_db.user_id;

                ds = SqlHelpher.ExecuteDataset(con, CommandType.StoredProcedure, "SP_CreateAttendanceAppDyanmicDb", param);


                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //GetAll
                        if (Convert.ToString(ds.Tables[0].Rows[0]["Message"]) == "200")
                        {

                            response.Data = "";

                            response.Message = "Database Created successfully";
                            response.Status = true;
                        }
                        else
                        {
                            response.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                            response.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]) != -1 ? true : false;
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {

            }
            return response;
        }



        public Response AddUserappWorkShiftTimingsMasterData(userapp_work_shift_timings_master_data obj_userapp_work_shift_timings_master_data)
        {
            Response response = new Response();
            DataSet ds = new DataSet();

            MySqlParameter[] param = new MySqlParameter[7];

            using MySqlConnection con = new MySqlConnection(connection);
            try
            {          

                param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                param[0].Value = obj_userapp_work_shift_timings_master_data.user_id;

                param[1] = new MySqlParameter("p_shift_time_id", MySqlDbType.Int64);
                param[1].Value = obj_userapp_work_shift_timings_master_data.shift_time_id;

                param[2] = new MySqlParameter("p_shift_name", MySqlDbType.VarChar);
                param[2].Value = obj_userapp_work_shift_timings_master_data.shift_name;

                param[3] = new MySqlParameter("p_work_schedule_category_id", MySqlDbType.Int64);
                param[3].Value = obj_userapp_work_shift_timings_master_data.work_schedule_category_id;

                param[4] = new MySqlParameter("p_weekday", MySqlDbType.VarChar);
                param[4].Value = obj_userapp_work_shift_timings_master_data.weekday;

                param[5] = new MySqlParameter("p_start_time", MySqlDbType.VarChar);
                param[5].Value = obj_userapp_work_shift_timings_master_data.start_time;

                param[6] = new MySqlParameter("P_shift_time_duration_minutes", MySqlDbType.Int64);
                param[6].Value = obj_userapp_work_shift_timings_master_data.shift_time_duration_minutes;

                ds = SqlHelpher.ExecuteDataset(con, CommandType.StoredProcedure, "SP_InsertUserappWorkShiftTimingsMasterData", param);


                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //GetAll
                        if (Convert.ToString(ds.Tables[0].Rows[0]["Message"]) == "200")
                        {

                            response.Data = "";

                            response.Message = "User app work shift timings master data insert successfully";
                            response.Status = true;
                        }
                        else
                        {
                            response.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                            response.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]) != -1 ? true : false;
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {

            }
            return response;
        }

        public DataTable GetAllUserappWorkShiftTimingsMasterData(int UserId)
        {
            Response response = new Response();
            DataTable dsetcm = new DataTable();
            MySqlParameter[] param = new MySqlParameter[1];
            try
            {
                using MySqlConnection con = new MySqlConnection(connection);
                {
                    param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                    param[0].Value = UserId;

          
                    dsetcm = SqlHelpher.ExecuteDataTable(con, CommandType.StoredProcedure, "SP_GetAllUserappWorkShiftTimingsMasterData", param);

                    return dsetcm;
                }
            }

            catch (Exception ex)
            {

            }
            return dsetcm;
        }


        public Response UpdateUserappWorkShiftTimingsMasterData(userapp_work_shift_timings_master_data obj_userapp_work_shift_timings_master_data)
        {
            Response response = new Response();
            DataSet ds = new DataSet();

            MySqlParameter[] param = new MySqlParameter[7];

            using MySqlConnection con = new MySqlConnection(connection);
            try
            {

                param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                param[0].Value = obj_userapp_work_shift_timings_master_data.user_id;

                param[1] = new MySqlParameter("p_shift_time_id", MySqlDbType.Int64);
                param[1].Value = obj_userapp_work_shift_timings_master_data.shift_time_id;

                param[2] = new MySqlParameter("p_shift_name", MySqlDbType.VarChar);
                param[2].Value = obj_userapp_work_shift_timings_master_data.shift_name;

                param[3] = new MySqlParameter("p_work_schedule_category_id", MySqlDbType.Int64);
                param[3].Value = obj_userapp_work_shift_timings_master_data.work_schedule_category_id;

                param[4] = new MySqlParameter("p_weekday", MySqlDbType.VarChar);
                param[4].Value = obj_userapp_work_shift_timings_master_data.weekday;

                param[5] = new MySqlParameter("p_start_time", MySqlDbType.VarChar);
                param[5].Value = obj_userapp_work_shift_timings_master_data.start_time;

                param[6] = new MySqlParameter("P_shift_time_duration_minutes", MySqlDbType.Int64);
                param[6].Value = obj_userapp_work_shift_timings_master_data.shift_time_duration_minutes;

                ds = SqlHelpher.ExecuteDataset(con, CommandType.StoredProcedure, "SP_UpdateUserappWorkShiftTimingsMasterData", param);


                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //GetAll
                        if (Convert.ToString(ds.Tables[0].Rows[0]["Message"]) == "200")
                        {

                            response.Data = "";

                            response.Message = "User app works shift timings master data update successfully";
                            response.Status = true;
                        }
                        else
                        {
                            response.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                            response.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]) != -1 ? true : false;
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {

            }
            return response;
        }




        public Response DeleteUserappWorkShiftTimingsMasterData(int UserId,int ShiftTimeId)
        {
            Response response = new Response();
            DataSet ds = new DataSet();

            MySqlParameter[] param = new MySqlParameter[2];

            using MySqlConnection con = new MySqlConnection(connection);
            try
            {

         

                param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                param[0].Value = UserId;

                param[1] = new MySqlParameter("p_shift_time_id", MySqlDbType.Int64);
                param[1].Value = ShiftTimeId;


                ds = SqlHelpher.ExecuteDataset(con, CommandType.StoredProcedure, "SP_DeleteUserappWorkShiftTimingsMasterData", param);


                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //GetAll
                        if (Convert.ToString(ds.Tables[0].Rows[0]["Message"]) == "200")
                        {

                            response.Data = "";

                            response.Message = "User app work shift timings master data delete successfully";
                            response.Status = true;
                        }
                        else
                        {
                            response.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                            response.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]) != -1 ? true : false;
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {

            }
            return response;
        }

        public Response AddUserappWorkBreakTimingsMasterData(userapp_work_break_timings_master_data obj_userapp_work_break_timings_master_data)
        {
            Response response = new Response();
            DataSet ds = new DataSet();

            MySqlParameter[] param = new MySqlParameter[7];

            using MySqlConnection con = new MySqlConnection(connection);
            try
            {          

                param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                param[0].Value = obj_userapp_work_break_timings_master_data.user_id;

                param[1] = new MySqlParameter("p_break_time_id", MySqlDbType.Int64);
                param[1].Value = obj_userapp_work_break_timings_master_data.break_time_id;

                param[2] = new MySqlParameter("p_break_name", MySqlDbType.VarChar);
                param[2].Value = obj_userapp_work_break_timings_master_data.break_name;

                param[3] = new MySqlParameter("p_work_schedule_category_id", MySqlDbType.Int64);
                param[3].Value = obj_userapp_work_break_timings_master_data.work_schedule_category_id;

                param[4] = new MySqlParameter("p_weekday", MySqlDbType.VarChar);
                param[4].Value = obj_userapp_work_break_timings_master_data.weekday;

                param[5] = new MySqlParameter("p_start_time", MySqlDbType.VarChar);
                param[5].Value = obj_userapp_work_break_timings_master_data.start_time;

                param[6] = new MySqlParameter("P_shift_time_duration_minutes", MySqlDbType.Int64);
                param[6].Value = obj_userapp_work_break_timings_master_data.shift_time_duration_minutes;

                ds = SqlHelpher.ExecuteDataset(con, CommandType.StoredProcedure, "SP_InsertUserappWorkBreakTimingsMasterData", param);


                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //GetAll
                        if (Convert.ToString(ds.Tables[0].Rows[0]["Message"]) == "200")
                        {

                            response.Data = "";

                            response.Message = "User app work break timings master data insert successfully";
                            response.Status = true;
                        }
                        else
                        {
                            response.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                            response.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]) != -1 ? true : false;
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {

            }
            return response;
        }



        public Response UpdateUserappWorkBreakTimingsMasterData(userapp_work_break_timings_master_data obj_userapp_work_break_timings_master_data)
        {
            Response response = new Response();
            DataSet ds = new DataSet();

            MySqlParameter[] param = new MySqlParameter[7];

            using MySqlConnection con = new MySqlConnection(connection);
            try
            {

                param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                param[0].Value = obj_userapp_work_break_timings_master_data.user_id;

                param[1] = new MySqlParameter("p_break_time_id", MySqlDbType.Int64);
                param[1].Value = obj_userapp_work_break_timings_master_data.break_time_id;

                param[2] = new MySqlParameter("p_break_name", MySqlDbType.VarChar);
                param[2].Value = obj_userapp_work_break_timings_master_data.break_name;

                param[3] = new MySqlParameter("p_work_schedule_category_id", MySqlDbType.Int64);
                param[3].Value = obj_userapp_work_break_timings_master_data.work_schedule_category_id;

                param[4] = new MySqlParameter("p_weekday", MySqlDbType.VarChar);
                param[4].Value = obj_userapp_work_break_timings_master_data.weekday;

                param[5] = new MySqlParameter("p_start_time", MySqlDbType.VarChar);
                param[5].Value = obj_userapp_work_break_timings_master_data.start_time;

                param[6] = new MySqlParameter("P_shift_time_duration_minutes", MySqlDbType.Int64);
                param[6].Value = obj_userapp_work_break_timings_master_data.shift_time_duration_minutes;

                ds = SqlHelpher.ExecuteDataset(con, CommandType.StoredProcedure, "SP_UpdateUserappWorkBreakTimingsMasterData", param);


                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //GetAll
                        if (Convert.ToString(ds.Tables[0].Rows[0]["Message"]) == "200")
                        {

                            response.Data = "";

                            response.Message = "User app work break timings master data update successfully";
                            response.Status = true;
                        }
                        else
                        {
                            response.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                            response.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]) != -1 ? true : false;
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {

            }
            return response;
        }


        public DataTable GetAllUserappAuditTrailForWorkScheduleShifts()
        {
            Response response = new Response();
            DataTable dsetcm = new DataTable();
            MySqlParameter[] param = new MySqlParameter[0];
            try
            {
                using MySqlConnection con = new MySqlConnection(connection);
                {
            

                    dsetcm = SqlHelpher.ExecuteDataTable(con, CommandType.StoredProcedure, "SP_GetAllUserappAuditTrailForWorkScheduleShifts", param);

                    return dsetcm;
               }
            }

            catch (Exception ex)
            {

            }
            return dsetcm;
        }




        public DataTable GetAllUserappWorkBreakTmingsMasterData(int UserId)
        {
            Response response = new Response();
            DataTable dsetcm = new DataTable();
            MySqlParameter[] param = new MySqlParameter[1];
            try
            {
                using MySqlConnection con = new MySqlConnection(connection);
                {
                    param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                    param[0].Value = UserId;

                 

                    dsetcm = SqlHelpher.ExecuteDataTable(con, CommandType.StoredProcedure, "SP_GetAllUserappWorkBreakTmingsMasterData", param);

                    return dsetcm;
                }
            }

            catch (Exception ex)
            {

            }
            return dsetcm;
        }



        public DataTable DeleteUserappWorkBreakTimingsMasterData(int UserId, int BreakTimeId)
        {
            Response response = new Response();
            DataTable dsetcm = new DataTable();
            MySqlParameter[] param = new MySqlParameter[2];
            try
            {
                using MySqlConnection con = new MySqlConnection(connection);
                {
                    param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                    param[0].Value = UserId;

                    param[1] = new MySqlParameter("p_break_time_id", MySqlDbType.Int64);
                    param[1].Value = BreakTimeId;


                    dsetcm = SqlHelpher.ExecuteDataTable(con, CommandType.StoredProcedure, "SP_DeleteUserappWorkBreakTimingsMasterData", param);

                    return dsetcm;
                }
            }

            catch (Exception ex)
            {

            }
            return dsetcm;
        }




        public Response AddUserappWorkShiftChangeoverSchedule(userapp_work_shift_changeover_schedule obj_userapp_work_shift_changeover_schedule)
        {
            Response response = new Response();
            DataSet ds = new DataSet();

            MySqlParameter[] param = new MySqlParameter[7];

            using MySqlConnection con = new MySqlConnection(connection);
            try
            {

                param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                param[0].Value = obj_userapp_work_shift_changeover_schedule.user_id;

                param[1] = new MySqlParameter("p_work_schedule_category_id", MySqlDbType.Int64);
                param[1].Value = obj_userapp_work_shift_changeover_schedule.work_schedule_category_id;

                param[2] = new MySqlParameter("p_effective_from_utc_timestamp", MySqlDbType.VarChar);
                param[2].Value = obj_userapp_work_shift_changeover_schedule.effective_from_utc_timestamp;

                param[3] = new MySqlParameter("p_changeover_frequency", MySqlDbType.Int64);
                param[3].Value = obj_userapp_work_shift_changeover_schedule.changeover_frequency;

                param[4] = new MySqlParameter("p_changeover_during_shift_time_id", MySqlDbType.Int64);
                param[4].Value = obj_userapp_work_shift_changeover_schedule.changeover_during_shift_time_id;

                param[5] = new MySqlParameter("p_changeover_with_work_group_of_shift_time_id", MySqlDbType.Int64);
                param[5].Value = obj_userapp_work_shift_changeover_schedule.changeover_with_work_group_of_shift_time_id;

          

                ds = SqlHelpher.ExecuteDataset(con, CommandType.StoredProcedure, "SP_InsertUserappWorkShiftChangeoverSchedule", param);


                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //GetAll
                        if (Convert.ToString(ds.Tables[0].Rows[0]["Message"]) == "200")
                        {

                            response.Data = "";

                            response.Message = " Insert user app work shift changeovers schedule successfully";
                            response.Status = true;
                        }
                        else
                        {
                            response.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                            response.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]) != -1 ? true : false;
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {

            }
            return response;
        }




        public Response UpdateUserappWorkShiftChangeoverSchedule(userapp_work_shift_changeover_schedule obj_userapp_work_shift_changeover_schedule)
        {
            Response response = new Response();
            DataSet ds = new DataSet();

            MySqlParameter[] param = new MySqlParameter[7];

            using MySqlConnection con = new MySqlConnection(connection);
            try
            {

                param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                param[0].Value = obj_userapp_work_shift_changeover_schedule.user_id;

                param[1] = new MySqlParameter("p_work_schedule_category_id", MySqlDbType.Int64);
                param[1].Value = obj_userapp_work_shift_changeover_schedule.work_schedule_category_id;

                param[2] = new MySqlParameter("p_effective_from_utc_timestamp", MySqlDbType.VarChar);
                param[2].Value = obj_userapp_work_shift_changeover_schedule.effective_from_utc_timestamp;

                param[3] = new MySqlParameter("p_changeover_frequency", MySqlDbType.Int64);
                param[3].Value = obj_userapp_work_shift_changeover_schedule.changeover_frequency;

                param[4] = new MySqlParameter("p_changeover_during_shift_time_id", MySqlDbType.Int64);
                param[4].Value = obj_userapp_work_shift_changeover_schedule.changeover_during_shift_time_id;

                param[5] = new MySqlParameter("p_changeover_with_work_group_of_shift_time_id", MySqlDbType.Int64);
                param[5].Value = obj_userapp_work_shift_changeover_schedule.changeover_with_work_group_of_shift_time_id;



                ds = SqlHelpher.ExecuteDataset(con, CommandType.StoredProcedure, "SP_UpdateUserappWorkShiftChangeoverSchedule", param);


                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //GetAll
                        if (Convert.ToString(ds.Tables[0].Rows[0]["Message"]) == "200")
                        {

                            response.Data = "";

                            response.Message = "Userapp insert userapp work shift changeover schedule successfully";
                            response.Status = true;
                        }
                        else
                        {
                            response.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                            response.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]) != -1 ? true : false;
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {

            }
            return response;
        }



        public DataTable GetAllUserappWorkShiftChangeoveSchedule(int UserId)
        {
            Response response = new Response();
            DataTable dsetcm = new DataTable();
            MySqlParameter[] param = new MySqlParameter[1];
            try
            {
                using MySqlConnection con = new MySqlConnection(connection);
                {
                    param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                    param[0].Value = UserId;



                    dsetcm = SqlHelpher.ExecuteDataTable(con, CommandType.StoredProcedure, "SP_GetAllUserappWorkShiftChangeoveSchedule", param);

                    return dsetcm;
                }
            }

            catch (Exception ex)
            {

            }
            return dsetcm;
        }



        public DataTable DeleteUserappWorkShiftChangeoverSchedule(int UserId,int ScheduleCategoryId)
        {
            Response response = new Response();
            DataTable dsetcm = new DataTable();
            MySqlParameter[] param = new MySqlParameter[2];
            try
            {
                using MySqlConnection con = new MySqlConnection(connection);
                {
                    param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                    param[0].Value = UserId;

                    param[1] = new MySqlParameter("p_schedule_category_id", MySqlDbType.Int64);
                    param[1].Value = ScheduleCategoryId;


                    dsetcm = SqlHelpher.ExecuteDataTable(con, CommandType.StoredProcedure, "SP_DeleteUserappWorkShiftChangeoverSchedule", param);

                    return dsetcm;
                }
            }

            catch (Exception ex)
            {

            }
            return dsetcm;
        }



        public Response AddUserappWorkScheduleCategoriesMasterData(userapp_work_schedule_categories_master obj_userapp_work_schedule_categories_master)
        {
            Response response = new Response();
            DataSet ds = new DataSet();

            MySqlParameter[] param = new MySqlParameter[4];

            using MySqlConnection con = new MySqlConnection(connection);
            try
            {
                param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                param[0].Value = obj_userapp_work_schedule_categories_master.user_id;

                param[1] = new MySqlParameter("p_work_schedule_category_id", MySqlDbType.Int64);
                param[1].Value = obj_userapp_work_schedule_categories_master.work_schedule_category_id;

                param[2] = new MySqlParameter("p_category_name", MySqlDbType.VarChar);
                param[2].Value = obj_userapp_work_schedule_categories_master.category_name;

                param[3] = new MySqlParameter("p_time_zone", MySqlDbType.Int64);
                param[3].Value = obj_userapp_work_schedule_categories_master.time_zone;

                ds = SqlHelpher.ExecuteDataset(con, CommandType.StoredProcedure, "SP_InsertUserappWorkScheduleCategoriesMasterData", param);


                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                    
                        if (Convert.ToString(ds.Tables[0].Rows[0]["Message"]) == "200")
                        {

                            response.Data = "";

                            response.Message = "Data Inserted Successfully into Work Schedule Category Master Data ";
                            response.Status = true;
                        }
                        else
                        {
                            response.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                            response.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]) != -1 ? true : false;
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {

            }
            return response;
        }



        public Response UpdateWorkScheduleCategoriesMaster(userapp_work_schedule_categories_master obj_userapp_work_schedule_categories_master)
        {
            Response response = new Response();
            DataSet ds = new DataSet();

            MySqlParameter[] param = new MySqlParameter[4];

            using MySqlConnection con = new MySqlConnection(connection);
            try
            {
                param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                param[0].Value = obj_userapp_work_schedule_categories_master.user_id;

                param[1] = new MySqlParameter("p_work_schedule_category_id", MySqlDbType.Int64);
                param[1].Value = obj_userapp_work_schedule_categories_master.work_schedule_category_id;

                param[2] = new MySqlParameter("p_category_name", MySqlDbType.VarChar);
                param[2].Value = obj_userapp_work_schedule_categories_master.category_name;

                param[3] = new MySqlParameter("p_time_zone", MySqlDbType.Int64);
                param[3].Value = obj_userapp_work_schedule_categories_master.time_zone;

                ds = SqlHelpher.ExecuteDataset(con, CommandType.StoredProcedure, "SP_UpdateWorkScheduleCategoriesMaster", param);


                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        if (Convert.ToString(ds.Tables[0].Rows[0]["Message"]) == "200")
                        {

                            response.Data = "";

                            response.Message = "Data update Successfully into Work Schedule Category Master Data ";
                            response.Status = true;
                        }
                        else
                        {
                            response.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                            response.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]) != -1 ? true : false;
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {

            }
            return response;
        }


        public DataTable GetAllUserappWorkScheduleCategoriesMaster(int UserId)
        {
            Response response = new Response();
            DataTable dsetcm = new DataTable();
            MySqlParameter[] param = new MySqlParameter[1];
            try
            {
                using MySqlConnection con = new MySqlConnection(connection);
                {
                    param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                    param[0].Value = UserId;

                    dsetcm = SqlHelpher.ExecuteDataTable(con, CommandType.StoredProcedure, "SP_GetAllUserappWorkScheduleCategoriesMaster", param);

                    return dsetcm;
                }
            }

            catch (Exception ex)
            {

            }
            return dsetcm;
        }

        public DataTable DeleteUserappWorkScheduleCategoriesMaster(int UserId,int WorkScheduleCategoryId)
        {
            Response response = new Response();
            DataTable dsetcm = new DataTable();
            MySqlParameter[] param = new MySqlParameter[2];
            try
            {
                using MySqlConnection con = new MySqlConnection(connection);
                {
                    param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                    param[0].Value = UserId;

                    param[1] = new MySqlParameter("p_work_schedule_category_id", MySqlDbType.Int64);
                    param[1].Value = WorkScheduleCategoryId;


                    dsetcm = SqlHelpher.ExecuteDataTable(con, CommandType.StoredProcedure, "SP_DeleteUserappWorkScheduleCategoriesMaster", param);

                    return dsetcm;
                }
            }

            catch (Exception ex)
            {

            }
            return dsetcm;
        }


        public Response AddUserappWorkHolidaysMasterData(userapp_work_holidays_master_data obj_userapp_work_holidays_master_data)
        {
            Response response = new Response();
            DataSet ds = new DataSet();

            MySqlParameter[] param = new MySqlParameter[7];

            using MySqlConnection con = new MySqlConnection(connection);
            try
            {
                param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                param[0].Value = obj_userapp_work_holidays_master_data.user_id;

                param[1] = new MySqlParameter("p_holiday_id", MySqlDbType.Int64);
                param[1].Value = obj_userapp_work_holidays_master_data.holiday_id;

                param[3] = new MySqlParameter("p_holiday_name", MySqlDbType.VarChar);
                param[3].Value = obj_userapp_work_holidays_master_data.holiday_name;

                param[4] = new MySqlParameter("p_work_schedule_category_id", MySqlDbType.Int64);
                param[4].Value = obj_userapp_work_holidays_master_data.work_schedule_category_id;

                param[5] = new MySqlParameter("p_holiday_start_utc_timestamp", MySqlDbType.VarChar);
                param[5].Value = obj_userapp_work_holidays_master_data.holiday_start_utc_timestamp;

                param[6] = new MySqlParameter("p_holiday_duration_minutes", MySqlDbType.Int64);
                param[6].Value = obj_userapp_work_holidays_master_data.holiday_duration_minutes;

                ds = SqlHelpher.ExecuteDataset(con, CommandType.StoredProcedure, "SP_InsertUserappWorkHolidaysMasterData", param);


                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                       
                        if (Convert.ToString(ds.Tables[0].Rows[0]["Message"]) == "200")
                        {

                            response.Data = "";

                            response.Message = "Data inserted successfully into Work holidays master data";
                            response.Status = true;
                        }
                        else
                        {
                            response.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                            response.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]) != -1 ? true : false;
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {

            }
            return response;
        }



        public Response UpdateUserappWorkHolidaysMasterData(userapp_work_holidays_master_data obj_userapp_work_holidays_master_data)
        {
            Response response = new Response();
            DataSet ds = new DataSet();

            MySqlParameter[] param = new MySqlParameter[7];

            using MySqlConnection con = new MySqlConnection(connection);
            try
            {
                param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                param[0].Value = obj_userapp_work_holidays_master_data.user_id;

                param[1] = new MySqlParameter("p_holiday_id", MySqlDbType.Int64);
                param[1].Value = obj_userapp_work_holidays_master_data.holiday_id;

                param[3] = new MySqlParameter("p_holiday_name", MySqlDbType.VarChar);
                param[3].Value = obj_userapp_work_holidays_master_data.holiday_name;

                param[4] = new MySqlParameter("p_work_schedule_category_id", MySqlDbType.Int64);
                param[4].Value = obj_userapp_work_holidays_master_data.work_schedule_category_id;

                param[5] = new MySqlParameter("p_holiday_start_utc_timestamp", MySqlDbType.VarChar);
                param[5].Value = obj_userapp_work_holidays_master_data.holiday_start_utc_timestamp;

                param[6] = new MySqlParameter("p_holiday_duration_minutes", MySqlDbType.Int64);
                param[6].Value = obj_userapp_work_holidays_master_data.holiday_duration_minutes;

                ds = SqlHelpher.ExecuteDataset(con, CommandType.StoredProcedure, "SP_UpdateUserappWorkHolidaysMasterData", param);


                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        if (Convert.ToString(ds.Tables[0].Rows[0]["Message"]) == "200")
                        {

                            response.Data = "";

                            response.Message = "Data updated successfully into Work holidays master data";
                            response.Status = true;
                        }
                        else
                        {
                            response.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                            response.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]) != -1 ? true : false;
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {

            }
            return response;
        }

        public DataTable GetAllUserappWorkHolidaysMasterData(int UserId)
        {
            Response response = new Response();
            DataTable dsetcm = new DataTable();
            MySqlParameter[] param = new MySqlParameter[1];
            try
            {
                using MySqlConnection con = new MySqlConnection(connection);
                {
                    param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                    param[0].Value = UserId;

              


                    dsetcm = SqlHelpher.ExecuteDataTable(con, CommandType.StoredProcedure, "SP_GetAllUserappWorkHolidaysMasterData", param);

                    return dsetcm;
                }
            }

            catch (Exception ex)
            {

            }
            return dsetcm;
        }

        public Response DeleteUserappWorkHolidaysMasterData(int UserId, int HolidayId)
        {
            Response response = new Response();
            DataSet ds = new DataSet();

            MySqlParameter[] param = new MySqlParameter[2];

            using MySqlConnection con = new MySqlConnection(connection);
            try
            {



                param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                param[0].Value = UserId;

                param[1] = new MySqlParameter("p_holiday_id", MySqlDbType.Int64);
                param[1].Value = HolidayId;


                ds = SqlHelpher.ExecuteDataset(con, CommandType.StoredProcedure, "SP_DeleteUserappWorkHolidaysMasterData", param);


                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        if (Convert.ToString(ds.Tables[0].Rows[0]["Message"]) == "200")
                        {

                            response.Data = "";

                            response.Message = "User app work holiday master data delete successfully";
                            response.Status = true;
                        }
                        else
                        {
                            response.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                            response.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]) != -1 ? true : false;
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {

            }
            return response;
        }


        public Response AddUserappApprovalOfOverTime(userapp_approval_of_over_time obj_userapp_approval_of_over_time)
        {
            Response response = new Response();
            DataSet ds = new DataSet();

            MySqlParameter[] param = new MySqlParameter[10];

            using MySqlConnection con = new MySqlConnection(connection);
            try
            {

                param[0] = new MySqlParameter("p_for_user_id", MySqlDbType.Int64);
                param[0].Value = obj_userapp_approval_of_over_time.for_user_id;

                param[1] = new MySqlParameter("p_work_schedule_start_utc_timestamp", MySqlDbType.VarChar);
                param[1].Value = obj_userapp_approval_of_over_time.work_schedule_start_utc_timestamp;

                param[2] = new MySqlParameter("p_attendance_clock_in_utc_timestamp", MySqlDbType.VarChar);
                param[2].Value = obj_userapp_approval_of_over_time.attendance_clock_in_utc_timestamp;

                param[3] = new MySqlParameter("p_work_schedule_end_utc_timestamp", MySqlDbType.VarChar);
                param[3].Value = obj_userapp_approval_of_over_time.work_schedule_end_utc_timestamp;

                param[4] = new MySqlParameter("p_attendance_clock_out_utc_timestamp", MySqlDbType.VarChar);
                param[4].Value = obj_userapp_approval_of_over_time.attendance_clock_out_utc_timestamp;

                param[5] = new MySqlParameter("p_sovertime_computation_in_minutes", MySqlDbType.Int64);
                param[5].Value = obj_userapp_approval_of_over_time.overtime_computation_in_minutes;

                param[6] = new MySqlParameter("P_status_pending_approved_denied", MySqlDbType.Bool);
                param[6].Value = obj_userapp_approval_of_over_time.status_pending_approved_denied;

                param[7] = new MySqlParameter("P_approved_denied_by_user_id", MySqlDbType.Int64);
                param[7].Value = obj_userapp_approval_of_over_time.approved_denied_by_user_id;


                param[8] = new MySqlParameter("p_approved_denied_utc_timestamp", MySqlDbType.Int64);
                param[8].Value = obj_userapp_approval_of_over_time.approved_denied_utc_timestamp;


                param[9] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                param[9].Value = obj_userapp_approval_of_over_time.user_id;



                ds = SqlHelpher.ExecuteDataset(con, CommandType.StoredProcedure, "SP_InsertUserappApprovalOfOverTime", param);


                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //GetAll
                        if (Convert.ToString(ds.Tables[0].Rows[0]["Message"]) == "200")
                        {

                            response.Data = "";

                            response.Message = "User app insert  approval of overtime successfully";
                            response.Status = true;
                        }
                        else
                        {
                            response.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                            response.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]) != -1 ? true : false;
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {

            }
            return response;
        }



        public Response UpdateUserappApprovalOfOverTime(userapp_approval_of_over_time obj_userapp_approval_of_over_time)
        {
            Response response = new Response();
            DataSet ds = new DataSet();

            MySqlParameter[] param = new MySqlParameter[10];

            using MySqlConnection con = new MySqlConnection(connection);
            try
            {
                param[0] = new MySqlParameter("p_for_user_id", MySqlDbType.Int64);
                param[0].Value = obj_userapp_approval_of_over_time.for_user_id;

                param[1] = new MySqlParameter("p_work_schedule_start_utc_timestamp", MySqlDbType.VarChar);
                param[1].Value = obj_userapp_approval_of_over_time.work_schedule_start_utc_timestamp;

                param[2] = new MySqlParameter("p_attendance_clock_in_utc_timestamp", MySqlDbType.VarChar);
                param[2].Value = obj_userapp_approval_of_over_time.attendance_clock_in_utc_timestamp;

                param[3] = new MySqlParameter("p_work_schedule_end_utc_timestamp", MySqlDbType.VarChar);
                param[3].Value = obj_userapp_approval_of_over_time.work_schedule_end_utc_timestamp;

                param[4] = new MySqlParameter("p_attendance_clock_out_utc_timestamp", MySqlDbType.VarChar);
                param[4].Value = obj_userapp_approval_of_over_time.attendance_clock_out_utc_timestamp;

                param[5] = new MySqlParameter("p_sovertime_computation_in_minutes", MySqlDbType.Int64);
                param[5].Value = obj_userapp_approval_of_over_time.overtime_computation_in_minutes;

                param[6] = new MySqlParameter("P_status_pending_approved_denied", MySqlDbType.Bool);
                param[6].Value = obj_userapp_approval_of_over_time.status_pending_approved_denied;

                param[7] = new MySqlParameter("P_approved_denied_by_user_id", MySqlDbType.Int64);
                param[7].Value = obj_userapp_approval_of_over_time.approved_denied_by_user_id;


                param[8] = new MySqlParameter("p_approved_denied_utc_timestamp", MySqlDbType.Int64);
                param[8].Value = obj_userapp_approval_of_over_time.approved_denied_utc_timestamp;


                param[9] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                param[9].Value = obj_userapp_approval_of_over_time.user_id;


                ds = SqlHelpher.ExecuteDataset(con, CommandType.StoredProcedure, "SP_UpdateUserappApprovalOfOverTime", param);


                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {

                        if (Convert.ToString(ds.Tables[0].Rows[0]["Message"]) == "200")
                        {

                            response.Data = "";

                            response.Message = "User app update  approval of overtime successfully";
                            response.Status = true;
                        }
                        else
                        {
                            response.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                            response.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]) != -1 ? true : false;
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {

            }
            return response;
        }


        public DataTable GetAllUserappApprovalOfOverTime(int UserId)
        {
            Response response = new Response();
            DataTable dsetcm = new DataTable();
            MySqlParameter[] param = new MySqlParameter[1];
            try
            {
                using MySqlConnection con = new MySqlConnection(connection);
                {
                    param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                    param[0].Value = UserId;




                    dsetcm = SqlHelpher.ExecuteDataTable(con, CommandType.StoredProcedure, "SP_GetAllUserappApprovalOfOverTime", param);

                    return dsetcm;
                }
            }

            catch (Exception ex)
            {

            }
            return dsetcm;
        }



        public Response DeleteUserAppApprovalvalOfOverTime(int UserId,int ForUserId)
        {
            Response response = new Response();
            DataSet ds = new DataSet();

            MySqlParameter[] param = new MySqlParameter[2];

            using MySqlConnection con = new MySqlConnection(connection);
            try
            {

                param[0] = new MySqlParameter("p_user_id", MySqlDbType.Int64);
                param[0].Value = UserId;

                param[1] = new MySqlParameter("p_for_user_id", MySqlDbType.Int64);
                param[1].Value = ForUserId;


                ds = SqlHelpher.ExecuteDataset(con, CommandType.StoredProcedure, "SP_DeleteUserAppApprovalvalOfOverTime", param);


                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                       
                        if (Convert.ToString(ds.Tables[0].Rows[0]["Message"]) == "200")
                        {

                            response.Data = "";

                            response.Message = "User app work break timings master data delete successfully";
                            response.Status = true;
                        }
                        else
                        {
                            response.Message = Convert.ToString(ds.Tables[0].Rows[0]["Message"]);
                            response.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]) != -1 ? true : false;
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {

            }
            return response;
        }


    }
}
