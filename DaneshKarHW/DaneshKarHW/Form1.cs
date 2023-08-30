namespace DaneshKarHW
{
    public partial class Form1 : Form
    {
        Practice practice;
        public Form1()
        {
            InitializeComponent();
            practice = new Practice();
        }

        private void btnIsAnagramByLinq_Click(object sender, EventArgs e)
        {            
            bool result = practice.IsAnagramByLinq(txtFirst.Text, txtSecond.Text);
            MessageBox.Show($"result is {result}");
        }

        private void btnIsAnagramByList_Click(object sender, EventArgs e)
        {
            bool result = practice.IsAnagramByList(txtFirst.Text, txtSecond.Text);
            MessageBox.Show($"result is {result}");
        }

        private void btnAddDigits_Click(object sender, EventArgs e)
        {
            int result = practice.AddDigits(Convert.ToInt32(txtAddDigitsNumber.Text));
            MessageBox.Show($"result is {result}");
        }

        private void btnIsUgly_Click(object sender, EventArgs e)
        {
            bool result = practice.IsUgly(Convert.ToInt32(txtIsUglyNumber.Text));
            MessageBox.Show($"result is {result}");
        }

        private void btnMoveZeroes_Click(object sender, EventArgs e)
        {
            //string[] l = txtMoveZeroesNumbers.Text.Split(',');
            int[] numbers = Array.ConvertAll(txtMoveZeroesNumbers.Text.Split(','), s => int.Parse(s));
            practice.MoveZeroes(numbers);
        }

        private void btnWordPattern_Click(object sender, EventArgs e)
        {
            bool result = practice.WordPattern(txtPattern.Text, txtS.Text);
            MessageBox.Show($"result is {result}");
        }
    }
}
