using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab_group_v1
{
    class Circle
    {
        public int x { get; set; }
        public int y { get; set; }
        public int r { get; set; }

        public Circle(int abscissa, int ordinate, int radius)

        {

            x = abscissa;

            y = ordinate;

            r = radius;

        }
        //При перевизначенні методу Equals слід подбати про те, щоб цей метод повертав false у випадках, коли в метод передано значення NULL,
        //коли переданий об'єкт не можна привести до типу поточного об'єкта, ну і коли поля об'єктів відрізняються
        public override bool Equals(object obj)

        {

            if (obj == null)

                return false;

            Circle m = obj as Circle; // Повертає null якщо об'єкт не можна привести до типу Circle

            if (m as Circle == null)

                return false;

            return m.x == this.x && m.y == this.y && m.r == this.r;
        }
        public bool Equals(Circle obj) // аргумент типу Circle

        {

            if (obj == null)

                return false;

            return obj.x == this.x && obj.y == this.y && obj.r == this.r;

        }
        //Базова реалізація методу GetHashCode в класі object дуже умовна, і вона не забезпечує друга властивість, коли однакові об'єкти мають однакові хеш-коди.
        //Щоб це виправити, ми перевизначаємо метод GetHashCode, і повертаємо хеш-код будь-яким способом, що залежить від поля / полів об'єкта:
        public override int GetHashCode()

        {

            int unitCode;

            if (x == 10 && y == 10)

                unitCode = 1;

            else unitCode = 0;

            return (int)r + unitCode;

        }

    }
}

