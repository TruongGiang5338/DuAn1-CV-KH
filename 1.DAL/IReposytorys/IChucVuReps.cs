using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;

namespace _1.DAL.IReposytorys
{
    public interface IChucVuReps
    {
        bool Add(ChucVu obj);
        bool Update(ChucVu obj);
        bool Delete(ChucVu obj);
        ChucVu GetById(Guid id);
        List<ChucVu> GetAll();
    }
}
