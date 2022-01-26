using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using guardi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace guardi.Pages
{
    public class PoliticsModel : PageModel
    {
        public void OnGet()
        {
            List<Article> artlist = InMemoryDatabase.ListOfArticles();
            ViewData["articlepoliticsdata"] = artlist.Where(lo => lo.ArticleType != "Politics").Where(lo => lo.ArticleType != "Sport").ToList(); ;

            ViewData["politicsarticles"] = artlist.Where(lo => lo.ArticleType == "Politics").ToList();
        }
    }
}
