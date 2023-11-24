using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace ColorMappingExample {
    class PriorityToColorConverter : MarkupExtension, IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is Priority val) {
                switch (val) {
                    case Priority.High:
                    return Colors.Red;

                    case Priority.Normal:
                    return Colors.Yellow;

                    case Priority.Low:
                    return Colors.Green;

                    default:
                    return Colors.Black;
                }
            }
            return Colors.Transparent;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
    }
}
