using Cheap.Flights.Business.Common.Interfaces;
using Microsoft.Extensions.Caching.Memory;

namespace WebApplicationTemplate.Infrastructure.Services
{
    public class MemoryCacheService : ICacheService
    {
        private readonly IMemoryCache _memoryCache;

        public MemoryCacheService(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public T? Get<T>(string key)
        {
            return _memoryCache.TryGetValue(key, out T value) ? value : default;
        }

        public void Set<T>(string key, T value, TimeSpan duration)
        {
            _memoryCache.Set(key, value, duration);
        }

        public void Remove(string key)
        {
            _memoryCache.Remove(key);
        }

        public bool Exists(string key)
        {
            return _memoryCache.TryGetValue(key, out _);
        }
    }
}
