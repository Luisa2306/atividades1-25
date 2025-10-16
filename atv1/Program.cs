

using atv1;

int escolha = 0;

while (true)
{
    void Menu()
    {
        Console.WriteLine("================================");
        Console.WriteLine("Escolha uma Atividade de 1 a 25");
        Console.Write("Atv:");
        escolha = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        Console.WriteLine("================================");

    }

    Atividades att = new Atividades();
    Atividades.At23 att23 = new Atividades.At23();
    Atividades.At24 att24 = new Atividades.At24();
    Menu();

    switch (escolha)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Atividade 1\n");
            att.At1();
           
            break;
        case 2:
            Console.WriteLine("Atividade 2:\n");
            att.At2();
            break;
        case 3:
            Console.WriteLine("Atividade 3:\n");
            att.At3();
            break;
        case 4:
            Console.WriteLine("Atividade 4:\n");
            att.At4();
            break;
        case 5:
            Console.WriteLine("Atividade 5:\n");
            att.At5();
            break;
        case 6:
            Console.WriteLine("Atividade 6:\n");
            att.At6();
            break;
        case 7:
            Console.WriteLine("Atividade 7:\n");
            att.At7();
            break;
        case 8:
            Console.WriteLine("Atividade 8:\n");
            att.At8();
            break;
        case 9:
            Console.WriteLine("Atividade 9:\n");
            att.At9();
            break;
        case 10:
            Console.WriteLine("Atividade 10:\n");
            att.At10();
            break;
        case 11:
            Console.WriteLine("Atividade 11:\n");
            att.At11();
            break;
        case 12:
            Console.WriteLine("Atividade 12:\n");
            att.At12();
            break;
        case 13:
            Console.WriteLine("Atividade 13:\n");
            att.At13();
            break;
        case 14:
            Console.WriteLine("Atividade 14:\n");
            att.At14();
            break;
        case 15:
            Console.WriteLine("Atividade 15:\n");
            att.At15();
            break;
        case 16:
            Console.WriteLine("Atividade 16:\n");
            att.At16();
            break;
        case 17:
            Console.WriteLine("Atividade 17:\n");
            att.At17();
            break;
        case 18:
            Console.WriteLine("Atividade 18:\n");
            att.At18();
            break;
        case 19:
            Console.WriteLine("Atividade 19:\n");
            att.At19();
            break;
        case 20:
            Console.WriteLine("Atividade 20:\n");
            att.At20();
            break;
        case 21:
            Console.WriteLine("Atividade 21:\n");
            att.At21();
            break;
        case 22:
            Console.WriteLine("Atividade 22:\n");
            att.At22();
            break;
        case 23:
            Console.WriteLine("Atividade 23:\n");
            att23.at23();
            break;
      
    }
}