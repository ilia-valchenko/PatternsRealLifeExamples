namespace Facade.RefactoringGuruExample.VideoSdk
{
    // You can think of the class below as of a class from an external library
    // which you cannot modify.
    public interface IVideoFile
    {
        VideoFileFormat FileFormat { get; }

        string FileName { get; }

        byte[] GetBytes();
    }
}