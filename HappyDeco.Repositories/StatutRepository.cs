using HappyDeco.DAL.Repositories;
using HappyDeco.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyDeco.Repositories
{
    public class StatutRepository : BaseRepository<StatutEntity>, IConcreteRepository<StatutEntity>
    {

        public  StatutRepository(string connectionString): base(connectionString)
        {

        }
    public bool Delete(StatutEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<StatutEntity> Get()
        {
            throw new NotImplementedException();
        }

        public StatutEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public List<StatutEntity> GetFromProjet(int idProjet)
        {
            string requete = @"Select Statut.* from Statut 
                               inner join Etat
                               ON Statut.IdStatut = Etat.IdStatut
                                WHERE Etat.IdProjet=" + idProjet;
            return base.Get(requete);
        }
        public bool Insert(StatutEntity toInsert)
        {
            string requete = @"INSERT INTO Statut (libellé)
                               VALUES (@libellé)";
            return base.Insert(toInsert, requete);
        }


        public bool Update(StatutEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
