using HappyDeco.DAL.Repositories;
using HappyDeco.Entities;
using HappyDeco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyDeco.Repositories
{
    public class DataContext
    {
        IConcreteRepository<ProjetEntity> _projetRepo;
        public DataContext(string connectionString)
        {
            _projetRepo = new ProjetRepository(connectionString);
        }

        public List<ProjetModel> GetAllProjet()
        {
            return _projetRepo.Get()
               .Select(m =>
               new ProjetModel()
               {
                   Nom = m.Nom,
                   Image = m.Image
               }).ToList();
        }
    }
}
