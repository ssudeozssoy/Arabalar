namespace WinFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string[] arabalar = { "BMW", "Mercedes", "Audi", "Toyota", "Honda" };
            //listBox1.Items.AddRange(arabalar);

            //List<string> arabalar = new List<string> { "BMW", "Mercedes", "Audi", "Toyota", "Honda" };
            //listBox1.DataSource = arabalar;
            listBox1.Items.AddRange(new string[] { "BMW", "Mercedes" });
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            if (listBox1.SelectedItem?.ToString() == "BMW")
            {
                listBox2.Items.Add("BMW 3 Serisi");
                listBox2.Items.Add("BMW 5 Serisi");
                listBox2.Items.Add("BMW 7 Serisi");
            }
            else if (listBox1.SelectedItem?.ToString() == "Mercedes")
            {
                listBox2.Items.Add("Mercedes A Serisi");
                listBox2.Items.Add("Mercedes C Serisi");
                listBox2.Items.Add("Mercedes E Serisi");
            }

        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

            if (listBox2.SelectedItem?.ToString() == "BMW 3 Serisi")
            {
                listBox3.Items.AddRange(new string[] { "BMW 3 Serisi Sedan", "BMW 3 Serisi Touring" });
            }
            else if (listBox2.SelectedItem?.ToString() == "BMW 5 Serisi")
            {
                listBox3.Items.AddRange(new string[] { "M Sport", "Luxury Line" }); // Örnek paketler
            }
            else if (listBox2.SelectedItem?.ToString() == "BMW 7 Serisi")
            {
                listBox3.Items.AddRange(new string[] { "Pure Excellence", "M Excellence" }); // Örnek paketler
            }
            else if (listBox2.SelectedItem?.ToString() == "Mercedes A Serisi")
            {
                listBox3.Items.AddRange(new string[] { "Mercedes A Serisi Sedan", "Mercedes A Serisi Hatchback" });
            }
            else if (listBox2.SelectedItem?.ToString() == "Mercedes C Serisi")
            {
                listBox3.Items.AddRange(new string[] { "AMG", "Avantgarde" });
            }
            else if (listBox2.SelectedItem?.ToString() == "Mercedes E Serisi")
            {
                listBox3.Items.AddRange(new string[] { "Exclusive", "AMG" });
            }
        }
    }
    
}
