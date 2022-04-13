using getster_attendance_app.Models;

namespace getster_attendance_app.Repository.Userapp_Work_Shift_Timings_Master_Data
{
    public interface IUserappWorkShiftTimingsMasterDataRepository
    {
        Response AddUserappWorkShiftTimingsMasterData(userapp_work_shift_timings_master_data obj_userapp_work_shift_timings_master_data);
        Response GetAllUserappWorkShiftTimingsMasterData(int UserId);
        Response UpdateUserappWorkShiftTimingsMasterData(userapp_work_shift_timings_master_data obj_userapp_work_shift_timings_master_data);
        Response DeleteUserappWorkShiftTimingsMasterData(int UserId, int ShiftTimeId);
    }
}