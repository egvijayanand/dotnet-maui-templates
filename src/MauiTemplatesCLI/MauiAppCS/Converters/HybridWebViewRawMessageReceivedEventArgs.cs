using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace MauiApp._1.Converters
{
    [AcceptEmptyServiceProvider]
    public partial class HybridWebViewRawMessageReceivedEventArgsConverter : BaseConverterOneWay<HybridWebViewRawMessageReceivedEventArgs?, object?>
    {
        public override object? DefaultConvertReturnValue { get; set; } = null;

        [return: NotNullIfNotNull(nameof(value))]
        public override object? ConvertFrom(HybridWebViewRawMessageReceivedEventArgs? value, CultureInfo? culture)
            => value switch
            {
                null => null,
                _ => value.Message
            };
    }
}
