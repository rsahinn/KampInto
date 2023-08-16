using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}


/*  Öncelikle List diye bir sınıf olmasaydı, kendi listimizi oluşturma şansını program bize 
    vermiş oluyordu. Bunun için bir MyList adında bir class açıp bu class'ı tıpkı List gibi 
    <> işaretleriyle yazardık. İstediğimiz bir tipte oluşturmak için buna T adını verdik. T
    burada hangi tip olacağını belirtmek için kullanılır. 

    Listin içine bir eleman eklemek istediğimizde bir fonksiyon kullandık. Buna Add fonksiyonu
    adını verdik. Bu fonksiyon program içerisinde list içine bir eleman eklemek istediğimiz zaman
    kullanabileceğimiz bir fonksiyondu. Parametre olarak yine hangi tip veri geleceğini bilmediğimiz
    için T item şeklinde parametremizi verdik. 

    




*/