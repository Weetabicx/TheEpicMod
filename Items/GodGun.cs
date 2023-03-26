using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheEpicMod.Items
{
    public class GodGun: ModItem{
        public override void SetDefaults() {

	       Item.width = 62; // Hitbox width of the item.
	       Item.height = 32; // Hitbox height of the item.
	       Item.scale = 0.75f;
	       Item.rare = ItemRarityID.Green; // The color that the item's name will be in-game
	       // Use Properties
	       Item.useTime = 8; // The item's use time in ticks (60 ticks == 1 second.)
	       Item.useAnimation = 8; // The length of the item's use animation in ticks (60 ticks == 1 second.)
	       Item.useStyle = ItemUseStyleID.Shoot; // How you use the item (swinging, holding out, etc.)
	       Item.autoReuse = true; // Whether or not you can hold click to automatically use it again.

	       // Weapon Properties
	       Item.DamageType = DamageClass.Ranged; // Sets the damage type to ranged.
	       Item.damage = 250; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
	       Item.knockBack = 5f; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
	       Item.noMelee = true; // So the item's animation doesn't do damage
	       // Gun Properties
	       Item.shoot = ProjectileID.ChlorophyteBullet; // For some reason, all the guns in the vanilla source have this.
	       Item.shootSpeed = 32f; // The speed of the projectile (measured in pixels per frame.)
	       Item.useAmmo = TileID.Dirt; // The "ammo Id" of the ammo item that this weapon uses. Ammo IDs are magic numbers that usually correspond to the item id of one item that most commonly represent the ammo type.Ammo IDs are magic numbers that usually correspond to the item id of one item that most commonly represent the ammo type.
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
    }
}