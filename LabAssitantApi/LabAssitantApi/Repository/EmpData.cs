using LabAssitantApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabAssitantApi.Repository
{
    public class EmpData : IEmpData
    {
        private LabAssitantDBContext LabAssitantDBContext;
        public EmpData(LabAssitantDBContext labAssitantDBContext)
        {
            LabAssitantDBContext = labAssitantDBContext;
        }
        public List<Employee> getData()
        {
            return LabAssitantDBContext.Employee.ToList();
        }
    }
}
