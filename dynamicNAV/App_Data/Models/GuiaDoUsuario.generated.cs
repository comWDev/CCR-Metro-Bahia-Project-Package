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
	/// <summary>Guia do usuário</summary>
	[PublishedContentModel("guiaDoUsuario")]
	public partial class GuiaDoUsuario : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "guiaDoUsuario";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public GuiaDoUsuario(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<GuiaDoUsuario, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// hSection Items
		///</summary>
		[ImplementPropertyType("hSectionItems")]
		public Archetype.Models.ArchetypeModel HSectionItems
		{
			get { return this.GetPropertyValue<Archetype.Models.ArchetypeModel>("hSectionItems"); }
		}

		///<summary>
		/// Section Icon
		///</summary>
		[ImplementPropertyType("sectionIcon")]
		public IPublishedContent SectionIcon
		{
			get { return this.GetPropertyValue<IPublishedContent>("sectionIcon"); }
		}

		///<summary>
		/// Section Intro
		///</summary>
		[ImplementPropertyType("sectionIntro")]
		public IHtmlString SectionIntro
		{
			get { return this.GetPropertyValue<IHtmlString>("sectionIntro"); }
		}

		///<summary>
		/// Section Title
		///</summary>
		[ImplementPropertyType("sectionTitle")]
		public string SectionTitle
		{
			get { return this.GetPropertyValue<string>("sectionTitle"); }
		}
	}
}
