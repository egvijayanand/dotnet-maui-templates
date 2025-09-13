#nullable enable

namespace VijayAnand.MauiTemplates.Extensions
{
    public static class StringExtensions
    {
        public static bool IsEmpty(this string? value)
            => string.IsNullOrEmpty(value);

        public static bool HasValue(this string? value)
            => !string.IsNullOrWhiteSpace(value);
    }
}
