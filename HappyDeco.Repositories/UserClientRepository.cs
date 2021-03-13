using HappyDeco.DAL.Repositories;
using HappyDeco.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool;

namespace HappyDeco.Repositories
{

    public class UserClientRepository : BaseRepository<UserClientEntity>, IConcreteRepository<UserClientEntity>
    {

        public UserClientRepository(string ConnectionString) : base(ConnectionString)
        {

        }


        public List<UserClientEntity> Get()
        {
            return base.Get("Select * from UserClient");
        }

        public UserClientEntity GetOne(int PK)
        {
            return base.GetOne(PK, "Select * from UserClient where IdUserClient=@id");
        }


        public List<UserClientEntity> GetFromProjet(int idProjet)
        {
            string requete = @"Select UserClient.* from UserClient 
                               inner join Creation
                               ON UserClient.IdUserClient = Creation.IdUserClient
                                WHERE Creation.IdProjet=" + idProjet;
            return base.Get(requete);
        }

        public bool InsertFromProject(int idUserClient, int idProjet) //ajout Mike pour insérer valeurs de idStatut et idProjet
        {
            string requete = $@"Insert into Creation Values (GetDate() ,{idUserClient},{idProjet})";
            return base.Insert(requete);
        }


        public UserClientEntity GetFromLogin(string login)
        {
            Dictionary<string, object> p = new Dictionary<string, object>();
            p.Add("login", login);
            return base.Get("Select * from [UserClient] where Login=@login", p).FirstOrDefault();
        }

        public bool Insert(UserClientEntity toInsert)
        {
            SecurityHelper securityHelper = new SecurityHelper();
            byte[] salt = securityHelper.GenerateLongRandomSalt();
            toInsert.Salt = Convert.ToBase64String(salt);
            toInsert.Password = securityHelper.createHash(toInsert.Password, salt);
            string requete = @"INSERT INTO [dbo].[UserClient]
           ([Nom]
           ,[Prenom]
            ,[DateDeNaissance]
            ,[Email]
           ,[Login]
           ,[Password]
           ,[Salt])
            VALUES
           (@nom
           ,@prenom
            ,@DateDeNaissance 
            ,@Email 
           ,@Login 
           ,@Password 
           ,@Salt)";


            return base.Insert(toInsert, requete);
        }

        public bool Update(UserClientEntity toUpdate)
        {
            throw new NotImplementedException();
        }

        public bool Delete(UserClientEntity toDelete)
        {
            throw new NotImplementedException();
        }


    }
}

