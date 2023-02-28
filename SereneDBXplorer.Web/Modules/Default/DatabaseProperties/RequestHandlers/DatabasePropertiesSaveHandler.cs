using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<SereneDBXplorer.Default.DatabasePropertiesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SereneDBXplorer.Default.DatabasePropertiesRow;

namespace SereneDBXplorer.Default
{
    public interface IDatabasePropertiesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class DatabasePropertiesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IDatabasePropertiesSaveHandler
    {
        public DatabasePropertiesSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}