using regionSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Mapping;
using Umbraco.Web.PublishedModels;

namespace regionSite.ViewModelsMappings
{
    public class HomePageChildMap : BaseMap<HomePageChildMap, HomePageChild, HomeChildViewModel>
    {
        public override void Map(HomePageChild src, HomeChildViewModel dst, MapperContext ctx)
        {
            dst.ChildData = src.ChildData;
        }
    }
}