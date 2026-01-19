using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Proxy.Interfaces;

namespace Proxy
{
    public class ProxyAmazonDynamoDb : IAmazonDynamoDb, IDisposable
    {
        private readonly IAmazonDynamoDb amazonDynamoDb = new AmazonDynamoDb();
        private readonly IMemoryCache memoryCache = new MemoryCache(new MemoryCacheOptions());

        private bool disposed = false;

        public async Task<T> GetAsync<T>(string id) where T : class
        {
            var cachedItem = this.memoryCache.Get<T>(id);

            if (cachedItem != null)
            {
                return cachedItem;
            }

            var item = await this.amazonDynamoDb.GetAsync<T>(id);
            this.memoryCache.Set<T>(id, item);

            return item;
        }

        public async Task SaveAsync<T>(T item) where T : class
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            await this.amazonDynamoDb.SaveAsync(item);
            this.memoryCache.Set<T>("itemId", item);
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                return;
            }

            if (disposing)
            {
                this.amazonDynamoDb?.Dispose();
                this.memoryCache?.Dispose();
            }

            this.disposed = true;
        }
    }
}