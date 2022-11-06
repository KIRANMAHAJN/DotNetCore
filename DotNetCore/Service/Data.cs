using DotNetCore.Service;
using DotNetCore.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore.Service
{
    public class Data : IData
    {
        private readonly EmployeeDataContext _employeeDataContext;


        public Data(EmployeeDataContext employeeDataContext)
        {
            _employeeDataContext = employeeDataContext;
        }

        public async Task<IEnumerable<TblData>> GetDataList()
        {
           var DataList=await _employeeDataContext.TblData.ToListAsync();
            return DataList;
        }
    }
}
