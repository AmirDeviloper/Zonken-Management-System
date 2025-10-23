using MapsManagerDataLayer.Model;
using MapsManagerDataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapsManagerDataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        private readonly MapsDatabaseEntities _db;

        public UnitOfWork()
        {
            _db = new MapsDatabaseEntities();
        }

        private GenericRepository<Map> _mapRepository;
        public GenericRepository<Map> MapRepository
        {
            get
            {
                return _mapRepository ?? new GenericRepository<Map>(_db);
            }
        }

        private GenericRepository<RingBinder> _ringBinderRepository;
        public GenericRepository<RingBinder> RingBinderRepository
        {
            get
            {
                return _ringBinderRepository ?? new GenericRepository<RingBinder>(_db);
            }
        }

        private GenericRepository<Department> _departmentRepository;
        public GenericRepository<Department> DepartmentRepository
        {
            get
            {
                return _departmentRepository ?? new GenericRepository<Department>(_db);
            }
        }
        
        public void Save()
        {
            try
            {
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
