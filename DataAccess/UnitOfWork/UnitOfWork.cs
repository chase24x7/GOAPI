using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;

namespace DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IAppUserRepository _appUserRepository;

        public UnitOfWork(ICategoryRepository categoryRepository, IAppUserRepository appUserRepository)
        {
            _categoryRepository = categoryRepository;
            _appUserRepository = appUserRepository;
        }
        public ICategoryRepository CategoryRepository
        {
            get
            {
                return _categoryRepository;
            }
        }
        public IAppUserRepository AppUserRepository
        {
            get
            {
                return _appUserRepository;
            }
        }



        void IUnitOfWork.Complete()
        {
            throw new NotImplementedException();
        }

       

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls



        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UnitOfWork() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
