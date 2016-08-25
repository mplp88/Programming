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
            if (n < 16)
            {
                bitArr = new int[4];
            }
            else if (n < 256)
            {
                bitArr = new int[8];
            }
            else if (n < 4096)
            {
                bitArr = new int[12];
            }
            else if (n < 65536)
            {
                bitArr = new int[16];
            }
            else
            {
                return;
            }
            
        }

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
