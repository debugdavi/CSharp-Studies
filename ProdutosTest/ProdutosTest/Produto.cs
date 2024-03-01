using System.Globalization;

namespace ProdutosTest {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quant;

        public double ValorTotal() {
            return Quant * Preco;
        }
        public void AdicionarUnid(int qntd) {
            Quant = Quant + qntd;
        }

        public void RemoverUnid(int qntd) {
            Quant = Quant - qntd;
        }

        public override string ToString() {
            return $"{Nome}, R$ {Preco.
                ToString("F2", CultureInfo.InvariantCulture)}, {Quant} unidades, no total de R$ {ValorTotal()}";

            /*
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", " + Quant + " unidades, total de $" + ValorTotal(); 
            */
        }
    }
}
