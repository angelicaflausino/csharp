Console.Title = "Iniciante - Tipos Internos de Valor e de Referência";
Console.BackgroundColor = ConsoleColor.DarkBlue;

Menu();

#region System.Boolean
void Boolean()
{
    bool verdadeiro = true;
    bool falso = false;

    Titulo("bool", "System.Boolean");
    Texto("Armazena um valor 'true' ou 'false'");
    QuebrarLinha();
    Texto($"Quando verdadeiro tem o valor: '{verdadeiro.ToString().ToLower()}'");
    Texto($"Quando falso tem o valor: '{falso.ToString().ToLower()}'");
    QuebrarLinha();
    Texto("Quando utilizar 'bool'?");
    Texto("- Para validar uma condição, por exemplo, usuário é um administrador? Se sim então 'true', caso não então 'false'");
    Texto("- Para usar em um sequência lógica com if e else, etc.");
    FinalizarSecao();

    Voltar();
}
#endregion

#region System.Int32
void Int()
{
    Titulo("int", "System.Int32");
    Texto("Armazena valores inteiros");
    QuebrarLinha();
    Texto("O valor mínimo é: " + int.MinValue);
    Texto("O valor máximo é: " + int.MaxValue);
    QuebrarLinha();
    Console.Write($" Por exemplo, quantos anos você tem? ");

    var idadeStr = Console.ReadLine();
    int idade = 0;
    int.TryParse(idadeStr, out idade);

    if(idade == 0)
    {
        Texto("Idade inválida ou você acabou de nascer!");
    } 
    else
    {
        Texto($"Você tem {idade} anos.");
    }
    
    QuebrarLinha();
    Texto("Quando utilizar o tipo 'int'?");
    Texto("- Idade");
    Texto("- Quantidade de Produtos no estoque");
    Texto("- Quantidade de Carros");
    Texto("- Quantidade de vezes que o usuário errou a senha");
    FinalizarSecao();

    Voltar();
}
#endregion

#region System.Decimal
void Decimal()
{
    decimal salarioMinimo = 1320.00m;

    Titulo("decimal", "System.Decimal");
    Texto("Armazena valores com casas decimais com alto nível de precisão.");
    QuebrarLinha();
    Texto("O valor mínimo é: " + decimal.MinValue);
    Texto("O valor máximo é: " + decimal.MaxValue);
    QuebrarLinha();
    Texto($"Exemplo: O valor do salário mínimo no Brasil é de R${salarioMinimo.ToString("N2")} reais.");
    QuebrarLinha();
    Texto("Quando utilizar 'decimal'?");
    Texto("Resposta: Quando seu sistema precisa armazenar valores que possuem casas decimais e necessitam ter precisão, por exemplo:");
    Texto("- Valores monetários como o salário de um empregado");
    Texto("- Preço de um produto");
    Texto("- Valores analíticos que devem ser precisos");
    QuebrarLinha();
    Texto("IMPORTANTE: Você deve adicionar um 'm' ao final do número para indicar ao compilador do C# que é um decimal, por exemplo: 1320.00m");
    FinalizarSecao();

    Voltar();
}
#endregion

#region System.Byte
void Byte()
{
    Titulo("byte", "System.Byte");
    Console.WriteLine("Armazena um número inteiro de 8 bits sem sinal. É parecido com o 'int' porém com uma capacidade muito menor de armazenamento.");
    QuebrarLinha();
    Texto("O valor mínimo é: " + byte.MinValue);
    Texto("O valor máximo é: " + byte.MaxValue);
    QuebrarLinha();
    Texto("Quando utilizar 'byte'?");
    Texto("Resposta: A aplicação do type 'byte' é utilizado em contextos muitos específicos, para manipular imagens, ponteiros...");
    Texto("- Manipulação de arquivos binários, como imagens");
    Texto("- Protocolos de rede");
    Texto("- Economia de memória, no caso de um grande array de números onde cada número é menor que 255");
    Texto("- Navegar por um conjunto de bytes um a um");
    QuebrarLinha();
    Texto("IMPORTANTE: Devido ao seu pequeno intervalo de valores, o 'byte' é mais adequado para armazenar dados pequenos e não para cálculos matemáticos.");
    FinalizarSecao();

    Voltar();
}
#endregion

#region System.SByte
void SByte()
{
    Titulo("sbyte", "System.SByte");
    Texto("Armazena um número inteiro de 8 bits com sinal.");
    QuebrarLinha();
    Texto("O valor mínimo é: " + sbyte.MinValue);
    Texto("O valor máximo é: " + sbyte.MaxValue);
    QuebrarLinha();
    Texto("Quando utilizar 'sbyte'?");
    Texto("Resposta: Quando você precisa trabalhar com bytes com sinal negativo ou positivo.");
    Texto("- Quando os valores estão entre -128 a 127");
    FinalizarSecao();

    Voltar();
}
#endregion

