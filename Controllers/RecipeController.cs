using Microsoft.AspNetCore.Mvc;

namespace CookbookApi.Controllers;

[ApiController]
[Route("[controller")]
public class RecipeController : Controller
{
    private readonly ILogger<RecipeController> _logger;

    public RecipeController(ILogger<RecipeController> logger)
    {
        _logger = logger;
    }

    // 設定這個API使用GET方法
    [HttpGet]
    public IActionResult Get()
    {
        // 宣告一個食譜的Ｍodel，並呼叫Libs.Recipe.Get函數取得資料
        Models.Recipes objRecipe = Libs.Recipe.Get();
        // 回傳HTTP 200，內容為糖醋排骨的食譜資料
        return Ok(objRecipe);
    }
}