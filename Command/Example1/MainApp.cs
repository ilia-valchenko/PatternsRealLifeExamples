using Command.Example1.Commands;
using Command.Example1.Interfaces;

namespace Command.Example1
{
    public class MainApp
    {
        public void Main()
        {
            var canvas = new CanvasReceiver();
            var graphicEditor = new GraphicEditorInvoker();

            ICommand drawCircle = new DrawCircleCommand(canvas);
            ICommand drawRectangle = new DrawRectangleCommand(canvas);

            graphicEditor.ExecuteCommand(drawCircle);
            graphicEditor.ExecuteCommand(drawRectangle);

            graphicEditor.UndoLastCommand();
            graphicEditor.UndoLastCommand();
        }
    }
}
