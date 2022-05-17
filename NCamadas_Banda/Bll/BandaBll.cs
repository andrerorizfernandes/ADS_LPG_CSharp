using Pojo;
using Dal;
using System.Collections.Generic;

namespace Bll
{
    public class BandaBll : ICadastro<Banda>
    {
        public bool Alterar(Banda banda)
        {
            BandaDal b = new BandaDal();
            return b.Alterar(banda);
        }

        public bool Excluir(Banda banda)
        {
            BandaDal b = new BandaDal();
            return b.Excluir(banda);
        }

        public bool Inserir(Banda banda)
        {
            BandaDal b = new BandaDal();
            return b.Inserir(banda);
        }

        public List<Banda> Listar()
        {
            BandaDal b = new BandaDal();
            return b.Listar();
        }
    }
}