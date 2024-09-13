/*Manipulação de string
Crie um programa que receba duas frases com mais de 30 caracteres.
Exiba no console as seguintes manipulações:
A concatenação das duas variáveis.
A primeira Letra das duas variáveis.
A Última letra das duas variáveis.
Todas as letras menos a primeira, nas duas variáveis.
Todas as letras menos a última, nas duas variáveis.
*/

            string s_f1 = "";
            string s_f2 = "";

            Console.WriteLine("digite a primeira frase");
            s_f1 = Console.ReadLine();
            Console.WriteLine("digite a segunda frase");
            s_f2 = Console.ReadLine();
            
            Console.WriteLine("\n a concatenação das duas frases é '{0}' e '{1}'", s_f1 , s_f2);
            Console.WriteLine("\n a primeira letra da primeira frase é '{0}'", s_f1.Substring (0, 1));
            Console.WriteLine("\n e a da segunda é '{0}'", s_f2.Substring (0, 1));
            Console.WriteLine("\n alem disso, a ultima letra da primeira frase é '{0}'", s_f1.Substring(s_f1.Length -1));
            Console.WriteLine("\n e tambem, a ultima palavra da segunda frase é '{0}'", s_f2.Substring(s_f2.Length -1));
            Console.WriteLine("\n todas a letras menos a primeira de cada frase é '{0}'", s_f1.Substring(1) + s_f2.Substring (1));
            Console.WriteLine("\n todas a letras menos a ultima de cada frase é '{0}' e '{1}'", s_f1.Substring(0, s_f1.Length -1) , s_f2.Substring(0,s_f2.Length - 1));

            Console.ReadLine();
//criado por: pedroabcbr 12/09/2024 - 22h10 :p
