using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Mapping;
using Umbraco.Core.Models.PublishedContent;

namespace regionSite.ViewModelsMappings
{
    public abstract class BaseMap<TSelf, TFrom, TTo>
        where TSelf : BaseMap<TSelf, TFrom, TTo>, new()
        where TTo : new()
    {
        private static readonly Lazy<TSelf> lazy = new Lazy<TSelf>(() => new TSelf());

        public static TSelf Instance { get { return lazy.Value; } }

        protected BaseMap()
        { }

        public TTo Map(TFrom src, MapperContext ctx)
        {
            var dst = new TTo();
            Map(src, dst, ctx);
            return dst;
        }

        public abstract void Map(TFrom src, TTo dst, MapperContext ctx);
    }
}