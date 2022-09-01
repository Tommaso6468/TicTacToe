// See https://aka.ms/new-console-template for more information
class Program {

    static void Main(string[] args) {
        
        Spel();

    }

    public struct Bord {

        private char[,] data = new char[,] {
            {' ', ' ', ' '},
            {' ', ' ', ' '},
            {' ', ' ', ' '}
        };


        public void zet(bool beurt) {
            
            while (true) {
                Console.Write(beurt ? "(X)" : "(O)");
                Console.WriteLine(" Typ het coordinaat in (x,y)");
                string[] coords = Console.ReadLine().Split(',');
                int x = Convert.ToInt32(coords[0]) - 1;
                int y = Convert.ToInt32(coords[1]) - 1;
                if (data[x,y] == 'X' || data[x,y] == 'O') {
                    Console.WriteLine("Dit vakje is al bezet");
                    continue;
                }
                data[x,y] = beurt ? 'X' : 'O';
                break;
            }

        }

        public void PrintBord() {

            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write(data[i,j]);
                    if (j != 2) Console.Write(" | ");
                }
                Console.WriteLine();
                if (i != 2) Console.WriteLine("---------");
            }

        }

        public Bord(){}

    }

    public static void Spel() {

        Bord bord = new Bord();
        bord.PrintBord();
        bool beurt = true;

        for (int i = 0; i < 9; i++) {
            bord.zet(beurt);
            beurt = !beurt;
            bord.PrintBord();
        }

        
    }


    

}
