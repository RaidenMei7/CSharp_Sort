using System;

namespace T_冒泡排序练习
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //Sort s = new Sort();
            //s.Assign();
            //s.BubbleSort();
            //s.Show();

            SortDown sd = new SortDown();
            sd.Assign();
            sd.BubbleSortDown();
            sd.Show();



           

            
        }
    }

    class Sort
    {
        int[] arr = new int[20];
        bool is_sort = false;
        int temp = 0;

        Random r = new Random();

        public void Assign()
        {
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = r.Next(101);

            }
        }

        public void BubbleSort()
        {
            for(int m=0;m<arr.Length-1;m++)
            {
                is_sort = false;
                for(int n=0;n<arr.Length-1-m;n++)
                {
                    
                    if(arr[n]<arr[n+1])
                    {
                        is_sort = true;

                        temp = arr[n];
                        arr[n] = arr[n + 1];
                        arr[n + 1] = temp;

                    }


                }
                if(!is_sort)
                {
                    break;
                }

            }

            

        }

        public void  Show()
        {
            for(int t=0;t<arr.Length;t++)
            {
                Console.WriteLine(arr[t]);
              
            }
            Console.WriteLine("*****");
            Console.WriteLine(arr.Length);
        }
    }
    class SortDown
    {
        int[] arr = new int[20];
        bool is_sort = false;
        int temp = 0;

        Random r = new Random();


        public void Assign()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(101);

            }
        }

        public void BubbleSortDown()
        {
            for(int m=0;m<arr.Length-1;m++)
            {
                is_sort = false;
                for(int n=0;n<arr.Length-1-m;n++)
                {
                    if(arr[n]>arr[n+1])
                    {
                        is_sort = true;

                        temp = arr[n];
                        arr[n] = arr[n + 1];
                        arr[n + 1] = temp;

                    }

                }
                if(!is_sort)
                {
                    break;
                }
            }

        }

        public void Show()
        {
            for (int t = 0; t < arr.Length; t++)
            {
                Console.WriteLine(arr[t]);

            }
            Console.WriteLine("*****");
            Console.WriteLine(arr.Length);
        }



    }


}
