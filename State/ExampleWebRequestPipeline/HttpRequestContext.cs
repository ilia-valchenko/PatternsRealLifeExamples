using System;
using State.ExampleWebRequestPipeline.States;
using State.ExampleWebRequestPipeline.States.Interfaces;

namespace State.ExampleWebRequestPipeline
{
    /// <summary>
    /// HttpRequestContext holds the request data and a reference to the current state.
    /// The state objects define what happens when the request is processed, and they also control transitions to the next state.
    /// </summary>
    public class HttpRequestContext
    {
        private IRequestState _currentState;

        public string Url { get; }
        public string Method { get; }

        public string User { get; set; }
        public bool IsAuthenticated { get; set; }
        public bool IsAuthorized { get; set; }
        public string Response { get; set; }

        public HttpRequestContext(string url, string method)
        {
            Url = url;
            Method = method;

            _currentState = new ReceivedState(); // Initial state
        }

        public void SetState(IRequestState newState)
        {
            _currentState = newState;
            Console.WriteLine($"Request state changed to: {newState.GetType().Name}");
        }

        public void Process()
        {
            // Delegating processing to the current state.
            _currentState.Handle(this);
        }
    }
}
