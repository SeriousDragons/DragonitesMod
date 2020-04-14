using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;
using Microsoft.Xna.Framework;
using DragonitesMod.Items.MagicWeapons.Calamity;

namespace DragonitesMod.Items.MagicWeapons.Calamity
{

public class GalaxyFracture : ModItem
{
public override string Texture => "Terraria/Item_" + ItemID.SkyFracture;
public override void SetStaticDefaults()
{
	DisplayName.SetDefault("Galactica Fracture"); 
	Item.staff[item.type] = true;
}
public override void SetDefaults()
{
	item.CloneDefaults(ItemID.SkyFracture);
	item.damage = 340;
}

public override void AddRecipes()
{
	Mod CalamityMod = ModLoader.GetMod("CalamityMod");
	ModRecipe recipe= new ModRecipe(mod);
	{
	recipe.AddIngredient(CalamityMod.ItemType("GalacticaSingularity"), 15);
	recipe.AddIngredient(mod.ItemType("LifeFracture"));
	recipe.AddTile(412);
	recipe.SetResult(this);
	recipe.AddRecipe();
	}
	ModRecipe recipe1= new ModRecipe(mod);
	{
	recipe1.AddIngredient(3458, 30);
	recipe1.AddIngredient(3457, 30);
	recipe1.AddIngredient(3456, 30);
	recipe1.AddIngredient(3459, 30);
	recipe1.AddIngredient(3467, 10);
	recipe1.AddIngredient(mod.ItemType("LifeFracture"));
	recipe1.AddTile(412);
	recipe1.SetResult(this);
	recipe1.AddRecipe();
	}
}
}
}
		