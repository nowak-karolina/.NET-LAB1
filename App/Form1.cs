using Lab1;

namespace App {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void TextChanged_number(object sender, EventArgs e) {
            TextBox textbox = sender as TextBox;

            if (int.TryParse(textbox.Text, out int result)) {
                textbox.BackColor = Color.LightGreen;
            } else {
                textbox.BackColor = Color.LightPink;
            }
        }

        private void ButtonRun(object sender, EventArgs e) {
            List<TextBox> list = new List<TextBox> { textBox_capacity, textBox_items, textBox_seed };
            if(GoodInput(list)) {
                Problem problem = new Problem(int.Parse(textBox_items.Text), int.Parse(textBox_seed.Text));
                textBox_instance.Text = problem.ToString();
                Result result = problem.Solve(int.Parse(textBox_capacity.Text));
                textBox_results.Text = result.ToString();

            } else {
                textBox_results.Text = "naucz sie pisac cyfry";
                textBox_instance.Text = "";
            }
        }

        private bool GoodInput(List<TextBox> list) {
            int counter = 0;
            for (int i = 0; i < list.Count; i++) {
                if (list[i].BackColor==Color.LightGreen) {
                    counter++;
                }
            }

            if(counter == list.Count) {
                return true;

            }else {
                return false;
            }

        }
    }
}
