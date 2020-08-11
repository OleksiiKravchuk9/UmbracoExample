//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.6.3
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>EventPageItem</summary>
	[PublishedModel("eventPageItem")]
	public partial class EventPageItem : PublishedContentModel, ISeachable, ISearchableBase
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		public new const string ModelTypeAlias = "eventPageItem";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<EventPageItem, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public EventPageItem(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// EventDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		[ImplementPropertyType("eventDescription")]
		public string EventDescription => this.Value<string>("eventDescription");

		///<summary>
		/// EventName
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		[ImplementPropertyType("eventName")]
		public string EventName => this.Value<string>("eventName");

		///<summary>
		/// IsSearchable
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		[ImplementPropertyType("isSearchable")]
		public bool IsSearchable => global::Umbraco.Web.PublishedModels.Seachable.GetIsSearchable(this);

		///<summary>
		/// SearchDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		[ImplementPropertyType("searchDescription")]
		public string SearchDescription => global::Umbraco.Web.PublishedModels.SearchableBase.GetSearchDescription(this);

		///<summary>
		/// SearchTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.3")]
		[ImplementPropertyType("searchTitle")]
		public string SearchTitle => global::Umbraco.Web.PublishedModels.SearchableBase.GetSearchTitle(this);
	}
}
