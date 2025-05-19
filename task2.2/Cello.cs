

namespace MusicianInstruments
{
    public class Cello : MusicianInstrument
    {
        public Cello(string name) : base(name)
        {
        }

        public override void Desc()
        {
            Console.WriteLine("Traditionally cellos are made of spruce and maple, but recently they’ve been brought bang-up-to-date with a carbon fiber version.");
        }

        public override void History()
        {
            Console.WriteLine("A violone was an instrument common in the 17th and 18th centuries which evolved into today’s double bass. The cello is the tenor voice in the string section. It can play an octave lower than the viola and, as with the other Strings, the cello section sits two to a desk. There are usually between eight and twelve cellos in a symphony orchestra.\r\n\r\nPerhaps more than any other instrument the cello sound can create a melancholy mood. Its deep tenor voice can be further enhanced by a broad vibrato which on other instruments might sound ridiculous. With its particularly wide range and powerful sound it can one minute be playing a bass line and the next a melody that is high enough for the rest of the orchestra to move underneath. Another of its useful qualities is its clarity of attack, which enables it to play crisp architectural shapes as well as driving rhythmic patterns and makes the cello a key component of the orchestra’s ‘engine room’.");
        }

        public override void Show()
        {
            Console.WriteLine($"My name is:{InstrumentName}");
        }

        public override void Sound()
        {
            Console.WriteLine("The Cello has four strings, tuned in 5ths to C, G, D and A");
        }
    }
}
