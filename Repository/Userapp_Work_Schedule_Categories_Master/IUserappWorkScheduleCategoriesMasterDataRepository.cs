using getster_attendance_app.Models;

namespace getster_attendance_app.Repository.Userapp_Work_Schedule_Categories_Master
{
    public interface IUserappWorkScheduleCategoriesMasterDataRepository
    {
        Response AddUserappWorkScheduleCategoriesMasterData(userapp_work_schedule_categories_master obj_userapp_work_schedule_categories_master);
        Response UpdateWorkScheduleCategoriesMaster(userapp_work_schedule_categories_master obj_userapp_work_schedule_categories_master);
        Response GetAllUserappWorkScheduleCategoriesMaster(int UserId);
        Response DeleteUserappWorkScheduleCategoriesMaster(int UserId, int WorkScheduleCategoryId);
    }
}