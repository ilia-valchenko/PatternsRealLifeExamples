namespace Facade.RefactoringGuruExample.VideoSdk
{
    // You can think of the class below as of a class from an external library
    // which you cannot modify.
    public class VideoFile : IVideoFile
    {
        public VideoFileFormat FileFormat { get; }

        public string FileName { get; }

        public VideoFile(string fileName, VideoFileFormat format)
        {
            this.FileName = fileName;
            this.FileFormat = format;
        }

        public byte[] GetBytes()
        {
            throw new System.NotImplementedException();
        }
    }
}