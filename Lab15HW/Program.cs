using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15HW
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    interface ISeries
    {

        void setStart(int x); //задать начальное значение
        int getNext();// возвратить следующее по порядку число
        void reset();// перезапустить


    }
    class ArithProgression : ISeries
    {
        int start;
        int val;
        int n;

        public ArithProgression()
        {
            start = 0;
            val = 0;
            n = 2;
        }
        public int getNext()
        {
            val += n;
            return val;
        }
        public void reset()
        {
            val = start; 
        }
        public void setStart(int x)
        {
            start = x;
            val = start;
        }
    }
    class GeomProgression : ISeries
    {
        int start;
        int val;
        int n;

        public GeomProgression()
        {
            start = 1;
            val = 1;
            n = 2;
        }
        public int getNext()
        {
            val = val*n;
            return val;
        }
        public void reset()
        {
            val = start;
        }
        public void setStart(int x)
        {
            start = x;
            val = start;
        }
    }
}



//Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:

//метод void setStart(int x) -устанавливает начальное значение
//метод int getNext() -возвращает следующее число ряда
//метод void reset() -выполняет сброс к начальному значению
//Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries. В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.

