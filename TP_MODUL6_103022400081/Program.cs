using TP_MODUL6_103022400081;

class Program
{
    static void Main(string[] args)
    {
    SayaMusicTrack musik = new SayaMusicTrack("Lagu anak-anak");
        musik.IncreasePlayCount(5);
        musik.PrintTrackDetails();
    }
}