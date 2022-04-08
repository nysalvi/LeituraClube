using ClubeLeitura.ConsoleApp.ModuloAmigo;
using ClubeLeitura.ConsoleApp.ModuloCaixa;
using ClubeLeitura.ConsoleApp.ModuloRevista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ConsoleApp.Compartilhado
{
    public abstract class CRUD
    {
        public abstract void Inserir();

        public abstract void Editar(int numeroSelecioando, Amigo amigo);
        public void Excluir(int numeroSelecionado)
        {
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i].numero == numeroSelecionado)
                {
                    amigos[i] = null;
                    break;
                }
            }
        }
        public int ObterPosicaoVazia()
        {
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null)
                    return i;
            }
            return -1;
        }
        public Amigo[] SelecionarTodos()
        {
            int quantidadeAmigos = ObterQtdAmigos();

            Amigo[] amigosInseridos = new Amigo[quantidadeAmigos];

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] != null)
                    amigosInseridos[i] = amigos[i];
            }

            return amigosInseridos;
        }
    }
}
