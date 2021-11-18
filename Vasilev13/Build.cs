using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasilev13
{
    public class Build
    {
        private static List<int> staticNumbers = new List<int>();
        private int number;
        private double height;
        private int levelsCount;
        private int apartmentsCount;
        private int entryCount;

        public Build()
        {
            NumberGenerate();
            number = staticNumbers[staticNumbers.Count - 1];

        }

        private static void NumberGenerate() //Генерируем программно номер здания
        {
            Random rnd = new Random();
            int staticNumber = rnd.Next(0, 999);
            if (staticNumbers.Contains(staticNumber))
                NumberGenerate();
            else
                staticNumbers.Add(staticNumber);
        }
        public void setHeight(double height)
        {
            if (height > 0)
                this.height = Math.Round(height, 3);
        }

        public void setLevelsCount(int Count)
        {
            if (Count > 0)
                levelsCount = Count;
        }

        public void setApartmentsCount(int Count)
        {
            if (Count > 0)
                apartmentsCount = Count;
        }

        public void setEntryCount(int Count)
        {
            if (Count > 0)
                entryCount = Count;
        }

        public int GetNumber() { return number; }
        public double GetHeight() { return height; }
        public int GetLevelsCount() { return levelsCount; }
        public int GetApartmentsCount() { return apartmentsCount; }
        public int GetEntryCount() { return entryCount; }

        public double CalcLevelsHeight()
        {
            if (levelsCount > 0 && height > 0)
                return Math.Round(height / levelsCount, 4);
            else
                return -1;
        }

        public double CalcApartmentsInLevel()
        {
            if (levelsCount > 0 && apartmentsCount > 0)
                return Math.Round((double)apartmentsCount / levelsCount, 2);
            else
                return -1;
        }

        public double CalcApartmensInEntry()
        {
            if (apartmentsCount > 0 && entryCount > 0) return Math.Round((double)apartmentsCount / entryCount, 2);
            else return -1;
        }
    }
}
