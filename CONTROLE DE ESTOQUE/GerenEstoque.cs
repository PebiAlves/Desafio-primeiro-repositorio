class GerenEstoque
{
    Pneus[] pneu = new Pneus[0];
    Tela tel = new Tela();

    public void Novo(Pneus newPneu)
    {
        //Cria novo arry com espaço de 1 extra
        Pneus[] newArry = new Pneus[pneu.Length + 1];
        for (int p = 0; p < pneu.Length; p++)
        {
            newArry[p] = pneu[p];
        }
        newArry[newArry.Length - 1] = newPneu;
        //Atualiza arry
        pneu = newArry;
    }
    public void Lista()
    {
        tel.EscrP("\n*****Lista de produtos em estoque*****");
        for (int p = 0; p < pneu.Length; p++)
        {
            Pneus prod = pneu[p];
            tel.EscrP($"[{p + 1}] {prod.Marca} - {prod.NacImp} {prod.Borracha}, {prod.Especif} |PREÇO R${prod.Preco}| Disponivel {prod.Estoque} no estoque.");
        }
    }
    public void Remover(int pRemov)
    {
        //Cria novo arry com espaço 1 ha menos
        Pneus[] newArry = new Pneus[pneu.Length - 1];
        for (int p = 0; p < newArry.Length; p++)
        {
            if (p >= pRemov)
            {
                newArry[p] = pneu[p + 1];
            }
            else
            {
                newArry[p] = pneu[p];
            }
        }
        //Atuliza arry
        pneu = newArry;
    }
    // funções de soma e tira quantidade de estoque
    public void EEst (int p, int qtd)
    {
        pneu[p].Estoque += qtd;
    }
    public void SEst (int p, int qtd)
    {
        pneu[p].Estoque -= qtd;
    }
}