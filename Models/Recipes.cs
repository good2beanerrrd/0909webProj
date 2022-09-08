using System.ComponentModel.DataAnnotations;
 
namespace CookbookApi.Models
{
    public class Recipes
    {
        // Required表示這是一個不能被遺漏掉的資料
        [Required]
        // 定義字串長度為5個字元
        [StringLength(5)]
        public string Id {set;get;}
 
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { set; get; }
 
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Description { set; get; }
 
        [Required]
        // 可以用正則表達式(Regex Tester)檢查輸入的內容
        [RegularExpression(@"\d{1,3}")]
        public int CookingTime { set; get; }
 
        [Required]
        // 以其他Model來定義另一個Model，屆時可以將資料組合在一起
        public Models.Dosage[] Ingredients { set; get; }
 
        [Required]
        public Models.Dosage[] Seasonings { set; get; }
    }
}