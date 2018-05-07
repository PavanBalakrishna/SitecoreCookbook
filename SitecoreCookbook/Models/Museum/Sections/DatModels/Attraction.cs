using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using SitecoreCookbook.Models.GlassMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreCookbook.Models.Museum.Sections.DatModels
{
    [SitecoreType(AutoMap = true)]
    public class Attraction : GlassBase
    {
        public override Guid Id { get; set; }
        public override string Name { get; set; }
        public override string Template { get; set; }


        public virtual string Description { get; set; }

        public virtual bool IsFree { get; set; }


        //[SitecoreField(FieldName = "PageUrl", UrlOptions = SitecoreInfoUrlOptions.AlwaysIncludeServerUrl | SitecoreInfoUrlOptions.SiteResolving)]
        public virtual Link PageUrl { get; set; }

        public virtual Image BackGroungImage { get; set; }

        public virtual decimal Cost { get; set; }
    }

}