using System;

namespace State.ExampleWebRequestPipeline
{
    // The State pattern lets an object change its behavior when its internal state changes.
    // It looks as if the object changed its class. Instead of using large conditional statements (if/else or switch)
    // to handle state-specific behavior, you delegate that behavior to separate state objects.
    // Each state object encapsulates the rules for one particular state, and the main object (the Context)
    // holds a reference to the current state. When the state changes, the context switches to a different state object,
    // and its behavior changes accordingly.
    public static class MainApp
    {
        public static void Main()
        {
            // Simulate an incoming request.
            var request = new HttpRequestContext("/admin/dashboard", "GET");
            request.Process();

            Console.WriteLine("\n------ Another request ------\n");

            var publicRequest = new HttpRequestContext("/public/home", "GET");
            publicRequest.Process();
        }
    }
}
