using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Mapping;
using Umbraco.Web.PublishedModels;

namespace regionSite.ViewModelsMappings
{
    public class SiteMap : BaseMap<SiteMap, HomePage, SitemapViewModel>
    {
        public override void Map(HomePage src, SitemapViewModel dst, MapperContext ctx)
        {
            dst.Root = BasicNodeMap.Instance.Map(src, ctx);

        }
    }
}