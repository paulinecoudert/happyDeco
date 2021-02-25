
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

        public List<ProjetEntity> GetFromStatut(int idStatut)
        {
            string requete = @"Select Projet.* from Projet 
                               inner join Etat
                               ON Projet.IdProjet = Etat.IdStatut
                                WHERE Etat.IdStatut=" + idStatut;
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
        public bool InsertWithId(ProjetEntity toInsert, out int id) //Ajout Mike de l'insertion pour ressortir la valeur de l'idProjet
        {
            string requete = @"INSERT INTO Projet (nom, image, description, piece, budget, dateDeDebut, dateDeFin)
OUTPUT INSERTED.IdProjet                              
VALUES (@nom, @image, @description, @piece ,@budget, @dateDeDebut, @dateDeFin)";

             
                
            return base.Insert(toInsert, requete, out id);
        }

        public bool Update(ProjetEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
