using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SereneDBXplorer.Default.DatabasePropertiesRow>;
using MyRow = SereneDBXplorer.Default.DatabasePropertiesRow;

namespace SereneDBXplorer.Default
{
    public interface IDatabasePropertiesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class DatabasePropertiesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IDatabasePropertiesRetrieveHandler
    {
        public DatabasePropertiesRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}