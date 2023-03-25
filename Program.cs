//exercicio 1 RESPOSTA É VARIAVEL SOMA será 91
int INDICE = 13;
int SOMA = 0;
int K = 0;
while (K<INDICE)
{
    K = K +1;
    SOMA = SOMA + K;
}
Console.WriteLine(SOMA);



//EXERCICIO 2 
Console.WriteLine("Digite o numero a ser verificado");
int num = int.Parse(Console.ReadLine());

int a = 0, b = 1, c;
while (b < num)
{
    c = a +b;
    a = b;
    b = c;
}
if (b == num) 
{
    Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
} 
else {
    Console.WriteLine($"O número {num} não pertence à sequência de Fibonacci.");
}


//EXERCICIO 3
// a) A lógica é adicionar 2 a cada elemento, o próximo número será 9.

// b) A lógica é multiplicar por 2 a cada elemento, o próximo número será 128.

// c) A lógica é elevar ao quadrado o índice de cada elemento, o próximo número será 49.

// d) A lógica é elevar ao quadrado o índice de cada elemento (começando do índice 1), o próximo número será 100.

// e) A lógica é somar os dois últimos elementos da sequência, o próximo número será 13.

// f) 2, 10, 12, 16, 17, 18, 19, 42


//EXERICIO 4
//O carro por estar em uma velocidade maior e por não parar no pedagio estará mais proximo da cidade de ribeirão preto, pois ele tem uma velocidade maior que a do caminhão.


//EXERICIO 5
Console.WriteLine("Digite uma palavra");
string palavra = Console.ReadLine();

char[] arrayPalavras = palavra.ToCharArray();


for (int i = arrayPalavras.Length - 1; i >= 0; i--)
{
    Console.Write(arrayPalavras[i]);
}
