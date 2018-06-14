using GeradorDeProvas.Domain;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeProvas.Infra.Pdf
{
    public class GerarPDF
    {
        
        private Document _document;
        private Font _bold;
        private PdfWriter _pdfWriter;

        public GerarPDF() { }

        public void CriarProva(Prova prova, string path)
        {
            _document = new Document(PageSize.A4); //Criando e estipulando o tipo da folha usada
            _bold = new Font(Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold);
            
            _pdfWriter = PdfWriter.GetInstance(_document, new FileStream(path, FileMode.Create));// Pegando a instancia do PDF Writer
            _document.SetMargins(40, 40, 40, 80); //estibulando o espaçamento das margens que queremos
            _document.AddCreationDate(); //adicionando as configuracoes

            _document.Open();

            Write("Escola de Educação Básica Mariana R. T.");
            Write("Data: ....../....../......");
            Write("Nome:                                            Nota:");
            Write("Matéria: " + prova.Materia.Nome);
            Write(string.Format("Disciplina: {0}                            Série: {1}", prova.Disciplina.Nome, prova.Serie));
            Write("\n");
            WriteTitulo(string.Format("Prova de {0}", prova.Materia.Nome));
            Write("\n");
            MontarQuestoes(prova.Questoes);
            _document.Add(Chunk.NEXTPAGE);
            WriteTitulo(string.Format("Gabarito - {0}", prova.Materia.Nome));
            Write("\n");
            MontarGabarito(prova.Questoes);
            _document.Close();
        }

        public void MontarQuestoes(List<Questao> questoes)
        {
            int numeroQuestão = 1;
            foreach (var questao in questoes)
            {
                Write(string.Format("{0} - {1}", numeroQuestão, questao.Pergunta));
                int letraID = 1;
                foreach (var alternativa in questao.Alternativas)
                {

                    Write(string.Format("{0}) (  ) {1}", DefinirLetraAlternativa(letraID), alternativa.Descricao));
                    letraID++;
                }
                Write("\n");
                numeroQuestão++;
            }
        }

        public string DefinirLetraAlternativa(int indice)
        {
            switch (indice)
            {
                case 1:
                    return "A";
                case 2:
                    return "B";
                case 3:
                    return "C";
                case 4:
                    return "D";
                case 5:
                    return "E";
                default:
                    return "";
            }

        }

        public void Write(string texto) //escrevendo no documento
        {
            //criando a variável para parágrafo
            Paragraph paragraph = new Paragraph(String.Empty, new Font(Font.NORMAL, 12));

            //estipulando alinhamento
            paragraph.Alignment = Element.ALIGN_JUSTIFIED;

            //adicionando text
            paragraph.Add(texto);

            //adicionando parágrafo ao documento 
            _document.Add(paragraph);
            //return paragraph;
        }

        public void WriteTitulo(string texto)
        {
            //criando a variável para parágrafo
            Paragraph paragraph = new Paragraph(String.Empty,_bold);

            //estipulando alinhamento
            paragraph.Alignment = Element.ALIGN_CENTER;

            //adicionando text
            paragraph.Add(texto);

            //adicionando parágrafo ao documento 
            _document.Add(paragraph);
        }

       
        public void Valida(Prova prova)
        {
            if (prova == null)
                throw new Exception("Não existe nada cadastrado nessa prova");
        }

        
       private void MontarGabarito(List<Questao> questoes)
       {
            int numeroQuestão = 1;
            foreach (var questao in questoes)
            {
                Write(string.Format("{0} - {1}", numeroQuestão, questao.Pergunta));
                int letraID = 1;
                foreach (var alternativa in questao.Alternativas)
                {
                    if (alternativa.IsVerdadeira)
                    {
                        Write(string.Format("{0}) {1}", DefinirLetraAlternativa(letraID), alternativa.Descricao));
                    }
                    letraID++;
                }
                Write("\n");
                numeroQuestão++;
            }
        }

             
       public GerarPDF(string pCaminhoArquivoPDF)
       {
           _document = new Document(PageSize.A4); //Criando e estipulando o tipo da folha usada
           _document.SetMargins(40, 40, 40, 80); //estibulando o espaçamento das margens que queremos
           _document.AddCreationDate(); //adicionando as configuracoes
           _pdfWriter = PdfWriter.GetInstance(_document, new FileStream(pCaminhoArquivoPDF, FileMode.Create));// Pegando a instancia do PDF Writer
       }

       public void OpenDocument() //abrindo documento
       {
           _document.Open();
       }

       public void CloseDocument() //fechando documento
       {
           _document.Close();
       }

    }
}
