using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Dapr.Client;
using Microsoft.AspNetCore.Mvc.RazorPages;
using guardi.Data;
using System.Linq;

namespace guardi.Pages
{
    public class IndexModel : PageModel
    {
        

         public IndexModel()
        {
            //_daprClient = daprClient ?? throw new ArgumentNullException(nameof(daprClient));
        }

        public void OnGet()
        {
            //var forecasts = await _daprClient.InvokeMethodAsync<IEnumerable<Article>>(
              //  HttpMethod.Get,
                //"daprbackend",
                //"article");

             //List<Article> ArticleList = InMemoryDatabase.ListOfArticles();

            ViewData["articleindexdata"] =InMemoryDatabase.ListOfArticles().Where(lo => lo.ArticleType != "Sport").ToList();

            List<Article> covidlist = InMemoryDatabase.ListOfArticles();

            ViewData["covidarticles"] = covidlist.Where(lo => lo.ArticleType == "Covid").ToList();

             ViewData["sportarticles"] = covidlist.Where(lo => lo.ArticleType == "Sport").ToList();

            Article hit1 =  covidlist.Where(po => po.ArticleNumber == 8).FirstOrDefault();
            Article hit2=   covidlist.Where(po => po.ArticleNumber == 9).FirstOrDefault();
            Article hit3 =  covidlist.Where(po => po.ArticleNumber == 10).FirstOrDefault();
            ViewData["hit1"] = hit1;
            ViewData["hit2"] = hit2;
            ViewData["hit3"] = hit3;
        }
    }
}