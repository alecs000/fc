using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Машинка
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }



        private void Form1_Load(object sender, EventArgs e)

        {
            int n = 0;
            for (int i = 0; i < 10; i++)
            {
                PictureBox pic10 = new PictureBox
                {
                    ClientSize = new Size(37, 37),
                    BackColor = Color.White,
                    Location = new Point(n, 32),
                    BorderStyle = BorderStyle.FixedSingle,
            };
                n += 37;
                panel1.Controls.Add(pic10);

            }
            int m = 0;
            for (int i = 0; i < 10; i++)
            {
                PictureBox pic11 = new PictureBox
                {
                    ClientSize = new Size(37, 37),
                    BackColor = Color.White,
                    Location = new Point(m, 112),
                    BorderStyle = BorderStyle.FixedSingle,
                };
                m += 37;
                panel2.Controls.Add(pic11);

            }
            Car c = new Car();//создаём обьект машинки
            var car1 = c.CarImg(1);//Вызываем функцию которая возвращает PictureBox с картинкой
            panel1.Controls.Add(car1);//добавляем машинку в форму
            car1.BringToFront();
            c.brand = "Lada";
            c.model = "Vesta";
            c.color = "Black";
            c.speed = 5;
            var prop1 = c.Show(40);
            c.CarDrive(40);
            c.CarDrive(40);
            c.CarDrive(40);
            panel1.Controls.Add(prop1);
            

            Car c123 = new Car();//создаём обьект машинки
            var car2 = c123.CarImg(80);//Вызываем функцию которая возвращает PictureBox с картинкой
            panel2.Controls.Add(car2);//добавляем машинку в форму
            car2.BringToFront();
            c123.brand = "Toyta";
            c123.model = "Rav4";
            c123.color = "White";
            c123.speed = 100;
            var prop2 = c123.Show(120);
            c123.CarDrive(120);
            panel2.Controls.Add(prop2);
        }
    }
        public class Car 
        {
           
            public string brand { get; set; }
            public string model { get; set; }
            public string color { get; set; }
            public int speed { get; set; }
            public Label Show(int b)
            {

                Label Property = new Label();
                Property.Location = new Point(0, b);
                
                Property.Dock = System.Windows.Forms.DockStyle.Fill;
                
                Property.Size = new System.Drawing.Size(20, 50);
                
                Property.Text = $"Марка: {brand} Модель: {model} Цвет: {color} Скорость: {speed}";
                //($"Марка: {brand} Модель: {model} Цвет: {color} Скорость: {speed}");
                return Property;
            }
            
            
            
            PictureBox car = new PictureBox();
            public PictureBox CarImg(int a)
            {
                car.Name = $"a";     
                   car.Location = new Point(0,a+40);
               
                car.SizeMode = PictureBoxSizeMode.StretchImage;
            car.BringToFront();
            ShowMyImage("C:\\Users\\alecs\\Downloads\\simple-travel-car-top_view.png", 35, 20);
            car.BringToFront();
            Form1 F = new Form1();
                return car;

            }
        int x = 38;
        
            public void CarDrive(int nn)
            {

            car.Location = new Point(x, nn);
            x += 37;
           
            }
            private Bitmap MyImage;
            public void ShowMyImage(String fileToDisplay, int xSize, int ySize)
            {
                if (MyImage != null)
                {
                    MyImage.Dispose();
                }

                car.SizeMode = PictureBoxSizeMode.StretchImage;
                MyImage = new Bitmap(fileToDisplay);
                car.ClientSize = new Size(xSize, ySize);
                car.Image = (Image)MyImage;
                
            }
        }


       
    
}
