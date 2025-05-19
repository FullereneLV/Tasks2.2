

namespace MusicianInstruments
{
    public class Trombone : MusicianInstrument
    {
        public Trombone(string instrumentName) : base(instrumentName)
        {
            Console.WriteLine("This is trombone: {0} ", instrumentName);
        }

        public override void Desc()
        {
            base.Desc();
            Console.WriteLine("The trombone is a musical instrument in the brass family.The trombone is a predominantly cylindrical tube with two U-shaped bends and a flared bell at the end. The tubing is approximately cylindrical but contains a complex series of tapers which affect the instrument's intonation. ");
        }

        public override void History()
        {
            base.History();
            Console.WriteLine("\"Trombone\" comes from the Italian word tromba (trumpet) plus the suffix -one (large), meaning \"large trumpet\". ");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine(InstrumentName);
        }

        public override void Sound()
        {
            base.Sound();
            Console.WriteLine("In a performance, the trumpet ranges between 80 and 110 decibels");
        }
    }
}
