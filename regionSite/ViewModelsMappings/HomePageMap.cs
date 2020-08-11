using regionSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;
using Umbraco.Core.Mapping;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.PublishedModels;

namespace regionSite.ViewModelsMappings
{
    public class HomePageMap : BaseMap<HomePageMap, HomePage, HomePageViewModel>
    {
        public override void Map(HomePage src, HomePageViewModel dst, MapperContext ctx)
        {
            dst.Title = src.Title;
            dst.Subtitle = src.Subtitle;
            dst.Paragraph = src.Paragraph;
            dst.Content = src.Content;
            dst.Children = src.Children<HomePageChild>().Select(x => new HomeChildViewModel()
            {
                ChildData = x.ChildData
            });
        }
    }
}