#region System.Char
void Char()
{
    Titulo("char", "System.Char");
    Texto("Armazena um caractere Unicode de 16 bits");
    QuebrarLinha();
    Texto("O valor mínimo é: '\0'");
    Texto("O valor máximo é: '\uffff'");
    QuebrarLinha();
    Texto("Quando utilizar 'char'?");
    Texto("Resposta: Quando você precisa armazenar um único caractere, por exemplo:");
    Texto("- Armazenar um caractere de uma senha");
    Texto("- Armazenar um caractere de um nome");
    Texto("- Armazenar um caractere de um endereço");
    FinalizarSecao();

    Voltar();
}
#endregion

#region System.String
void String()
{
    Titulo("string", "System.String");
    Texto("É um tipo interno de referência e é utilizado para armazenar textos");
    QuebrarLinha();
    Texto("O valor padrão é: null ou seja, referência nula.");

    Console.Write(" Por exemplo: Digite o seu nome completo? ");
    var nome = Console.ReadLine();

    Console.Write(" Digite o nome da sua cidade? ");
    var cidade = Console.ReadLine();

    Texto($"Seu nome é {nome} e você mora em {cidade}");

    QuebrarLinha();
    Texto("Quando utilizar 'string'?");
    Texto("Resposta: Quando precisar armazenar qualquer tipo de texto:");
    Texto("- Palavras");
    Texto("- Frases");
    Texto("- Nome de Pessoas");
    Texto("- Nome de Produtos");
    Texto("- Textos");
    Texto("- Endereço");
    FinalizarSecao();

    Voltar();
}
#endregion

#region System.Double
void Double()
{
    double pi = 3.141592653;

    Titulo("double", "System.Double");
    Texto("Armazena valores de ponto flutuante de precisão dupla.");
    QuebrarLinha();
    Texto("O valor mínimo é: " + double.MinValue);
    Texto("O valor máximo é: " + double.MaxValue);
    QuebrarLinha();
    Texto($"Exemplo: O Número pi (π) é tem um valor aproximado de {pi}...");
    QuebrarLinha();
    Texto("Quando utilizar 'double'?");
    Texto("Resposta: Quando você precisa armazenar valores que têm casas decimais e a precisão é importante");
    Texto("- Quando você está trabalhando com números muito grandes como cálculos científicos");
    Texto("- Cálculos financeiros");
    QuebrarLinha();
    Texto("IMPORTANTE: Lembre-se de que o uso de 'double' pode levar a problemas de arredondamento no seu sistema...");
    Texto("...devido à maneira como os números de ponto flutuante são armazenados internamente.");
    Texto("Se você precisa de precisão absoluta, exemplo cálculos monetários, é melhor usar o tipo 'decimal'.");
    FinalizarSecao();

    Voltar();
}
#endregion

#region System.Float
void Float()
{
    float altura = 1.75f;
    float pi = 3.141592653f;

    Titulo("float", "System.Float");
    Texto("Armazena valores de ponto flutuante de precisão simples.");
    QuebrarLinha();
    Texto("O valor mínimo é: " + float.MinValue);
    Texto("O valor máximo é: " + float.MaxValue);
    QuebrarLinha();
    Texto($"Exemplo: Minha altura é de {altura} metros");
    Texto($"Exemplo: O Número pi (π) é tem um valor aproximado de {pi}...");
    QuebrarLinha();
    Texto("Quando utilizar 'float'?");
    Texto("Resposta: Quando você precisa representar números com casas decimais e tem uma precisão de 7 dígitos.");
    Texto("- O intervalo de valores que você está trabalhando está dentro do mínimo e do máximo do float");
    Texto("- A precisão de 7 dígitos é suficiente para suas necessidades");
    Texto("- Você deseja economizar memória, pois um float usa 4 bytes de memória, enquanto um double usa 8 bytes.");
    QuebrarLinha();
    Texto("IMPORTANTE: Você deve adicionar um 'f' ao final do número para indicar ao compilador do C# que é um float, por exemplo: 1.75f");
    FinalizarSecao();

    Voltar();
}
#endregion

