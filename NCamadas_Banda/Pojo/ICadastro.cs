using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojo
{
    public interface ICadastro<T>
    {
        bool Inserir(T obj);
        bool Alterar(T obj);
        bool Excluir(T obj);
        List<T> Listar();
    }
}
