using System;
using System.Collections.Generic;
using System.Text;

namespace CustomGenericLinkedList
{
    public class GenericList<T> : IGenericList<T>
    {
        private T[] values { get; set; }

        public GenericList()
        {
            values = new T[0];
        }
       
        public void Add(T value)
        {
         
            if(values.Length > 0)
            {
                T[] newArray = new T[values.Length + 1];
                for (int i = 0; i < values.Length; i++)
                {
                    newArray[i] = values[i];
                }
                newArray[values.Length] = value;
                values = newArray;
            }
            else
            {
                values = new T[1];
                values[0] = value;
            }
            
        }

        public void AddByPositon(T value, int position)
        {
           
            if (values.Length > 0 )
            {
                T[] newArray = new T[values.Length + 1];
                for (int i = 0; i < values.Length; i++)
                {
                    if (i == position)
                    {
                        newArray[i] = value;
                    }
                    else
                    {
                        newArray[i] = values[i];
                    }
                }
                newArray[values.Length] = values[position];
                values = newArray;
            }
            else
            {
                values[0] = value;
            }
         
        }

        public void DeleteByPosition(int position)
        {
            if (values == null)
                throw new ArgumentNullException("not initialized");
            if (values.Length < position+1)
                throw new Exception("position not found"); 

            if (values.Length > 0)
            {
                T[] newArray = new T[values.Length];
                for (int i = 0; i < values.Length; i++)
                {
                    if (i != position)
                    {
                        newArray[i] = values[i];
                    }
                }
                values = newArray;
            }
        }

        public string DisplayNode()
        {
            if (values == null)
                throw new ArgumentNullException("not initialized");

            StringBuilder sb = new StringBuilder();
            foreach (var item in values)
            {
                sb.Append($"{item},");
            }
            return sb.ToString();
            throw new Exception("no elements");
        }

        public T GetByPosition(int position)
        {
            return values[position];
        }
    }
    }
