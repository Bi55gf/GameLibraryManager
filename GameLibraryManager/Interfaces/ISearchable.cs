using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibraryManager.Models;

namespace GameLibraryManager.Interfaces
{
    public interface ISearchable
    {
        Player SearchById(int id);
    }
}
