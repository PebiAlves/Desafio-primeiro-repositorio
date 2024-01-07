using System.Runtime.Serialization;

class Tela
{
    public void EscrM(string msg)
    {
        Console.Write(msg);
    }
    public void EscrP(string msg)
    {
        Console.WriteLine(msg);
    }
    public void Menu()
    {
        EscrP("______________________________________");
        EscrP("||||  Escolha uma opção do MENU   ||||");
        EscrP("|||| [1] - Login  [2] - Cadastrar ||||");
        EscrP("|||| [3] - Sair   [4] - Lista     ||||");
        EscrP("|||| [0] - Excluir usuario        ||||");
        EscrP("--------------------------------------");
    }
}