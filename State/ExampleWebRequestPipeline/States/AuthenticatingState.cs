using System;
using State.ExampleWebRequestPipeline.States.Interfaces;

namespace State.ExampleWebRequestPipeline.States
{
    public class AuthenticatingState : IRequestState
    {
        public void Handle(HttpRequestContext context)
        {
            // Simulate authentication (e.g. validate token).
            if (!string.IsNullOrWhiteSpace(context.User))
            {
                context.IsAuthenticated = true;
                Console.WriteLine("User authenticated successfully.");
                context.SetState(new AuthorizingState());
            }
            else
            {
                context.Response = "401 Unauthorized";
                Console.WriteLine("Authentication failed");
                context.SetState(new CompletedState());
            }
        }
    }
}
