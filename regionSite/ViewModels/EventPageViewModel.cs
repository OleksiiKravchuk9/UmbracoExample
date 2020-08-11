using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace regionSite.ViewModels
{
    public class EventPageViewModel
    {

        public string Description { get; set; }

        public string Title { get; set; }

        public bool IsSearchable { get; set; }

        public string SearchDescription { get; set; }

        public string SearchTitle { get; set; }

        public string Path { get; set; }

        public string Type { get; set; }

        public IEnumerable<EventPageItemViewModel> Children { get; set; }
    }
}