using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _1021FZ.Data;
using _1021FZ.Models;

namespace _1021FZ.Controllers
{
    [Route("Blogger")]
    [ApiController]
    public class BloggerController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BloggerController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<_1021FZ.Models.Blogger>>> Getproducts()
        {
            return await _context.bloggers.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Blogger>> PostBloggers(Blogger blogt)
        {
            _context.bloggers.Add(blogt);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = blogt.Id }, blogt);
        }

    }
}
