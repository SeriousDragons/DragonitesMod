using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using DragonitesMod.Items.MagicWeapons.VanillaFracture;

namespace DragonitesMod.Items.MagicWeapons.Calamity
{
public class LifeFracture : ModItem
{
public override void SetStaticDefaults()
{
	DisplayName.SetDefault("Fracture of Life"); 
	Item.staff[item.type] = true;
	Tooltip.SetDefault("Requires Calamity to craft");
}
public override void SetDefaults()
{
	item.CloneDefaults(ItemID.SkyFracture);
	item.damage = 240;
}

public override void AddRecipes()
{
	Mod CalamityMod = ModLoader.GetMod("CalamityMod");
	ModRecipe recipe= new ModRecipe(mod);
	{
	recipe.AddIngredient(CalamityMod.ItemType("BarofLife"), 5);
	recipe.AddIngredient(mod.ItemType("HallowedFracture"));
	recipe.AddTile(TileID.MythrilAnvil);
	recipe.SetResult(this);
	recipe.AddRecipe();
	}
}
}
}
		