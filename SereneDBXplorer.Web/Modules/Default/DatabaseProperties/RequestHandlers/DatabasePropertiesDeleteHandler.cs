using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SereneDBXplorer.Default.DatabasePropertiesRow;

namespace SereneDBXplorer.Default
{
    public interface IDatabasePropertiesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class DatabasePropertiesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IDatabasePropertiesDeleteHandler
    {
        public DatabasePropertiesDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}