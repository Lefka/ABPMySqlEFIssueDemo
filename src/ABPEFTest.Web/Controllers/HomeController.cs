using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ABPEFTest.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABPEFTestControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}