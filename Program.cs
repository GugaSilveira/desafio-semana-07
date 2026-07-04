using System;
using System.Collections.Generic;

// ==========================================================
// TRABALHO DE C# - LISTA DE EXERCÍCIOS 01 A 10
// ==========================================================

// --- QUESTÃO 1: SISTEMA DE APROVAÇÃO DE ALUNOS ---
Console.WriteLine("============= Questão 1 =============\n");

// Criando as variáveis para guardar as notas e o nome
string nome;
double nota1;
double nota2;
double media;

// Pedindo os dados para o usuário
Console.Write("Digite o nome do aluno: ");
nome = Console.ReadLine();

Console.Write("Digite a primeira nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());

// Calculando a média das duas notas
media = (nota1 + nota2) / 2;

Console.WriteLine(); // Pula uma linha
Console.WriteLine("Aluno: " + nome);
Console.WriteLine("Média: " + media);

// Verificando se o aluno passou ou não
if (media >= 7)
{
    Console.WriteLine("Situação: Aprovado");
}
else if (media >= 5)
{
    Console.WriteLine("Situação: Recuperação");
}
else
{
    Console.WriteLine("Situação: Reprovado");
}

// Pausa antes de ir para o próximo exercício
Console.WriteLine("\nPressione ENTER para ir para a próxima questão...");
Console.ReadLine();
Console.WriteLine("\n\n--------------------------------------------\n");



//  QUESTÃO 2: CONTROLE DE ESTOQUE 
Console.WriteLine("============= Questão 2 =============\n");

// Variáveis do produto
string nomeProduto;
int quantidadeAtual;

Console.Write("Digite o nome do produto: ");
nomeProduto = Console.ReadLine();

Console.Write("Digite a quantidade atual em estoque: ");
quantidadeAtual = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Produto: " + nomeProduto);

// Checando como está a situação do estoque
if (quantidadeAtual < 5)
{
    Console.WriteLine("Status: Estoque Crítico");
}
else if (quantidadeAtual <= 10)
{
    Console.WriteLine("Status: Estoque Baixo");
}
else
{
    Console.WriteLine("Status: Estoque OK");
}

Console.WriteLine("\nPressione ENTER para ir para a próxima questão...");
Console.ReadLine();
Console.WriteLine("\n\n--------------------------------------------\n");



//  QUESTÃO 3: FILA DE ATENDIMENTO 
Console.WriteLine("============= Questão 3 =============\n");

// Criando a fila de pacientes
Queue<string> filaPacientes = new Queue<string>();

// Adicionando os nomes na fila
filaPacientes.Enqueue("Maria");
filaPacientes.Enqueue("João");
filaPacientes.Enqueue("Pedro");

Console.WriteLine("--- Status Inicial da Fila ---");
Console.WriteLine("Pacientes na fila: Maria, João, Pedro");
Console.WriteLine();

// Tirando o primeiro da fila para ser atendido
string pacienteAtendido = filaPacientes.Dequeue();

Console.WriteLine("--- Atendimento ---");
Console.WriteLine("Paciente que foi atendido agora: " + pacienteAtendido);
Console.WriteLine();

// Mostrando quem ainda ficou esperando
Console.WriteLine("--- Pacientes Aguardando ---");
foreach (string paciente in filaPacientes)
{
    Console.WriteLine("- " + paciente);
}

Console.WriteLine("\nPressione ENTER para ir para a próxima questão...");
Console.ReadLine();
Console.WriteLine("\n\n--------------------------------------------\n");



//  QUESTÃO 4: HISTÓRICO DE NAVEGAÇÃO 
Console.WriteLine("============= Questão 4 =============\n");

// Criando a pilha para salvar as páginas acessadas
Stack<string> historico = new Stack<string>();

// Colocando as páginas na pilha
historico.Push("Home");
historico.Push("Produtos");
historico.Push("Carrinho");

Console.WriteLine("--- Histórico de Navegação ---");
Console.WriteLine("Páginas visitadas na ordem: Home -> Produtos -> Carrinho");
Console.WriteLine("Página atual: " + historico.Peek());
Console.WriteLine();

// Tirando a última página que o usuário entrou (simulando o botão voltar)
string paginaRemovida = historico.Pop();

Console.WriteLine("-> Usuário clicou em 'Voltar'.");
Console.WriteLine("Saindo da página: " + paginaRemovida);
Console.WriteLine();

Console.WriteLine("--- Histórico Atualizado ---");
Console.WriteLine("Nova página atual: " + historico.Peek());
Console.WriteLine();
Console.WriteLine("Páginas que sobraram no histórico:");

// Listando o resto das páginas
foreach (string pagina in historico)
{
    Console.WriteLine("- " + pagina);
}

Console.WriteLine("\nPressione ENTER para ir para a próxima questão...");
Console.ReadLine();
Console.WriteLine("\n\n--------------------------------------------\n");



//  QUESTÃO 5: SISTEMA DE LOGIN 
Console.WriteLine("============= Questão 5 =============\n");

// Dados corretos para entrar no sistema
string usuarioCorreto = "admin";
string senhaCorreta = "123456";

// Variáveis para guardar o que a pessoa vai digitar
string usuarioDigitado;
string senhaDigitada;

Console.Write("Digite o usuário: ");
usuarioDigitado = Console.ReadLine();

Console.Write("Digite a senha: ");
senhaDigitada = Console.ReadLine();

Console.WriteLine();

// Testando se o usuário E a senha estão iguais aos dados corretos
if (usuarioDigitado == usuarioCorreto && senhaDigitada == senhaCorreta)
{
    Console.WriteLine("Acesso concedido! Bem-vindo ao sistema.");
}
else
{
    Console.WriteLine("Acesso negado! Usuário ou senha incorretos.");
}

Console.WriteLine("\nPressione ENTER para ir para a próxima questão...");
Console.ReadLine();
Console.WriteLine("\n\n--------------------------------------------\n");



//  QUESTÃO 6: CADASTRO DE PRODUTOS COM DICIONÁRIO 
Console.WriteLine("============= Questão 6 =============\n");

// Criando a lista de produtos com seus respectivos preços
Dictionary<string, double> produtos = new Dictionary<string, double>();

produtos.Add("Mouse", 80.00);
produtos.Add("Teclado", 120.00);
produtos.Add("Monitor", 900.00);

Console.Write("Digite o nome do produto que deseja consultar: ");
string produtoBuscado = Console.ReadLine();

Console.WriteLine();

// Verificando se o produto digitado está cadastrado
if (produtos.ContainsKey(produtoBuscado))
{
    double preco = produtos[produtoBuscado];
    Console.WriteLine("O preço do produto " + produtoBuscado + " é: R$ " + preco);
}
else
{
    Console.WriteLine("Produto não encontrado no estoque.");
}

Console.WriteLine("\nPressione ENTER para ir para a próxima questão...");
Console.ReadLine();
Console.WriteLine("\n\n--------------------------------------------\n");



//  QUESTÃO 7: CONTROLE DE GASTOS DO MÊS 
Console.WriteLine("============= Questão 7 =============\n");

// Criando a lista com os valores dos gastos
List<double> gastos = new List<double>();

gastos.Add(150.00);
gastos.Add(250.00);
gastos.Add(400.00);
gastos.Add(80.00);

double totalGasto = 0;
double mediaGastos = 0;

// Somando todos os gastos da lista
foreach (double gasto in gastos)
{
    totalGasto = totalGasto + gasto;
}

// Calculando a média dividindo pela quantidade de itens
mediaGastos = totalGasto / gastos.Count;

Console.WriteLine("--- Relatório de Finanças ---");
Console.WriteLine("Total gasto no mês: R$ " + totalGasto);
Console.WriteLine("Média por gasto: R$ " + mediaGastos);
Console.WriteLine();

// Checando se a média ficou alta ou não
if (mediaGastos > 200)
{
    Console.WriteLine("Situação: Gastos elevados");
}
else
{
    Console.WriteLine("Situação: Gastos controlados");
}

Console.WriteLine("\nPressione ENTER para ir para a próxima questão...");
Console.ReadLine();
Console.WriteLine("\n\n--------------------------------------------\n");



//  QUESTÃO 8: SISTEMA DE FRETE 
Console.WriteLine("============= Questão 8 =============\n");

Console.Write("Digite o valor total da compra: R$ ");
double valorCompra = Convert.ToDouble(Console.ReadLine());

// Usando a função para descobrir o valor do frete
double valorFrete = CalcularFrete(valorCompra);

double valorFinal = valorCompra + valorFrete;

Console.WriteLine();
Console.WriteLine("--- Resumo do Pedido ---");
Console.WriteLine("Valor da Compra: R$ " + valorCompra);
Console.WriteLine("Valor do Frete: R$ " + valorFrete);
Console.WriteLine("Valor Total a Pagar: R$ " + valorFinal);

Console.WriteLine("\nPressione ENTER para ir para a próxima questão...");
Console.ReadLine();


// Função da Questão 8 (pode ficar aqui sem problema nenhum!)
double CalcularFrete(double valor)
{
    if (valor > 300)
    {
        return 0;
    }
    else if (valor >= 200)
    {
        return 15;
    }
    else
    {
        return 30;
    }
}

Console.WriteLine("\n\n--------------------------------------------\n");



// QUESTÃO 9: CONTROLE DE CHAMADOS DE TI 
Console.WriteLine("============= Questão 9 =============\n");

// Criando a fila de problemas de TI
Queue<string> filaChamados = new Queue<string>();

filaChamados.Enqueue("Impressora não funciona");
filaChamados.Enqueue("Computador lento");
filaChamados.Enqueue("Problema no e-mail");

Console.WriteLine("--- SISTEMA DE SUPORTE ---");
Console.WriteLine("Carga inicial: 3 chamados registrados na fila.");
Console.WriteLine();

// Atendendo o primeiro chamado
string chamadoAtendido = filaChamados.Dequeue();

Console.WriteLine(">>> Chamado em atendimento atual:");
Console.WriteLine("Descrição: " + chamadoAtendido);
Console.WriteLine();

Console.WriteLine("--- Chamados Restantes na Fila ---");

// Verificando se ainda tem chamado na fila ou se ela ficou vazia
if (filaChamados.Count == 0)
{
    Console.WriteLine("Nenhum chamado pendente. Fila vazia!");
}
else
{
    foreach (string chamado in filaChamados)
    {
        Console.WriteLine("[Aguardando] -> " + chamado);
    }
}

Console.WriteLine("\nPressione ENTER para ir para a última questão...");
Console.ReadLine();
Console.WriteLine("\n\n--------------------------------------------\n");



//  QUESTÃO 10: SISTEMA DE PERMISSÕES 
Console.WriteLine("============= Questão 10 =============\n");

Console.Write("Digite o cargo do usuário (Admin, Gerente ou Funcionario): ");
string cargo = Console.ReadLine();

Console.WriteLine();

// Testando qual foi o cargo digitado para mostrar a permissão certa
switch (cargo)
{
    case "Admin":
        Console.WriteLine("Permissão: Acesso total ao sistema (Leitura, Escrita e Exclusão).");
        break;

    case "Gerente":
        Console.WriteLine("Permissão: Acesso aos relatórios e aprovação de processos.");
        break;

    case "Funcionario":
        Console.WriteLine("Permissão: Acesso básico para tarefas diárias (Apenas Leitura).");
        break;

    default:
        Console.WriteLine("Cargo inválido ou não reconhecido pelo sistema.");
        break;
}

Console.WriteLine("\n=============================================");
Console.WriteLine("Trabalho concluído! Pressione ENTER para sair.");
Console.ReadLine();