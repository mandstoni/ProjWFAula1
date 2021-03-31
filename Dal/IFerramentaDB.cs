using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IFerramentaDB
    {
        bool Insert(Ferramentas ferramenta);
        bool Update(Ferramentas ferramenta);
        bool Delete(int id);
        Ferramentas SelectById(int id);
        List<Ferramentas> GetAll();
    }
}
