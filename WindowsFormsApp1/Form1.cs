using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Device d3d; Control c;
        Mesh[] koleco, verevka;
        Mesh gruz, kreplenie;
        Material[] mat;
        double t = 0; bool Tfl = true;
        public static float[] rad;
        public static double omega = 40;
        float R = 20.0f;
        CheckBox[] checkBox;
        List<CustomVertex.PositionColored>[] myList = null;

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            koleco = new Mesh[3];
            verevka = new Mesh[3];
            rad = new float[3];
            mat = new Material[5];

            checkBox = new CheckBox[4];
            checkBox[0] = checkBox1;
            checkBox[1] = checkBox2;
            checkBox[2] = checkBox3;
            checkBox[3] = checkBox4;

            myList = new List<CustomVertex.PositionColored>[4];
            for (int i = 0; i < 4; i++)
                myList[i] = new List<CustomVertex.PositionColored>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            c = new Control(this, "", 200,0, this.Width - 217,this.Height-17);
            try
            {
                // Устанавливаем режим отображения трехмерной графики
                PresentParameters d3dpp = new PresentParameters();
                d3dpp.BackBufferCount = 1;
                d3dpp.SwapEffect = SwapEffect.Discard;
                d3dpp.Windowed = true; // Выводим графику в окно
                d3dpp.MultiSample = MultiSampleType.None; // Выключаем антиалиасинг
                d3dpp.EnableAutoDepthStencil = true; // Разрешаем создание z-буфера
                d3dpp.AutoDepthStencilFormat = DepthFormat.D16; // Z-буфер в 16 бит
                d3d = new Device(0, // D3D_ADAPTER_DEFAULT - видеоадаптер по 
                                    // умолчанию
                      DeviceType.Hardware, // Тип устройства - аппаратный ускоритель
                      c, // Окно для вывода графики
                      CreateFlags.SoftwareVertexProcessing, // Геометрию обрабатывает CPU
                      d3dpp);

            }
            catch (Exception exc)
            {
                MessageBox.Show(this, exc.Message, "Ошибка инициализации");
                Close(); // Закрываем окно
            }
            for(int i = 0; i< 5; i++){            
                mat[i] = new Material();
                mat[i].Specular = Color.White;
            }
            mat[0].Diffuse = Color.Firebrick;
            mat[1].Diffuse = Color.Blue;
            mat[2].Diffuse = Color.Green;
            mat[3].Diffuse = Color.Coral;
            mat[4].Diffuse = Color.Black;

            //первое колесо
            rad[0] = 3.0f;
            koleco[0] = Mesh.Cylinder(d3d, rad[0], rad[0], 0.6f, 40, 5);
            //второе колесо
            rad[1] = 1.5f;
            koleco[1] = Mesh.Cylinder(d3d, rad[1], rad[1], 0.6f, 20, 5);
            //Третье колесо
            rad[2] = 1.0f;
            koleco[2] = Mesh.Cylinder(d3d, rad[2], rad[2], 0.6f, 20, 5);
            //Грузик
            gruz = Mesh.Cylinder(d3d, 0.3f, 0.3f, 1.5f, 15, 15);
            //веревка1
            float dlina = 5f;
            verevka[0] = Mesh.Cylinder(d3d, 0.02f, 0.02f, dlina, 10, 10);
            //веревка2
            dlina = 5f;
            verevka[1] = Mesh.Cylinder(d3d, 0.02f, 0.02f, dlina, 10, 10);
            //крепление
            kreplenie = Mesh.Box(d3d, 1f, 0.5f,0.5f);

            foreach (Control p in Controls)
                p.Refresh();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (radioButton21.Checked) t += Tfl ? 0.01 : -0.01; ;
            if (radioButton12.Checked) t = 0;
            if (radioButton11.Checked)
            {
                radioButton21.Enabled = true;
                radioButton22.Enabled = true;
            }
            if (radioButton12.Checked)
            {
                radioButton21.Enabled = false;
                radioButton22.Enabled = false;
                radioButton21.Checked = false;
                radioButton22.Checked = true;
                for(int i = 0; i < 4; i++)
                    myList[i].Clear();
            }
            PictureDvig();
        }
        public void OnIdle(object sender, EventArgs e)
        {
            Invalidate(); // Помечаем главное окно (this) как требующее перерисовки
        }
        private void SetupCamera()
        {
            d3d.Lights[0].Enabled = true;   // Включаем нулевой источник освещения
            d3d.Lights[0].Diffuse = Color.White;         // Цвет источника освещения
            d3d.Lights[0].Position = new Vector3(0, 0, 0); // Задаем координаты
            d3d.Lights[1].Enabled = true;   // Включаем нулевой источник освещения
            d3d.Lights[1].Diffuse = Color.White;         // Цвет источника освещения
            d3d.Lights[1].Position = new Vector3(-5, -5, 0.0f); //new Vector3(-15,0,0);
            d3d.Lights[1].Direction = new Vector3(3, 0, 0);
            //d3d.Lights[2].Enabled = true;   // Включаем нулевой источник освещения
            //d3d.Lights[2].Diffuse = Color.White;         // Цвет источника освещения
            //d3d.Lights[2].Position = new Vector3(-5, -5, 5.0f); //new Vector3(-15,0,0);
            //d3d.Lights[2].Direction = new Vector3(0, 0, -1);
            float X = R * (float)Math.Sin(Math.PI / 180 * vScrollBar1.Value) * (float)Math.Cos(Math.PI / 180 * hScrollBar1.Value);
            float Z = R * (float)Math.Sin(Math.PI / 180 * vScrollBar1.Value) * (float)Math.Sin(Math.PI / 180 * hScrollBar1.Value);
            float Y = R * (float)Math.Cos(Math.PI / 180 * vScrollBar1.Value);// * (float)Math.Cos(Math.PI / 180 * hScrollBar1.Value);
            d3d.Transform.View = Matrix.LookAtLH(new Vector3(-X, Y, -Z), new Vector3(0,-3,0), new Vector3(0, 1, 0));
            d3d.Transform.Projection = Matrix.PerspectiveFovLH((float)Math.PI / 4, this.Width / this.Height, 1.0f, 100.0f);
        }
        private void PictureDvig()
        {
            d3d.RenderState.Lighting = true;
            float f2 = (float)(Math.PI / 180 * rad[0] * t * omega / rad[2]);
            // Очищаем буфер глубины и дублирующий буфер
            d3d.Clear(ClearFlags.Target | ClearFlags.ZBuffer, Color.Wheat, 1.0f, 0);
            if (radioButton12.Checked)
            {
                d3d.Present();
                return;
            }
            SetupCamera();
            d3d.BeginScene();

            //первое колесо
            d3d.Material = mat[0];
            d3d.Transform.World = Matrix.RotationZ((float)(Math.PI/180 * t * omega));
            koleco[0].DrawSubset(0);

            //второе колесо
            d3d.Material = mat[1];
            d3d.Transform.World = Matrix.RotationZ((float)(Math.PI / 180 * t * omega)) 
                                * Matrix.Translation(0.0f, 0.0f, -0.60f);
            koleco[1].DrawSubset(0);

            //Третье колесо
            d3d.Material = mat[2];
            d3d.Transform.World = Matrix.RotationZ(-f2) 
                * Matrix.Translation(rad[0] + rad[2], -5.0f + (float)(Math.PI / 180 * t * omega * rad[0]), 0.0f);
            koleco[2].DrawSubset(0);

            //Грузик
            d3d.Material = mat[3];
            d3d.Transform.World = Matrix.RotationX((float)Math.PI / 2) 
                * Matrix.Translation(-rad[1], -5.0f - (float)(Math.PI / 180 * t * omega * rad[1]), -0.6f);
            gruz.DrawSubset(0);
            if (5.0f + (float)(Math.PI / 180 * t * omega * rad[1]) < rad[0] 
                || 5.0f + (float)(Math.PI / 180 * t * omega * rad[1]) < rad[1]) { Tfl = true; }

            try{
            //веревка1
            d3d.Material = mat[4];
            verevka[0] = Mesh.Cylinder(d3d, 0.02f, 0.02f, 5.0f + (float)(Math.PI / 180 * t * omega * rad[1]), 10, 10);
            d3d.Transform.World = Matrix.RotationX((float)Math.PI / 2) 
                    * Matrix.Translation(-rad[1], -2.5f-(float)(Math.PI / 180 * t * omega * rad[1]/2), -0.6f);
            verevka[0].DrawSubset(0);

            //веревка2
            
            verevka[1] = Mesh.Cylinder(d3d, 0.02f, 0.02f, 5.0f - (float)(Math.PI / 180 * t * omega * rad[0]), 10, 10);
            d3d.Transform.World = Matrix.RotationX((float)Math.PI / 2) 
                * Matrix.Translation(rad[0], -2.5f + (float)(Math.PI / 180 * t * omega * rad[0] / 2), 0);
            verevka[1].DrawSubset(0);}
            catch (Exception e) { Tfl = !Tfl; }

            //веревка3
            verevka[2] = Mesh.Cylinder(d3d, 0.02f, 0.02f, 8.0f - (float)(Math.PI / 180 * t * omega * rad[0]), 10, 10);
            d3d.Transform.World = Matrix.RotationX((float)Math.PI / 2) 
                * Matrix.Translation(rad[0]+ 2*rad[2], -1f + (float)(Math.PI / 180 * t * omega * rad[0] / 2), 0);
            verevka[2].DrawSubset(0);

            //Крепление
            d3d.Transform.World = Matrix.Translation(rad[0] + 2 * rad[2], 3f, 0);
            kreplenie.DrawSubset(0);

            //Материал
            d3d.Material = mat[0];
            if (radioButton31.Checked == true) d3d.RenderState.FillMode = FillMode.Solid;
            else d3d.RenderState.FillMode = FillMode.WireFrame;

            //Траектория
            Traek();
            for (int i = 0; i < 4; i++)
            {
                if (myList[i].Count > 2 && checkBox[i].Checked)
                {
                    d3d.RenderState.Lighting = false;
                    d3d.VertexFormat = CustomVertex.PositionColored.Format;
                    d3d.Transform.World =  Matrix.Translation(0, 0, 0);
                    d3d.DrawUserPrimitives(PrimitiveType.LineStrip, myList[i].Count - 1, myList[i].ToArray());
                }
            }
            d3d.EndScene();
            //Показываем содержимое дублирующего буфера
            d3d.Present();
            Invalidate();
        }
        private void Geometry_Click(object sender, EventArgs e)
        {
            radioButton22.Checked = true;
            Form2 MyF2 = new Form2();
            Point Pos = new Point(this.Location.X + 100, this.Location.Y + 100);
            MyF2.StartPosition = FormStartPosition.Manual;
            MyF2.Location = new Point(Pos.X, Pos.Y);

            if (MyF2.ShowDialog() == DialogResult.OK)
            {
                //первое колесо
                koleco[0] = Mesh.Cylinder(d3d, rad[0], rad[0], 0.6f, 20, 5);
                //второе колесо
                koleco[1] = Mesh.Cylinder(d3d, rad[1], rad[1], 0.6f, 20, 5);
                //Третье колесо
                koleco[2] = Mesh.Cylinder(d3d, rad[2], rad[2], 0.6f, 20, 5);
                for (int i = 0; i < 4; i++)
                    myList[i].Clear();
                t = 0;
            }
            radioButton21.Checked = true;

        }
        private void Kinematic_Click(object sender, EventArgs e)
        {
            radioButton22.Checked = true;
            Form3 MyF3 = new Form3();
            Point Pos = new Point(this.Location.X + 100, this.Location.Y + 100);
            MyF3.StartPosition = FormStartPosition.Manual;
            MyF3.Location = new Point(Pos.X, Pos.Y);
            if (MyF3.ShowDialog() == DialogResult.OK)
            {
                if (omega == 0)
                    MessageBox.Show("Вы задали угловую скорость равной 0");
                t = 0;
            }
            radioButton21.Checked = true;
        }
        private void MouseWheel1(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
                R += 2f;
            else if(R > 10) R -= 2f;
        }
        private void Traek()
        {
            //вращение второго колеса
            Vector2 O2 = new Vector2(rad[0] + rad[2], (float)(-5.0f + (Math.PI / 180 * t * omega * rad[0])));
            double f2 = -Math.PI / 180 * rad[0] * t * omega / rad[2];
            Vector2[] T = new Vector2[4];
            T[0] = new Vector2((float)(O2.X + rad[2] * Math.Sin(f2)), (float)(O2.Y - rad[2] * Math.Cos(f2)));
            T[1] = new Vector2((float)(O2.X - rad[2] * Math.Sin(f2)), (float)(O2.Y + rad[2] * Math.Cos(f2)));
            T[2] = new Vector2((float)(O2.X - rad[2] * Math.Cos(f2)), (float)(O2.Y - rad[2] * Math.Sin(f2)));
            T[3] = new Vector2((float)(O2.X + rad[2] * Math.Cos(f2)), (float)(O2.Y + rad[2] * Math.Sin(f2)));
            Color[] r = new Color[4] { Color.Red, Color.Blue, Color.Green, Color.Gold };
            CustomVertex.PositionColored one = new CustomVertex.PositionColored();
            for (int i = 0; i < 4; i++)
            {
                one.Position = new Vector3(T[i].X, T[i].Y, 0.0f);
                one.Color = r[i].ToArgb();
                myList[i].Add(one);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}