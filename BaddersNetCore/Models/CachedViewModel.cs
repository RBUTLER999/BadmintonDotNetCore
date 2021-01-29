using System.Net;
using Microsoft.Extensions.Caching.Memory;

namespace BaddersNetCore.Models
{
    public class CachedViewModel : ILatestResults
    {
        private readonly IMemoryCache _cache;
        public CachedViewModel(IMemoryCache cache)
        {
            _cache = cache;
        }

        public string LatestResults
        {
            get
            {
                string latest = "latestResults";

                if (_cache.TryGetValue(latest, out string cachedString))
                {
                    return cachedString;
                }

                using (WebClient client = new WebClient())
                {
                    cachedString =
                        client.DownloadString(
                            "https://www.dropbox.com/s/hlj1urkxivhikdq/Results Ticker ANGEL CENTRE.htm?dl=1");

                    _cache.Set(latest, cachedString);

                    return cachedString;
                }
            }
        }
    }
}