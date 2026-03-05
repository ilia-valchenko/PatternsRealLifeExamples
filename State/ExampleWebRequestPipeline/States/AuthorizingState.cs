using System;
using State.ExampleWebRequestPipeline.States.Interfaces;

namespace State.ExampleWebRequestPipeline.States
{
    public class AuthorizingState : IRequestState
    {
        public void Handle(HttpRequestContext context)
        {
            // Simple authorization: allow all requests to "/public", otherwise require role.
            if (context.Url.StartsWith("/public") || string.Equals(context.User, "admin", StringComparison.OrdinalIgnoreCase))
            {
                context.IsAuthorized = true;
                Console.WriteLine("Authorization successful.");
                context.SetState(new ProcessingState());
            }
            else
            {
                context.Response = "403 Forbidden";
                Console.WriteLine("Authrization failed.");
                context.SetState(new CompletedState());
            }
        }
    }
}
