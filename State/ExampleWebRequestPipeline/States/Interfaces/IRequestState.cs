namespace State.ExampleWebRequestPipeline.States.Interfaces
{
    public interface IRequestState
    {
        void Handle(HttpRequestContext context);
    }
}
