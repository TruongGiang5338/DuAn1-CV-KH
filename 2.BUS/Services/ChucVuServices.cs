using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using _2.BUS.IServices;
using _1.DAL.Reposytorys;
using _1.DAL.IReposytorys;
using _1.DAL.DomainModels;

namespace _2.BUS.Services
{
    public class ChucVuServices : IChucVuServices
    {
        private IChucVuReps _IChucVuServices;
        private List<ChucVu> _ChucVu;
        public ChucVuServices()
        {
            _IChucVuServices = new ChucVuReps();
            _ChucVu = new List<ChucVu>();
        }

        public string Add(ChucVu chucVu)
        {
            _IChucVuServices.Add(chucVu);
            return "Thành công";
        }

        public string Delete(ChucVu chucVu)
        {
            _IChucVuServices.Delete(chucVu);
            return "Thành công";
        }

        public List<ChucVu> GetAll()
        {
            _ChucVu = _IChucVuServices.GetAll();
            return _ChucVu;
        }

        public List<ChucVu> GetAll(string input)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> LocTrangThai(int input)
        {
            throw new NotImplementedException();
        }

        public string Update(ChucVu chucVu)
        {
            _IChucVuServices.Update(chucVu);
            return "Thành công";
        }
    }
}
