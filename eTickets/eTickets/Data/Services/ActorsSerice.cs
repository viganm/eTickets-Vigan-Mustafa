using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ActorsSerice : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsSerice(AppDbContext context) : base(context) { }


    }
}
