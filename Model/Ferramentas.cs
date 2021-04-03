using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ferramentas : Produto
    {
        public const string INSERT = "INSERT INTO TB_FERRAMENTA (Descricao, Tipo, Marca, Preco) VALUES ('{0}', '{1}', '{2}', '{3}')";
        public const string GETALL = "SELECT id, Descricao, Tipo, Marca, Preco FROM TB_FERRAMENTA";
    }
}
