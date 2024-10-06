//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v14.2.0+1b21caa
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Annual Report</summary>
	[PublishedModel("annualReport")]
	public partial class AnnualReport : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const string ModelTypeAlias = "annualReport";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<AnnualReport, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public AnnualReport(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Annual Report - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("annualReportHeadline")]
		public virtual string AnnualReportHeadline => this.Value<string>(_publishedValueFallback, "annualReportHeadline");

		///<summary>
		/// Annual Report - Navigation1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("annualReportNavigation1")]
		public virtual string AnnualReportNavigation1 => this.Value<string>(_publishedValueFallback, "annualReportNavigation1");

		///<summary>
		/// Annual Report - Navigation2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("annualReportNavigation2")]
		public virtual string AnnualReportNavigation2 => this.Value<string>(_publishedValueFallback, "annualReportNavigation2");

		///<summary>
		/// Article tags - bubble - business
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("articleTagsBubbleBusiness")]
		public virtual string ArticleTagsBubbleBusiness => this.Value<string>(_publishedValueFallback, "articleTagsBubbleBusiness");

		///<summary>
		/// Article tags - bubble - consulting
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("articleTagsBubbleConsulting")]
		public virtual string ArticleTagsBubbleConsulting => this.Value<string>(_publishedValueFallback, "articleTagsBubbleConsulting");

		///<summary>
		/// Article tags - bubble - onatrix
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("articleTagsBubbleOnatrix")]
		public virtual string ArticleTagsBubbleOnatrix => this.Value<string>(_publishedValueFallback, "articleTagsBubbleOnatrix");

		///<summary>
		/// Article tags - title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("articleTagsTitle")]
		public virtual string ArticleTagsTitle => this.Value<string>(_publishedValueFallback, "articleTagsTitle");

		///<summary>
		/// Big text1 - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("bigText1Headline")]
		public virtual string BigText1Headline => this.Value<string>(_publishedValueFallback, "bigText1Headline");

		///<summary>
		/// Big text1 - Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("bigText1Image")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops BigText1Image => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "bigText1Image");

		///<summary>
		/// Big text1 - Text1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("bigText1Text1")]
		public virtual string BigText1Text1 => this.Value<string>(_publishedValueFallback, "bigText1Text1");

		///<summary>
		/// Big text1 - Text2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("bigText1Text2")]
		public virtual string BigText1Text2 => this.Value<string>(_publishedValueFallback, "bigText1Text2");

		///<summary>
		/// Big text1 - Text3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("bigText1Text3")]
		public virtual string BigText1Text3 => this.Value<string>(_publishedValueFallback, "bigText1Text3");

		///<summary>
		/// Big text2 - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("bigText2Headline")]
		public virtual string BigText2Headline => this.Value<string>(_publishedValueFallback, "bigText2Headline");

		///<summary>
		/// Big text2 - Text1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("bigText2Text1")]
		public virtual string BigText2Text1 => this.Value<string>(_publishedValueFallback, "bigText2Text1");

		///<summary>
		/// Big text2 - Text2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("bigText2Text2")]
		public virtual string BigText2Text2 => this.Value<string>(_publishedValueFallback, "bigText2Text2");

		///<summary>
		/// Email ticket - Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("emailTicketText")]
		public virtual string EmailTicketText => this.Value<string>(_publishedValueFallback, "emailTicketText");

		///<summary>
		/// Email ticket - Titel
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("emailTicketTitel")]
		public virtual string EmailTicketTitel => this.Value<string>(_publishedValueFallback, "emailTicketTitel");

		///<summary>
		/// Hero - OnatrixLogo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroOnatrixLogo")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops HeroOnatrixLogo => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "heroOnatrixLogo");

		///<summary>
		/// Page Titel
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitel")]
		public virtual string PageTitel => this.Value<string>(_publishedValueFallback, "pageTitel");

		///<summary>
		/// Recent Projects - Box - Date1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentProjectsBoxDate1")]
		public virtual string RecentProjectsBoxDate1 => this.Value<string>(_publishedValueFallback, "recentProjectsBoxDate1");

		///<summary>
		/// Recent Projects - Box - Date2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentProjectsBoxDate2")]
		public virtual string RecentProjectsBoxDate2 => this.Value<string>(_publishedValueFallback, "recentProjectsBoxDate2");

		///<summary>
		/// Recent Projects - Box - Date3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentProjectsBoxDate3")]
		public virtual string RecentProjectsBoxDate3 => this.Value<string>(_publishedValueFallback, "recentProjectsBoxDate3");

		///<summary>
		/// Recent Projects - Box - Date4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentProjectsBoxDate4")]
		public virtual string RecentProjectsBoxDate4 => this.Value<string>(_publishedValueFallback, "recentProjectsBoxDate4");

		///<summary>
		/// Recent Projects - Box - Image1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentProjectsBoxImage1")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops RecentProjectsBoxImage1 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "recentProjectsBoxImage1");

		///<summary>
		/// Recent Projects - Box - Image2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentProjectsBoxImage2")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops RecentProjectsBoxImage2 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "recentProjectsBoxImage2");

		///<summary>
		/// Recent Projects - Box - Image3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentProjectsBoxImage3")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops RecentProjectsBoxImage3 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "recentProjectsBoxImage3");

		///<summary>
		/// Recent Projects - Box - Image4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentProjectsBoxImage4")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops RecentProjectsBoxImage4 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "recentProjectsBoxImage4");

		///<summary>
		/// Recent Projects - Box - Title1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentProjectsBoxTitle1")]
		public virtual string RecentProjectsBoxTitle1 => this.Value<string>(_publishedValueFallback, "recentProjectsBoxTitle1");

		///<summary>
		/// Recent Projects - Box - Title2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentProjectsBoxTitle2")]
		public virtual string RecentProjectsBoxTitle2 => this.Value<string>(_publishedValueFallback, "recentProjectsBoxTitle2");

		///<summary>
		/// Recent Projects - Box - Title3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentProjectsBoxTitle3")]
		public virtual string RecentProjectsBoxTitle3 => this.Value<string>(_publishedValueFallback, "recentProjectsBoxTitle3");

		///<summary>
		/// Recent Projects - Box - Title4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentProjectsBoxTitle4")]
		public virtual string RecentProjectsBoxTitle4 => this.Value<string>(_publishedValueFallback, "recentProjectsBoxTitle4");

		///<summary>
		/// Recent Projects - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("recentProjectsHeadline")]
		public virtual string RecentProjectsHeadline => this.Value<string>(_publishedValueFallback, "recentProjectsHeadline");

		///<summary>
		/// Report List - Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("reportListDate")]
		public virtual string ReportListDate => this.Value<string>(_publishedValueFallback, "reportListDate");

		///<summary>
		/// Report List - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("reportListHeadline")]
		public virtual string ReportListHeadline => this.Value<string>(_publishedValueFallback, "reportListHeadline");

		///<summary>
		/// Report List - Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("reportListImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ReportListImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "reportListImage");

		///<summary>
		/// Report Suggestion - Headline 
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("reportSuggestionHeadline")]
		public virtual string ReportSuggestionHeadline => this.Value<string>(_publishedValueFallback, "reportSuggestionHeadline");

		///<summary>
		/// Report Suggestion - Text1 
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("reportSuggestionText1")]
		public virtual string ReportSuggestionText1 => this.Value<string>(_publishedValueFallback, "reportSuggestionText1");

		///<summary>
		/// Report Suggestion - Text2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("reportSuggestionText2")]
		public virtual string ReportSuggestionText2 => this.Value<string>(_publishedValueFallback, "reportSuggestionText2");

		///<summary>
		/// Report Suggestion - Text3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("reportSuggestionText3")]
		public virtual string ReportSuggestionText3 => this.Value<string>(_publishedValueFallback, "reportSuggestionText3");

		///<summary>
		/// Tags - Bubble - App
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tagsBubbleApp")]
		public virtual string TagsBubbleApp => this.Value<string>(_publishedValueFallback, "tagsBubbleApp");

		///<summary>
		/// Tags - Bubble - Busines plans
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tagsBubbleBusinesPlans")]
		public virtual string TagsBubbleBusinesPlans => this.Value<string>(_publishedValueFallback, "tagsBubbleBusinesPlans");

		///<summary>
		/// Tags - Bubble - Business
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tagsBubbleBusiness")]
		public virtual string TagsBubbleBusiness => this.Value<string>(_publishedValueFallback, "tagsBubbleBusiness");

		///<summary>
		/// Tags - Bubble - Finance
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tagsBubbleFinance")]
		public virtual string TagsBubbleFinance => this.Value<string>(_publishedValueFallback, "tagsBubbleFinance");

		///<summary>
		/// Tags - Bubble - Insights
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tagsBubbleInsights")]
		public virtual string TagsBubbleInsights => this.Value<string>(_publishedValueFallback, "tagsBubbleInsights");

		///<summary>
		/// Tags - Bubble - Pricing
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tagsBubblePricing")]
		public virtual string TagsBubblePricing => this.Value<string>(_publishedValueFallback, "tagsBubblePricing");

		///<summary>
		/// Tags - Bubble - Project
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tagsBubbleProject")]
		public virtual string TagsBubbleProject => this.Value<string>(_publishedValueFallback, "tagsBubbleProject");

		///<summary>
		/// Tags - Bubble - Report
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tagsBubbleReport")]
		public virtual string TagsBubbleReport => this.Value<string>(_publishedValueFallback, "tagsBubbleReport");

		///<summary>
		/// Tags - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tagsHeadline")]
		public virtual string TagsHeadline => this.Value<string>(_publishedValueFallback, "tagsHeadline");

		///<summary>
		/// Text interrupt - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("textInterruptHeadline")]
		public virtual string TextInterruptHeadline => this.Value<string>(_publishedValueFallback, "textInterruptHeadline");

		///<summary>
		/// Text interrupt - Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("textInterruptImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops TextInterruptImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "textInterruptImage");

		///<summary>
		/// Text interrupt - Text1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("textInterruptText1")]
		public virtual string TextInterruptText1 => this.Value<string>(_publishedValueFallback, "textInterruptText1");

		///<summary>
		/// Text interrupt - Text2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("textInterruptText2")]
		public virtual string TextInterruptText2 => this.Value<string>(_publishedValueFallback, "textInterruptText2");

		///<summary>
		/// Your Project - Email - EmailAddress
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("yourProjectEmailEmailAddress")]
		public virtual string YourProjectEmailEmailAddress => this.Value<string>(_publishedValueFallback, "yourProjectEmailEmailAddress");

		///<summary>
		/// Your Project - Email - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("yourProjectEmailHeadline")]
		public virtual string YourProjectEmailHeadline => this.Value<string>(_publishedValueFallback, "yourProjectEmailHeadline");

		///<summary>
		/// Your Project - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("yourProjectHeadline")]
		public virtual string YourProjectHeadline => this.Value<string>(_publishedValueFallback, "yourProjectHeadline");

		///<summary>
		/// Your Project - Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("yourProjectImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops YourProjectImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "yourProjectImage");

		///<summary>
		/// Your Project - Location - Address
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("yourProjectLocationAddress")]
		public virtual string YourProjectLocationAddress => this.Value<string>(_publishedValueFallback, "yourProjectLocationAddress");

		///<summary>
		/// Your Project - Location - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("yourProjectLocationHeadline")]
		public virtual string YourProjectLocationHeadline => this.Value<string>(_publishedValueFallback, "yourProjectLocationHeadline");

		///<summary>
		/// Your Project - PhoneNumber - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("yourProjectPhoneNumberHeadline")]
		public virtual string YourProjectPhoneNumberHeadline => this.Value<string>(_publishedValueFallback, "yourProjectPhoneNumberHeadline");

		///<summary>
		/// Your Project - PhoneNumber - Number
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("yourProjectPhoneNumberNumber")]
		public virtual string YourProjectPhoneNumberNumber => this.Value<string>(_publishedValueFallback, "yourProjectPhoneNumberNumber");
	}
}
