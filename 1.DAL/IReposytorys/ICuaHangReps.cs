using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IReposytorys
{
    public interface ICuaHangReps
    {
        bool Add(CuaHang obj);
        bool Update(CuaHang obj);
        bool Delete(CuaHang obj);
        CuaHang GetById(Guid id);
        List<CuaHang> GetAll();
    }
}
