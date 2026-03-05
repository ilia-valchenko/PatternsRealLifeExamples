using System;
using State.ExampleWebRequestPipeline.States.Interfaces;

namespace State.ExampleWebRequestPipeline.States
{
    public class ReceivedState : IRequestState
    {
        public void Handle(HttpRequestContext context)
        {
            Console.WriteLine($"Request received: {context.Method} {context.Url}");

            // Parse header, extract user, ect.
            // For demo, assume we got a user from a header.
            context.User = "john_doe";

            Console.WriteLine($"Authenticating user: '{context.User}'.");

            context.SetState(new AuthenticatingState());
        }
    }
}
