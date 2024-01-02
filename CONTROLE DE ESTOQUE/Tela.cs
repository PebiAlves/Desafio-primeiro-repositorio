class Tela
{

    //Digita mesma lina
    public void EscrM(string msg)
    {
        Console.Write(msg);
    }

    //Digita proxima lina
    public void EscrP(string msg)
    {
        Console.WriteLine(msg);
    }

    //Menu interativo
    public void Menu()
    {
        EscrP("\n          _-_-_-_-_-_-_-_Escolha uma opção do MENU_-_-_-_-_-_-_-_");
        EscrP("         |[1] Novo                         [4]Entrada de Estoque |");
        EscrP("         |[2] Listar Produtos              [5]Saída de Estoque   |");
        EscrP("         |[3] Remover Produtos             [0]Sair               |");
        EscrP("         ---------------------------------------------------------");
    }
}