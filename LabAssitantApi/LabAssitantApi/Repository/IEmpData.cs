using LabAssitantApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabAssitantApi.Repository
{
    public interface IEmpData
    {
        List<Employee> getData();
    }
}
