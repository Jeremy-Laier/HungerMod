﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HungerMode.Items
{
	class CherryPie : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cherry Pie");
			Tooltip.SetDefault("Delicious pie, leaves you full for 10 minutes.");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useTurn = true;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.rare = 2;
			item.consumable = true;
			item.buffType = mod.BuffType("HungerModeBuff");
			item.buffTime = 3600 * 10;
			item.noMelee = true;
			item.notAmmo = true;
			// item.potion = true;
			item.maxStack = 10;
			item.healLife = 25;
			item.UseSound = SoundID.Item3;
		}

		public override void GetHealLife(Player player, bool quickHeal, ref int healValue)
		{
			healValue = 25;
		}

		public override bool UseItem(Player player)
		{
			HungryPlayer p = player.GetModPlayer<HungryPlayer>();
			p.isHungry = false;
			// player.AddBuff(mod.BuffType("HungerModeBuff"), 3600 * 10);
			return base.UseItem(player);
		}
	}
}
