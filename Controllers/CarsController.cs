using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class CarsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly AutomobilesContext _context;

        public CarsController(IMapper mapper, AutomobilesContext context)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cars = _mapper.Map<IEnumerable<Car>, IEnumerable<CarViewModel>>(_context.Car.Where(c => c.BrandId == id).ToList());
            return View(cars);
        }
    }
}