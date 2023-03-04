using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SereneDBXplorer.Definition.DatabaseDefinitionsRow;

namespace SereneDBXplorer.Definition
{
    public interface IDatabaseDefinitionsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class DatabaseDefinitionsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IDatabaseDefinitionsDeleteHandler
    {
        public DatabaseDefinitionsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}