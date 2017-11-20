using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    /// <summary>
    /// Interface d'accès aux comptes
    /// </summary>
    public interface ICompteRepository
    {
        /// <summary>
        /// Récupère la liste des comptes
        /// </summary>
        /// <returns></returns>
        IList<Compte> GetAll();
    }
}