namespace RandWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // ���������� ���������� X � ������ � ���������� � ���� ����� 
            textBox1.Text = e.X.ToString();
            // ��������� ���������� Y � ������ � ���������� � ���� ����� 
            textBox2.Text = e.Y.ToString();

            Random rnd = new Random();
            Point tmp_location;
            int _w = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
            int _h = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;


            // ���� ���������� �� ��� X � �� ��� Y ����� � ������������ ������ ������ "��, �������" ��������
            // if (e.X > 191 && e.X < 302 && e.Y > 158 && e.Y < 260) benimki
            //(e.X > 80 && e.X < 195 && e.Y > 100 && e.Y < 135) benim degil
            if (e.X > 185 && e.X < 309 && e.Y > 152 && e.Y < 266)  
            {
                // ���������� ������� ��������� ���� 
                tmp_location = this.Location;

                // ���������� ����������� �� ���� X � Y � ���������� �� � ��������� �������� �������� ��������� ���� 
                // ����� ������������ � ��������� �� -100 �� 100. 
                tmp_location.X += rnd.Next(-100, 100);
                tmp_location.Y += rnd.Next(-100, 100);

                // ���� ���� ������� �� ������� ������ �� ����� �� ���� 
                if (tmp_location.X < 0 || tmp_location.X > (_w - this.Width / 2) || tmp_location.Y < 0 || tmp_location.Y > (_h - this.Height / 2))
                { // ������ ������������ ������ ����� ���� 
                    tmp_location.X = _w / 2;
                    tmp_location.Y = _h / 2;
                }

                // ��������� ��������� ����, �� ����� ��������������� 
                this.Location = tmp_location;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ������� ��������� � ������� "�� �������" 
            MessageBox.Show("�������, ��� � ���� ��� �� ������� ���� �������� � �����.");
            // ��������� ���������� 
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ������� ���������, � ������� "�� �� ����������� � ����� �����������" 
            // ������ �������� - ��������� ���� ��������� "��������" 
            // MessageBoxButtons.OK - ��� ����������� ������ �� ����� ��������� 
            // MessageBoxIcon.Information - ��� ��������� - ����� ����� ������ "����������" � ��������������� �������� ������ 
            MessageBox.Show("����� �� ������ ��������", "��������", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}