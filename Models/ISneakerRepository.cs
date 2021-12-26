using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakersFootprint.Models
{
    public interface ISneakerRepository
    {
        IEnumerable<Sneaker> AllSneakers { get; }
        IEnumerable<Sneaker> Sale { get; }
        Sneaker GetSneakerById(int sneakerId);
    }
}
