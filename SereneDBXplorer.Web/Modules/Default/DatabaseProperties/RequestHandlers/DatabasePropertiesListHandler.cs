using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SereneDBXplorer.Default.DatabasePropertiesRow>;
using MyRow = SereneDBXplorer.Default.DatabasePropertiesRow;

namespace SereneDBXplorer.Default
{
    public interface IDatabasePropertiesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class DatabasePropertiesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IDatabasePropertiesListHandler
    {
        public DatabasePropertiesListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}