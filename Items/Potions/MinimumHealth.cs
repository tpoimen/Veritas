using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Veritas.Items.Potions
{
    public class MinimumHealth : ModItem
    {
        //public new string LocalizationCategory => "Items.Potions";

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 18;
            Item.useTurn = true;
            Item.maxStack = 9999;
            Item.healLife = 25;
            Item.useAnimation = 17;
            Item.useTime = 17;
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.UseSound = SoundID.Item3;
            Item.consumable = true;
            Item.potion = true;
            Item.rare = ItemRarityID.White;
            Item.value = Item.buyPrice(0, 0, 50, 0);
        }

        public override void AddRecipes()
        {
            CreateRecipe(5).
                AddIngredient(ItemID.DirtBlock, 10).
                AddIngredient(ItemID.Wood, 3).
                AddTile(TileID.WorkBenches).
                Register()
                .DisableDecraft();
        }
    }
}
