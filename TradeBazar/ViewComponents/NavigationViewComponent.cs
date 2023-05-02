using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace TradeBazar.ViewComponents;

public class NavigationViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(IPublishedContent content)
    {
        var homePage = content.AncestorOrSelf<HomePage>();
        
        var navigation = homePage?.MainNavigation?
            .Select(x => (NavigationItem)x.Content) ?? Enumerable.Empty<NavigationItem>();

        // ReSharper disable once Mvc.ViewComponentViewNotResolved
        return View(navigation);
    }
}