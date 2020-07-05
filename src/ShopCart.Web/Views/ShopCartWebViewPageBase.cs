using Abp.Web.Mvc.Views;

namespace ShopCart.Web.Views
{
    public abstract class ShopCartWebViewPageBase : ShopCartWebViewPageBase<dynamic>
    {

    }

    public abstract class ShopCartWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ShopCartWebViewPageBase()
        {
            LocalizationSourceName = ShopCartConsts.LocalizationSourceName;
        }
    }
}