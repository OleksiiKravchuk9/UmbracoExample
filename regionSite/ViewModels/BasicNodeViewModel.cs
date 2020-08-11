using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;

namespace regionSite.ViewModelsMappings
{
    public class BasicNodeViewModel
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public IEnumerable<BasicNodeViewModel> Children { get; set; }
    }
}