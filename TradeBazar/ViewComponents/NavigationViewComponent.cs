using Microsoft.AspNetCore.Mvc;
using TradeBazar.ViewModels;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace TradeBazar.ViewComponents;

public class NavigationViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(Settings settings, string language)
    {
        var navigation = settings?.MainNavigation?
            .Select(x => (NavigationItem)x.Content) ?? Enumerable.Empty<NavigationItem>();
        
        var model = new NavigationViewModel
        {
            Navigation = navigation,
            Language = language
        };

        // ReSharper disable once Mvc.ViewComponentViewNotResolved
        return View(model);
    }
}