using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Fridge fr = new Fridge(false, FridgeMode.Norm, 5);
            while (true)
            {
                Console.Clear();
                Console.WriteLine(fr.Info() + "\n");
                Console.WriteLine("Нажмите клавишу для выполнения действия:");
                Console.WriteLine("1 - Включить холодильник");
                Console.WriteLine("2 - Выключить холодильник");
                Console.WriteLine("3 - Установить оптимальный режим");
                Console.WriteLine("4 - Установить режим отпуск");
                Console.WriteLine("5 - Установить супер заморозку");
                Console.WriteLine("6 - Ручной режим -ув. температуру MAX 9 градусов");
                Console.WriteLine("7 - Ручной режим - ум. температуру MIN 1 градус");
                Console.WriteLine("e - Выйти");


                char key = Console.ReadKey().KeyChar;
                switch (key)
                {
                    case '1':
                        fr.On();
                        break;
                    case '2':
                        fr.Off();
                        break;
                    case '3':
                        fr.SetNormMode();
                        break;
                    case '4':
                        fr.SetVacationMode();
                        break;
                    case '5':
                        fr.SetSuperFrozeMode();
                        break;
                    case '6':
                        fr.UpTemp();
                        break;
                    case '7':
                        fr.DownTemp();
                        break;
                    case 'e':
                        return;
                }
            }
        }
    }
}

