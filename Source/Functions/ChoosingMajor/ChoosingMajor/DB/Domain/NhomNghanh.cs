using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoosingMajor.DB.Domain
{
    public class NhomNghanh
    {
        public virtual int ID { get; set; }
        public virtual string MaNhomNghanh { get; set; }
        public virtual string TenNhomNghanh { get; set; }
    }
}
