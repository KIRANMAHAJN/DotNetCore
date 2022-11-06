
using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCore.Model;
using DotNetCore.Model;

namespace DotNetCore.Service
{
    public interface IData
    {
        Task<IEnumerable<TblData>> GetDataList();
    }
}
