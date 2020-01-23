using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new Form1());
            // Создаем объект-окно
            Form1 mainForm = new Form1();
            // Cвязываем метод OnIdle с событием Application.Idle
            Application.Idle += new EventHandler(mainForm.OnIdle);
            // Показываем окно и запускаем цикл обработки сообщений
            Application.Run(mainForm);
        }
    }
}
