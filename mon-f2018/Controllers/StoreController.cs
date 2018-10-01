﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


//eference Models NameSpace
using mon_f2018.Models;

namespace mon_f2018.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        // GET: Store?Product
        public ActionResult Product()
        {
            return View();
        }

        //GET: Store/Albums

        public ActionResult Albums()
        {
            // mock up some album data
            var albums = new List<Album>();

            for (int i=1; i <=10; i++)
            {
                albums.Add(new Album { Title = "Album " + i.ToString() });
            }

            return View(albums);
        }
    }
}