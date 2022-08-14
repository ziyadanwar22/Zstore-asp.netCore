using Serenity.Navigation;
using MyPages = Admin.souqcom.Pages;

[assembly: NavigationLink(int.MaxValue, "souqcom/Category", typeof(MyPages.CategoryController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "souqcom/Cart", typeof(MyPages.CartController), icon: null)]