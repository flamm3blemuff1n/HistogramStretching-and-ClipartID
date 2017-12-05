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
            this.IsClipart = TreeTwo();
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
            if (this.data[34] <= 31)
            {
                if (this.data[118] <= 20)
                {
                    return true;
                }
                else
                {
                    if (this.data[39] <= 16)
                    {
                        if (this.data[38] <= 0)
                        {
                            return true;
                        }
                        else
                        {
                            if (this.data[173] <= 2)
                            {
                                if (this.data[0] <= 1) return false;
                                else return true;
                            }
                            else
                            {
                                if (this.data[176] <= 66)
                                {
                                    if (this.data[239] <= 73)
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        if (this.data[18] <= 0) return false;
                                        else return true;
                                    }
                                }
                                else
                                {
                                    if (this.data[31] <= 6) return false;
                                    else return true;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (this.data[170] <= 64)
                        {
                            if (this.data[82] <= 31)
                            {
                                return true;
                            }
                            else
                            {
                                if (this.data[248] <= 31)
                                {
                                    if (this.data[27] <= 39)
                                    {
                                        if (this.data[107] <= 28)
                                        {
                                            if (this.data[94] <= 26) return false;
                                            else return true;
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        return true;
                                    }
                                }
                                else
                                {
                                    return true;
                                }
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                if (this.data[0] <= 4612)
                {
                    if (this.data[12] <= 0)
                    {
                        return true;
                    }
                    else
                    {
                        if (this.data[45] <= 26)
                        {
                            if (this.data[126] <= 74) return true;
                            else return false;
                        }
                        else
                        {
                            if (this.data[99] <= 31)
                            {
                                if (this.data[242] <= 10)
                                {
                                    if (this.data[90] <= 59) return false;
                                    else return true;
                                }
                                else
                                {
                                    if (this.data[31] <= 92)
                                    {
                                        if (this.data[218] <= 59) return true;
                                        else return false;
                                    }
                                    else
                                    {
                                        return false;
                                    }
                                }
                            }
                            else
                            {
                                if (this.data[202] <= 482)
                                {
                                    if (this.data[8] <= 0)
                                    {
                                        if (this.data[231] <= 18) return false;
                                        else return true;
                                    }
                                    else
                                    {
                                        return false;
                                    }
                                }
                                else
                                {
                                    if (this.data[211] <= 478) return true;
                                    else return false;
                                }
                            }
                        }
                    }
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
