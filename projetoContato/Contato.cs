using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoContato
{
    internal class Contato
    {

        public string Email { get => Email; set => Email = value; }
        public string Nome { get => Nome; set => Nome = value; }
        public Data dtNasc { get => dtNasc; set => dtNasc = value; }

        List<Telefone> Telefones { get => Telefones; set => Telefones = value; }



        public int getIdade(Data dtNasc, int Data)
        {

        }

    }
}
           


    

