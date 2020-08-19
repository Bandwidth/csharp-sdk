using Newtonsoft.Json.Converters;

namespace Bandwidth.Standard.Utilities
{
    public class CustomDateTimeConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the CustomDateTimeConverter object based on the given format.
        /// </summary>
        public CustomDateTimeConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}