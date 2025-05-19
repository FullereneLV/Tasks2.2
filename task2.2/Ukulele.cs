

namespace MusicianInstruments
{
    public class Ukulele : MusicianInstrument
    {
        public Ukulele(string instrumentName) : base(instrumentName)
        {
        }

        public override void Desc()
        {
            base.Desc();
            Console.WriteLine("The most familiar Hawaiian instrument is the 'ukulele, a small type of guitar.");
        }

        public override void History()
        {
            base.History();
            Console.WriteLine("The instrument was probably introduced to Hawai'i in 1879 by Portuguese settlers from Madeira who brought with them a small guitar called the braguinha. The settlers included three men, Manuel Nunes, Augusto Dias, and Jose do Espirito Santo who knew how to make braguinha. ");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"I am {InstrumentName} in Ukulele.");
        }

        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("Ukuleles generally have four nylon strings tuned to G C E A");
        }
    }
}
