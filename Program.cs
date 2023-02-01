using System;
using System.Collections.Generic;


namespace ConsoleDiary
{

    // Хранит массив дней
    class Diary
    {
        public class Day// Хранит массив заметок
        {
            public class Note// Хранит в себе информацию о конкретной заметке
            {
                public string name;
                public string description;
                public DateTime date;
                public Note(string name, string description, DateTime date)// Конструктор класса
                {
                    this.name = name;
                    this.description = description;
                    this.date = date;
                }
            }

            public DateTime date;
            public List<Note> notes = new List<Note>();// Массив для хранения заметок внутри одного дня

            public Day(DateTime date)// Конструктор для создания дня
            {
                this.date = date;
            }
        }
        public List<Day> days = new List<Day>();// Массив для хранения дней внутри ежедневника

        public void addNote(int dayIndex, Day.Note note)// Метод для добавления новой заметки в определенный день. День определяется по индексу
        {
            days[dayIndex].notes.Add(note);
        }
    }

    class userInterface// Класс для отрисовки интерфейса
    {

        int arrowPos = 0;// Позиция стрелки в текущий момент
        Diary diary;// Хранит ежедневник, который будет отрисовываться
        int dayIndex = 0;// Отслеживает какой день отрисовывать
        private void ShowDay(Diary.Day day)// Метод для отрисовки дня
        {
            Console.Clear();// Очищаем консоль
            Console.WriteLine("День: {0}", day.date.ToShortDateString());
            for (int j = 0; j < day.notes.Count; j++)// Цикл по всем доступным заметкам этого дня
            {
                if (arrowPos == j)// Если позиция стрелки находится напротив этой заметки - её отрисовываем
                {
                    Console.WriteLine("->" + day.notes[j].name);
                }
                else// Если нет-оставляем место пустым
                {
                    Console.WriteLine("  " + day.notes[j].name);
                }
            }
            //Console.WriteLine(arrowPos);
        }

        private void ShowNote(Diary.Day.Note note)
        {
            Console.Clear();
            Console.WriteLine("День: {0}", note.date.ToShortDateString());
            Console.WriteLine("Название: " + note.name);
            Console.WriteLine("Описание: " + note.description);

        }

        private void arrowInc()
        {
            if (arrowPos + 1 < diary.days[dayIndex].notes.Count)
                arrowPos++;
            else
                arrowPos = 0;
        }// Инкремент для позиции стрелки, благодаря ему она не выйдет за границы диапазона. Далее аналогично

        private void arrowDec()
        {
            if (arrowPos - 1 >= 0)
                arrowPos--;
            else
                arrowPos = diary.days[dayIndex].notes.Count - 1;
        }

        private void dayIndexInc()
        {
            if (dayIndex + 1 < diary.days.Count)
                dayIndex++;
            else
                dayIndex = 0;
        }

        private void dayIndexDec()
        {
            if (dayIndex - 1 >= 0)
                dayIndex--;
            else
                dayIndex = diary.days.Count - 1;
        }


        public void Work()// Главный метод, который запускает работу приложения
        {
            ShowDay(diary.days[dayIndex]);// Первая отрисовка дня
            while (true)
            {

                ConsoleKeyInfo keyPushed = Console.ReadKey();// Считываем какую кнопку пользователь нажал
                switch (keyPushed.Key)// В зависимости от нажатой кнопки выполняются разные наборы функций
                {
                    case ConsoleKey.DownArrow:
                        arrowInc();
                        ShowDay(diary.days[dayIndex]);
                        break;
                    case ConsoleKey.UpArrow:
                        arrowDec();
                        ShowDay(diary.days[dayIndex]);
                        break;

                    case ConsoleKey.RightArrow:
                        dayIndexInc();
                        ShowDay(diary.days[dayIndex]);
                        break;

                    case ConsoleKey.LeftArrow:
                        dayIndexDec();
                        ShowDay(diary.days[dayIndex]);
                        break;
                    case ConsoleKey.Enter:
                        ShowNote(diary.days[dayIndex].notes[arrowPos]);
                        break;
                    case ConsoleKey.Escape:
                        ShowDay(diary.days[dayIndex]);
                        arrowPos = 0;
                        break;

                    default:
                        break;
                }
            }
        }
        public userInterface(Diary diary)
        {
            this.diary = diary;
        }
    }

    internal class Program
    {

        static void Init(Diary diary)// Инициализация ежедневника 3мя днями и 7ю заметками
        {
            DateTime date1 = DateTime.Now;
            diary.days.Add(new Diary.Day(date1));
            diary.addNote(0, new Diary.Day.Note("Пойти в гараж", "Не забыть инструменты", date1));
            diary.addNote(0, new Diary.Day.Note("Пойти за удочками", "Не забыть деньги", date1));

            DateTime date2 = DateTime.Now.AddDays(5);
            diary.days.Add(new Diary.Day(date2));
            diary.addNote(1, new Diary.Day.Note("Выкинуть мусор", "Кошка - не мусор", date2));
            diary.addNote(1, new Diary.Day.Note("Построить дом", "В конце порадовать себя шоколадкой", date2));

            DateTime date3 = DateTime.Now.AddDays(10);
            diary.days.Add(new Diary.Day(date3));
            diary.addNote(2, new Diary.Day.Note("Посадить дерево", "Но не дуб", date3));
            diary.addNote(2, new Diary.Day.Note("Вырастить сына", "Играть в его радиоуправляемый вертолётик", date3));
            diary.addNote(2, new Diary.Day.Note("Вырастить дочь", "Не давать красить ногти", date3));
        }
        static void Main(string[] args)
        {
            Diary diary = new Diary();// Создаём ежедневник
            Init(diary);// Инициализируем

            userInterface userInterface = new userInterface(diary);// Создаём интерфейс, передаём туда ежедневник
            userInterface.Work();// Запускаем
        }
    }
}
