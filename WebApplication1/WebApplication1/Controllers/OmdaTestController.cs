﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class OmdaTestController : Controller
    {
        // GET: OmdaTest
        public ActionResult Index222()
        {
            return View();
        }

        // GET: OmdaTest/Details/5
        public ActionResult Details5555555dddddddddddddddd(int id)
        {
            return View();
        }

        // GET: OmdaTest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OmdaTest/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: OmdaTest/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OmdaTest/Edit/5
        [HttpPost]
        public ActionResult Edit8888(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: OmdaTest/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OmdaTest/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete22(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Koko()
        {
            return View();
        }
    }
}
