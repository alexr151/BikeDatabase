using BikeDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BikeDatabase.Controllers
{
    public class HomeController : Controller
    {
        private BikeContext context;
        public HomeController(BikeContext ctx) => context = ctx;

        public IActionResult Index(string id)
        {
            var filters = new Filters(id);
            ViewBag.Filters = filters;
            ViewBag.BikeSize = context.BikeSizes.ToList();
            ViewBag.GearNumber = context.GearNumbers.ToList();
            ViewBag.BikeColor = context.BikeColors.ToList();
            ViewBag.BikeType = context.BikeTypes.ToList();
            ViewBag.TireSize = context.TireSizes.ToList();

            IQueryable<Bike> query = context.Bikes
                .Include(b => b.BikeSize).
                Include(b => b.GearNumber).
                Include(b => b.BikeColor).
                Include(b => b.BikeType).
                Include(b => b.TireSize);


            if (filters.HasBikeSize)
            {
                query = query.Where(bs => bs.BikeSizeId == filters.BikeSizeId);
            }

            if (filters.HasGearNumber)
            {
                query = query.Where(gn => gn.GearNumberId == filters.GearNumberId);
            }

            if (filters.HasBikeColor)
            {
                query = query.Where(bc => bc.BikeColorId == filters.BikeColorId);
            }

            if (filters.HasBikeType)
            {
                query = query.Where(bt => bt.BikeTypeId == filters.BikeTypeId);
            }

            if (filters.HasTireSize)
            {
                query = query.Where(ts => ts.TireSizeId == filters.TireSizeId);
            }


            


            var bikes = context.Bikes.
                Include(b => b.BikeSize).
                Include(b => b.GearNumber).
                Include(b => b.BikeColor).
                Include(b => b.BikeType).
                Include(b => b.TireSize).
                OrderBy(b => b.Make);

            return View(bikes);
        }

        [HttpGet]
        public IActionResult Add(string description)
        {
            ViewBag.BikeSize = context.BikeSizes.ToList();
            ViewBag.GearNumber = context.GearNumbers.ToList();
            ViewBag.BikeColor = context.BikeColors.ToList();
            ViewBag.BikeType = context.BikeTypes.ToList();
            ViewBag.TireSize = context.TireSizes.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Bike bike)
        {
            if (ModelState.IsValid)
            {
                context.Bikes.Add(bike);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.BikeSize = context.BikeSizes.ToList();
                ViewBag.GearNumber = context.GearNumbers.ToList();
                ViewBag.BikeColor = context.BikeColors.ToList();
                ViewBag.BikeType = context.BikeTypes.ToList();
                ViewBag.TireSize = context.TireSizes.ToList();
                return View(bike);
            }
        }

        [HttpPost]
        public IActionResult Filter(string[] filter)
        {
            string id = string.Join('-', filter);
            return RedirectToAction("Index", new { ID = id });
        }

        [HttpPost]
        public IActionResult Edit([FromRoute] string id, Bike selected)
        {
            if (selected.BikeId == 0)
            {
                context.Bikes.Remove(selected);
            }
            else
            {
                int newStatusId = selected.BikeId;
                selected = context.Bikes.Find(selected.BikeId);
                selected.BikeId = newStatusId;
                context.Bikes.Update(selected);
            }

            context.SaveChanges();

            return RedirectToAction("Index", new { ID = id });
        }
    }
}
