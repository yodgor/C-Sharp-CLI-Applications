

namespace DomainLayer
{
    
    public class TowerOfHanoi
    {
        static string msg = string.Empty;
        public static string Tower(int disks, int peg1, int peg3, int peg2)
        {
            //throw new NotImplementedException();
            if (disks == 1)
            {
                msg += string.Format($"{peg1} -- > { peg3}\n");
                //
                return msg;
            }
            //move  disks -1 from peg 1 to peg 2 recursively
            Tower(disks - 1, peg1, peg2, peg3);

            //move the last disk form peg 1 to peg3
            msg += string.Format($"{peg1} --> {peg3} \n");

            Tower(disks - 1, peg2, peg3, peg1);
            return msg;
        }
    }
}

