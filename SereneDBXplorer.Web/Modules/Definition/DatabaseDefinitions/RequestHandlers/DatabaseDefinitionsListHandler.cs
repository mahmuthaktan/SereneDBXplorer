using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SereneDBXplorer.Definition.DatabaseDefinitionsRow>;
using MyRow = SereneDBXplorer.Definition.DatabaseDefinitionsRow;

namespace SereneDBXplorer.Definition
{
    public interface IDatabaseDefinitionsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class DatabaseDefinitionsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IDatabaseDefinitionsListHandler
    {
        public DatabaseDefinitionsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}