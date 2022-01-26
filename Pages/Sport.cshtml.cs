using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using guardi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace guardi.Pages
{
    public class SportModel : PageModel
    {
        public void OnGet()
        {
            List<Article> artlist = InMemoryDatabase.ListOfArticles();
            ViewData["articlesportdata"] = artlist.Where(lo => lo.ArticleType != "Sport").ToList(); ;

            ViewData["sportarticles"] = artlist.Where(lo => lo.ArticleType == "Sport").ToList();
        }
    }
}
