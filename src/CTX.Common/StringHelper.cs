using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTX.Common
{
    public static class StringHelper
    {
        public static string StripDiacritics(this String text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }

    public struct AdSortType
    {
        public const string Id = "id";
        public const string Title = "title";
        public const string Favorite = "favorite";
        public const string FavoriteDate = "favoritedate";
        public const string Price = "price";
        public const string Rate = "rate";
        public const string Recently = "recently";
        public const string Score = "score";
        public const string Type = "type";
        public const string CreatedDate = "created-date";
    }
}
