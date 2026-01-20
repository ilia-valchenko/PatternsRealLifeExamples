using Command.Example1.Interfaces;

namespace Command.Example1.Commands
{
    public class DrawRectangleCommand : ICommand
    {
        private readonly CanvasReceiver _canvas;

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawCircleCommand"/> class.
        /// </summary>
        public DrawRectangleCommand(CanvasReceiver canvas)
        {
            _canvas = canvas;
        }

        public void Execute()
        {
            _canvas.DrawRectangle();
        }

        public void Undo()
        {
            _canvas.RemoveRectangle();
        }
    }
}
