using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using DragonitesMod.Items.Projectiles;

namespace DragonitesMod.Items.MagicWeapons.VanillaFracture
{
public class NightFracture : ModItem
{
public override string Texture => "Terraria/Item_" + ItemID.SkyFracture;
public override void SetStaticDefaults()
{
	DisplayName.SetDefault("True Fracture of the Night"); 
	Item.staff[item.type] = true;
}

public override void SetDefaults()
{
	item.CloneDefaults(ItemID.SkyFracture);
	item.damage = 215;
	item.color = Color.Purple;
	item.shootSpeed = 5f;
	item.mana = 9;
	item.shoot = ModContent.ProjectileType<NightOrb>();
}
public override void AddRecipes()
{
	ModRecipe recipe= new ModRecipe(mod);
	recipe.AddIngredient(273);
	recipe.AddIngredient(1570);
	recipe.AddIngredient(mod.ItemType("HallowedFracture"), 1);
	recipe.AddTile(TileID.MythrilAnvil);
	recipe.SetResult(this);
	recipe.AddRecipe();
}
}
}

