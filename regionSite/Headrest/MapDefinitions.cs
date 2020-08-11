using regionSite.ViewModels;
using regionSite.ViewModelsMappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Mapping;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.PublishedModels;

namespace regionSite.Headrest
{
    public class MapDefinitions : IMapDefinition
    {
        public void DefineMaps(UmbracoMapper mapper)
        {
            mapper.Define<HomePage, HomePageViewModel>(HomePageMap.Instance.Map);
            mapper.Define<HomePage, SitemapViewModel>(ViewModelsMappings.SiteMap.Instance.Map);
            mapper.Define<PublishedContentModel, BasicNodeViewModel>(BasicNodeMap.Instance.Map);
            mapper.Define<HomePageChild, HomeChildViewModel>(HomePageChildMap.Instance.Map);
            mapper.Define<EventPage, EventPageViewModel>(EventPageMap.Instance.Map);
        }
    }
}