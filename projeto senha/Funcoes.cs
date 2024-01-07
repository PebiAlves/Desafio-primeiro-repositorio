class Funcoes
{
    Tela tel = new Tela();

    Cadastro[] cad = new Cadastro[0];

    public void NewCad(Cadastro newCad)
    {
        Cadastro[] newArry = new Cadastro[cad.Length + 1];
        for (int p = 0; p < cad.Length; p++)
        {
            newArry[p] = cad[p];
        }
        newArry[newArry.Length - 1] = newCad;
        cad = newArry;
    }
    public void List()
    {
        tel.EscrP("**** Lista de ID e usuarios ****");
        for (int p = 0; p < cad.Length; p++)
        {
            Cadastro user = cad[p];
            tel.EscrP($"ID: {p + 1} - {user.NomeUser}");
        }
    }
    public void Delete(int pDel)
    {
        Cadastro[] newArry = new Cadastro[cad.Length - 1];

        for (int p = 0; p < newArry.Length; p++)
        {
            if (p >= pDel)
            {
                newArry[p] = cad[p + 1];
            }
            else
            {
                newArry[p] = cad[p];
            }
        }
        cad = newArry;
    }
    public void CheckPass(string nomeUser, string senhaUser)
    {
        foreach (var user in cad)
        {
            if (user.NomeUser.Equals(nomeUser) && user.SenhaUser.Equals(senhaUser))
            {
                tel.EscrP("Usuario e senha corretos, login efetuado");
                break;
            }
            else
            {
                tel.EscrP("Usuario ou senha incorretos, tente novamente");
            }
        }
    }
}