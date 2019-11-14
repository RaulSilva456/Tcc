using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;
using System.Speech.Synthesis;


namespace FERIADO_JARVIS_
{
    public partial class Jarvis : Form
    {
        private SpeechRecognitionEngine engine;//reconecimento meu
        private static SpeechSynthesizer jarvi = new SpeechSynthesizer();//reconhecimento do jarvis

          public bool jarvisOuvindo = true;





        //telas
        Telas.frmMenu menu = new Telas.frmMenu();
        Telas.frmInserirFuncionario inserirfuncionario = new Telas.frmInserirFuncionario();
        Telas.frmFolhaPagamento folhapagamnento = new Telas.frmFolhaPagamento();
        Telas.frmEstoque estoque = new Telas.frmEstoque();
        Telas.frmCadastroProdutos produtos = new Telas.frmCadastroProdutos();
        Telas.frmClientes cliente = new Telas.frmClientes();
        Telas.frmDespesas despesas = new Telas.frmDespesas();
        Telas.frmFornecedores fornecedores = new Telas.frmFornecedores();
      
        public Jarvis()
        {
            InitializeComponent();
        }
        private void loadSpeech()
        {
            try
            {
                engine = new SpeechRecognitionEngine();
                engine.SetInputToDefaultAudioDevice();//micro

                //comandos do sitema para voz
                Choices c_ComandoDoSistema = new Choices();
                c_ComandoDoSistema.Add(GrammarRules.QueHorasSão.ToArray());//HORAS
                c_ComandoDoSistema.Add(GrammarRules.QualData.ToArray());//DATA
                c_ComandoDoSistema.Add(GrammarRules.FeriadoStar.ToArray());//jarvis Star
                c_ComandoDoSistema.Add(GrammarRules.FeriadoStop.ToArray());//jarvis stop
                c_ComandoDoSistema.Add(GrammarRules.MinimizarJanela.ToArray());//minimizar janela
                c_ComandoDoSistema.Add(GrammarRules.MaximizarTela.ToArray());//MAXIMIZAR JANELA
                c_ComandoDoSistema.Add(GrammarRules.AbrirMenu.ToArray());//abrir menu
                c_ComandoDoSistema.Add(GrammarRules.FecharMenu.ToArray()); //fechar menu
                c_ComandoDoSistema.Add(GrammarRules.AbriCliente.ToArray());
                c_ComandoDoSistema.Add(GrammarRules.fecharCliente.ToArray());
                c_ComandoDoSistema.Add(GrammarRules.AbriFolha.ToArray());
                c_ComandoDoSistema.Add(GrammarRules.AbrirDespesas.ToArray());
                c_ComandoDoSistema.Add(GrammarRules.AbrirEstoque.ToArray());
                c_ComandoDoSistema.Add(GrammarRules.AbrirFornecedores.ToArray());
                c_ComandoDoSistema.Add(GrammarRules.AbrirFuncionario.ToArray());
                c_ComandoDoSistema.Add(GrammarRules.AbrirProduto.ToArray());
                c_ComandoDoSistema.Add(GrammarRules.fecharCliente.ToArray());
                c_ComandoDoSistema.Add(GrammarRules.fecharDespesas.ToArray());
                c_ComandoDoSistema.Add(GrammarRules.fecharEstoque.ToArray());
                c_ComandoDoSistema.Add(GrammarRules.fecharFolha.ToArray());
                c_ComandoDoSistema.Add(GrammarRules.fecharFornecedores.ToArray());
                c_ComandoDoSistema.Add(GrammarRules.fecharFuncionario.ToArray());
                c_ComandoDoSistema.Add(GrammarRules.fecharProduto.ToArray());
               

                GrammarBuilder gb_ComandosDoSistema = new GrammarBuilder();
                gb_ComandosDoSistema.Append(c_ComandoDoSistema);

                Grammar g_ComandoDosistema = new Grammar(gb_ComandosDoSistema);
                g_ComandoDosistema.Name = "sys";

                engine.LoadGrammar(g_ComandoDosistema);//carrega funçoes

                engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(reconhecimento);
                engine.AudioLevelUpdated += new EventHandler<AudioLevelUpdatedEventArgs>(audiolevel);
                engine.SpeechRecognitionRejected += new EventHandler<SpeechRecognitionRejectedEventArgs>(rej);

                // gramatica do jarvis falando

                jarvi.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(jarvisfalando);










             



                //"pare de ouvir" "feriado" voltar a ouvir

                engine.RecognizeAsync(RecognizeMode.Multiple);//inicia o conhecimento
                speak("Esperando Meus Componetes Fikar Pronto");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu No LoadSpeech():  " + ex.Message);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            loadSpeech();
            speak("Ja Carreguei Meus Componetes");
        }
        private void reconhecimento(object sender, SpeechRecognizedEventArgs e)
        {
            try
            {
                string speech = e.Result.Text;
                float conf = e.Result.Confidence;
                this.label1.Text = "Reconecimineto: " + speech;

                if (conf > 0.35f)
                {
                    this.label1.ForeColor = Color.Aquamarine; ;
                    if (GrammarRules.FeriadoStop.Any(x => x == speech))
                    {
                        speak("Fui Dormi Até Logo");
                        jarvisOuvindo = false;
                    }
                    else if (GrammarRules.FeriadoStar.Any(x => x == speech))
                    {
                        speak("Acordei Como Posso Ajudar");
                        jarvisOuvindo = true;
                    }
                    if (jarvisOuvindo == true)
                    {
                        switch (e.Result.Grammar.Name)
                        {
                            case "sys":
                                if (GrammarRules.QueHorasSão.Any(x => x == speech))
                                {
                                    Runner.qualHORAS();
                                }
                                else if (GrammarRules.QualData.Any(x => x == speech))
                                {
                                    Runner.QualDia();
                                }
                                else if (GrammarRules.MinimizarJanela.Any(x => x == speech))
                                {
                                    minimizarJanela();
                                }

                                else if (GrammarRules.MaximizarTela.Any(x => x == speech))
                                {
                                    MaximizarJanela();
                                }
                                else if (GrammarRules.AbrirMenu.Any(x => x == speech))
                                {
                                    abrirmenu();
                                }
                                else if (GrammarRules.FecharMenu.Any(x => x == speech))
                                {
                                    fecharmenu();
                                }

                                else if (GrammarRules.AbriCliente.Any(x => x == speech))
                                {
                                    abrircliente();
                                }
                                else if (GrammarRules.fecharCliente.Any(x => x == speech))
                                {
                                    fecharcliente();
                                }
                                else if (GrammarRules.AbriFolha.Any(x => x == speech))
                                {
                                    abrirfolha();
                                }
                                else if (GrammarRules.fecharFolha.Any(x => x == speech))
                                {
                                    fecharfolha();
                                }
                                else if (GrammarRules.AbrirDespesas.Any(x => x == speech))
                                {
                                    abrirdespesas();
                                }
                                else if (GrammarRules.fecharDespesas.Any(x => x == speech))
                                {
                                    fechardespesas();
                                }
                                else if (GrammarRules.AbrirEstoque.Any(x => x == speech))
                                {
                                    abrirestoque();
                                }
                                else if (GrammarRules.fecharEstoque.Any(x => x == speech))
                                {
                                    fecharestoque();
                                }
                                else if (GrammarRules.AbrirFornecedores.Any(x => x == speech))
                                {
                                    abrifornercedores();
                                }
                                else if (GrammarRules.Feu.Any(x => x == speech))
                                {
                                  fechar
                                }


                                break;


                        }

                    }

                }
                else
                {


                    this.label1.ForeColor = Color.Blue;
                }

            }
            catch (Exception)
            {

                speak("Comando De Voz Invalido Venha Com Um Portugues Mais Transparente");
            }
            
        }
        //metodos
        private void audiolevel(Object s, AudioLevelUpdatedEventArgs e)
        {
            this.progressBar1.Maximum = 100;
            this.progressBar1.Value = e.AudioLevel;
        }

        private void rej(object s, SpeechRecognitionRejectedEventArgs e)
        {
            this.label1.ForeColor = Color.Red;
        }
        //Tela do feriado
        private void minimizarJanela()
        {
            if (this.WindowState == FormWindowState.Normal || this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
                speak("VoCê Que Manda", "Pronto", "Tabom Né", "Minimizada");
            }
            else
            {
                speak("Ja Esta Minimizada");
            }



        }
        private void MaximizarJanela()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                speak("Pronto Você Que Manda", "vocÊ Que Manda Meu Truta", "Pronto", "Levantada");
            }
            else
            {
                speak("Ja Esta Maximizada");
            }


        }
        //metodos para as telas minimizar e janela normal 

