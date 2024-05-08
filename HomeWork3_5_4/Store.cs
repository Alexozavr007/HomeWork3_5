namespace HomeWork3_5_4
{
    internal class Store
    {
        private Article[] _articles;

        public Store() { 
            _articles = new Article[5];
            _articles[0] = new Article("Витерачка", "Гранд", 12);
            _articles[1] = new Article("Зошит", "Гранд", 52);
            _articles[2] = new Article("Олівець", "Гранд", 42);
            _articles[3] = new Article("Циркуль", "Гранд", 22);
            _articles[4] = new Article("Ручка", "Гранд", 14);
        }

        public Article this[int index]
        {
            get
            {
                return _articles[index];
            }
        }

        public void SearchAndDisplayInfo(string articleName)
        {
            bool articleFound = false;
            for (int i=0; i< _articles.Length; i++)
            {
                if (_articles[i].IsEqual(articleName))
                {
                    _articles[i].DisplayInfo();
                    articleFound = true;
                    break;
                }
            }

            if (!articleFound)
            {
                Console.WriteLine("Товар не знайдено");
            }
        }

    }
}