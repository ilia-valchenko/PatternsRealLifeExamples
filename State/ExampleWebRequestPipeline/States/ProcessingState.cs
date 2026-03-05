using System;
using State.ExampleWebRequestPipeline.States.Interfaces;

namespace State.ExampleWebRequestPipeline.States
{
    public class ProcessingState : IRequestState
    {
        public void Handle(HttpRequestContext context)
        {
            Console.WriteLine($"Processing request for '{context.Url}'.");

            // Simulate work.
            context.Response = $"200 OK. Content: Hello, {context.User}!";
            context.SetState(new CompletedState());
        }
    }
}
