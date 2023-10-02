using FundamentosNET.Models;

// Pessoa person = new Pessoa(); // variável person do tipo pessoa que instancia a classe (fica armazenada na memória)

// person.Nome = "Joacks";
// person.Idade = 29;

// person.Apresentar();

// string apresentacao = "Olá seja bem vindo";

// int quantidade = 1;

// double altura = 1.80;

// decimal preco = 1.80M; //M refere-se ao valor decimal. Somente necessário se for passar valor direto.

// bool condicao = false;

//int a = Convert.ToInt32("5");  Conversão com Convert
// int a = int.Parse("5"); // Conversão por Parse. 
var a = int.TryParse("5", out int valor); // Conversão por Método TryParse. 

string b = 7.ToString();

int d = 5;
double e = d; //Cast implícito.

System.Console.WriteLine(a);
System.Console.WriteLine(b);


// System.Console.WriteLine(apresentacao);
// System.Console.WriteLine("Valor da variável quantidade: " + quantidade);
// System.Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));//to string para tratar o double e não excluir o zero.
// System.Console.WriteLine("Valor da variável preco: " + preco);
// System.Console.WriteLine("Valor da variável condicao: " + condicao);


// DateTime dataAtual = DateTime.Now;

// string aniversario = "10/07/1994";

// DateTime dataAniversario = new DateTime(1994, 07, 10);
//DateTime possui varios métodos para manipular as datas, tais como, AddYear, AddDays, etc.
// string dataAjustada = dataAtual.ToShortDateString();



