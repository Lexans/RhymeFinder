using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhymeFinder
{
    public partial class FormMain : Form
    {
        private Text txt;

        public FormMain()
        {
            InitializeComponent();
        }

        private void ввестиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInputText fit = new FormInputText();
            fit.ShowDialog();
            txt = new Text(fit.InputedText);
            findRhymes();
            showTxt();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txt = new Text(
                    File.ReadAllText(openFileDialog1.FileName)
                    );
                findRhymes();
                showTxt();
            }
            
        }

        private void findRhymes()
        {
            txt.FindRhyme((int)numericUpDownForward.Value);
        }

        /// <summary>
        /// вывод текста в flowLayout
        /// </summary>
        private void showTxt()
        {
            foreach(Word w in txt.Words)
            {
                //слово в виде лейбла
                Label l = new Label();
                l.Tag = w;

                l.AutoSize = true;
                l.Location = new System.Drawing.Point(3, 0);
                l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                l.Text = w.Text;
                l.Margin = new System.Windows.Forms.Padding(0);
                l.BackColor = Color.White;


                //цвет слова в зависимости от найденной рифмы
                switch (w.bestRhyme)
                {
                    case RhymeType.ThreeLetter:
                        l.ForeColor = Color.Red;
                        break;
                    case RhymeType.TwoLetter:
                        l.ForeColor = Color.Green;
                        break;
                    case RhymeType.Special:
                        l.ForeColor = Color.Blue;
                        break;
                    case RhymeType.NoRhyme:
                        l.ForeColor = Color.Black;
                        break;
                    default:
                        break;
                }

                l.Click += new System.EventHandler(this.letter_Click);

                flowLayoutPanelText.Controls.Add(l);
            }

            flowLayoutPanelText.Refresh();
        }

        /// <summary>
        /// обработчик события нажатия на слово
        /// </summary>
        private void letter_Click(object sender, EventArgs e)
        {

            foreach (Label lw in flowLayoutPanelText.Controls)
            {
                lw.BackColor = Color.White;
            }

            Label l = (Label)sender;
            Word w = (Word)l.Tag;

            if (w.bestRhyme < RhymeType.NoRhyme)
            {
                int currIndex = flowLayoutPanelText.Controls.IndexOf(l);
                for (int i = currIndex + 1; i <= currIndex + (int)numericUpDownForward.Value; i++)
                {
                    if (i < flowLayoutPanelText.Controls.Count)
                    {
                        Word nextW = (Word)flowLayoutPanelText.Controls[i].Tag;
                        RhymeType rt = nextW.CheckRhyme(w);
                        switch (rt)
                        {
                            case RhymeType.ThreeLetter:
                                flowLayoutPanelText.Controls[i].BackColor = Color.Yellow;
                                break;
                            case RhymeType.TwoLetter:
                                flowLayoutPanelText.Controls[i].BackColor = Color.GreenYellow;
                                break;
                            case RhymeType.Special:
                                flowLayoutPanelText.Controls[i].BackColor = Color.Cyan;
                                break;
                            case RhymeType.NoRhyme:
                                flowLayoutPanelText.Controls[i].BackColor = Color.White;
                                break;
                            default:
                                break;
                        }
                    }

                }
            }
        }
    }
}
