namespace CONTROLE_DE_ESTOQUE;

class Program
{
    static void Main(string[] args)
    {
        Tela tel = new Tela();
        GerenEstoque ger = new GerenEstoque();

        tel.EscrP("\n\n_-_-_-_PROGRAMA DE CONTROLE DE ESTOQUE - LOJA DE PNUES PARA LINHA PESADA_-_-_-_");

        bool executando = true;
        while (executando == true)
        {
            //Exibe o menu
            tel.Menu();

            //Escolha do usuario
            tel.EscrM("Digite: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            //Reação da escolha do usuario
            if (opcao == 0)
            {
                tel.EscrP("Saindo...");
                executando = false;
            }
            else if (opcao == 1)
            {
                //Passa valores para os atributos 
                Pneus pneu = new Pneus();
                tel.EscrM("Informe a marca: ");
                pneu.Marca = Console.ReadLine();
                tel.EscrM("Informe se é NACIONAL ou IMPORTADO: ");
                pneu.NacImp = Console.ReadLine();
                tel.EscrM("Informe o tipo da borracha [BORRACHUDO ou LISO]: ");
                pneu.Borracha = Console.ReadLine();
                tel.EscrM("Informe a especificação [275/80 r22.5, 295/80 r22.5 ou 315/80 r22.5]: ");
                pneu.Especif = Console.ReadLine();
                pneu.Estoque = 0;
                tel.EscrM("Informe o preço do pneu: ");
                pneu.Preco = Convert.ToDouble(Console.ReadLine());
                //Adicinona na arry
                ger.Novo(pneu);
                tel.EscrP("\n\nADICIONADO!");
            }
            else if (opcao == 2)
            {
                ger.Lista();
            }
            else if (opcao == 3)
            {
                tel.EscrM("Irforme o numero do pneu a ser removido do estoque: ");
                int r = Convert.ToInt32(Console.ReadLine()) - 1;
                ger.Remover(r);
                tel.EscrP("REMOVIDO!");
            }
            else if (opcao == 4)
            {
                tel.EscrM("Irforme o numero do pneu a para adicionar a quantidade no estoque: ");
                int p = Convert.ToInt32(Console.ReadLine()) - 1;
                tel.EscrM("Irforme quantidade de pneus: ");
                int q = Convert.ToInt32(Console.ReadLine());
                ger.EEst(p, q);
            }
            else if (opcao == 5)
            {
                tel.EscrM("Irforme o numero do pneu a para retirar a quantidade no estoque: ");
                int p = Convert.ToInt32(Console.ReadLine()) - 1;
                tel.EscrM("Irforme quantidade de pneus: ");
                int q = Convert.ToInt32(Console.ReadLine());
                ger.SEst(p, q);
            }
            else
            {
                tel.EscrP("Opção invalida...");
            }
        }
    }
}
