using System;
using System.Media;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Timer
{
    public partial class Form1 : Form
    {
        bool first = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrAlarme.Interval = 1000;
            tmrAlarme.Enabled = true;
            tmrAlarme.Start();
            tmrSecond.Interval = 1000;
            tmrSecond.Enabled = true;
            tmrSecond.Start();
        }

        private void btnConverteHora_Click(object sender, EventArgs e)
        {
            converteHora();
        }

        private void btnWave_Click(object sender, EventArgs e)
        {
            ofdWave.DefaultExt = ".wav";
            if (ofdWave.ShowDialog() == DialogResult.OK)
            {
                lblWave.Text = ofdWave.FileName;
            }
        }

        private void tmrSecond_Tick(object sender, EventArgs e)
        {
            lblHora.Text = FormataHora();
            Recursisvo();
        }

        private void tmrAlarme_Tick(object sender, EventArgs e)
        {
            if (first)
            {
                if (DateTime.Now.Second > 30 && (DateTime.Now.Minute.ToString().EndsWith("4") || (DateTime.Now.Minute.ToString().EndsWith("9"))))
                {
                    tmrAlarme.Interval = 300000;
                    first = false;
                }
            }

            if (!first)
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.SetOutputToDefaultAudioDevice();

                if (chk60Minutos.Checked && DateTime.Now.Minute == 59)
                {
                    synth.Speak("60 minutos");
                }
                else if (chk30Minutos.Checked && (DateTime.Now.Minute == 29 || DateTime.Now.Minute == 59))
                {
                    synth.Speak("30 minutos");
                }
                else if (chk15Minutos.Checked && (DateTime.Now.Minute == 14 || DateTime.Now.Minute == 29 || DateTime.Now.Minute == 44 || DateTime.Now.Minute == 59))
                {
                    synth.Speak("15 minutos");
                }
                else
                {
                    if (rdbSomPadrao.Checked)
                    {
                        SystemSounds.Beep.Play();
                    }
                    else if (rdbObjectiveCompleted.Checked)
                    {
                        SoundPlayer snd = new SoundPlayer(Properties.Resources.Objective_Completed);
                        snd.Play();
                    }
                    else if (rdbWave.Checked && lblWave.Text != "Nenhum arquivo selecionado")
                    {
                        try
                        {
                            SoundPlayer snd = new SoundPlayer(lblWave.Text);
                            snd.Play();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Audio em formato inválido! A API de som só oferece suporte para a execução de arquivos wave PCM. Converta com o Switch Sound File Converter");
                        }
                    }
                }
            }
        }

        private string FormataHora()
        {
            DateTime data = DateTime.Now;
            string dataF;
            dataF = (data.Hour.ToString().Length == 1 ? "0" + data.Hour.ToString() : data.Hour.ToString()) + ":";
            dataF += (data.Minute.ToString().Length == 1 ? "0" + data.Minute.ToString() : data.Minute.ToString()) + ":";
            dataF += (data.Second.ToString().Length == 1 ? "0" + data.Second.ToString() : data.Second.ToString());
            return dataF;
        }

        private void Recursisvo()
        {
            string Minut = "0" + (4 - DateTime.Now.Minute % 5).ToString();
            string Second = ((60 - DateTime.Now.Second) == 60 ? 0 : (60 - DateTime.Now.Second)).ToString();
            if (Second.Length == 1) Second = "0" + Second;
            lblLeft.Text = Minut + ":" + Second;
        }

        private void BarNum_ValueChanged(object sender, EventArgs e)
        {
            converteHora();
        }

        private void converteHora()
        {
            DateTime dataInicial = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0);
            DateTime dataCandle = dataInicial.AddMinutes(((int)BarNum.Value - 1) * 5);
            lblHoraCandle.Text = (dataCandle.Hour.ToString().Length == 1 ? "0" + dataCandle.Hour.ToString() : dataCandle.Hour.ToString()) + ":" + (dataCandle.Minute.ToString().Length == 1 ? "0" + dataCandle.Minute.ToString() : dataCandle.Minute.ToString());
        }
    }
}
