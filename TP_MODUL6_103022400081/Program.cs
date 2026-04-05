using TP_MODUL6_103022400081;

class Program
{
    static void Main(string[] args)
    {
        SayaMusicTrack musik = new SayaMusicTrack("lagu anak-anak");
        musik.IncreasePlayCount(5);
        musik.PrintTrackDetails();

        for (int i = 0; i < 100; i++)
        {
            musik.IncreasePlayCount(10000000);
        }
    }
}
