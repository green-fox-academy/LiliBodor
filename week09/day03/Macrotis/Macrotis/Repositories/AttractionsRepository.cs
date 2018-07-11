using Macrotis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Macrotis.Repositories
{
    public class AttractionsRepository
    {
        private MacrotisOrientationExamContext macrotisOrientationExamContaxt;

        public AttractionsRepository(MacrotisOrientationExamContext macrotisOrientationExamContaxt)
        {
            this.macrotisOrientationExamContaxt = macrotisOrientationExamContaxt;
        }

        public List<Attractions> GetAttractions()
        {
            return macrotisOrientationExamContaxt.Attractions.ToList();
        }

        public void AddAttractions(Attractions attraction)
        {
            macrotisOrientationExamContaxt.Attractions.Add(attraction);
            macrotisOrientationExamContaxt.SaveChanges();
        }
    }
}
