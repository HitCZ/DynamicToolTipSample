using System;
using System.Globalization;
using System.Windows.Data;

namespace DynamicToolTipSample
{
    public class BooleanToStringConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.IsNullOrEmpty() || values.Length < 3)
                return string.Empty;

            if (values[0] is bool boolValue && values[1] is string value1 && values[2] is string value2)
                return boolValue ? value1 : value2;
            return string.Empty;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
