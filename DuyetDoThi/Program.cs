namespace DuyetDoThi
{
    class Program
    {
        public const int max = 9;
        public static int[,] m = new int[,]
        {
            {0, 1, 1, 0, 0, 0, 0, 0, 0},
            {1, 0, 1, 0, 0, 0, 0, 0, 1},
            {1, 1, 0, 1, 1, 0, 0, 0, 0},
            {0, 0, 1, 0, 1, 0, 0, 0, 1},
            {0, 0, 1, 1, 0, 1, 1, 0, 0},
            {0, 0, 0, 0, 1, 0, 0, 0, 0},
            {0, 0, 0, 0, 1, 0, 0, 1, 0},
            {0, 0, 0, 0, 0, 0, 1, 0, 0},
            {0, 1, 0, 1, 0, 0, 0, 0, 0},
        };
        public static bool[] chuaxet = new bool[max];
        public static bool[,] ke = new bool[max, max];
        // duyet do thi theo chieu sau su dung de quy
        public static int z = 0;
        public static void DFSdequy(int v)
        {
            //duyet dinh v
            chuaxet[v] = false;
            for (int u = 0; u < max; u++)
            {
                if (ke[u, v] == true && chuaxet[u] == true)
                {
                    DFSdequy(u); z++;
                }
            }
        }
        static void Main(string[] args)
        {
            // tao mang ke
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    if(m[i,j] == 1)
                    {
                        ke[i, j] = true;
                    }
                }
            }
            // tao nhan cho dinh
            for (int i = 0; i < max; i++)
            {
                chuaxet[i] = true;
            }
            // duyet do thi theo chieu sau su dung de quy (co huong va vo huong deu dc)
            for (int i = 0; i < max; i++)
            {
                if (chuaxet[i])
                {
                    DFSdequy(i); 
                }
            }
        }
    }
}
