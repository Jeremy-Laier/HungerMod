using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HungerMode.Buffs
{
    class HungerModeBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Satiated");
            Description.SetDefault("You are not hungry.");
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed += 5f;
        }
    }
}
