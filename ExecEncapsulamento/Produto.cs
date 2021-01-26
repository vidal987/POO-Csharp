using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExecEncapsulamento
{
        class Produto
        {
            private string _nome;
            private double _preco;
            private int _quantidade;

        //CONSTRUTOR OBRIGA A ENTREDA DE PARAMENTROS

        public Produto() { }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if(nome != null && nome.Length > 1)
            {
             _nome = nome;
            }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        //não retornat algo apenas executa o bloco de codigo
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        //SOBREPOSICAO DE METODO 
        public override string ToString()
        {
            return _nome +
                " , $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + " "
                + _quantidade
                + " unidades ," + " Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
