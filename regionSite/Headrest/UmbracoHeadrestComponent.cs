using Our.Umbraco.HeadRest;
using Our.Umbraco.HeadRest.Web;
using Our.Umbraco.HeadRest.Web.Mapping;
using Our.Umbraco.HeadRest.Web.Routing;
using regionSite.ViewModels;
using regionSite.ViewModelsMappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Composing;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.PublishedModels;

namespace regionSite.Headrest
{
    public class UmbracoHeadrestComponent : IComponent
    {
        private readonly HeadRest _headRest;

        public UmbracoHeadrestComponent(HeadRest headRest)
            => _headRest = headRest;

        public void Initialize()
        {

            _headRest.ConfigureEndpoint(new HeadRestOptions
            {
                CustomRouteMappings = new HeadRestRouteMap()
                    .For("^/(?<altRoute>init|sitemap)/?$").MapTo("/")
                    /* UA Route endpoints */
                    .For("^/(?<altRoute>ua)/?$").MapTo("/")
                    .For("^/(?<altRoute>ua/sitemap)/?$").MapTo("/")
                    .For("^/(?<altRoute>ua/homepagechild)/?$").MapTo("/homepagechild")
                    .For("^/(?<altRoute>ua/eventpage)/?$").MapTo("/eventpage")

                    /*RU Route endpoints*/
                    .For("^/(?<altRoute>ru)/?$").MapTo("/")
                    .For("^/(?<altRoute>ru/sitemap)/?$").MapTo("/")
                    .For("^/(?<altRoute>ru/eventpage)/?$").MapTo("/eventpage"),

                ViewModelMappings = new HeadRestViewModelMap()
                    .For(HomePage.ModelTypeAlias)
                        .If(x => x.Request.HeadRestRouteParam("altRoute") == "sitemap")
                        .MapTo<SitemapViewModel>()
                    .For(HomePage.ModelTypeAlias)
                        .If(x => x.Request.HeadRestRouteParam("altRoute") == "ua/sitemap")
                        .MapTo<SitemapViewModel>()
                    .For(HomePage.ModelTypeAlias)
                        .If(x => x.Request.HeadRestRouteParam("altRoute") == "ua")
                        .MapTo<HomePageViewModel>()
                    .For(HomePage.ModelTypeAlias).MapTo<HomePageViewModel>()
                       /* Products Page ViewModel mappings */
                       .For(HomePageChild.ModelTypeAlias).MapTo<HomeChildViewModel>()
                       .For(EventPage.ModelTypeAlias).MapTo<EventPageViewModel>()
                    .For(HomePageChild.ModelTypeAlias)
                        .If(x => x.Request.HeadRestRouteParam("altRoute") == "/ua/homepagechild")
                        .MapTo<HomeChildViewModel>()
                    .For(HomePageChild.ModelTypeAlias)
                        .If(x => x.Request.HeadRestRouteParam("altRoute") == "/ru/homepagechild")
                        .MapTo<HomeChildViewModel>()



                    .ForEverythingElse().MapTo<PublishedContentModel>()
            });


        }

        public void Terminate() { }
    }
}