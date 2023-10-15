using System;
using System.Collections.Generic;

namespace ReviewBasic
{
    // khai báo class vói Generic
    class TestGeneric <T>
    {
        // khai báo mảng với Generic
        private T[] array;

       // sử dụng lại class và truyền kiểu dl cụ thể
        public TestGeneric(int size)
        {
            array = new T[size + 1];
        }   

         //method với Generic     
        public T getItem(int index)
        {
            return array[index];
        }        
        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }
}