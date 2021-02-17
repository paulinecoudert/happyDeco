
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyDeco.DAL.Repositories;
using HappyDeco.Entities;

namespace HappyDeco.Repositories
{

    public class ProjetRepository : BaseRepository<ProjetEntity>, IConcreteRepository<ProjetEntity>
    {
        public ProjetRepository(string connectionString) : base(connectionString)
        {

        }
        public bool Delete(ProjetEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<ProjetEntity> Get()
        {
            string requete = "Select * from Projet";

            return base.Get(requete);
        }

        public ProjetEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ProjetEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProjetEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
