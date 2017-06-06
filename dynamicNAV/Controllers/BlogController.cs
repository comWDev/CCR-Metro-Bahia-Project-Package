using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using dynamicNAV.Models;
using Umbraco.Web;
using Umbraco.Core.Models;
using Archetype.Models;

namespace dynamicNAV.Controllers
{
    public class BlogController : SurfaceController
    {

        private const string PARTIAL_VIEW_FOLDER = "~/Views/Partials/";
	

	public ActionResult RenderPostList()
        {

            List<BlogPreview> model = new List<BlogPreview>();
            IPublishedContent blogPage = CurrentPage.AncestorOrSelf(1).DescendantsOrSelf().Where(x => x.DocumentTypeAlias == "articlesItem").FirstOrDefault();
            ArchetypeModel BlogPreviews = blogPage.GetPropertyValue<ArchetypeModel>("BlogPreviews");

            foreach (IPublishedContent page in blogPage.Children.OrderByDescending(x => x.UpdateDate))
            {
                int imageId = page.GetPropertyValue<int>("articleImage");
                var mediaItem = Umbraco.Media(imageId);

                model.Add(new BlogPreview(page.Name, page.GetPropertyValue<string>("articleIntro"), mediaItem.Url, page.Url));
            }

            return PartialView(PARTIAL_VIEW_FOLDER + "_PostList.cshtml", model);

        }
    }
}
