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
	/// <summary>Guia Content Page</summary>
	[PublishedContentModel("guiaContentPage")]
	public partial class GuiaContentPage : GuiaDoUsuario, ICustomTabs
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "guiaContentPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public GuiaContentPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<GuiaContentPage, TValue>> selector)
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
		/// Slider Pictures
		///</summary>
		[ImplementPropertyType("sliderPictures")]
		public IEnumerable<IPublishedContent> SliderPictures
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("sliderPictures"); }
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

		///<summary>
		/// customTabsA
		///</summary>
		[ImplementPropertyType("customTabsA")]
		public Archetype.Models.ArchetypeModel CustomTabsA
		{
			get { return Umbraco.Web.PublishedContentModels.CustomTabs.GetCustomTabsA(this); }
		}
	}
}
