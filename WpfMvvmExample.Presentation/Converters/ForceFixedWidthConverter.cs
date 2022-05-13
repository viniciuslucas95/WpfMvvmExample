using WpfMvvmExample.Presentation.Constants;

namespace WpfMvvmExample.Presentation.Converters;

internal class ForceFixedWidthConverter : ForceNumberConverter
{
    public ForceFixedWidthConverter() : base(TextFieldConstants.MIN_TEXT_FIELD_WIDTH) { }
}
