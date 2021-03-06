﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Asteroid
{
    static class Game
    {
        private static BufferedGraphicsContext _context;
        public static BufferedGraphics Buffer;
        // Свойства
        // Ширина и высота игрового поля
        public static int Width { get; set; }
        public static int Height { get; set; }
        static Game()
        {
        }
        public static BaseObject[] _objs;
        public static void Load()
        {
            Random rand = new Random();
            _objs = new BaseObject[30];
            for (int i = 0; i < _objs.Length / 2; i++)
                _objs[i] = new Star(new Point(i + rand.Next(1000), i + rand.Next(1000)), new Point(i+rand.Next(10), i+rand.Next(10)), new Size(30-2*i+1, 30-2*i+1));
            for (int i = _objs.Length / 2; i < _objs.Length; i++)
                _objs[i] = new BaseObject(new Point(100, i + rand.Next(1000)), new Point(40-i, 0), new Size(i, i));
        }
        public static void Init(Form form)
        {
            // Графическое устройство для вывода графики
            Graphics g;
            // Предоставляет доступ к главному буферу графического контекста для текущего приложения
            _context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();
            // Создаем объект (поверхность рисования) и связываем его с формой
            // Запоминаем размеры формы
            Width = form.ClientSize.Width;
            Height = form.ClientSize.Height;
            // Связываем буфер в памяти с графическим объектом, чтобы рисовать в буфере
            Buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Height));
            Load();

            Timer timer = new Timer { Interval = 100 };
            timer.Start();
            timer.Tick += Timer_Tick;
        }
        private static void Timer_Tick(object sender, EventArgs e)
        {
            
            Update();
            Draw();
        }
        public static void Draw()
        {
            // Проверяем вывод графики
            /*
                Buffer.Graphics.Clear(Color.Black);
                Buffer.Graphics.DrawRectangle(Pens.White, new Rectangle(100, 100, 200, 200));
                Buffer.Graphics.FillEllipse(Brushes.Wheat, new Rectangle(100, 100, 200, 200));
                Buffer.Render();
            */

            Buffer.Graphics.Clear(Color.Black);
            foreach (BaseObject obj in _objs)
                obj.Draw();
            Buffer.Render();
        }
        public static void Update()
        {
            foreach (BaseObject obj in _objs)
                obj.Update();
        }
    }
}
