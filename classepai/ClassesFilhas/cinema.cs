using System;
using System.IO;
using System.Text;

namespace ProjetoEvento.ClassePai.ClassesFilhas
{
    public class Cinema : Evento
    {
        public Cinema(DateTime[] sessao,  string generofilme)
        {
            this.Sessao = sessao;
            this.GeneroFilme = generofilme;
        }
        public DateTime[] Sessao { get; set; }
        public string GeneroFilme { get; set; }
        public Cinema(string Titulo, string Local, int Lotacao, string Duracao, int Classificacao, DateTime Data, DateTime[] Sessao, string GeneroFilme)
        {
            base.Titulo = Titulo;
            base.Local = Local;
            base.Lotacao = Lotacao;
            base.Duracao = Duracao;
            base.Classificacao = Classificacao;
            base.Data = Data;
            this.Sessao = Sessao;
            this.GeneroFilme = GeneroFilme;
        }
        public override bool Cadastrar()
        {
            bool efetuado = false;
            StreamWriter arquivo = null;
            try
            {
                arquivo = new StreamWriter("cinema.csv", true);
                arquivo.WriteLine(Titulo + ";" + Local + ";" + Duracao + ";" + Data + ";" + Lotacao + ";" + Classificacao + ";" + Sessao + ";" + GeneroFilme);
                efetuado = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar gravar o arquivo" + ex.Message);
            }
            finally
            {
                arquivo.Close();
            }
            return efetuado;
        }
        // public override string Pesquisar(DateTime Sessao)
        // {
        //     string resultado = "Nenhuma sessão prevista para esta data.";
        //     StreamReader ler = null;
        //     try
        //     {
        //         ler = new StreamReader("cinema,csv", Encoding.Default);
        //         string linha = "";
        //         if(Sessao.Contains(linha)){
        //             while((linha = ler.ReadLine()) != null){
        //             string[] dados = linha.Split(';');
        //             if(dados[6] == Sessao.ToString){
        //                 resultado = linha;
        //                 break;
        //             }
        //             }

        //         }
        //     }
        //     catch(Exception ex){
        //         resultado = "Erro ao tentar ler o arquivo." + ex.Message;
        //     }
        //     finally{
        //         ler.Close();
        //     }
        //     return resultado;
        // }

    }
}
