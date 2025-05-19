// See https://aka.ms/new-console-template for more information
using MusicianInstruments;

Console.WriteLine("Musician Instruments:");
var cello1 = new Cello("Stradivari");
cello1.Sound();
cello1.Desc();
cello1.Show();
cello1.History();
var ukulele = new Ukulele("Kamaka");
ukulele.Sound();
ukulele.Desc();
ukulele.Show();
ukulele.History();
var trombone = new Trombone("Yamaha");
trombone.Sound();
trombone.Desc();
trombone.Show();
trombone.History();
var violine = new Violin("Stentor");
violine.Sound();
violine.Desc();
violine.Show();
violine.History();
