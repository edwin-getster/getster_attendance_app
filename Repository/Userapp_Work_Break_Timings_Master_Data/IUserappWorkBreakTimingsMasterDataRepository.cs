using getster_attendance_app.Models;

namespace getster_attendance_app.Repository.Userapp_Work_Break_Timings_Master_Data
{
    public interface IUserappWorkBreakTimingsMasterDataRepository
    {
        Response AddUserappWorkBreakTimingsMasterData(userapp_work_break_timings_master_data obj_userapp_work_break_timings_master_data);
        Response UpdateUserappWorkBreakTimingsMasterData(userapp_work_break_timings_master_data obj_userapp_work_break_timings_master_data);
        Response GetAllUserappWorkBreakTmingsMasterData(int UserId);
        Response DeleteUserappWorkBreakTimingsMasterData(int UserId, int BreakTimeId);
    }
}