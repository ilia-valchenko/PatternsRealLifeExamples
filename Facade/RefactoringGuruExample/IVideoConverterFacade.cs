using Facade.RefactoringGuruExample.VideoSdk;

namespace Facade.RefactoringGuruExample
{
    public interface IVideoConverterFacade
    {
        IVideoFile Convert(IVideoFile file, VideoFileFormat destinationFormat);
    }
}