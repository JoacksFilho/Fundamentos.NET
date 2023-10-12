using FundamentosNET.Models;


// Calculadora calc = new Calculadora();

// // calc.Somar(3, 4);
// // calc.Subtrair(5, 4);
// // calc.Multiplicar(5, 7);
// // calc.Dividir(8, 2);
// // calc.Potencia(5, 4);

// calc.Seno(30);
// calc.Cosseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(25);
// System.Console.WriteLine(calc);

string opcao;
bool exibirMenu = true;

while(true)
{
    System.Console.WriteLine("Digite a sua opção: ");
    System.Console.WriteLine("1 - Cadastrar cliente");
    System.Console.WriteLine("2 - Buscar cliente");
    System.Console.WriteLine("3 - Apagar cliente");
    System.Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            System.Console.WriteLine("Cadastro de cliente");
            break;
        
        case "2":
            System.Console.WriteLine("Busca de cliente");
            break;
        
        case "3":
            System.Console.WriteLine("Apagar cliente");
            break;
        
        case "4":
            System.Console.WriteLine("Encerrar");
            exibirMenu = false;
            break;
        default:
            System.Console.WriteLine("Opção Inválida");
            break;
    }
}




























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
// var a = int.TryParse("5", out int valor); // Conversão por Método TryParse. 

// string b = 7.ToString();

// int d = 5;
// double e = d; //Cast implícito.

// System.Console.WriteLine(a);
// System.Console.WriteLine(b);


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




