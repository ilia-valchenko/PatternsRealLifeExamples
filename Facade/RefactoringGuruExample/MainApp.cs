using Facade.RefactoringGuruExample.VideoSdk;

namespace Facade.RefactoringGuruExample
{
    public class MainApp
    {
        public void Main()
        {
            var videoFile = new VideoFile("SampleVideo", VideoFileFormat.Ogg);
            var converter = new VideoConverterFacade();

            var convertedVideoFile = converter.Convert(videoFile, VideoFileFormat.Mp4);
        }
    }
}