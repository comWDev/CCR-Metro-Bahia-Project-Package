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
	/// <summary>Comericial Content Page</summary>
	[PublishedContentModel("comericialContentPage")]
	public partial class ComericialContentPage : Comercial, IPageSubContentBlock
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "comericialContentPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ComericialContentPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ComericialContentPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Page Body Text
		///</summary>
		[ImplementPropertyType("pageBodyText")]
		public IHtmlString PageBodyText
		{
			get { return Umbraco.Web.PublishedContentModels.PageSubContentBlock.GetPageBodyText(this); }
		}

		///<summary>
		/// Sub Title
		///</summary>
		[ImplementPropertyType("subTitle")]
		public string SubTitle
		{
			get { return Umbraco.Web.PublishedContentModels.PageSubContentBlock.GetSubTitle(this); }
		}

		///<summary>
		/// Sub Title Icon
		///</summary>
		[ImplementPropertyType("subTitleIcon")]
		public IPublishedContent SubTitleIcon
		{
			get { return Umbraco.Web.PublishedContentModels.PageSubContentBlock.GetSubTitleIcon(this); }
		}
	}
}
