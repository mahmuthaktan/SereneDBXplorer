using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SereneDBXplorer.Definition.DatabaseDefinitionsRow>;
using MyRow = SereneDBXplorer.Definition.DatabaseDefinitionsRow;

namespace SereneDBXplorer.Definition
{
    public interface IDatabaseDefinitionsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class DatabaseDefinitionsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IDatabaseDefinitionsRetrieveHandler
    {
        public DatabaseDefinitionsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}