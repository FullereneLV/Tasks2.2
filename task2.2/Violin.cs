

namespace MusicianInstruments
{
    public class Violin : MusicianInstrument
    {
        public Violin(string instrumentName) : base(instrumentName)
        {
        }

        public override void Desc()
        {
            base.Desc();
            Console.WriteLine("The violin is the soprano of the string family. It has a hollow, wooden body and four strings. The sound made by the violin can vary from bright and vibrant to solemn and mellow. The sound is made by drawing a bow across the strings, or by plucking the strings with a finger.");
        }

        public override void History()
        {
            base.History();
            Console.WriteLine("first built in the early 16th century, in Italy.");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine(InstrumentName);
        }

        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("At full volume, an acoustic violin can range from 78 to 95 dB");
        }
    }
}
