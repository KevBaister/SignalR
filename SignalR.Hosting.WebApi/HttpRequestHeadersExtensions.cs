﻿using System.Collections.Specialized;
using System.Net.Http.Headers;

namespace SignalR.Hosting.WebApi
{
    internal static class HttpRequestHeadersExtensions
    {
        public static IRequestCookieCollection ParseCookies(this HttpRequestHeaders headers)
        {            
            return new CookieCollection(headers);
        }

        public static NameValueCollection ParseHeaders(this HttpRequestHeaders headers)
        {
            var headerValues = new NameValueCollection();

            foreach (var header in headers)
            {
                foreach (var value in header.Value)
                {
                    headerValues.Add(header.Key, value);
                }
            }

            return headerValues;
        }
    }
}