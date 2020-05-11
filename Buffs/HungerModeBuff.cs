using Terraria;
using Terraria.ModLoader;

namespace HungerMode.Buffs
{
    class HungerModeBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Starving");
            Description.SetDefault("You are weaker while you starve.");
            Main.debuff[Type] = false; // needed so nurse will not remove this buff 
            longerExpertDebuff = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            HungryPlayer p = player.GetModPlayer<HungryPlayer>();
            if (!p.isHungry)
            {
                player.meleeDamage -= player.meleeDamage * 0.10f;
                player.statDefense -= player.statDefense * (int)0.10;
                player.GetModPlayer<HungryPlayer>().isHungry = true;

                int buf = mod.BuffType("HungerModeBuff");
                player.AddBuff(buf, 3600 * 10);
            } 
            else
            {
                // fails if we get here, log something
            }
        }
    }
}
