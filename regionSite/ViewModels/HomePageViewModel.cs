using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.PublishedModels;

namespace regionSite.ViewModels
{
    public class HomePageViewModel
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Paragraph { get; set; }
        public string Content { get; set; }

        public IEnumerable<HomeChildViewModel> Children { get; set; }
    }
}