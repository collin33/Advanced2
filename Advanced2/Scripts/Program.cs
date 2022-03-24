using System;

namespace Advanced2
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new PositionTestScene())
                game.Run();
        }
    }
}
