﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogGo.Repositories;
using DogGO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DogGO.Controllers
{
    public class WalkersController : Controller
    {
        private readonly WalkerRepository _walkerRepo;

        // The constructor accepts an IConfiguration object as a parameter. This class comes from the ASP.NET framework and is useful for retrieving things out of the appsettings.json file like connection strings.
        public WalkersController(IConfiguration config)
        {
            _walkerRepo = new WalkerRepository(config);
        }

        // GET: Walkers
        public ActionResult Index()
        {
            List<Walker> walkers = _walkerRepo.GetAllWalkers();
            return View(walkers);
        }

        // GET: Walkers/Details/5
        public ActionResult Details(int id)
        {
            Walker walker = _walkerRepo.GetWalkerById(id);
            Console.WriteLine(walker);
            if (walker == null)
            {
                return NotFound();
            }

            return View(walker);
        }
        // GET: Walkers/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Walkers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Walkers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Walkers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Walkers/Delete/5
      //  public ActionResult Delete(int id)
       // {
        //    Walker walker = _walkerRepo.DeleteWaLker(id);
        //         Console.WriteLine(walker);
         //   if (walker == null)
         //   {
          //      return NotFound();
           // }

          //  return View(walker);
       // }

        // POST: Walkers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
