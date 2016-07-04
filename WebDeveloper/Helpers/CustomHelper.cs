using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helpers
{
    public static class CustomHelper
    {
        #region Displays
        public static IHtmlString DisplayPriceStatic(double price)
        {
            return new HtmlString(DisplayPrintPrice(price));
        }
        public static IHtmlString DisplayPriceExtension(this HtmlHelper helper,double price)
        {          
            return new HtmlString(DisplayPrintPrice(price));
        }
        public static IHtmlString DisplayDateOrNull(DateTime? SellEndDate)
        {
            return new HtmlString(DisplayPrintDate(SellEndDate));
        }
        public static IHtmlString DisplayDateOrNullExtension(this HtmlHelper helper, DateTime? SellEndDate)
        {
            return new HtmlString(DisplayPrintDate(SellEndDate));
        }
        #endregion

        #region Metodos
        private static string DisplayPrintPrice(double price)
        {
            return (price == 0.0 ? "<span></span" : $"<span>{price}</span");
        }
        private static string DisplayPrintDate(DateTime? SellEndDate)
        {
            return (SellEndDate.HasValue ? "<span></span" : $"<span>{SellEndDate}</span");
        }
        #endregion
    }
}