#region System.UInt32
void UInt()
{
    nuint quantidadeProdutos = 100;
    Titulo("uint", "System.UInt32");
    Texto("Armazena valores inteiros sem sinal");
    QuebrarLinha();
    Texto("O valor mínimo é: " + uint.MinValue);
    Texto("O valor máximo é: " + uint.MaxValue);
    Texto($"Exemplo: A quantidade de produtos em estoque é de {quantidadeProdutos}");
    QuebrarLinha();
    Texto("Quando utilizar 'uint'?");
    Texto("Resposta: Quando você precisa armazenar valores inteiros que não podem ser negativos.");
    Texto("- Por exemplo, a quantidade de produtos em estoque, a quantidade de vendas, a quantidade de usuários online...");
    FinalizarSecao();

    Voltar();
}
#endregion

#region System.IntPtr
void NInt()
{
    Titulo("nint", "System.IntPtr");
    Texto("Armazena um inteiro que é do mesmo tamanho que um ponteiro ou identificador.");
    QuebrarLinha();
    Texto("O valor mínimo é: " + nint.MinValue);
    Texto("O valor máximo é: " + nint.MaxValue);
    QuebrarLinha();
    Texto("Quando utilizar 'nint'?");
    Texto("Resposta: Quando você precisa armazenar um valor inteiro que é do mesmo tamanho que um ponteiro ou identificador.");
    Texto("- Por exemplo, quando você está trabalhando com ponteiros em código não gerenciado.");
    FinalizarSecao();

    Voltar();
}
#endregion

#region System.UIntPtr
void NUInt()
{
    Titulo("nuint", "System.UIntPtr");
    Texto("Armazena um inteiro sem sinal que é do mesmo tamanho que um ponteiro ou identificador.");
    QuebrarLinha();
    Texto("O valor mínimo é: " + nuint.MinValue);
    Texto("O valor máximo é: " + nuint.MaxValue);
    QuebrarLinha();
    Texto("Quando utilizar 'nuint'?");
    Texto("Resposta: Quando você precisa armazenar um valor inteiro sem sinal que é do mesmo tamanho que um ponteiro ou identificador.");
    Texto("- Por exemplo, quando você está trabalhando com ponteiros em código não gerenciado.");
    FinalizarSecao();

    Voltar();
}
#endregion

#region System.Int64
void Long()
{
    long populacaoMundial = 7_800_000_000;

    Titulo("long", "System.Int64");
    Texto("Armazena valores inteiros longos");
    QuebrarLinha();
    Texto("O valor mínimo é: " + long.MinValue);
    Texto("O valor máximo é: " + long.MaxValue);
    Texto($"Exemplo: A população mundial é de aproximadamente {populacaoMundial} bilhões de pessoas.");
    QuebrarLinha();
    Texto("Quando utilizar 'long'?");
    Texto("Resposta: Quando você precisa armazenar valores inteiros muito grandes.");
    Texto("- Por exemplo, a população mundial, o número de vendas de uma empresa, o número de usuários de um aplicativo...");
    FinalizarSecao();

    Voltar();
}
#endregion

#region System.UInt64
void ULong()
{
    ulong populacaoMundial = 7_800_000_000;

    Titulo("ulong", "System.UInt64");
    Texto("Armazena valores inteiros longos sem sinal");
    QuebrarLinha();
    Texto("O valor mínimo é: " + ulong.MinValue);
    Texto("O valor máximo é: " + ulong.MaxValue);
    Texto($"Exemplo: A população mundial é de aproximadamente {populacaoMundial} bilhões pessoas.");
    QuebrarLinha();
    Texto("Quando utilizar 'ulong'?");
    Texto("Resposta: Quando você precisa armazenar valores inteiros muito grandes que não podem ser negativos.");
    Texto("- Por exemplo, a população mundial, o número de vendas de uma empresa, o número de usuários de um aplicativo...");
    FinalizarSecao();

    Voltar();
}
#endregion

#region System.Int16
void Short()
{
    short temperatura = -10;

    Titulo("short", "System.Int16");
    Texto("Armazena valores inteiros curtos");
    QuebrarLinha();
    Texto("O valor mínimo é: " + short.MinValue);
    Texto("O valor máximo é: " + short.MaxValue);
    Texto($"Exemplo: A temperatura é de {temperatura} graus Celsius.");
    QuebrarLinha();
    Texto("Quando utilizar 'short'?");
    Texto("Resposta: Quando você precisa armazenar valores inteiros curtos.");
    Texto("- Por exemplo, a temperatura, o número de vendas de um produto, o número de usuários de um aplicativo...");
    FinalizarSecao();

    Voltar();
}
#endregion

