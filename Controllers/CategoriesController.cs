using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace BlogApp.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        Database.ApplicationDbContext dbContext;

        public CategoriesController(Database.ApplicationDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }




    }
}
