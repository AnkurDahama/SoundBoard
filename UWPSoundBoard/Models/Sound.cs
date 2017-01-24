using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundBoard.Models
{
   public class Sound
    {
        public string Name { get; set; }
        public SoundCatagory Catagory { get; set; }
        public string AudioFile { get; set; }
        public string ImageFile { get; set; }

        public Sound(string name, SoundCatagory catagory)
        {
            Name = name;
            Catagory = catagory;
            AudioFile = string.Format("/Assets/Audio/{0}/{1}.wav", catagory, name);
            ImageFile = string.Format("/Assets/Images/{0}/{1}.png", catagory, name);

        }

    }
    public enum SoundCatagory { Animals, Cartoons, Taunts, Warnings}
}
