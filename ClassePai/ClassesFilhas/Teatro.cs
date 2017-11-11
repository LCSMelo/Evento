using System;
using System.IO;
using System.Text;

namespace ProjetoEvento.ClassePai.ClassesFilhas
{
    public class Teatro : Evento
    {
        public Teatro(string[] elenco, string diretor)
        {
            this.Elenco = elenco;
            this.Diretor = diretor;
        }
        public string[] Elenco { get; set; }
        public string Diretor { get; set; }

        public Teatro(string Titulo, string Local, int Lotacao, string Duracao, int Classificacao, DateTime Data, string[] Elenco, string Diretor)
        {
            base.Titulo = Titulo;
            base.Local = Local;
            base.Lotacao = Lotacao;
            base.Duracao = Duracao;
            base.Classificacao = Classificacao;
            base.Data = Data;
            this.Elenco = Elenco;
            this.Diretor = Diretor;
        }
        
        /// <summary>
        /// Efetua o cadastro de um novo show.
        /// </summary>
        /// <param name="Cadastrar">Utiliza o parâmetro do tipo boolean.</param>
        /// <returns>Não retorna dados, apenas realiza o cadastro.</returns>
        public override bool Cadastrar()
        {
            bool efetuado = false;
            StreamWriter arquivo = null;
            try
            {
                string elenco1 = "";
                foreach(string ator in Elenco){
                    elenco1 += (ator + ",");
                }
                elenco1 = elenco1.Substring(0, (elenco1.Length) - 1);

                arquivo = new StreamWriter("teatro.csv", true);
                arquivo.WriteLine(Titulo + ";" + Local + ";" + Duracao + ";" + Data + ";" + Lotacao + ";" + Classificacao + ";" + Elenco + ";" + Diretor);
                efetuado = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar gravar o arquivo." + ex.Message);
            }
            finally
            {
                arquivo.Close();
            }
            return efetuado;
        }

        /// <summary>
        /// Pesquisa o elenco do teatro
        /// </summary>
        /// <param name="Elenco">Utiliza o parâmetro do tipo string</param>
        /// <returns>Retorna se encontrou ou não o ator dentro de elenco</returns>
        public override string Pesquisar(string Elenco)
        {
            string resultado = "Ator não encontrado.";
            StreamReader ler = null;
            try
            {
                
                ler = new StreamReader("teatro.csv", Encoding.Default);
                string linha = "";
                if (Elenco.Contains(linha)){
                    while((linha = ler.ReadLine()) != null){
                        string[] dados = linha.Split(';');
                        if(dados[6] == Elenco){
                            resultado = linha;
                            break;
                        }
                    }
                }
            }
            catch(Exception ex){
                resultado = "Erro ao tentar ler o arquivo." + ex.Message;

            }
            finally{
                ler.Close();
            }
            return resultado;
        }

        public string Pesquisardiretor (string Diretor)
        {
            string resultado = "Diretor não encontrado.";
            StreamReader ler = null;
            try
            {
                ler = new StreamReader("teatro.csv", Encoding.Default);
                string linha = "";
                while((linha = ler.ReadLine()) != null){
                    string[] dados = linha.Split(';');
                    if(dados[7] == Diretor.ToString()){
                        resultado = linha;
                        break;
                    }
                }
            }
            catch(Exception ex){
                resultado = "Erro ao tentar ler o arquivo." + ex.Message;

            }
            finally{
                ler.Close();
            }
            return resultado;
        }
        public string PesquisarTitulo(string Titulo)
        {
            string resultado = "Título não encontrado.";
            StreamReader ler = null;
            try
            {
                ler = new StreamReader("teatro.csv", Encoding.Default);
                string linha = "";
                while((linha = ler.ReadLine()) != null){
                    string[] dados = linha.Split(';');
                    if(dados[0] == Titulo){
                        resultado = linha;
                        break;
                    }
                }
            }
            catch(Exception ex){
                resultado = "Erro ao tentar ler o arquivo." + ex.Message;

            }
            finally{
                ler.Close();
            }
            return resultado;
        }

    }
} 