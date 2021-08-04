using System;
using System.Text;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Constructor

            //Student fagan = new Student("Fagan", "Eyvazov");
            //fagan.Name = "Fagan";
            //fagan.Surname = "Eyvazov";
            //fagan.Age = 24;
            //Console.WriteLine(fagan.GetFullName());

            //Student elnur = new Student("Elnur", "Suleymanzade", 31, "P318");
            //string result = elnur.GetFullName();
            //Console.WriteLine(result);
            //Student elnur = new Student
            //{
            //    Name = "Elnur",
            //    Surname = "Suleymanzade",
            //    Age = 31,
            //    Group = "P318"
            //};
            //Console.WriteLine(elnur.GetFullNameWithGroup()); 

            //Room pluto = new Room("Pluto");
            //pluto.Capacity = 12;

            //Console.WriteLine(pluto.Name);
            //Console.WriteLine(pluto.Capacity);

            #endregion

            #region Homework

            string[] arr = { "Rail", "Ulvi", "Fegan", "Ulvi" };
            Console.WriteLine(CustomJoin(arr, ','));

            #endregion
        }

        static string CustomJoin(string[] arr, char symbol)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                string item = arr[i];
                string lastItem = arr[arr.Length - 1]; //Ulvi

                stringBuilder.Append(item);

                if (i != arr.Length - 1)
                {
                    stringBuilder.Append(symbol);
                }
                //if (item != lastItem)
                //{
                //    stringBuilder.Append(symbol);
                //}
            }

            return stringBuilder.ToString();
        }
    }
}
