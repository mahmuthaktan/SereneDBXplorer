using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SereneDBXplorer.Definition.DatabaseDefinitionsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SereneDBXplorer.Definition.DatabaseDefinitionsRow;

namespace SereneDBXplorer.Definition
{
    public interface IDatabaseDefinitionsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class DatabaseDefinitionsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IDatabaseDefinitionsSaveHandler
    {
        public DatabaseDefinitionsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}