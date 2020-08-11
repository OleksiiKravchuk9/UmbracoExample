using regionSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Umbraco.Core.Mapping;
using Umbraco.Web;
using Umbraco.Web.PublishedModels;

namespace regionSite.ViewModelsMappings
{
    public class EventPageMap : BaseMap<EventPageMap, EventPage, EventPageViewModel>
    {
        public override void Map(EventPage src, EventPageViewModel dst, MapperContext ctx)
        {
            dst.Description = src.Description;

            dst.Title = src.Title;

            dst.IsSearchable = src.IsSearchable;

            dst.SearchDescription = src.SearchDescription;

            dst.SearchTitle = src.SearchTitle;

            dst.Path = src.UrlSegment;

            dst.Type = src.Name;

            dst.Children = src.Children<EventPageItem>().Select(x => new EventPageItemViewModel()
            {
                EventDescription = x.EventDescription,

                EventName = x.EventName,

                IsSearchable = x.IsSearchable,

                SearchDescription = x.SearchDescription,

                Id = x.Id.ToString(),

                SearchTitle = x.SearchTitle,

                Path = src.UrlSegment


            });

        }
    }
}