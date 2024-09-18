using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Wish
    {
        public delegate void WishNumbersHandler();
        public event WishNumbersHandler? OnWishedNumberChanged;
        public event WishNumbersHandler? OnMinMaxChanged;

        private List<int> _usedNumbers = new();

        public int WishedNumber { get; private set; }
        public int MinNumber {  get; private set; }
        public int MaxNumber { get; private set; }

        public Wish(int wishedNumber = 0, int minNumber = 1, int maxNumber = 100)
        {
            WishedNumber = wishedNumber;
            MinNumber = minNumber;
            MaxNumber = maxNumber;
        }

        public bool SetWishedNumber(int num)
        {
            if (num >= MinNumber && num <= MaxNumber)
            {
                WishedNumber = num;
                OnWishedNumberChanged?.Invoke();
                return true;
            }
            else
            {
                MessageBox.Show("Загаданное вами число находится вне допустимого диапазона. Попробуйте еще раз.",
                    "Произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }  
        }

        public void SetMinNumber(int num)
        {
            MinNumber = num;
            OnMinMaxChanged?.Invoke();
        }
        public void SetMaxNumber(int num)
        {
            MaxNumber = num;
            OnMinMaxChanged?.Invoke();
        }

        /// <summary>
        /// Select a random number between a MinNumber and MaxNumber value 
        /// </summary>
        public void RandomizeWishedNumber()
        {
            Random random = new();
            int randomizedNumber = WishedNumber;

            while (randomizedNumber == WishedNumber)
            {
                randomizedNumber = random.Next(MinNumber, MaxNumber + 1);
            }

            WishedNumber = randomizedNumber;

            _usedNumbers.Add(WishedNumber);
            OnWishedNumberChanged?.Invoke();
        }
    }
}