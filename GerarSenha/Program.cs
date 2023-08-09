namespace GerarSenha
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int tamanho = 0;
            Console.WriteLine("Insira o tamanho da senha: ");
            tamanho = Convert.ToInt32(Console.ReadLine());
                      
            Console.WriteLine(geradorDeSenha(tamanho));
        }

        public static string geradorDeSenha(int tamanho)
        {
            string senha = "";
            char chosenChar = ' ';
            string charArray = "";
            Dictionary<int, string> caracteres = new Dictionary<int, string>();
                caracteres.Add(0, "abcdefghijklmnopqrstuvwxyz");
                caracteres.Add(1, "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
                caracteres.Add(2, "0123456789");
                caracteres.Add(3, "@!#$%&*?");
            Random rnd = new Random();
            

            for (int i = 0; i < tamanho; i++)
            {
                charArray = caracteres[rnd.Next(4)]; // caracteres[3]
                chosenChar = charArray[rnd.Next(charArray.Length)]; // charArray[3]
                senha += Convert.ToString(chosenChar);
            }
            return senha;
        }
    }
}