namespace fukuv0615
{
    public partial class Form1 : Form
    {

        static Random rand = new Random();
        int ans = rand.Next(100);
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            count++;
            int guess = int.Parse(textBox1.Text);
            if (guess==ans)
            {
                MessageBox.Show("Bingo!");
                count = 0;
                ans = rand.Next(100);   
            }
            else if(guess < ans)
                MessageBox.Show("Less");
            else
                MessageBox.Show("Greater");
        }
    }
}