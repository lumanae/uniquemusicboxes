using Terraria.ID;
using Terraria.ModLoader;

namespace bettermusicboxes.Items
{
    public class dngs : ModItem
	{
        public override void SetStaticDefaults()
        {
			// DisplayName.SetDefault("dngs"); "D.N.G.S."
			Tooltip.SetDefault("Lamp oil? Rope? Bombs? You want it, it's Starscream's.");
		}

		public override void SetDefaults() 
		{
			item.noMelee = true;
			item.width = 18;
			item.height = 18;
			item.useTime = 10;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.value = 345;
			item.rare = 11;
			item.UseSound = SoundID.Item36;
			item.consumable = true;
			item.createTile = ModContent.TileType<dngsTile>();
			item.expert = true;
			item.makeNPC = 67;
			item.accessory = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GlowingMushroom, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}