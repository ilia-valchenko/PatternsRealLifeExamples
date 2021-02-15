using System;

namespace Facade.RefactoringGuruExample.VideoSdk
{
    // You can think of the class below as of a class from an external library
    // which you cannot modify.
    public class BitrateReader
    {
        private const int MinBitrate = 50;

        public void ChangeBitrate(IVideoFile file, BaseCompressionCodec codec, int rate)
        {
            if (file == null)
            {
                throw new ArgumentNullException(nameof(file));
            }

            if (codec == null)
            {
                throw new ArgumentNullException(nameof(codec));
            }

            if (rate < MinBitrate)
            {
                throw new InvalidBitrateException($"The rate value cannot be less than {MinBitrate}.");
            }

            // TODO: Do some stuff.
        }
    }
}