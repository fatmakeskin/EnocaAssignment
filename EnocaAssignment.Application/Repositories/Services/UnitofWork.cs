using EnocaAssignment.Application.Context;
using EnocaAssignment.Application.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaAssignment.Application.Repositories.Services
{
    public class UnitofWork:IUnitofWork,IDisposable
    {
        private DbContext _masterContext;

        public DbContext MasterContext
        {
            get
            {
                if (_masterContext == null)
                    _masterContext = new MasterContext();//(MasterContext)Activator.CreateInstance(typeof(DbContext));
                return _masterContext;

            }
            set { _masterContext = value; }
        }

        public void Dispose()
        {
            MasterContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(MasterContext);
        }

        public int SaveChange()
        {
            return MasterContext.SaveChanges();
        }
    }
}
