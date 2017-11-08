using System;

namespace ProjetoEvento.ClassePai.ClassesFilhas
{
    public class Show:Evento
    {
        public Show(string artista, string generoMusical) 
        {
            this.Artista = artista;
                this.GeneroMusical = generoMusical;
               
        }
                public string Artista { get; set; }
        public string GeneroMusical { get; set; }


        public Show(){

        }

        public Show(string Titulo, string Local, int Lotacao, string Duracao, int Classificacao, DateTime Data, string Artista, string GeneroMusical){
            
            base.Titulo = Titulo;
            base.Local  = Local;
            base.Lotacao = Lotacao;
            base.Duracao = Duracao;
            base.Classificao = Classificacao;
            base.Data = Data;
            this.Artista = Artista;
            this.GeneroMusical = GeneroMusical;
        
        }
        public override bool Cadastrar(){
            return false;
        }

    }
}