using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace TradeBazar.ViewModels;

public class NavigationViewModel
{
    public IEnumerable<NavigationItem> Navigation { get; set; }
    public MediaWithCrops? HomeImage { get; set; }
    public string Language { get; set; }
    
}