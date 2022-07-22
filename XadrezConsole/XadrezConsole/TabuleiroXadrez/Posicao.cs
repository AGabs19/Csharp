
namespace TabuleiroXadrez
{
    class Posicao
    {
        //Atributos
        public int linha { get; set; }
        public int coluna { get; set; }

        //Construtor
        public Posicao (int linha, int coluna)
        { //This autorreferência 
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString() //Sobreposição
        {
            return linha
                + ","
                + coluna;
        }
    }
}
