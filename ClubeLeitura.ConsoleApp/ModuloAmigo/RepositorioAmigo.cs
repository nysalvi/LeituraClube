using System;

namespace ClubeLeitura.ConsoleApp.ModuloAmigo
{
    public class RepositorioAmigo
    {
        public Amigo[] amigos;
        public int numeroAmigo;

        public void Inserir(Amigo amigo)
        {
            amigo.numero = ++numeroAmigo;

            int posicaoVazia = ObterPosicaoVazia();
            amigos[posicaoVazia] = amigo;
        }

        public void Editar(int numeroSelecioando, Amigo amigo)
        {
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i].numero == numeroSelecioando)
                {
                    amigo.numero = numeroSelecioando;
                    amigos[i] = amigo;
                    break;
                }
            }
        }

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
        public bool VerificarNumeroAmigoExiste(int numeroAmigo)
        {
            bool numeroAmigoEncontrado = false;

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] != null && amigos[i].numero == numeroAmigo)
                {
                    numeroAmigoEncontrado = true;
                    break;
                }
            }

            return numeroAmigoEncontrado;
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

        public int ObterQtdAmigos()
        {
            int numeroAmigos = 0;

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] != null)
                    numeroAmigos++;
            }

            return numeroAmigos;
        }
    }
}
