using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace RedisClass.Extensions
{
    public static  class DistributedCacheExtention
    {
        public static async Task SetRecordAsync<T>(
            this IDistributedCache cache,
            string recodrKey,
            T data,
            TimeSpan? absoluteExpirationTime=null,
            TimeSpan? unusedExpirationTime=null
            )
        {
            var options = new DistributedCacheEntryOptions();
            options.AbsoluteExpirationRelativeToNow = absoluteExpirationTime ?? TimeSpan.FromSeconds(60);
            options.SlidingExpiration = unusedExpirationTime;
            var jsonData=JsonSerializer.Serialize(data);
            await cache.SetStringAsync(recodrKey, jsonData, options);
        }
        public static async Task<T> GetRecordAsync<T>(this IDistributedCache cahce,string recordKey)
        {
            var jsonData=await cahce.GetStringAsync(recordKey);
            if (jsonData is null) return default(T);
            return JsonSerializer.Deserialize<T>(jsonData);
        }
    }
}
