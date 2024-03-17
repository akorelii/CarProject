namespace CarProject
{
    public partial class form1 : Form
    {
        bool isGasOpen = false;
        public form1()
        {
            InitializeComponent();
        }

        private void gas_MouseEnter(object sender, EventArgs e)
        {
            isGasOpen = true;
        }

        private void brake_MouseEnter(object sender, EventArgs e)
        {
            isGasOpen = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isGasOpen)
            {
                car.Location = new Point(car.Location.X, car.Location.Y - 3);
            }
        }
    }
}
