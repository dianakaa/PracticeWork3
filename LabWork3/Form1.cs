using System;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace LabWork3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createDocumentButton_Click(object sender, EventArgs e)
        {
            var App = new Word.Application();
            var document = App.Documents.Add(Path.Combine(Environment.CurrentDirectory, "״אבכמם.docx"));
            App.Visible = true;

            int numberOfTasks = (int)numericUpDown1.Value;

            document.Content.Find.Execute(FindText: "ׂוךסעָחֿמכÿֲגמהא", ReplaceWith: textBox1.Text);

            document.Content.Find.Execute(FindText: "הה.לל.דדדד קק:לל", ReplaceWith: DateTime.Now.ToString());

            var table = document.Tables[1];
            for (int i = 1; i <= numberOfTasks + 1; i++)
            {
                table.Rows.Add();
                table.Cell(i, 1).Range.Text = i.ToString();
                table.Cell(i, 2).Range.Text = "";
            }

            App.Visible = true;
        }
    }
}
