using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace DragonitesMod.Items.MagicWeapons.VanillaFracture
{
public class MythrilFracture : ModItem
{
public override string Texture => "Terraria/Item_" + ItemID.SkyFracture;
public override void SetStaticDefaults()
{
	DisplayName.SetDefault("Mythril Fracture"); 
	Item.staff[item.type] = true;
}
public override void SetDefaults()
{
	item.CloneDefaults(ItemID.SkyFracture);
	item.damage = 125;
	item.color = Color.Teal;
}

public override void AddRecipes()
{
	ModRecipe twotwo= new ModRecipe(mod);
	{
	twotwo.AddIngredient(ItemID.OrichalcumBar, 5);
	twotwo.AddIngredient(ItemID.PalladiumBar, 3);
	twotwo.AddIngredient(ItemID.SkyFracture);
	twotwo.AddTile(TileID.MythrilAnvil);
	twotwo.SetResult(this);
	twotwo.AddRecipe();
	}
	ModRecipe onetwo= new ModRecipe(mod);
	{
	onetwo.AddIngredient(ItemID.MythrilBar, 5);
	onetwo.AddIngredient(ItemID.PalladiumBar, 3);
	onetwo.AddIngredient(ItemID.SkyFracture);
	onetwo.AddTile(TileID.MythrilAnvil);
	onetwo.SetResult(this);
	onetwo.AddRecipe();
	}
	ModRecipe oneone= new ModRecipe(mod);
	{
	oneone.AddIngredient(ItemID.MythrilBar, 5);
	oneone.AddIngredient(ItemID.CobaltBar, 3);
	oneone.AddIngredient(ItemID.SkyFracture);
	oneone.AddTile(TileID.MythrilAnvil);
	oneone.SetResult(this);
	oneone.AddRecipe();
	}
	ModRecipe recipe= new ModRecipe(mod);
	{
	recipe.AddIngredient(ItemID.OrichalcumBar, 5);
	recipe.AddIngredient(ItemID.CobaltBar, 3);
	recipe.AddIngredient(ItemID.SkyFracture);
	recipe.AddTile(TileID.MythrilAnvil);
	recipe.SetResult(this);
	recipe.AddRecipe();
	}
}
}
}
		