using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysCSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeArrayTutorial();
            ForEachTutorial();
            MultiDimensionalArraysTutorial();
            JaggedArray();
            JaggedArrayChallenge();
            Console.ReadKey();
        }

        public static void InitializeArrayTutorial()
        {
            //array with 5 values
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 13;
            grades[4] = 9;

            Console.WriteLine("Enter the grades at 0 index");
            string input = Console.ReadLine();

            while (!(int.TryParse(input,out grades[0])))
            {
                Console.WriteLine("Entered string wasn't a nubmer!");
                Console.WriteLine("Enter the grades at 0 index");
                input = Console.ReadLine();
            }

            Console.WriteLine("Grades at 0 index is {0}", grades[0]);

            int[] gradesOFMathStudentsA = {20,10,10,4,5};

            int[] gradesOFMathStudentsB = new int[]{ 20, 10, 10, 14, 15, 18};

            Console.WriteLine("number of grades in Math studens A",gradesOFMathStudentsA.Length); 

        }

        public static void ForEachTutorial()
        {
            int[] nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("element at position {0} = {1} ", i, nums[i]);
            }

            int counter = 0;
            //k - value of nums at specific position
            foreach (var k in nums)
            {
                Console.WriteLine("element at position {0} = {1} ", counter, k);
                counter++;
            }

            string[] friends = new string[] {"Anita", "Kamil", "Kamil","Patryk","Adam"};

            foreach (var friend in friends)
            {
                Console.WriteLine("Hi {0}, my firend!", friend);
            }
        }

        public static void MultiDimensionalArraysTutorial()
        {
            //declare 2d array
            //DON'T DO THAT
            //initialize "ASAP" 
           // string[,] matrix;
           // matrix = { {"a ","b " },{"c","d" } };

            //3d
            int[,,] threeDArray;

            int[,] array2D = new int[,]
            {
                {1,2,3}, //row 0
                {3,4,5}, //row 1
                {7,8,9}  //row 2
            };

            Console.WriteLine("Central value is {0}",array2D[1,1]);

            string[,,] array3D = new string[,,]
            {
                {
                    {"00", "11"},
                    {"01","10"},
                    { "Hello ","There"}
                },
                {
                    {"11","01"},
                    {"10","00"},
                    { "Another One", " Bite the Dust"}
                }
            };

            Console.WriteLine("The value is {0}", array3D[1,1,1]);
            Console.WriteLine(array3D[0, 2, 0] + array3D[0, 2, 1] + array3D[1, 2, 0] + array3D[1, 2, 1]);


            string[,] array2DString = new string[3, 2] 
            {
                { "one","two"},
                {"three","four"},
                {"five","six"}
            };

            array2DString[1, 1] = "chicken";
            Console.WriteLine(array2DString[1, 0] + " " + array2DString[1, 1] + " " + array2DString[2, 0]);

            int dimensions = array2DString.Rank;

            Console.WriteLine(dimensions);

            int[,] array2D2 = { {1,2 }, {3,4} };

            return;
        }

        public static void JaggedArray()
        {
            //arrays in arrays

            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 1, 2 };

            //aleternative way
            int[][] jaggedArray0 = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 1, 2, 3 },
                new int[] { 1, 2 }
            };

            Console.WriteLine( jaggedArray0[0][2] );

            for (int i = 0; i < jaggedArray0.Length; i++)
            {
                for (int j = 0; j < jaggedArray0[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray0[i][j]);
                }
            }

            return;
        }

        public static void JaggedArrayChallenge()
        {

            string[] patrykFamily = new string[] { "Mik", "Olaf" };

            string[][] firendsAndFamilyArray = new string[][]
            {
                new string[] { "Kamil","Patryk" },
                new string[] { "Olgierd", "Genowefa" },
                patrykFamily
            };

            foreach (var array in firendsAndFamilyArray)
            {
                foreach (var friend in array)
                {
                    Console.WriteLine("Hi!");
                    //Console.WriteLine(friend);
                    foreach (var meetArray in firendsAndFamilyArray)
                    {
                        foreach (var familyMember in meetArray)
                        {
                            if (array!=meetArray)
                            {
                                Console.WriteLine("{0}! Meet {1}", friend, familyMember);
                            }
                        }

                    }

                }

            }

            return;
        }

    }
}
