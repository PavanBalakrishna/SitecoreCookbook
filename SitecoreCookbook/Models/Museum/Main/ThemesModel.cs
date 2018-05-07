using SitecoreCookbook.Models.GlassMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using SitecoreCookbook.Models.Museum.Sections.DatModels;

namespace SitecoreCookbook.Models.Museum.Main
{
    [SitecoreType(AutoMap =true)]
    public class ThemesModel : GlassBase
    {
     
        public override Guid Id { get; set; }


        public override string Name { get; set; }

  
        public override string Template { get; set; }


        public virtual string Title { get; set; }

        
        public virtual string Description { get; set; }


        public virtual Image BackGroundImage { get; set; }

        
        public virtual IEnumerable<Attraction> Attractions { get; set; }
    }
}