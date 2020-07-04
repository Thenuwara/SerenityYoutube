using Serenity.Navigation;
using MyPages = SerenityApp.Market.Pages;

[assembly: NavigationMenu(int.MaxValue, "Market", icon: "fa-shopping-bag ")]
[assembly: NavigationLink(int.MaxValue, "Market/Store", typeof(MyPages.StoreController), icon: "fa-shopping-cart")]
[assembly: NavigationLink(int.MaxValue, "Market/Visit", typeof(MyPages.VisitController), icon: "fa-truck")]