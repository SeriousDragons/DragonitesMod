using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using DragonitesMod.Items.Projectiles;

namespace DragonitesMod.Items.MagicWeapons.VanillaFracture
{
public class TerraFracture : ModItem
{
public override void SetStaticDefaults()
{
	DisplayName.SetDefault("Terra Fracture"); 
	Item.staff[item.type] = true;
}

public override void SetDefaults()
{
	item.CloneDefaults(ItemID.SkyFracture);
	item.damage = 215;
	item.shootSpeed = 10f;
	item.mana = 9;
	item.shoot = ModContent.ProjectileType<TerraOrb>();
}
public override void AddRecipes()
{
	ModRecipe recipe= new ModRecipe(mod);
	recipe.AddIngredient(1570);
	recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
	recipe.AddIngredient(mod.ItemType("NightFracture"), 1);
	recipe.AddTile(TileID.MythrilAnvil);
	recipe.SetResult(this);
	recipe.AddRecipe();
}
}
}

