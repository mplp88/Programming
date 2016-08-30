using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter
{
    public class BitArray
    {
        private int[] bitArr;
        private bool odd = false;

        public int[] BitArr
        {
            get
            {
                return bitArr;
            }

            set
            {
                bitArr = value;
            }
        }

        public BitArray(int n)
        {
            CreateBitArray(n);
            FillBitArray(n);
        }

        private void CreateBitArray(int n)
        {
            int pow = 2;

            while (n < Math.Pow(4,pow))
            {
                n = 4 * (pow / 2);
                pow += 2;
            }

            bitArr = new int[n];
        }

        /*
         * if ( n < 4 ^ 2 )
         *  return 4 * cont; 
         * if ( n < 4 ^ 2+2)
         *  return 4 * cont+1;
         * if ( n < 4 ^ 2+2+2)
         *  return 4 * cont+2;
         * if ( n < 4 ^ 2+2+2+2) 
         *  return 4 * cont+3;
         * if ( n < 4 ^ x)
         *  return 4 * cont; 
         */

        private void FillBitArray(int n)
        {
            int r = 0;
            int[] fill = new int[this.bitArr.Length];

            if (n % 2 == 1)
            {
                odd = true;
            }

            for (int i = 0; i < fill.Length; i++)
            {
                if (i==0)
                {
                    if (odd)
                    {
                        fill[i] = 1;
                    }
                    else
                    {
                        fill[i] = 0;
                    }
                }
                else
                {
                    r = n % 2;
                    fill[i] = r;
                }
                n = n / 2;
            }

            int len = this.bitArr.Length;

            for (int i = 0; i < this.bitArr.Length; i++)
            {
                this.bitArr[i] = fill[--len];
            }
        }

        public string PrintBitArray(int n)
        {
            string print = "";

            for (int i = 0; i < this.bitArr.Length; i++)
            {
                print = print + bitArr[i].ToString();
            }

            return n + " = " + print;
        }
    }
}
