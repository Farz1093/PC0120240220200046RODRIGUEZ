using Microsoft.EntityFrameworkCore;
using PC0120240220200046RODRIGUEZ.DOMAIN.Core.Entities;
using PC0120240220200046RODRIGUEZ.DOMAIN.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC0120240220200046RODRIGUEZ.DOMAIN.Infrastructure.Repositories
{
    public class AttendeesRepository
    {
        private readonly EventManagementDbContext _dbContext;

        public AttendeesRepository(EventManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Attendees>> GetAttendes()
        { 
        
            var attendes = await _dbContext.Attendees.ToListAsync();
            return attendes;
        }

        public async Task<int> Insert(Attendees attendees)
            


       



    }
}
