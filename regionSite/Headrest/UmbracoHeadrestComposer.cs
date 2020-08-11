using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Mapping;

namespace regionSite.Headrest
{
    [ComposeAfter(typeof(UmbracoHeadRestComposer))]
    public class UmbracoHeadRestComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {

            composition.Components()
                .Append<UmbracoHeadrestComponent>();

            composition.WithCollectionBuilder<MapDefinitionCollectionBuilder>()
                .Add<MapDefinitions>();
        }
    }
}