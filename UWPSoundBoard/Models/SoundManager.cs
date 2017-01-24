using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundBoard.Models
{
    public class SoundManager
    {

        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            var allsounds = GetSounds();
            sounds.Clear();
            allsounds.ForEach(p => sounds.Add(p));
        }

        public static void GetSoundsByCatagory(ObservableCollection<Sound> sounds, SoundCatagory catagory)
        {
            var allsounds = GetSounds();
            var filtered = allsounds.Where(p => p.Catagory == catagory).ToList();
            sounds.Clear();
            filtered.ForEach(p => sounds.Add(p));
        }

        public static void GetSoundsByName(ObservableCollection<Sound> sounds, String name)
        {
            var allsounds = GetSounds();
            var filtered = allsounds.Where(p => p.Name == name).ToList();
            sounds.Clear();
            filtered.ForEach(p => sounds.Add(p));
        }
        public static List<Sound> GetSounds()
        {
            var sounds = new List<Sound>();
            sounds.Add(new Sound("Cow", SoundCatagory.Animals));
            sounds.Add(new Sound("Cat", SoundCatagory.Animals));
            sounds.Add(new Sound("Gun", SoundCatagory.Cartoons));
            sounds.Add(new Sound("Spring", SoundCatagory.Cartoons));
            sounds.Add(new Sound("Clock", SoundCatagory.Taunts));
            sounds.Add(new Sound("LOL", SoundCatagory.Taunts));
            sounds.Add(new Sound("Ship", SoundCatagory.Warnings));
            sounds.Add(new Sound("Siren", SoundCatagory.Warnings));

            return sounds;
        }
    }
}
