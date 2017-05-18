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
	// Mixin content Type 1255 with alias "numerosAtype"
	/// <summary>numerosAtype</summary>
	public partial interface INumerosAtype : IPublishedContent
	{
		/// <summary>numAtype</summary>
		Archetype.Models.ArchetypeModel NumAtype { get; }
	}

	/// <summary>numerosAtype</summary>
	[PublishedContentModel("numerosAtype")]
	public partial class NumerosAtype : PublishedContentModel, INumerosAtype
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "numerosAtype";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public NumerosAtype(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<NumerosAtype, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// numAtype
		///</summary>
		[ImplementPropertyType("numAtype")]
		public Archetype.Models.ArchetypeModel NumAtype
		{
			get { return GetNumAtype(this); }
		}

		/// <summary>Static getter for numAtype</summary>
		public static Archetype.Models.ArchetypeModel GetNumAtype(INumerosAtype that) { return that.GetPropertyValue<Archetype.Models.ArchetypeModel>("numAtype"); }
	}
}