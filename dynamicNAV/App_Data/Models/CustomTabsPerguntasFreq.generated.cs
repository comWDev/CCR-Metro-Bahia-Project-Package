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
	// Mixin content Type 1315 with alias "customTabsPerguntasFreq"
	/// <summary>CustomTabsPerguntasFreq</summary>
	public partial interface ICustomTabsPerguntasFreq : IPublishedContent
	{
		/// <summary>Custom Tabs APF</summary>
		Archetype.Models.ArchetypeModel CustomTabsApf { get; }
	}

	/// <summary>CustomTabsPerguntasFreq</summary>
	[PublishedContentModel("customTabsPerguntasFreq")]
	public partial class CustomTabsPerguntasFreq : PublishedContentModel, ICustomTabsPerguntasFreq
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "customTabsPerguntasFreq";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public CustomTabsPerguntasFreq(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CustomTabsPerguntasFreq, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Custom Tabs APF
		///</summary>
		[ImplementPropertyType("customTabsAPF")]
		public Archetype.Models.ArchetypeModel CustomTabsApf
		{
			get { return GetCustomTabsApf(this); }
		}

		/// <summary>Static getter for Custom Tabs APF</summary>
		public static Archetype.Models.ArchetypeModel GetCustomTabsApf(ICustomTabsPerguntasFreq that) { return that.GetPropertyValue<Archetype.Models.ArchetypeModel>("customTabsAPF"); }
	}
}
