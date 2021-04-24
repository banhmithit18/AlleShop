﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPIUser.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductInfoesController : ControllerBase
    {
        private readonly OnlineShoppingContext _context;

        public ProductInfoesController(OnlineShoppingContext context)
        {
            _context = context;
        }

        // GET: api/ProductInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductInfo>>> GetProductInfos(int ProductID)
        {
            return await _context.ProductInfos.Where(a=>a.ProductID == ProductID).ToListAsync();
        }

        
    }
}
