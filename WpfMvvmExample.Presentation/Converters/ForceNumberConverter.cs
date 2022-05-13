using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfMvvmExample.Presentation.Converters;

internal abstract class ForceNumberConverter : IValueConverter
{
    private readonly double _defaultNumber;

    public ForceNumberConverter(double defaultNumber)
    {
        _defaultNumber = defaultNumber;
    }

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (double.IsNaN((double)value)) return _defaultNumber;
        return value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
