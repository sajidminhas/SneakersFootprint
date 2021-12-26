using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SneakersFootprint.Models
{
    public class SnearkerRepository: ISneakerRepository
    {
        private readonly AppDbContext _appDbContext;

        public SnearkerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Sneaker> AllSneakers
        {
            get
            {
                return _appDbContext.Sneakers.Include(c => c.Category);
            }
        }

        public IEnumerable<Sneaker> Sale
        {
            get
            {
                return _appDbContext.Sneakers.Include(c => c.Category).Where(s => s.Sale);
            }
        }

        public Sneaker GetPieById(int sneakerId)
        {
            return _appDbContext.Sneakers.FirstOrDefault(s => s.SneakerId == sneakerId);
        }

        public Sneaker GetSneakerById(int sneakerId)
        {
            throw new NotImplementedException();
        }
    }
}
