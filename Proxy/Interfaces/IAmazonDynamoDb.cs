using System;
using System.Threading.Tasks;

namespace Proxy.Interfaces
{
    public interface IAmazonDynamoDb : IDisposable
    {
        Task<T> GetAsync<T>(string id) where T : class;

        Task SaveAsync<T>(T item) where T : class;
    }
}