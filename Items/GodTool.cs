using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEpicMod.Items

{
    public class GodTool : ModItem
    {
        public override void SetDefaults() {
            var rand = new Random();
            Item.damage = rand.Next(1,1000);
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 5;
            Item.useAnimation = 5;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 1000;
            Item.value = 1_000_000_000;
            Item.rare = ItemRarityID.Purple;
            Item.autoReuse = true;

            Item.axe = 1000;
            Item.pick = 1000;

        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
    }
}