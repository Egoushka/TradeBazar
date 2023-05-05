using Microsoft.AspNetCore.Mvc;
using TradeBazar.ViewModels;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace TradeBazar.ViewComponents;

public class MetaDataViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(IPublishedContent content)
    {
        var seoTags = content.Value<IEnumerable<string>>("seoTags");
        
        var tags = string.Join(", ", seoTags ?? Array.Empty<string>());
        
        var seoTitle = content.Value<string>("seoTitle");
        
        var seoDescription = content.Value<string>("seoDescription");
        
        
        var metaDataViewModel = new MetaDataViewModel
        {
            SeoTags = tags,
            SeoTitle = seoTitle,
            SeoDescription = seoDescription
        };
        
        // ReSharper disable once Mvc.ViewComponentViewNotResolved
        return View(metaDataViewModel);
    }
}