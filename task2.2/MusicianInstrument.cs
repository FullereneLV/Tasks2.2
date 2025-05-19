

namespace MusicianInstruments
{
    public class MusicianInstrument
    {
        public string InstrumentName { get; set; }

        public MusicianInstrument(string instrumentName)
        {
            InstrumentName = instrumentName;
            Console.WriteLine($"Instrument name is {InstrumentName}");
        }

        public virtual void Sound()
        {
            Console.WriteLine("I can sound");
        }

        public virtual void Show()
        {
            Console.WriteLine("My name:");
        }

        public virtual void Desc()
        {
            Console.WriteLine("My description:");
        }

        public virtual void History()
        {
            Console.WriteLine("My history:");
        }

    }
}
