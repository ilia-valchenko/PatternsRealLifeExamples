using Mediator.Interfaces;

namespace Mediator.Devices
{
    public abstract class BaseDevice
    {
        protected IMediator _mediator;

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
