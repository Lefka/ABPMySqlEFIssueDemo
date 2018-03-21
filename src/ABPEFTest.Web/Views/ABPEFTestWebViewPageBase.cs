using Abp.Web.Mvc.Views;

namespace ABPEFTest.Web.Views
{
    public abstract class ABPEFTestWebViewPageBase : ABPEFTestWebViewPageBase<dynamic>
    {

    }

    public abstract class ABPEFTestWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ABPEFTestWebViewPageBase()
        {
            LocalizationSourceName = ABPEFTestConsts.LocalizationSourceName;
        }
    }
}