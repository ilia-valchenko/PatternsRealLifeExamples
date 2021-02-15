using System;

namespace Facade.RefactoringGuruExample.VideoSdk
{
    // You can think of the class below as of a class from an external library
    // which you cannot modify.
    public class AudioMixer
    {
        public IVideoFile UpdateAudio(IVideoFile file)
        {
            if (file == null)
            {
                throw new ArgumentNullException(nameof(file));
            }

            // TODO: Do some stuff.

            return file;
        }
    }
}