using System;
using System.Collections.Generic;
using System.Text;

namespace DataStruct
{
  class List
    {
      /*make filed Properties*/
        // a khai bao array
        int[] nums;
        // khai bao indexer wihth get and set method
        public int this[int i]
        {
            get
            {
                return nums[i];
            }
            set
            {
                nums[i] = value;
            }
        }

        // make propertie Capacity
        int _Capacity;
        public int Capacity
        {
            get
            {
                return _Capacity;
            }
        }

        // make properties Length;
        int _Length;
        public int Length
        {
            get
            {
                return _Length;
            }
           
        }


      /*make Contructor class List*/
      public List(int numberOfList)
        {
            this._Capacity = numberOfList;
            nums = new int[Capacity];
            _Length = 0;
        }


        // make 4 method
        public void Add(int value)
        {

        }
    }

    // class SuperList
    class SuperList
}


/*Nhờ thầy hướng dẫn lại..........help?*/