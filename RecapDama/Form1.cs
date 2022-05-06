namespace RecapDama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8,8];
            int left = 0;
            int top = 0;
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i,j] = new Button();
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    this.Controls.Add(buttons[i,j]);
                    left += 50;
                    if ((i+j) % 2 == 0)
                    {
                        buttons[i,j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                }
                left = 0;
                top += 50;
            }
        }
    }
}