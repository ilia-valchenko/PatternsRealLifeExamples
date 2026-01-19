using System;
using System.Threading.Tasks;
using Proxy.Interfaces;

namespace Proxy
{
    public class AmazonDynamoDb : IAmazonDynamoDb
    {
        public Task<T> GetAsync<T>(string id) where T : class
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync<T>(T item) where T : class
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}