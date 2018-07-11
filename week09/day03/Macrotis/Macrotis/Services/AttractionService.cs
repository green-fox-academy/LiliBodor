using Macrotis.Models;
using Macrotis.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Macrotis.Services
{
    public class AttractionService
    {
        private AttractionsRepository attractionsRepository;

        public AttractionService(AttractionsRepository attractionsRepository)
        {
            this.attractionsRepository = attractionsRepository;
        }

        public List<Attractions> GetAttractions()
        {
           return attractionsRepository.GetAttractions();
        }

        public void AddAttractions(Attractions attraction)
        {
            attractionsRepository.AddAttractions(attraction);
        }
    }
}
