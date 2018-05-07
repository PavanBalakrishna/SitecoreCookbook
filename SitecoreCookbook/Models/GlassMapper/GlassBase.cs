using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreCookbook.Models.GlassMapper
{

    public abstract class GlassBase
    {
        public abstract Guid Id { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        public abstract string Name { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateName)]
        public abstract string Template { get; set; }
    }
}
