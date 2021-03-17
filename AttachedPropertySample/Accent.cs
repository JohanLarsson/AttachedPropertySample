namespace AttachedPropertySample
{
    using System.Windows;
    using System.Windows.Media;

    public static class Accent
    {
        public static readonly DependencyProperty BrushProperty = DependencyProperty.RegisterAttached(
            "Brush",
            typeof(Brush),
            typeof(Accent),
            new FrameworkPropertyMetadata(
                default(Brush),
                FrameworkPropertyMetadataOptions.Inherits));

        /// <summary>Helper for getting <see cref="BrushProperty"/> from <paramref name="element"/>.</summary>
        /// <param name="element"><see cref="DependencyObject"/> to read <see cref="BrushProperty"/> from.</param>
        /// <returns>Brush property value.</returns>
        [AttachedPropertyBrowsableForType(typeof(DependencyObject))]
        public static Brush GetBrush(DependencyObject element)
        {
            return (Brush)element.GetValue(BrushProperty);
        }

        /// <summary>Helper for setting <see cref="BrushProperty"/> on <paramref name="element"/>.</summary>
        /// <param name="element"><see cref="DependencyObject"/> to set <see cref="BrushProperty"/> on.</param>
        /// <param name="value">Brush property value.</param>
        public static void SetBrush(DependencyObject element, Brush value)
        {
            element.SetValue(BrushProperty, value);
        }
    }
}