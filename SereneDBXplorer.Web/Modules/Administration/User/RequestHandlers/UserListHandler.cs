using Serenity.Services;
using MyRequest = SereneDBXplorer.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<SereneDBXplorer.Administration.UserRow>;
using MyRow = SereneDBXplorer.Administration.UserRow;

namespace SereneDBXplorer.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}