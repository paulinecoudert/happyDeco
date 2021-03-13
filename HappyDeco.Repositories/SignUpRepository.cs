using HappyDeco.DAL.Repositories;
using HappyDeco.Entities;
using Microsoft.Owin.Security.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HappyDeco.Repositories
{
    public class SignUpRepository : BaseRepository<SignUpEntity>, IConcreteRepository<SignUpEntity>
    {
        public SignUpRepository(string connectionString) : base(connectionString)
        {

        }

        public bool Delete(SignUpEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<SignUpEntity> Get()
        {
            return base.Get("Select * from UserClient");
        }


        public SignUpEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(SignUpEntity toInsert)
        {
            string requete = @"INSERT INTO [dbo].[UserClient]
           ([login]
           ,[password]
           ,[nom]
           ,[prenom]
          
           ,[email]
           ,[salt])
     VALUES
           (login, nvarchar(50),
           ,password, nvarchar(500),
           ,nom, nvarchar(50),
           ,prenom, nvarchar(50),
          
           ,email, nvarchar(50),
           ,salt, nvarchar(250)";




            return base.Insert(toInsert, requete);
        }

        public bool Update(SignUpEntity toUpdate)
        {
            throw new NotImplementedException();
        }

    }
}

