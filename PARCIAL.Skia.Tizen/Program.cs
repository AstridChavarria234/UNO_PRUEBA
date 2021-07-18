using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace PARCIAL.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new PARCIAL.App(), args);
            host.Run();
        }
    }
}
