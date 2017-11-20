using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using NHibernate.Linq;

namespace DAL
{
    public class CompteRepository : Repository,ICompteRepository
    {
        public IList<Compte> GetAll()
        {
            return Session.Query<Compte>().ToList();
        }

    }
}
