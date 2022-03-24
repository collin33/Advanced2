using System;

namespace Advanced2
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new ScaleTestScene())
                game.Run();
        }
    }
}
