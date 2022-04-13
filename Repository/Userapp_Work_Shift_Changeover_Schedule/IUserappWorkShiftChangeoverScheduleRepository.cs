using getster_attendance_app.Models;

namespace getster_attendance_app.Repository.Userapp_Work_Shift_Changeover_Schedule
{
    public interface IUserappWorkShiftChangeoverScheduleRepository
    {
        Response AddUserappWorkShiftChangeoverSchedule(userapp_work_shift_changeover_schedule obj_userapp_work_shift_changeover_schedule);
        Response UpdateUserappWorkShiftChangeoverSchedule(userapp_work_shift_changeover_schedule obj_userapp_work_shift_changeover_schedule);
        Response GetAllUserappWorkShiftChangeoveSchedule(int UserId);
        Response DeleteUserappWorkShiftChangeoverSchedule(int UserId, int ScheduleCategoryId);
    }
}