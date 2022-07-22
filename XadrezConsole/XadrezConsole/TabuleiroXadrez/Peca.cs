

namespace TabuleiroXadrez
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int qteMovimentos { get; protected set; } //Ela pode ser acessada por outras classes, e só pode ser alterada por ela mesma ou pelas sub classe
        public Tabuleiro tab { get; protected set; }

        //Construtor da Peca
        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0; //Inicia em zero
        }
    }
}
