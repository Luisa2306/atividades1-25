

using atv1;

int escolha = 0;
void Menu()
{
    Console.WriteLine("================================");
    Console.WriteLine("Escolha uma Atividade de 1 a 25");
    Console.WriteLine("================================");
    Console.WriteLine("\n");
    escolha = int.Parse(Console.ReadLine());
}

Atividades att = new Atividades();

switch (escolha)
{
    case 1:
        Console.WriteLine("Atividade 1:\n");
        att.At1();

        break;
    case 2:
        Console.WriteLine("Atividade 2:\n");
        break;
    case 3:
        Console.WriteLine("Atividade 3:\n");
        break;
    case 4:
        Console.WriteLine("Atividade 4:\n");
        break;
    case 5:
        Console.WriteLine("Atividade 5:\n");
        break;
    case 6:
        Console.WriteLine("Atividade 6:\n");
        break;
    case 7:
        Console.WriteLine("Atividade 7:\n");
        break;
    case 8:
        Console.WriteLine("Atividade 8:\n");
        break;
    case 9:
        Console.WriteLine("Atividade 9:\n");
        break;
    case 10:
        Console.WriteLine("Atividade 10:\n");
        break;
    case 11:
        Console.WriteLine("Atividade 11:\n");
        break;
    case 12:
        Console.WriteLine("Atividade 12:\n");
        break;
    case 13:
        Console.WriteLine("Atividade 13:\n");
        break;
    case 14:
        Console.WriteLine("Atividade 14:\n");
        break;
    case 15:
        Console.WriteLine("Atividade 15:\n");
        break;
    case 16:
        Console.WriteLine("Atividade 16:\n");
        break;
    case 17:
        Console.WriteLine("Atividade 17:\n");
        break;
    case 18:
        Console.WriteLine("Atividade 18:\n");
        break;
    case 19:
        Console.WriteLine("Atividade 19:\n");
        break;
    case 20:
        Console.WriteLine("Atividade 20:\n");
        break;
    case 21:
        Console.WriteLine("Atividade 21:\n");
        break;
    case 22:
        Console.WriteLine("Atividade 22:\n");
        break;
    case 23:
        Console.WriteLine("Atividade 23:\n");
        break;
    case 24:
        Console.WriteLine("Atividade 24:\n");
        break;
    case 25:
        Console.WriteLine("Atividade 25:\n");
        break;
}