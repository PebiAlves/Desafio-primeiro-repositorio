namespace projeto_senha;

class Program
{
    static void Main(string[] args)
    {
        Tela tel = new Tela();
        Funcoes fun = new Funcoes();

        tel.EscrP("|||| SOFTWARE DE LOGIM DE USUARIO ||||");
        bool exe = true;
        while (exe == true)
        {
            tel.Menu();

            tel.EscrM("Digite: ");
            int opUser = int.Parse(Console.ReadLine());

            if (opUser == 1)
            {
                tel.EscrM("Usuario: ");
                string nomeUser = Console.ReadLine();
                tel.EscrM("Senha: ");
                string senhaUser = Console.ReadLine();
                fun.CheckPass(nomeUser,senhaUser);
            }
            if (opUser == 2)
            {
                Cadastro cad = new Cadastro();

                tel.EscrM("Nome do cadastro: ");
                cad.NomeUser = Console.ReadLine();
                tel.EscrM("Cadastre uma senha: ");
                cad.SenhaUser = Console.ReadLine();

                fun.NewCad(cad);
                tel.EscrP("Cadastrado...");
            }
            if (opUser == 3)
            {
                tel.EscrP("Saindo...");
                exe = false;
            }
            if (opUser == 4)
            {
                fun.List();
            }
            if (opUser == 0)
            {
                tel.EscrM("Informe o ID do usuario que deseja excluir: ");
                int d = Convert.ToInt32(Console.ReadLine()) - 1;
                fun.Delete(d);
                tel.EscrP("Usuario excluido!");
            }
        }
    }
}
