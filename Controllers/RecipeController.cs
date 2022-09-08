using Microsoft.AspNetCore.Mvc;
namespace test.Controllers;

[ApiController]
[Route("[controller]")]
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
        // 宣告一個食譜的Model，並呼叫Libs.Recipe.Get函數取得資料
        Models.Recipes objRecipe = Libs.Recipe.Get();
        // 回傳HTTP 200，內容為糖醋排骨的食譜資料
        return Ok(objRecipe);
    }

    // 設定這個API使用POST方法
    [HttpPost]
    // 接受以Json格式的資料，並且放置於HTTP Body傳送進來
    public IActionResult Post([FromBody] Models.Recipes objRecipe)
    {
        // 檢查傳進來的資料Model是否符合所定義的規格
        if (ModelState.IsValid)
        {
            // 不做任何處理，直接回傳給客戶端
            return Ok(objRecipe);
        }
        else
        {
            // 資料規格不符，回傳HTTP 400
            return BadRequest();
        }
    }
}