using System.Collections.Generic;

namespace Desafio.Decola.Tech.interfaces
{
    public interface IRepositorio<U>
    {

        Dictionary<int, U> Lista();

        void Inserir(int chave,U entidade);

        void Excluir(int chave);

        void Update(int chave, U entidade);

        int NextID(Dictionary <int, Series> U);

    }
}