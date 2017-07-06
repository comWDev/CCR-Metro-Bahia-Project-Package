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
	// Mixin content Type 1490 with alias "estacoesTabs"
	/// <summary>estacoesTabs</summary>
	public partial interface IEstacoesTabs : IPublishedContent
	{
		/// <summary>estacoesTabsContent</summary>
		Archetype.Models.ArchetypeModel EstacoesTabsContent { get; }
	}

	/// <summary>estacoesTabs</summary>
	[PublishedContentModel("estacoesTabs")]
	public partial class EstacoesTabs : PublishedContentModel, IEstacoesTabs
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "estacoesTabs";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public EstacoesTabs(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<EstacoesTabs, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// estacoesTabsContent
		///</summary>
		[ImplementPropertyType("estacoesTabsContent")]
		public Archetype.Models.ArchetypeModel EstacoesTabsContent
		{
			get { return GetEstacoesTabsContent(this); }
		}

		/// <summary>Static getter for estacoesTabsContent</summary>
		public static Archetype.Models.ArchetypeModel GetEstacoesTabsContent(IEstacoesTabs that) { return that.GetPropertyValue<Archetype.Models.ArchetypeModel>("estacoesTabsContent"); }
	}
}