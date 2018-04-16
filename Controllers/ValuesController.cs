using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace BlogApp.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        Database.ApplicationDbContext dbContext;

        public ValuesController(Database.ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Entities.Blog> Get()
        {
            return dbContext.Blogs;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Entities.Blog Get(int id)
        {
            return dbContext.Blogs.Where(t => t.Id == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public Entities.Blog Post([FromBody]Entities.Blog value)
        {
            dbContext.Blogs.Add(value);
            dbContext.SaveChanges();
            return value;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Entities.Blog Put(int id, [FromBody]Entities.Blog value)
        {
            var entity = dbContext.Blogs.Where(t => t.Id == id).FirstOrDefault();
            entity.Title = value.Title;
            entity.Content = value.Content;
            dbContext.SaveChanges();
            return entity;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public Entities.Blog Delete(int id)
        {
            var entity = dbContext.Blogs.Where(t => t.Id == id).FirstOrDefault();
            dbContext.Blogs.Remove(entity);
            dbContext.SaveChanges();
            return entity;
        }
    }
}
