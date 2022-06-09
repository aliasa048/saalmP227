using System;
using System.Collections.Generic;
using System.Text;

namespace homework09._06._2022
{
    class Library
    {
        public Product[] products = new Product[0];
        public void Getproduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;

        }

        public int GetJournalCount()
        {
            int count = 0;
            foreach (var item in products)
            {
                if (item is Journal)
                {

                    count++;
                }


            }

            return count;
        }
        public int GetJBookCount()
        {
            int count = 0;
            foreach (var item in products)
            {
                if (item is Book)
                {

                    count++;
                }


            }

            return count;
        }

        public Product[] GetProducts(bool isBook )
        {
            Product[] newArr = new Product[0];
            if (isBook == true)
            {
                foreach (var item in products)
                {
                    if (item is Book)
                    {
                        Array.Resize(ref newArr,newArr.Length + 1);
                        newArr[newArr.Length - 1] = item;

                    }
                }

                return newArr;
            }
            else
            {
                foreach (var item in  products)
                {
                    if (item is Journal)
                    {
                        Array.Resize(ref newArr, newArr.Length + 1);
                        newArr[newArr.Length - 1] = item;
                    }
                }

                return newArr;

            }
        }

        


        
    }
}
