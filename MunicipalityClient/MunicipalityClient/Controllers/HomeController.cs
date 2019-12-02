using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MunicipalityClient.Controllers
{
    public class HomeController : Controller
    {
        // GET: Municipality
        string url = "https://localhost:44300/";

        public async Task<ActionResult> Index()
        {
            MunicipalityList mlist = new MunicipalityList();
            Debug.WriteLine("Test");
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("municipalities");
                if (response.IsSuccessStatusCode)
                {
                    var reqResponse = response.Content.ReadAsStringAsync().Result;
                    mlist = JsonConvert.DeserializeObject<MunicipalityList>(reqResponse);
                }
                return View(mlist.municipalities);
            }
        }
    }
}