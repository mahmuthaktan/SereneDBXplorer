using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SereneDBXplorer.Definition.Pages 
{

    [PageAuthorize(typeof(DatabaseDefinitionsRow))]
    public class DatabaseDefinitionsController : Controller
    {
        [Route("Definition/DatabaseDefinitions")]
        public ActionResult Index()
        {
            return this.GridPage("@/Definition/DatabaseDefinitions/DatabaseDefinitionsPage",
                DatabaseDefinitionsRow.Fields.PageTitle());
        }
    }
}