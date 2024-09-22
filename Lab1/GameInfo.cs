namespace Lab1
{
    public class GameInfo
    {
        public delegate void GameInfoHandler();
        public event GameInfoHandler? OnWishedNumberChanged;
        public event GameInfoHandler? OnMinMaxChanged;

        private List<int> _usedNumbers = new();

        public int WishedNumber { get; private set; }
        public int MinNumber {  get; private set; }
        public int MaxNumber { get; private set; }

        public GameInfo(int wishedNumber = 0, int minNumber = 1, int maxNumber = 100)
        {
            WishedNumber = wishedNumber;
            MinNumber = minNumber;
            MaxNumber = maxNumber;

            _usedNumbers.Add(wishedNumber);
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
            if (num < MaxNumber)
            {
                MinNumber = num;
                OnMinMaxChanged?.Invoke();
            }
            else
                ShowMinMaxSetError("Минимальное значение не может быть больше максимального!");
        }
        public void SetMaxNumber(int num)
        {
            if (num > MinNumber)
            {
                MaxNumber = num;
                OnMinMaxChanged?.Invoke();
            }
            else
                ShowMinMaxSetError("Максимальное значение не может быть меньше минимального!");
        }

        private void ShowMinMaxSetError(string message)
        {
            MessageBox.Show(message, "Произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Select a uniqe random number between a MinNumber and MaxNumber value
        /// </summary>
        public void RandomizeWishedNumber()
        {
            Random random = new();

            int randomizedNumber;
            bool isUnique;

            while (true)
            {
                isUnique = true;
                randomizedNumber = random.Next(MinNumber, MaxNumber + 1);

                foreach (int num in _usedNumbers)
                {
                    if (randomizedNumber == num)
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                    break;
            }

            WishedNumber = randomizedNumber;

            _usedNumbers.Add(WishedNumber);
            OnWishedNumberChanged?.Invoke();
        }
    }
}