using System.Globalization;
using System.IO;

namespace FileService
{
    public class ArquivoService
    {
        #region Atributs
     
        string caminho;
        string extensao;
        string novoCaminho;
        string destino;

        #endregion

        #region Properties
        public string Destino { get; set; }
        public string NovoCaminho { get; set; }
        public string Extensao
        {
            get
            {
                return extensao;
            }
            set
            {
                extensao = value;
            }
        }

        public string Caminho
        {
            get
            {
                return caminho;
            }
            set
            {
                 caminho = value;
            }
        }

        #endregion

        #region Methods
        public string[] ApagarFicheirosPorCaracteresDoNome(string caminho, string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return new string[] { "Nome inválido." };
            }

            string[] arquivos = Directory.GetFiles(caminho, $"*{nome}*.*", SearchOption.AllDirectories);

            string[] arquivosNaoApagados = new string[arquivos.Length];

            int i = 0;

            try
            {

                foreach (string arquivo in arquivos)
                {
                    try
                    {
                        File.Delete(arquivo);

                    }
                    catch (Exception ex)
                    {
                        arquivosNaoApagados[i++] = $"Erro ao apagar {arquivo}: {ex.Message}";
                    }
                }

                return arquivos;

            }
            catch (Exception ex)
            {
                return new string[] { $"Erro ao buscar arquivos: {ex.Message}" };
            }

        }

        public string[] ApagarFicheirosPorExtensao(string caminho, string extensao)
        {
            if (string.IsNullOrWhiteSpace(extensao))
            {
                return new string[] { "Extensão inválida." };
            }

            string[] arquivos = Directory.GetFiles(caminho, $"*.{extensao}", SearchOption.AllDirectories);

            string[] arquivosNaoApagados = new string[arquivos.Length];

            int i = 0;

            try
            {

                foreach (string arquivo in arquivos)
                {
                    try
                    {
                        File.Delete(arquivo);

                    }
                    catch (Exception ex)
                    {
                       arquivosNaoApagados[i++] = $"Erro ao apagar {arquivo}: {ex.Message}";
                    }
                }

                return arquivos;

            }
            catch (Exception ex)
            {
                return new string[] { $"Erro ao buscar arquivos: {ex.Message}" };
            }

        }
        public string[] MoverFicheiros(string caminho, string destino)
        {
            string[] arquivos = Directory.GetFiles(caminho);

            foreach (string arquivo in arquivos)
            {
                File.Move(arquivo, $"{destino} {Path.GetFileName(arquivo)}", true);
            }
            return arquivos;
        }

        public string[] CopiarFicheiros(string caminho, string destino)
        {
            string[] arquivos = Directory.GetFiles(caminho);

            foreach (string arquivo in arquivos)
            {
                File.Copy(arquivo, $"{destino} {Path.GetFileName(arquivo)}", true);
            }
            return arquivos;
        }

        public string CriarPasta(string newPath)
        {
            NovoCaminho = newPath;
            bool directoryExists = Directory.Exists(newPath);

            if (directoryExists)
            {
                return "A pasta já existe";
            }
            else
            {
                return Directory.CreateDirectory(newPath).ToString();
            }
        }

        public string[] ListarFicheirosEspecificos(string caminho, string extensao)
        {

            if (string.IsNullOrWhiteSpace(extensao))    
            {
                return new string[] { "Extensão inválida." };
            }
            string[] arquivos = Directory.GetFiles(caminho, $"*.{extensao}", SearchOption.AllDirectories);

            for (int i = 0; i < arquivos.Length; i++)
            {
                arquivos[i] = Path.GetFileName(arquivos[i]);
            }
            return arquivos;
        }

        public string[] ListarFicheirosCompleto(string caminho)
        {
            string[] arquivos = Directory.GetFiles(caminho, "*.*", SearchOption.AllDirectories);
           
            for (int i = 0; i < arquivos.Length; i++)
            {
               var info = new FileInfo(arquivos[i]);

                arquivos[i] = $"{Path.GetFileName(arquivos[i])} {info.Length} bytes";
            }
            return  arquivos;
        }
        public string[] ListarFicheirosNomes(string caminho)
        {
            string[] arquivos = Directory.GetFiles(caminho, "*.*", SearchOption.AllDirectories);

            for (int i = 0; i < arquivos.Length; i++)
            {
                arquivos[i] = Path.GetFileName(arquivos[i]); 
            }
            return arquivos;
        }
        public  string[] ListarSubPastas(string caminho)
        {
            if (string.IsNullOrWhiteSpace(caminho) || !Directory.Exists(caminho))
            {
                return new string[] { "Caminho inválido ou inexistente." };
            }
            return Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);
        }

        public ArquivoService()
        {
            caminho = string.Empty;
            extensao = string.Empty;
            novoCaminho = string.Empty;
            destino = string.Empty;
        }


        #endregion
    }
}
