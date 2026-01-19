using System;
using Proxy.Interfaces;

namespace Proxy
{
    public class MainApp
    {
        public void Main()
        {
            var id = Guid.NewGuid().ToString();

            IAmazonDynamoDb dynamoDb = new ProxyAmazonDynamoDb();
            var result = dynamoDb.GetAsync<string>(id).Result;
        }
    }
}