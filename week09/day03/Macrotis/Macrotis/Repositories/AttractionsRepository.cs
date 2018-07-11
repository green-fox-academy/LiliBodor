using Macrotis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Macrotis.Repositories
{
    public class AttractionsRepository
    {
        private object MacrotisOrientationExamContext;

        public AttractionsRepository(object attractionContext)
        {
            this.MacrotisOrientationExamContext = attractionContext;
        }

        public void AddAttractions(Attractions attraction)
        {
            MacrotisOrientationExamContext.Attractions.Add(attraction);
            MacrotisOrientationExamContext.SaveChanges();
        }
    }
}
