using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
   public class Agenda
    {
       public List<Contato> contatos;
        public Agenda()
        {

            contatos = new List<Contato>();

        }
        public void Adicionar(Contato contato)
        {

            contatos.Add(contato);

        }
        //listar todos
        public List<Contato> Buscar()
        {
            return contatos;

        }

        public List<Contato> BuscarNome(String nome)
        {
            List <Contato> retorno = new List<Contato>();
            foreach (Contato c in contatos)
            {
                if (c.Nome.Equals(nome))
                {
                    retorno.Add(c);
                }
            }
            return retorno;
        }

    }
}
