namespace ConsoleApp1 {
    internal class Program {
        static int imGlobal = 420;
        int globalint = 2;
        static void Main(string[] args) {
            Console.WriteLine(@"Hei, hva heter du?
            woohooooo
            jeg elsker linjer");
            var input = Console.ReadLine();
            int num = 2000;
            long bigNum = 1000;
            float floating = 4.2055f;
            decimal decimals = 4.20m;
            double doubleNum = 420.5;
            string text = "Dette er tekst";
            char oneLetter = 'W';
            bool isTrue = true;
            int[] manyNUm = { 1, 2, 3 };
            string[] manyText = { "hei", "på", "deg" };
            List<int> manyList = new List<int>();
            int[] myNums = kek();
            int globalNum = global();
            Console.WriteLine(@$"Velkommen {input} {num} {funNum()}
            {bigNum} {floating} {decimals} {doubleNum} {globalNum}
            {text} {oneLetter} {isTrue} {myNums[2]} {manyText[1]} {test()}");
        }

        static int[] kek() {
        return new int[] {1, 3, 2};
        }
        static int global(){
        return imGlobal; 
        }
        public int test(){
        return globalint; 
        }
        static int funNum(){
        return 22; 
        }
    }
}