#region System.UInt16
void UShort()
{
    ushort temperatura = 10;

    Titulo("ushort", "System.UInt16");
    Texto("Armazena valores inteiros curtos sem sinal");
    QuebrarLinha();
    Texto("O valor mínimo é: " + ushort.MinValue);
    Texto("O valor máximo é: " + ushort.MaxValue);
    Texto($"Exemplo: A temperatura é de {temperatura} graus Celsius.");
    QuebrarLinha();
    Texto("Quando utilizar 'ushort'?");
    Texto("Resposta: Quando você precisa armazenar valores inteiros curtos que não podem ser negativos.");
    Texto("- Por exemplo, a temperatura, o número de vendas de um produto, o número de usuários de um aplicativo...");
    FinalizarSecao();

    Voltar();
}
#endregion

#region System.Object
void Object()
{
    object valor = 10;

    Titulo("object", "System.Object");
    Texto("É a classe base de todos os tipos no .NET");
    QuebrarLinha();
    Texto("Quando utilizar 'object'?");
    Texto("Resposta: Quando você precisa armazenar qualquer tipo de valor.");
    Texto("- Por exemplo, você pode armazenar um valor inteiro, um valor decimal, um valor booleano...");
    Texto("- Você pode armazenar qualquer tipo de valor em um 'object'");
    FinalizarSecao();

    Voltar();
}
#endregion

#region System.Dynamic
void Dynamic()
{
    dynamic valor = 10;

    Titulo("dynamic", "System.Dynamic");
    Texto("Permite que você armazene qualquer tipo de valor e altere o tipo de valor em tempo de execução.");
    QuebrarLinha();
    Texto("Exemplo: dynamic valor = 10; // valor é um inteiro");

    valor = "Olá Mundo!";
    Texto("Exemplo: dynamic valor = 'Olá Mundo!'; // valor é uma string");
    QuebrarLinha();
    Texto("Quando utilizar 'dynamic'?");
    Texto("Resposta: Quando você precisa armazenar qualquer tipo de valor e alterar o tipo de valor em tempo de execução.");
    Texto("- Por exemplo, você pode armazenar um valor inteiro, um valor decimal, um valor booleano...");
    Texto("- Você pode alterar o tipo de valor em tempo de execução.");
    FinalizarSecao();

    Voltar();
}
#endregion

void Voltar()
{

   Console.WriteLine("  Pressione qualquer tecla para voltar ao Menu...");
   Console.ReadKey();
   Console.Clear();
   Menu();
}

void QuebrarLinha()
{
    Console.WriteLine("");
}

void Titulo(string titulo, string sistema)
{
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine($"                {titulo}                   ");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine($" Tipo .NET: {sistema}");
}

void Texto(string texto)
{
    Console.WriteLine(" " + texto);
}

void FinalizarSecao()
{
    Console.WriteLine("--------------------------------------------");
}

void Menu()
{
    Console.Clear();
    Console.WriteLine(" Bem vindo ao tutorial de Tipos Internos de Valor e Referência :)");
    Console.WriteLine(" 1 - bool");
    Console.WriteLine(" 2 - int");
    Console.WriteLine(" 3 - decimal");
    Console.WriteLine(" 4 - byte");
    Console.WriteLine(" 5 - char");
    Console.WriteLine(" 6 - string");
    Console.WriteLine(" 7 - double");
    Console.WriteLine(" 8 - float");
    Console.WriteLine(" 9 - uint");
    Console.WriteLine(" 10 - nint");
    Console.WriteLine(" 11 - nuint");
    Console.WriteLine(" 12 - long");
    Console.WriteLine(" 13 - ulong");
    Console.WriteLine(" 14 - short");
    Console.WriteLine(" 15 - ushort");
    Console.WriteLine(" 16 - object");
    Console.WriteLine(" 17 - dynamic");
    Console.WriteLine(" 18 - sbyte");
    Console.WriteLine(" 0 - Sair");
    Console.Write(" Escolha uma opção: ");

    int opcao = 0;

    var opcaoSelecionada = Console.ReadLine();
    int.TryParse(opcaoSelecionada, out opcao);

    switch(opcao)
    {
        case 1:
            Boolean();
            break;
        case 2:
            Int();
            break;
        case 3:
            Decimal();
            break;
        case 4:
            Byte();
            break;
        case 5:
            Char();
            break;
        case 6:
            String();
            break;
        case 7:
            Double();
            break;
        case 8:
            Float();
            break;
        case 9:
            UInt();
            break;
        case 10:
            NInt();
            break;
        case 11:
            NUInt();
            break;
        case 12:
            Long();
            break;
        case 13:
            ULong();
            break;
        case 14:
            Short();
            break;
        case 15:
            UShort();
            break;
        case 16:
            Object();
            break;
        case 17:
            Dynamic();
            break;
        case 18:
            SByte();
            break;
        case 0:
            Environment.Exit(0);
            break;
        default:
            Console.Beep();
            Console.WriteLine("Opção inválida! Digite qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu();
            break;
    }
}

