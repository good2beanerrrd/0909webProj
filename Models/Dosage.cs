using System.ComponentModel.DataAnnotations;
 
namespace test.Models
{
    public class Dosage
    {
        // Required標籤表示這個欄位是必填
        [Required]
        // 定義字串最長20字元，最短5字元
        [StringLength(20, MinimumLength = 1)]
        public string? Name {set;get;}
 
        [Required]
        [StringLength(20, MinimumLength = 1)]
        public string? Unit {set;get;}
 
        [Required]
        public int Weight {set;get;}
    }
}