using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SereneDBXplorer.Default.Pages 
{

    [PageAuthorize(typeof(DatabasePropertiesRow))]
    public class DatabasePropertiesController : Controller
    {
        [Route("Default/DatabaseProperties")]
        public ActionResult Index()
        {
            return this.GridPage("@/Default/DatabaseProperties/DatabasePropertiesPage",
                DatabasePropertiesRow.Fields.PageTitle());
        }
    }
}