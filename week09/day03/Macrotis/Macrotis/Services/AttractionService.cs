using Macrotis.Models;
using Macrotis.Repositories;
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

        public void AddAttractions(Attractions attraction)
        {
            attractionsRepository.AddAttractions(attraction);
        }
    }
}
