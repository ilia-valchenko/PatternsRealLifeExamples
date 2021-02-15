namespace Facade.RefactoringGuruExample.VideoSdk
{
    // You can think of the class below as of a class from an external library
    // which you cannot modify.
    public class CodecFactory
    {
        public BaseCompressionCodec CreateCompressionCodec(VideoFileFormat format)
        {
            switch (format)
            {
                case VideoFileFormat.Mp4:
                    return new Mpeg4CompressionCodec();

                case VideoFileFormat.Ogg:
                    return new OggCompressionCodec();

                default:
                    throw new UnexpectedVideoFileFormatException("The file format is not supported.");
            }
        }
    }
}