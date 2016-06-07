namespace Tee.FamilyApp.Services
{
    public interface INotificationService
    {
        bool SendInviteNotification(int branchId);
    }
}