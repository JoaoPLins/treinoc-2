using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treino
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        static int a;
        private void button1_Click(object sender, EventArgs e)
        {
            privatefacts();

            foreach (int number in SortList(theWhile()))
            {
                Console.WriteLine(number);
            }
        }

        private void privatefacts()
        {
            for (int i = 0;i<4 ;i++)
            {
                Console.WriteLine("HAHAHAHAHHA");
                if (i == 0)
                {
                    Console.WriteLine("i is one");
                } else if (i == 1)
                {
                    Console.WriteLine("i actually is one rn");
                } else
                {
                    Console.WriteLine("joke on you another number is I");
                    Console.WriteLine(i);
                    
                }


            }
            
        }

        private List<int> theWhile()
        {
            List<int> i = new List<int> {50,40} ;
            int b = 0;
            while (a<2)
            {
                i.Add(b);
                a++;
                b++;
            }

            
            return i;
        }
    
        private List<int> SortList(List<int> a)
        {
            a.Sort();
            return a;
        }
    
    
    }
    
    
}
