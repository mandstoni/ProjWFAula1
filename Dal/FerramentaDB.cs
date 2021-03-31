using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class FerramentaDB : IFerramentaDB
    {
        private static List<Ferramentas> lst = new List<Ferramentas>();

        public List<Ferramentas> GetAll()
        {
            var lstOut = new List<Ferramentas>();

            foreach (var item in lst)
            {
                lstOut.Add(item);
            }
            return lstOut;
        }

        public bool Insert(Ferramentas ferramenta)
        {
            lst.Add(ferramenta);
            return true;
        }

        //Segundo momento:

        public Ferramentas SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Ferramentas ferramenta)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            string teste = "Fim da instancia de uma classe";
        }
    }
}
