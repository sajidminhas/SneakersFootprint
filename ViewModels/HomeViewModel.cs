using SneakersFootprint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakersFootprint.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Sneaker> Sale { get; set; }
    }
}
