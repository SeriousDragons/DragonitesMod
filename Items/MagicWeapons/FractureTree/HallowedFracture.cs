using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace DragonitesMod.Items.MagicWeapons.VanillaFracture
{
public class HallowedFracture : ModItem
{
public override string Texture => "Terraria/Item_" + ItemID.SkyFracture;
public override void SetStaticDefaults()
{
	DisplayName.SetDefault("Hallowed Fracture"); 
	Item.staff[item.type] = true;
}

public override void SetDefaults()
{
	item.CloneDefaults(ItemID.SkyFracture);
	item.damage = 175;
	item.color = Color.PaleGoldenrod;
	item.shootSpeed = 25f;
	item.mana = 6;
}
public override void AddRecipes()
{
	ModRecipe recipe= new ModRecipe(mod);
	recipe.AddIngredient(ItemID.HallowedBar, 25);
	recipe.AddIngredient(mod.ItemType("MythrilFracture"), 1);
	recipe.AddTile(TileID.MythrilAnvil);
	recipe.SetResult(this);
	recipe.AddRecipe();
}
}
}

