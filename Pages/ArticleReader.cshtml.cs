using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using guardi.Data;

namespace guardi.Pages
{
    public class ArticleReaderModel : PageModel
    {
              public void  OnGet(int ArticleNo)
    {
        List<Article> article = InMemoryDatabase.ListOfArticles();
        //var article = JsonConvert.DeserializeObject<Article>(passedObject);
         
        ViewData["articlepassed"] = article.Where(po => po.ArticleNumber == ArticleNo).FirstOrDefault();
        
        Random rng = new Random();
        
        ViewData["randomarticles"] = article.OrderBy(a => rng.Next()).ToList();


        


        }
    }
}
