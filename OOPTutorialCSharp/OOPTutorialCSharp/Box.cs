using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorialCSharp
{
    class Box
    {
        private int width;
        private int lenght;
        private int height;
        private int volume;

        //construtors
        public Box(int width, int lenght, int height)
        {
            this.Width = width;
            this.Lenght = lenght;
            this.height = height;
        }

        public Box()
        {
            
        }

        //properties
        //you dont have to declare/define get\set methods and even private variable member, just properties
            //autoimplement , enetr prop then double tab, NOT USE ANY MEMBERS OF CLASS
        public int Width { get; set; }
        //classic, read-write, read only - get only, write only - set only

        //public int Lenght
        //{
        //    get
        //    {
        //        return lenght;
        //    }
        //    set
        //    {
        //        lenght = value;
        //    }
        //}
        public int Lenght
        {
            get => lenght;
            set => lenght=value;
        }

        public int Height
        { 
            get
            {
                return height;
            }
            set
            {
                if (value < 0) throw new Exception("value should have been positive");
                height = value;
            }
        }
        public int Volume
        {
            get
            {

                return Height * Width * Lenght;
            }
            set
            {
                volume = value;
            }
        }

        public int FrontSurface { get => Height * Lenght; }


        //methods
        public void setLenght(int lenght)
        {
            this.lenght = lenght;
        }

        public void setWidht(int width)
        {
            this.width = width;
        }

        public void setHeight(int height)
        {
            this.height = height;
        }

        public int getLenght()
        {
            return this.lenght;
        }

        public int getWidht()
        {
            return this.width;
        }

        public int getHeight()
        {
            return this.height;
        }


        public void DisplayInfo()
        {
            Console.WriteLine("Width {0} lenght {1} height {2} volume {3}",Width,lenght,height, Volume=(Width*lenght*height));
            //Console.WriteLine("Width {0} lenght {1} height {2} volume {3}", Width, lenght, height, volume = (Width * lenght * height));
            return;
        }

        public void FrontSurfaceInfo()
        {
            Console.WriteLine("Front surface {0}", FrontSurface);
            //Console.WriteLine("Width {0} lenght {1} height {2} volume {3}", Width, lenght, height, volume = (Width * lenght * height));
            return;
        }




    }


}


/*
 * 
 * a class created for learning properties
 * 
 * 
 */
