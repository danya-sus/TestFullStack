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
    public class BrandsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly AutomobilesContext _context;

        public BrandsController(IMapper mapper, AutomobilesContext context)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var brands = _mapper.Map<IEnumerable<Brand>, IEnumerable<BrandViewModel>>(_context.Brand.ToList());
            return View(brands);
        }
    }
}