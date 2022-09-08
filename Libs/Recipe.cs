namespace test.Libs
{
    public class Recipe
    {
        // 宣告一個Get函數，返回Models.Recipe，前面加上static，表示是一個靜態函數，之後可以直接使用
        static public Models.Recipes Get()
        {
            // 宣告食譜的Model
            Models.Recipes recipe = new Models.Recipes();
            // 宣告一個放入食材份量的Model
            Models.Dosage[] dosageIngredients = new Models.Dosage[2];
            // 宣告一個放入調味料份量的Model
            Models.Dosage[] dosageSeasonings = new Models.Dosage[3];
 
            // 這道菜品的ID
            recipe.Id = @"R0001";
            // 菜品名稱
            recipe.Name = @"糖醋排骨";
            // 描述一下菜品
            recipe.Description = @"一種酸酸甜甜的排骨料理";
            // 預計烹煮時間(分鐘)
            recipe.CookingTime = 30;
 
            // 將材料寫入食材份量的Model陣列
            dosageIngredients[0] = new Models.Dosage() { Name = "排骨", Unit = "公斤", Weight = 1 };
            dosageIngredients[1] = new Models.Dosage() { Name = "彩椒", Unit = "個", Weight = 2 };
            recipe.Ingredients = dosageIngredients;
 
            // 將材料寫入調味料份量的Model陣列
            dosageSeasonings[0] = new Models.Dosage() { Name = "糖", Unit = "公克", Weight = 30 };
            dosageSeasonings[1] = new Models.Dosage() { Name = "醋", Unit = "匙", Weight = 5 };
            dosageSeasonings[2] = new Models.Dosage() { Name = "番茄醬", Unit = "匙", Weight = 10 };
            recipe.Seasonings = dosageSeasonings;

            return recipe;
        }
    }
}