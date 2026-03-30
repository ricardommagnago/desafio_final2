/* Aqui vai vim   QUESTÃO 01*/
Console.WriteLine("-------------------------------------------------------------");

Console.WriteLine(" Atividade ");



string[] pocoes = { "Cura", "Mana" };

if (pocoes.Length > 0)
{
    Console.WriteLine("Poção consumida!");
}
else
{
    Console.WriteLine("Inventário Vazio!");
}


// Verifique se pocoes.Length > 0
// Se sim: Console.WriteLine("Poção consumida!");
// Senão: Console.WriteLine("Inventário Vazio!");

Console.WriteLine("-------------------------------------------------------------");

Console.WriteLine(" Vamos para a atividade 2");

int nivelJogador = int.Parse(Console.ReadLine());

if (nivelJogador >= 50)
{
    Console.WriteLine("Porta VIP liberada!");
}
else
{
    Console.WriteLine("Vá para treinamento!");
}

// Se nivelJogador >= 50: "Porta VIP liberada!"
// Senão: "Vá para treinamento!"

Console.WriteLine("------------------------------------");
Console.WriteLine("Vamos para atividade 3");

int noAtual = 50;
int valorProcurado = int.Parse(Console.ReadLine());


if (valorProcurado > noAtual)
{
    Console.WriteLine("Ir para DIREITA");
}
else
{
    Console.WriteLine("Ir para ESQUERDA");
}



// Compare valorProcurado com noAtual
// Maior: "Ir para DIREITA"
// Menor: "Ir para ESQUERDA"