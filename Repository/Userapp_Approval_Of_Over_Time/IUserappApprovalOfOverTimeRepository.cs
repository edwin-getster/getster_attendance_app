using getster_attendance_app.Models;

namespace getster_attendance_app.Repository.Userapp_Approval_Of_Over_Time
{
    public interface IUserappApprovalOfOverTimeRepository
    {
        Response AddUserappApprovalOfOverTime(userapp_approval_of_over_time obj_userapp_approval_of_over_time);
        Response UpdateUserappApprovalOfOverTime(userapp_approval_of_over_time obj_userapp_approval_of_over_time);
        Response GetAllUserappApprovalOfOverTime(int UserId);
        Response DeleteUserAppApprovalvalOfOverTime(int UserId, int ForUserId);
    }
}