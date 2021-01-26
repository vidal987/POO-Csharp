using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExecPropriedades
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; } // AUTO PROPETIE
        //CONSTRUTOR OBRIGA A ENTREDA DE PARAMENTROS

        public Produto() { }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        //SIMPLIFICANDO O ENCAPSULAMENTO COM AS PROPRIEDADES

        //LOGICA CUSTOMIZADA DA PROPRIEDADE
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        //public string GetNome()
        //{
        //    return _nome;
        //}

        //public void SetNome(string nome)
        //{
        //    if (nome != null && nome.Length > 1)
        //    {
        //        _nome = nome;
        //    }
        //}

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        //não retornat algo apenas executa o bloco de codigo
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        //SOBREPOSICAO DE METODO 
        public override string ToString()
        {
            return _nome +
                " , $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " "
                + Quantidade
                + " unidades ," + " Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
