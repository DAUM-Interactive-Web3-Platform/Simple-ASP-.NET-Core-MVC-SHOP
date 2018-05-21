using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Models
{
    public interface ISnowboardRepository
    {
        IEnumerable<Snowboard> Snowboards { get; }
        IEnumerable<Snowboard> GetAllSnowboards();

        Snowboard GetSnowboardById(int snowboardId);
    }
}
