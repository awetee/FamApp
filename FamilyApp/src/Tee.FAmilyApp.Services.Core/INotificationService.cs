namespace Tee.FamilyApp.Services.Core
{
    public interface INotificationService
    {
        bool SendInviteNotification(int branchId);
    }
}