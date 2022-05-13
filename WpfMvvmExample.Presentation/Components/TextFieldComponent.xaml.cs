using System.Windows;
using System.Windows.Controls;

namespace WpfMvvmExample.Presentation.Components;

public partial class TextFieldComponent : UserControl
{
    public static readonly DependencyProperty LabelProperty =
        DependencyProperty.Register("Label", typeof(string), typeof(TextFieldComponent));
    public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register("Text", typeof(string),
            typeof(TextFieldComponent),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

    public string Label
    {
        get => (string)GetValue(LabelProperty);
        set => SetValue(LabelProperty, value);
    }

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set
        {
            SetValue(TextProperty, value);
        }
    }

    public TextFieldComponent()
    {
        InitializeComponent();
    }
}
