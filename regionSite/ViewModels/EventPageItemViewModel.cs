using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace regionSite.ViewModels
{
    public class EventPageItemViewModel
    {

        public string EventDescription { get; set; }

        public string EventName { get; set; }

        public bool IsSearchable { get; set; }

        public string SearchDescription { get; set; }

        public string Path { get; set; }

        public string Id { get; set; }

        public string SearchTitle { get; set; }
    }
}