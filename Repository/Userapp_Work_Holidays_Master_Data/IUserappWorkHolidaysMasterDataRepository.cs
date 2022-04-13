using getster_attendance_app.Models;

namespace getster_attendance_app.Repository.Userapp_Work_Holidays_Master_Data
{
    public interface IUserappWorkHolidaysMasterDataRepository
    {
        Response AddUserappWorkHolidaysMasterData(userapp_work_holidays_master_data obj_userapp_work_holidays_master_data);
        Response UpdateUserappWorkHolidaysMasterData(userapp_work_holidays_master_data obj_userapp_work_holidays_master_data);
        Response GetAllUserappWorkHolidaysMasterData(int UserId);
        Response DeleteUserappWorkHolidaysMasterData(int UserId, int HolidayId);
    }
}