using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using guardi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace guardi.Pages
{
    public class ClimateModel : PageModel
    {
        public void OnGet()
        {
           

            List<Article> climatelist = InMemoryDatabase.ListOfArticles();
            ViewData["articleclimatedata"] = climatelist.Where(lo => lo.ArticleType != "Sport").ToList();  

            ViewData["climatearticles"] = climatelist.Where(lo => lo.ArticleType == "Climate Crisis").Where(lo => lo.ArticleType != "Sport").ToList();


        }
    }
}
