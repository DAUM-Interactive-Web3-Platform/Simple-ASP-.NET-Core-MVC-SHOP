using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Models
{
    public class SnowboardRepository : ISnowboardRepository
    {
        private AppDbContext _appDbContext;

        public SnowboardRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Snowboard> Snowboards
        {
            get
            {
                return _appDbContext.Snowboards;
            }
        }

        public IEnumerable<Snowboard> GetAllSnowboards()
        {
            
            return _appDbContext.Snowboards;
        }

        public Snowboard GetSnowboardById(int snowboardId)
        {
            return _appDbContext.Snowboards.FirstOrDefault(s => s.Id == snowboardId);
        }
    }
}
