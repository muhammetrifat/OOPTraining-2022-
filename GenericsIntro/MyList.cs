using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    public class MyList<T,Y,U>
    {
        T[] array1;
        Y[] array2;
        U[] array3;

        public MyList()
        {
            array1 = new T[0];
            array2 = new Y[0];
            array3 = new U[0];
        }
        public void Add(T t,Y y,U u)
        {
            T[] tempArray1 = array1;
            Y[] tempArray2 = array2;
            U[] tempArray3 = array3;
            array1 = new T[array1.Length + 1];
            array2 = new Y[array2.Length + 1];
            array3 = new U[array3.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                array1[i] = tempArray1[i];
                array2[i] = tempArray2[i];
                array3[i] = tempArray3[i];
            }
            array1[array1.Length - 1] = t;
            array2[array2.Length - 1] = y;
            array3[array3.Length - 1] = u;
        }

        public int Length
        {
            get { return array1.Length; }
        }

        public T[] Item1
        {
            get { return array1; }
        }
        public Y[] Item2
        {
            get { return array2; }
        }
        public U[] Item3
        {
            get { return array3; }
        }
    }
}
