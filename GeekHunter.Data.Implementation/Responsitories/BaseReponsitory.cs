using GeekHunter.Data.Implementation.Entities;

namespace GeekHunter.Data.Implementation.Responsitories
{
    public class BaseReponsitory
    {
        protected GeekHunterEntities ctx;

        public BaseReponsitory(GeekHunterEntities context)
        {
            ctx = context;
        }
    }
}
