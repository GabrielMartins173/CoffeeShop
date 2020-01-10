using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShopApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        CoffeeShopDbContext _coffeeShopDbContext;

        public MenusController(CoffeeShopDbContext coffeeShopDbContext)
        {
            _coffeeShopDbContext = coffeeShopDbContext;
        }

        [HttpGet]
        public IActionResult GetMenus()
        {
            var menus = _coffeeShopDbContext.Menus.Include("SubMenus");
            return Ok(menus);
        }

        [HttpGet("{id}")]
        public IActionResult GetMenu(int id)
        {
            var menu = _coffeeShopDbContext.Menus.Include("SubMenus").FirstOrDefault(m=>m.Id == id);

            if (menu == null)
            {
                return NotFound("We can't found a menu with this id...");
            }
            else
            {
                return Ok(menu);
            }
        }
    }
}