using GeekHunter.Data.Implementation.Entities;

namespace GeekHunter.Data.Implementation.Responsitories
{
    public abstract class BaseReponsitory:IDisposable
    {
        protected GeekHunterEntities ctx;

        public BaseReponsitory(GeekHunterEntities context)
        {
            ctx = context;
        }
        
        public void Dispose()
        {
            ctx.Dispose();
        }
    }
}
