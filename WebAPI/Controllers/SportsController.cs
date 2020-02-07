using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class SportsController : ApiController
    {
        SportEntities entities = new SportEntities(); 
      public IEnumerable<Sport> Get()
        {
            return entities.Sports.ToList();
        }


        //This method will return a single Sport against id  
        public Sport Get(int id)
        {
            Sport customer = entities.Sports.Find(id);
            return customer;
        }

        public void PUT(int id, Sport sport)
        {
            var sport1 = entities.Sports.Find(id);
            sport1.Description = sport.Description;
           
            entities.Entry(sport1).State = System.Data.Entity.EntityState.Modified;
            entities.SaveChanges();
        }


    }
}
