using System;

namespace Indexers {

    public enum ELangCode {
        UK,
        EN,
        CZ
    }

    class Dictionary {
        private string[] ukWords = new string[5];
        private string[] enWords = new string[5];
        private string[] czWords = new string[5];

        public Dictionary() {
            ukWords[0] = "книга"; /*        */ enWords[0] = "book"; /*          */ czWords[0] = "rezervovat";
            ukWords[1] = "ручка"; /*        */ enWords[1] = "pen"; /*           */ czWords[1] = "pero";
            ukWords[2] = "сонце"; /*        */ enWords[2] = "sun"; /*           */ czWords[2] = "slunce";
            ukWords[3] = "яблуко"; /*       */ enWords[3] = "apple"; /*         */ czWords[3] = "jablko";
            ukWords[4] = "стіл"; /*         */ enWords[4] = "table"; /*         */ czWords[4] = "stůl";
        }

        public int Length {
            get { return ukWords.Length; }
        }

        private int SearchItemIndex(ELangCode lang, string word) {
            string[] wordsCollectionToSearch;
            switch (lang) {
                case ELangCode.CZ:
                    wordsCollectionToSearch = czWords;
                    break;
                case ELangCode.UK:
                    wordsCollectionToSearch = ukWords;
                    break;
                case ELangCode.EN:
                    wordsCollectionToSearch = enWords;
                    break;

                default:
                    throw new Exception("Unexpected lang code");
            }

            for (int i = 0; i < wordsCollectionToSearch.Length; i++)
                if (wordsCollectionToSearch[i] == word)
                    return i;

            return -1;
        }

        public string this[ELangCode lang, string wordToSearch] {
            get {
                //for (int i = 0; i < ukWords.Length; i++)
                //    if (ukWords[i] == wordToSearch)
                //        return ukWords[i] + " - " + enWords[i];

                int idx = SearchItemIndex(lang, wordToSearch);
                if (idx == -1) {
                    return $"немає перекладу для слова {wordToSearch} на мові {lang}.";
                } else {
                    return $"{ukWords[idx]} - {enWords[idx]} - {czWords[idx]}";
                }
            }
        }

        public string this[int index] {
            get {
                if (index >= 0 && index < ukWords.Length)
                    return ukWords[index] + " - " + enWords[index] + " - " + czWords[index];
                else
                    return "Спроба звернення за межі масиву.";
            }
        }

    }
}