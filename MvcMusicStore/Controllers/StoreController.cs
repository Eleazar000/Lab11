using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        private MusicStoreDB db = new MusicStoreDB();
        // GET: Store
        /*public ActionResult Index()
        {
            return View();
        }*/
        public ActionResult Browse()
        {
            var genres = db.Genres.ToList();
            return View(genres);
        }
        public ActionResult Index(int? id)
        {
            //var genreModel = db.Genres.Include("Albums");   
            var genreModel = db.Albums.Where(a=>a.GenreId == id).ToList();
            return View(genreModel);
        }
        public ActionResult Details (int? id)
        {
            var album = db.Albums.Find(id);
            return View(album);
        }
        

    }
}