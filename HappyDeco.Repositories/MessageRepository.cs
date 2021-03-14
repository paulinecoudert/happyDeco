using HappyDeco.DAL.Repositories;
using HappyDeco.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyDeco.Repositories
{
    public class MessageRepository : BaseRepository<MessageEntity>,
        IConcreteRepository<MessageEntity>
    {
        public MessageRepository(string connectionString) : base(connectionString)
        {

        }

        public bool Delete(MessageEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<MessageEntity> Get()
        {
            throw new NotImplementedException();
        }

        public MessageEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(MessageEntity toInsert)
        {
            string requete = @"INSERT INTO [dbo].[Message]
           (
           [Nom]
           ,[Email]
           ,[Phone]
           ,[Information]
           ,[DateEnvoie])
     VALUES
           (
           @Nom
           ,@Email
           ,@Phone
           ,@Information
           ,@DateEnvoie)";
            return base.Insert(toInsert, requete);
        }

        public bool Update(MessageEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
