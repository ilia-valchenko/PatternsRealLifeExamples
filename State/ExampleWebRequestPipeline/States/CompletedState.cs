using System;
using State.ExampleWebRequestPipeline.States.Interfaces;

namespace State.ExampleWebRequestPipeline.States
{
    public class CompletedState : IRequestState
    {
        public void Handle(HttpRequestContext context)
        {
            Console.WriteLine($"Request completed. Response: {context.Response}");

            // End of pipeline.
        }
    }
}
