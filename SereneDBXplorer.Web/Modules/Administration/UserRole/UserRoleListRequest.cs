using Serenity.Services;

namespace SereneDBXplorer.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}