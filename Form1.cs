namespace Project
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private Form2 form2;
        private Form3 form3;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


          
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (!checkBox1.ThreeState)
                {
                    checkBox1.ThreeState = true;
                    checkBox1.CheckAlign = ContentAlignment.MiddleRight;
                }
                else
                {
                    checkBox1.ThreeState = false;
                    checkBox1.CheckAlign = ContentAlignment.MiddleLeft;
                }
            }
        }


        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox4.ThreeState)
            {
                checkBox4.ThreeState = true;
                checkBox4.CheckAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                checkBox4.ThreeState = false;
                checkBox4.CheckAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox6.ThreeState)
            {
                checkBox6.ThreeState = true;
                checkBox6.CheckAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                checkBox6.ThreeState = false;
                checkBox6.CheckAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox9.ThreeState)
            {
                checkBox9.ThreeState = true;
                checkBox9.CheckAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                checkBox9.ThreeState = false;
                checkBox9.CheckAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox10.ThreeState)
            {
                checkBox10.ThreeState = true;
                checkBox10.CheckAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                checkBox10.ThreeState = false;
                checkBox10.CheckAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox12.ThreeState)
            {
                checkBox12.ThreeState = true;
                checkBox12.CheckAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                checkBox12.ThreeState = false;
                checkBox12.CheckAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void checkBox12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Започваш категория АМ !");
            }
            if (checkBox1.Checked == true)
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }


             if (checkBox4.Checked == true)
            {
                MessageBox.Show("Започваш категория А !");
            }
            if (checkBox4.Checked == true)
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
                f3.Close();
            }


             if (checkBox6.Checked == true)
            {
                MessageBox.Show("Започваш категория B !");
            }
            if (checkBox6.Checked == true)
            {
                Form4 f4 = new Form4();
                f4.ShowDialog();
                f4.Close();
            }


            if (checkBox9.Checked == true)
            {
                MessageBox.Show("Започваш категория C !");
            }
            if (checkBox9.Checked == true)
            {
                Form5 f5 = new Form5();
                    f5.ShowDialog();
                f5.Close();
            }


            if (checkBox10.Checked == true)
            {
                MessageBox.Show("Започваш категория D !");
            }
            if (checkBox10.Checked == true)
            {
                Form6 f6 = new Form6();
                f6.ShowDialog();
                f6.Close();
            }


            if (checkBox12.Checked == true)
            {
                MessageBox.Show("Започваш категория F !");
            }
            if (checkBox12.Checked == true)
            {
                Form7 f7 = new Form7();
                f7.ShowDialog();
                f7.Close();
            }
        }

        private Form2 CreateForm2()
        {
            throw new NotImplementedException();
        }

        private void buttonThatOpenForm2()
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}