        private void MinimizarMenu()
        {
            if (menu.WindowState == FormWindowState.Normal)
            {
                menu.WindowState = FormWindowState.Minimized;
                speak("Menu Minimizado", "Pronto", "vocé que manda");


            }
            else
            {
                speak("Tela Menu ja esta Minimizada");

            }




        }

      
        
        //telas abrir e Fechar
        private void fecharmenu()
        {
            menu.Close();
        }
        private void abrirmenu()
        {

            menu.Show();

        }

        private void fecharcliente()
        {
            cliente.Close();
        }
        private void abrircliente()
        {

            cliente.Show();

        }
        private void fechardespesas()
        {
            despesas.Close();
        }
        private void abrirdespesas()
        {

            despesas.Show();

        }
        private void fecharestoque()
        {
            estoque.Close();
        }
        private void abrirestoque()
        {

           estoque.Show();

        }
        private void fecharfolha()
        {
            folhapagamnento.Close();
        }
        private void abrirfolha()
        {

           folhapagamnento.Show();

        }
        private void fecharfornecedores()
        {
            fornecedores.Close();
        }
        private void abrifornercedores()
        {

            fornecedores.Show();

        }
        private void fecharfuncionario()
        {
            inserirfuncionario.Close();
        }
        private void abriinserirFuncionario()
        {

          inserirfuncionario.Show();

        }







        // jarvis falando
        public void jarvisfalando(object s, SpeakProgressEventArgs e)
        {
            label2.Text = e.Text;
        }


        // saida
        private static void speak(string text)
        {
            jarvi.SpeakAsync(text);
        }
        private static void speak(params string[] texts)
        {
            Random rnd = new Random();
            speak(texts[rnd.Next(1, texts.Length)]);
        }
    }
}