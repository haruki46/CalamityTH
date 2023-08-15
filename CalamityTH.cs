using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityTH
{
    public class CalamityTH : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.MoreEmblem.hjson file.

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.value = Item.sellPrice(0, 1, 0, 0);
            Item.rare = ItemRarityID.Red;
            Item.accessory = true;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
               .AddIngredient(ItemID.CrystalShard, 1)
               .AddIngredient(ItemID.FragmentSolar, 2)
               .AddTile(TileID.LunarCraftingStation)
               .Register();
        }
        
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic) += 10f;
            player.GetDamage(DamageClass.Magic) += 5f;
            player.GetDamage(DamageClass.Melee) += 5f;
            player.GetDamage(DamageClass.Summon) += 5f;
            player.GetDamage(DamageClass.Ranged) += 5f;
            player.GetCritChance(DamageClass.Generic) += 60;
            player.GetArmorPenetration(DamageClass.Generic) += 1000;
            player.maxMinions = 90;
            player.maxTurrets = 90;
        }
    }
}