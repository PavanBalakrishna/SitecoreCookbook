using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using SitecoreCookbook.Models.Museum.Sections.DatModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreCookbook.Controllers
{
    public class ThemesController : GlassController
    {
       public ActionResult GetAttraction()
        {
            var context = new SitecoreContext();
            Attraction model = GetDataSourceItem<Attraction>();
            return View("~/Views/Museum/Main/_ThemesAndAttractions.cshtml", model);
        }
    }
}