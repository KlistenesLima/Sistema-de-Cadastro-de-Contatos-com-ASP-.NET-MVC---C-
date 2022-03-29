using ControleDeContatos.Models;
using System.Collections.Generic;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BucarTodos();

        ContatoModel Adicionar(ContatoModel contato);
    }
}
