using System.Text.RegularExpressions;

namespace SearchWords
{
    public partial class Form1 : Form
    {
        //private string _filePath = Directory.GetCurrentDirectory();

        //private string _filePath = Path.Combine(Path.GetFullPath(@"..\..\Data"), "all_russian_words.txt");
        private string _filePath = Path.Combine(Path.GetFullPath(@"..\..\Data"), "russian_nouns.txt");

        public Form1()
        {
            InitializeComponent();
        }

        private void addNewWordBtn_Click(object sender, EventArgs e)
        {
            if (wordsCb.Items == null || wordsCb.SelectedItem == null)
            {
                return;
            }

            wordsTb.Text += " " + wordsCb.SelectedItem.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void findWords_Click(object sender, EventArgs e)
        {
            if (!File.Exists(_filePath))
            {
                MessageBox.Show("Файл не найден!");

                return;
            }

            if (wordPatternTb.Text == null || wordPatternTb.Text == string.Empty)
            {
                MessageBox.Show("Вы не ввели паттерн!");

                return;
            }

            wordsCb.Items.Clear();

            Regex regex = new Regex(wordPatternTb.Text, RegexOptions.IgnoreCase);

            using (StreamReader reader = new StreamReader(_filePath))
            {
                string? line;

                while ((line = await reader.ReadLineAsync()) != null)
                {
                    if (regex.IsMatch(line))
                    {
                        wordsCb.Items.Add(line);
                    }
                }
            }

            MessageBox.Show($"Найдено: {wordsCb.Items.Count}");
        }

        private void wordsCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
