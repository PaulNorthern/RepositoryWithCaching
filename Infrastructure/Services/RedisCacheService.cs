using System;
using Core.Interfaces;

namespace Infrastructure.Services
{
    public class RedisCacheService : ICacheService
    {
        public bool TryGet<T>(string cacheKey, out T value)
        {
            throw new NotImplementedException();
        }

        public T Set<T>(string cacheKey, T value)
        {
            throw new NotImplementedException();
        }

        public void Remove(string cacheKey)
        {
            throw new NotImplementedException();
        }
    }
}
