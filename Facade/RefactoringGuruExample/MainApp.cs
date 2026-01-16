using Facade.RefactoringGuruExample.VideoSdk;

namespace Facade.RefactoringGuruExample
{
    public class MainApp
    {
        // Facade pattern provides a simplified interface to a complex subsystem.
        // A facade is an object that provides a simplified interface to
        // a larger body of code, such as a class library.
        public void Main()
        {
            var videoFile = new VideoFile("SampleVideo", VideoFileFormat.Ogg);
            var converter = new VideoConverterFacade();

            var convertedVideoFile = converter.Convert(videoFile, VideoFileFormat.Mp4);
        }
    }
}