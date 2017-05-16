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
	/// <summary>Por Dentro Content Page</summary>
	[PublishedContentModel("porDentroContentPage")]
	public partial class PorDentroContentPage : PorDentroDoMetro
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "porDentroContentPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PorDentroContentPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PorDentroContentPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Page Body Text
		///</summary>
		[ImplementPropertyType("pageBodyText")]
		public IHtmlString PageBodyText
		{
			get { return this.GetPropertyValue<IHtmlString>("pageBodyText"); }
		}

		///<summary>
		/// Sub Title
		///</summary>
		[ImplementPropertyType("subTitle")]
		public string SubTitle
		{
			get { return this.GetPropertyValue<string>("subTitle"); }
		}

		///<summary>
		/// Sub Title Icon
		///</summary>
		[ImplementPropertyType("subTitleIcon")]
		public IPublishedContent SubTitleIcon
		{
			get { return this.GetPropertyValue<IPublishedContent>("subTitleIcon"); }
		}
	}
}
