using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Translation.V2;
using DarrenLee.Translator;
using System.Speech;
using System.Speech.Synthesis;
using System.Windows.Controls;
using System.Globalization;

namespace TA_PBO
{
    public partial class FormTranslate : Form
    {
        public string fromLang;
        public string toLang;
        public string temp, temp2;

        public FormTranslate()
        {
            InitializeComponent();
        }

        private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFrom.SelectedIndex == 0)
            {
                fromLang = "ar";
            }
            else if (cbFrom.SelectedIndex == 1)
            {
                fromLang = "de";
            }
            if (cbFrom.SelectedIndex == 2)
            {
                fromLang = "en";
            }
            else if (cbFrom.SelectedIndex == 3)
            {
                fromLang = "fr";
            }
            if (cbFrom.SelectedIndex == 4)
            {
                fromLang = "nl";
            }
            else if (cbFrom.SelectedIndex == 5)
            {
                fromLang = "hu";
            }
            if (cbFrom.SelectedIndex == 6)
            {
                fromLang = "id";
            }
            else if (cbFrom.SelectedIndex == 7)
            {
                fromLang = "it";
            }
            if (cbFrom.SelectedIndex == 8)
            {
                fromLang = "ja";
            }
            else if (cbFrom.SelectedIndex == 9)
            {
                fromLang = "ko";
            }
            if (cbFrom.SelectedIndex == 10)
            {
                fromLang = "no";
            }
            else if (cbFrom.SelectedIndex == 11)
            {
                fromLang = "pt";
            }
            if (cbFrom.SelectedIndex == 12)
            {
                fromLang = "ro";
            }
            else if (cbFrom.SelectedIndex == 13)
            {
                fromLang = "es";
            }
            if (cbFrom.SelectedIndex == 14)
            {
                fromLang = "ru";
            }
            else if (cbFrom.SelectedIndex == 15)
            {
                fromLang = "sv";
            }
            if (cbFrom.SelectedIndex == 16)
            {
                fromLang = "th";
            }
            else if (cbFrom.SelectedIndex == 17)
            {
                fromLang = "tr";
            }
            else if (cbFrom.SelectedIndex == 18)
            {
                fromLang = "uk";
            }

        }

        private void FormTranslate_Load(object sender, EventArgs e)
        {
            btnVoice.Hide();
            btnVoice2.Hide();
        }

        private void btnTranslateWord_Click(object sender, EventArgs e)
        {
            if (cbFrom.Text == string.Empty | cbTo.Text == string.Empty)
            {
                MessageBox.Show("Please selest the language", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string text = Translator.Translate(tbFrom.Text, fromLang, toLang);
                    tbTo.Text = text;
                }
                catch
                {
                    MessageBox.Show("Please open your internet connection" + System.Environment.NewLine + "Or try with another word and language", "No internet connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if(cbFrom.Text == "English")
            {
                btnVoice.Show();
            }
            else if(cbTo.Text == "English")
            {
                btnVoice2.Show();
            }
            else
            {
                btnVoice.Hide();
                btnVoice2.Hide();
            }
        }

        private void cbTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTo.SelectedIndex == 0)
            {
                toLang = "ar";
            }
            else if (cbTo.SelectedIndex == 1)
            {
                toLang = "de";
            }
            if (cbTo.SelectedIndex == 2)
            {
                toLang = "en";
            }
            else if (cbTo.SelectedIndex == 3)
            {
                toLang = "fr";
            }
            if (cbTo.SelectedIndex == 4)
            {
                toLang = "nl";
            }
            else if (cbTo.SelectedIndex == 5)
            {
                toLang = "hu";
            }
            if (cbTo.SelectedIndex == 6)
            {
                toLang = "id";
            }
            else if (cbTo.SelectedIndex == 7)
            {
                toLang = "it";
            }
            if (cbTo.SelectedIndex == 8)
            {
                toLang = "ja";
            }
            else if (cbTo.SelectedIndex == 9)
            {
                toLang = "ko";
            }
            if (cbTo.SelectedIndex == 10)
            {
                toLang = "no";
            }
            else if (cbTo.SelectedIndex == 11)
            {
                toLang = "pt";
            }
            if (cbTo.SelectedIndex == 12)
            {
                toLang = "ro";
            }
            else if (cbTo.SelectedIndex == 13)
            {
                toLang = "es";
            }
            if (cbTo.SelectedIndex == 14)
            {
                toLang = "ru";
            }
            else if (cbTo.SelectedIndex == 15)
            {
                toLang = "sv";
            }
            if (cbTo.SelectedIndex == 16)
            {
                toLang = "th";
            }
            else if (cbTo.SelectedIndex == 17)
            {
                toLang = "tr";
            }
            else if (cbTo.SelectedIndex == 18)
            {
                toLang = "uk";
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                e.Handled = true;
                btnTranslateWord.PerformClick();
            }
        }
        SpeechSynthesizer Synthesizer = new SpeechSynthesizer();
        private void btnVoice_Click(object sender, EventArgs e)
        {
            if(tbFrom.Text != string.Empty)
            {
                Synthesizer.Dispose();
                Synthesizer = new SpeechSynthesizer();
                Synthesizer.SpeakAsync(tbFrom.Text);
            }
        }

        private void btnVoice2_Click(object sender, EventArgs e)
        {
            if (tbTo.Text != string.Empty)
            {
                Synthesizer.Dispose();
                Synthesizer = new SpeechSynthesizer();
                Synthesizer.SpeakAsync(tbTo.Text);
            }
        }

        private void tbTo_Click(object sender, EventArgs e)
        {
            tbTo.Clear();
            btnVoice2.Hide();
        }

        private void tbFrom_Click(object sender, EventArgs e)
        {
            tbFrom.Clear();
            btnVoice.Hide();
        }

        private void tbFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                btnTranslateWord.PerformClick();
            }
        }

        private void cbFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                btnTranslateWord.PerformClick();
            }
        }

        private void btnTukar_Click(object sender, EventArgs e)
        {
            if(tbFrom.Text != string.Empty && tbTo.Text!= string.Empty)
            {
                temp = tbFrom.Text;
                tbFrom.Text = tbTo.Text;
                tbTo.Text = temp;

                temp2 = cbFrom.Text;
                cbFrom.Text = cbTo.Text;
                cbTo.Text = temp2;

                btnVoice.Hide();
                btnVoice2.Hide();
            }

        }
    }
}
