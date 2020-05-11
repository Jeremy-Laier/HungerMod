using Terraria
using Terraria.ModLoader;

namespace HungerMode
{
    class HungryPlayer: ModPlayer
    {
        public bool isHungry = true;
        public override void Initialize()
        {
            
        }
        public float Timer
        {
            get => player.ai[0];
            set => projectile.ai[0] = value;
        }

        public override void ResetEffects()
        {
            isHungry = true;
        }
        public override void OnRespawn(Player player)
        {
            isHungry = true;
            base.OnRespawn(player);
        }
    }
}
