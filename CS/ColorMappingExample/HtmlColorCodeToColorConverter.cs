using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace ColorMappingExample {
    #region #HtmlColorCodeToHexConverter
    class HtmlColorCodeToHexConverter : MarkupExtension, IValueConverter  {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if ((value.GetType() == typeof(string)) && value.ToString().StartsWith("#"))
                return String.Concat("0x", value.ToString().Remove(0,1));
            else
                return value;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            if ((value.GetType() == typeof(string)) && value.ToString().StartsWith("0x"))
                return String.Concat("#", value.ToString().Remove(0, 2));
            else
                return value;
        }
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
    }
    #endregion #HtmlColorCodeToHexConverter
}
