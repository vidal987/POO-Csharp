using System;
using System.Globalization;


namespace ExecEstoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        //não retornat algo apenas executa o bloco de codigo
        public void AdicionarProdutos( int quantidade)
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
            return Nome +
                " , $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " "
                + Quantidade
                + " unidades ," + " Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
