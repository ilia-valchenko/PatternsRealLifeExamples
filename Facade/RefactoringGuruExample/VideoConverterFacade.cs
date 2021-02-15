using System;
using Facade.RefactoringGuruExample.VideoSdk;

namespace Facade.RefactoringGuruExample
{
    public class VideoConverterFacade : IVideoConverterFacade
    {
        private const int Mpeg4Bitrate = 95;
        private const int OggBitrate = 60;
        private const int DefaultBitrate = 55;

        private readonly CodecFactory codecFactory = new CodecFactory();
        private readonly BitrateReader bitrateReader = new BitrateReader();
        private readonly AudioMixer audioMixer = new AudioMixer();

        public IVideoFile Convert(IVideoFile file, VideoFileFormat destinationFormat)
        {
            if (file == null)
            {
                throw new ArgumentNullException(nameof(file));
            }

            var compressionCodec = this.codecFactory.CreateCompressionCodec(destinationFormat);
            var convertedVideoFile = this.audioMixer.UpdateAudio(file);
            var bitrate = this.GetBitrate(destinationFormat);
            this.bitrateReader.ChangeBitrate(convertedVideoFile, compressionCodec, bitrate);

            return convertedVideoFile;
        }

        // TODO: It can be refactored by using the Factory pattern.
        private int GetBitrate(VideoFileFormat format)
        {
            switch (format)
            {
                case VideoFileFormat.Mp4:
                    return Mpeg4Bitrate;

                case VideoFileFormat.Ogg:
                    return OggBitrate;

                default:
                    return DefaultBitrate;
            }
        }
    }
}