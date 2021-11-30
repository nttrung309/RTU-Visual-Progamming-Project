using ChoosingMajor.DB.Domain;
using ChoosingMajor.DB.Interfaces;
using FX.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoosingMajor.DB.Implements
{
    public class TongHopService : BaseService<TongHop, string>, ITongHopService
    {
        public TongHopService(string sessionFactoryConfigPath, string connectionString = null)
          : base(sessionFactoryConfigPath, connectionString)
        {
        }
    }
}
