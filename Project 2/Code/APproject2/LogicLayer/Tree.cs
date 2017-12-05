using System;

namespace LogicLayer
{
    public class Tree
    {
        public Boolean IsClipart { get; private set; }

        private long[] data;

        public Tree(long[] data)
        {
            this.data = data;
            this.IsClipart = TreeOne();
        }
        /*
            42 <= 99
            |   191 <= 183: clipart (167.0)
            |   191 > 183
            |   |   161 <= 205: clipart (7.0)
            |   |   161 > 205: normal (2.0)
            42 > 99
            |   0 <= 4612: normal (95.0)
            |   0 > 4612: clipart (8.0/1.0)
         */
        private Boolean TreeOne()
        {
            if(this.data[42] <= 99)
            {
                if (this.data[191] <= 183)
                {
                    return true;
                }
                else
                {
                    if (this.data[161] <= 205) return true;
                    else return false;
                }
            }
            else
            {
                if (this.data[0] <= 4612) return false;
                else return true;
            }
        }

        private Boolean TreeTwo()
        {

            return false;
        }
    }
}
