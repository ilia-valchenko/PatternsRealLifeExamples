using Command.Example1.Interfaces;

namespace Command.Example1.Commands
{
    public class DrawCircleCommand : ICommand
    {
        private readonly CanvasReceiver _canvas;

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawCircleCommand"/> class.
        /// </summary>
        public DrawCircleCommand(CanvasReceiver canvas)
        {
            _canvas = canvas;
        }

        public void Execute()
        {
            _canvas.DrawCircle();
        }

        public void Undo()
        {
            _canvas.RemoveCircle();
        }
    }
}
