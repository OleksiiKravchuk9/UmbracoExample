using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Mapping;
using Umbraco.Core.Models.PublishedContent;

namespace regionSite.ViewModelsMappings
{
    public class BasicNodeMap : BaseMap<BasicNodeMap, PublishedContentModel, BasicNodeViewModel>
    {
        public override void Map(PublishedContentModel src, BasicNodeViewModel dst, MapperContext ctx)
        {
            dst.Id = src.Id;
            dst.Url = src.Url;
            dst.Type = src.ContentType.Alias;
            dst.Children = src.Children.Select(x => Map((PublishedContentModel)x, ctx));
            dst.Name = src.Name;
        }
    }
}