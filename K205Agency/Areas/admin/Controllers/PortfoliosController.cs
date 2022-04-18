﻿using K205Agency.Areas.admin.ViewModel;
using K205Agency.Data;
using K205Agency.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace K205Agency.Areas.admin.Controllers
{
    [Area("admin")]
    public class PortfoliosController : Controller
    {
        private readonly AgencyDbContext _context;

        public PortfoliosController(AgencyDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Portfolios.ToListAsync());
        }
        public async Task<IActionResult> Detail(int id)
        {
            var portfolio = (_context.Portfolios.FirstOrDefault(x => x.ID == id));//bir nece melumat, single birdene.bes firt?
            if (portfolio == null) return NotFound();
           
                return View(portfolio);


        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var portfolio = (_context.Portfolios.FirstOrDefault(x => x.ID == id));//bir nece melumat, single birdene.bes firt?
            if (portfolio == null) return NotFound();

            return View(portfolio);
        }



        [HttpPost]
        public async Task<IActionResult> Edit(Portfolio portfolio)
        {
            try
            {
                var updateEntity=_context.Entry(portfolio);
                updateEntity.State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            { 
                return NotFound();
            }

            return View();
        }


        public async Task<IActionResult> Create()
        {

           
            ViewBag.Category = _context.Categories.ToList();

            return View();
        }





        [HttpPost]
        public async Task<IActionResult> Create(Portfolio portfolio)
        {


            _context.Portfolios.Add(portfolio);
            _context.SaveChanges(); 
            return View(portfolio);
        }
    }
}
