using System;

namespace ProjetoEvento.ClassePai
{
    public abstract class Evento
    {
        public string Local { get; set; }
        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public int Lotacao { get; set; }
        public string Duracao { get; set; }
        public int Classificao { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual bool Cadastrar(){
            return false;
        }
        
        /// <summary>
        /// Efetua a pesquisa com a data do evento.
        /// </summary>
        /// <param name="DataEvento">Utiliza um parâmetro do tipo DateTime.</param>
        /// <returns>Retorna o resultado da pesquisa.</returns>
        public virtual string Pesquisar(DateTime DataEvento){
            return null;
        }

        /// <summary>
        /// Efetua a pesquisa com o título do evento.
        /// </summary>
        /// <param name="TituloEvento">Utiliza um parâmetro do tipo string</param>
        /// <returns></returns>
        public virtual string Pesquisar(string TituloEvento){
        return null;
        }
    }
}