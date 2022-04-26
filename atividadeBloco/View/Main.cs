using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividadeBloco.View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbBoard.Text = string.Empty;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "C:\\Users";
            openFileDialog1.Filter = "Arquivo de texto|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader leitor = new System.IO.StreamReader(openFileDialog1.FileName);
                rtbBoard.Text = leitor.ReadToEnd();
                leitor.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salvar Como";
            saveFileDialog1.FileName = "";
            saveFileDialog1.InitialDirectory = "C:\\Users";
            saveFileDialog1.Filter = "Arquivo de texto|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter salvar = new System.IO.StreamWriter(saveFileDialog1.FileName);
                salvar.Write(rtbBoard.Text);
                salvar.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbBoard.Text == "")
            {
                MessageBox.Show("Não há nada marcado");
            }
            else
            {
                Clipboard.SetText(rtbBoard.SelectedText);
                rtbBoard.SelectedText = "";
            }
        }


        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbBoard.SelectedText == "")
            {
                MessageBox.Show("Marque algo");

            }
            else
            {
                Clipboard.SetText(rtbBoard.SelectedText);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbBoard.SelectedText = Clipboard.GetText();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbBoard.SelectAll();
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbBoard.SelectionFont = fontDialog1.Font;
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == (DialogResult.OK))
            {
                rtbBoard.SelectionColor = colorDialog1.Color;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feito por Leonardo S. Vicente :)");
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem.PerformClick();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem.PerformClick();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveAsToolStripMenuItem.PerformClick();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem.PerformClick();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem.PerformClick();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem.PerformClick();
        }
    }
}
