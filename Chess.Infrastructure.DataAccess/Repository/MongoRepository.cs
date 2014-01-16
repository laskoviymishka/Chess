using Chess.Infrastructure.DataAccess.Model.Portal;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Linq;

namespace Chess.Infrastructure.DataAccess.Repository
{
    public class MongoRepository<T> : IRepository<T> where T : IMongoEntity
    {
        #region Private Fields

        private readonly MongoClient _client;

        private readonly MongoServer _server;

        private readonly MongoDatabase _db;

        private volatile Dictionary<string, bool> _cacheExpired;

        #endregion

        #region Constructor

        public MongoRepository(string connectionString, string dbName)
        {
            _client = new MongoClient(new MongoUrl(connectionString));
            _server = _client.GetServer();
            _db = _server.GetDatabase(dbName);
            _cacheExpired = new Dictionary<string, bool>();
        }

        #endregion

        #region IRepository

        public void Insert(T entity)
        {
            _db.GetCollection(typeof(T).Name).Save(entity);
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _db.GetCollection(typeof(T).Name).AsQueryable<T>();
        }

        public T GetById(string id)
        {
            return GetAll().Where(t => t.Id == id).SingleOrDefault();
        }


        public T GetOne(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate).SingleOrDefault();
        }

        public void Update(T entity)
        {
            if (GetById(entity.Id) != null)
            {
                _db.GetCollection(typeof(T).Name).Save<T>(entity);
            }
        }

        #endregion

        public static MongoRepository<T> RepositoryFactory(string connectionString, string dbName)
        {
            return new MongoRepository<T>(connectionString, dbName);
        }
    }
}
