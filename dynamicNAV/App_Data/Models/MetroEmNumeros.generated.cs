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
	/// <summary>Metrô em números</summary>
	[PublishedContentModel("metroEmNumeros")]
	public partial class MetroEmNumeros : PorDentroDoMetro
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "metroEmNumeros";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public MetroEmNumeros(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<MetroEmNumeros, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Numeros List
		///</summary>
		[ImplementPropertyType("numerosList")]
		public Newtonsoft.Json.Linq.JToken NumerosList
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("numerosList"); }
		}
	}
}
