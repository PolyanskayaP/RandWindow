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
            // ппереводим координату X в строку и записывает в пол€ ввода 
            textBox1.Text = e.X.ToString();
            // переводим координату Y в строку и записывает в пол€ ввода 
            textBox2.Text = e.Y.ToString();

            Random rnd = new Random();
            Point tmp_location;
            int _w = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
            int _h = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;


            // если координата по оси X и по оси Y лежит в очерчиваемом вокруг кнопки "да, конечно" квадрате
            // if (e.X > 191 && e.X < 302 && e.Y > 158 && e.Y < 260) benimki
            //(e.X > 80 && e.X < 195 && e.Y > 100 && e.Y < 135) benim degil
            if (e.X > 185 && e.X < 309 && e.Y > 152 && e.Y < 266)  
            {
                // запоминаем текущее положение окна 
                tmp_location = this.Location;

                // генерируем перемещени€ по ос€м X и Y и прибавл€ем их к хранимому значению текущего положени€ окна 
                // числа генерируютс€ в диапазоне от -100 до 100. 
                tmp_location.X += rnd.Next(-100, 100);
                tmp_location.Y += rnd.Next(-100, 100);

                // если окно вылезло за пределы экрана по одной из осей 
                if (tmp_location.X < 0 || tmp_location.X > (_w - this.Width / 2) || tmp_location.Y < 0 || tmp_location.Y > (_h - this.Height / 2))
                { // новыми координатами станет центр окна 
                    tmp_location.X = _w / 2;
                    tmp_location.Y = _h / 2;
                }

                // обновл€ем положение окна, на новое сгенерированное 
                this.Location = tmp_location;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ¬ывести сообщение с текстом "¬ы усердны" 
            MessageBox.Show("ѕолагаю, что в этот раз вы бросили вашу гордость в огонь.");
            // «авершить приложение 
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ¬ывести сообщение, с текстом "ћы не сомневались в вешем безразличии" 
            // второй параметр - заголовок окна сообщени€ "¬нимание" 
            // MessageBoxButtons.OK - тип размещаемой кнопки на форме сообщени€ 
            // MessageBoxIcon.Information - тип сообщени€ - будет иметь иконку "информаци€" и соответствующий звуковой сигнал 
            MessageBox.Show("“огда вы пришли цыплЄнком", "¬нимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}