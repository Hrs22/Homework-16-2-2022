namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox11.ThreeState)
            {
                checkBox11.ThreeState = true;
                checkBox11.CheckAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                checkBox11.ThreeState = false;
                checkBox11.CheckAlign = ContentAlignment.MiddleLeft;
            }
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.ThreeState)
            {
                checkBox2.ThreeState = true;
                checkBox2.CheckAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                checkBox2.ThreeState = false;
                checkBox2.CheckAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox3.ThreeState)
            {
                checkBox3.ThreeState = true;
                checkBox3.CheckAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                checkBox3.ThreeState = false;
                checkBox3.CheckAlign = ContentAlignment.MiddleLeft;
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

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox5.ThreeState)
            {
                checkBox5.ThreeState = true;
                checkBox5.CheckAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                checkBox5.ThreeState = false;
                checkBox5.CheckAlign = ContentAlignment.MiddleLeft;
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

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox7.ThreeState)
            {
                checkBox7.ThreeState = true;
                checkBox7.CheckAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                checkBox7.ThreeState = false;
                checkBox7.CheckAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox8.ThreeState)
            {
                checkBox8.ThreeState = true;
                checkBox8.CheckAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                checkBox8.ThreeState = false;
                checkBox8.CheckAlign = ContentAlignment.MiddleLeft;
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
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false &&
               checkBox6.Checked == false && checkBox7.Checked == false && checkBox8.Checked == false && checkBox9.Checked == false && checkBox10.Checked == false &&
               checkBox11.Checked == false && checkBox12.Checked == false)
            {
                MessageBox.Show("Избери категория !");
            }
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Започваш категория АМ !");
            }
            else if (checkBox2.Checked == true)
            {
                MessageBox.Show("Започваш категория А1 !");
            }
            else if (checkBox3.Checked == true)
            {
                MessageBox.Show("Започваш категория А2 !");
            }
            else if (checkBox4.Checked == true)
            {
                MessageBox.Show("Започваш категория А !");
            }
            else if (checkBox5.Checked == true)
            {
                MessageBox.Show("Започваш категория B1 !");
            }
            else if (checkBox6.Checked == true)
            {
                MessageBox.Show("Започваш категория B !");
            }
            else if (checkBox7.Checked == true)
            {
                MessageBox.Show("Започваш категория BE !");
            }
            else if (checkBox8.Checked == true)
            {
                MessageBox.Show("Започваш категория C1 !");
            }
            else if (checkBox9.Checked == true)
            {
                MessageBox.Show("Започваш категория C !");
            }
            else if (checkBox10.Checked == true)
            {
                MessageBox.Show("Започваш категория D !");
            }
            else if (checkBox11.Checked == true)
            {
                MessageBox.Show("Започваш категория DE !");
            }
            else if (checkBox12.Checked == true)
            {
                MessageBox.Show("Започваш категория T !");
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}