using Terraria.ModLoader;
using Terraria;

namespace HungerMode
{
    public class HungerMode : Mod
    {
        public static HungerMode Instance { get; private set; }


        public HungerMode()
        {
            HungerMode.Instance = this;
        }

        public override void Unload()
        {
            HungerMode.Instance = null;
        }

        public override object Call(params object[] args)
        {
            return null;
        }
    }
}