//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
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
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	// Mixin content Type 1273 with alias "pageSubContentBlock"
	/// <summary>Page Sub Content Block</summary>
	public partial interface IPageSubContentBlock : IPublishedContent
	{
		/// <summary>Page Body Text</summary>
		IHtmlString PageBodyText { get; }

		/// <summary>Sub Title</summary>
		string SubTitle { get; }

		/// <summary>Sub Title Icon</summary>
		IPublishedContent SubTitleIcon { get; }
	}

	/// <summary>Page Sub Content Block</summary>
	[PublishedContentModel("pageSubContentBlock")]
	public partial class PageSubContentBlock : PublishedContentModel, IPageSubContentBlock
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pageSubContentBlock";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PageSubContentBlock(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PageSubContentBlock, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Page Body Text
		///</summary>
		[ImplementPropertyType("pageBodyText")]
		public IHtmlString PageBodyText
		{
			get { return GetPageBodyText(this); }
		}

		/// <summary>Static getter for Page Body Text</summary>
		public static IHtmlString GetPageBodyText(IPageSubContentBlock that) { return that.GetPropertyValue<IHtmlString>("pageBodyText"); }

		///<summary>
		/// Sub Title
		///</summary>
		[ImplementPropertyType("subTitle")]
		public string SubTitle
		{
			get { return GetSubTitle(this); }
		}

		/// <summary>Static getter for Sub Title</summary>
		public static string GetSubTitle(IPageSubContentBlock that) { return that.GetPropertyValue<string>("subTitle"); }

		///<summary>
		/// Sub Title Icon
		///</summary>
		[ImplementPropertyType("subTitleIcon")]
		public IPublishedContent SubTitleIcon
		{
			get { return GetSubTitleIcon(this); }
		}

		/// <summary>Static getter for Sub Title Icon</summary>
		public static IPublishedContent GetSubTitleIcon(IPageSubContentBlock that) { return that.GetPropertyValue<IPublishedContent>("subTitleIcon"); }
	}
}
