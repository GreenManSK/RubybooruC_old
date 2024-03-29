using System;
using System.Collections.Generic;

namespace IqdbApi.parsers
{
    public class ParseResult
    {
        public List<Tag> Tags { get; }
        public Uri Image { get; }
        public Uri Source { get; }

        public ParseResult(List<Tag> tags, Uri image, Uri source)
        {
            Tags = tags;
            Image = image;
            Source = source;
        }
    }
}