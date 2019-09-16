using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace comp2084_music_store.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return Ok("hello world from store.index()");
        }

        public IActionResult Browse(string genre)
        {
           genre= System.Web.HttpUtility.HtmlEncode("store.browse,genre =" + genre);
            return Ok(genre);
        }

       

        public IActionResult Details(int id)
        {
            return Ok(id.ToString());
        }


    }
}