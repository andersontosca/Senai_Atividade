
using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            
            
            Console.WriteLine("Informe Nome:");
            string var_nome = Console.ReadLine();

            Console.WriteLine("Informe Endereco:");
            string var_endereco = Console.ReadLine();

            Console.WriteLine("Pessoa FÍsica (f) ou Jurídica (j):");
            string var_tipo = Console.ReadLine();

            if (var_tipo == "f")
            {                

            //----Pessoa Fisica----
            Pessoa_Fisica pf = new Pessoa_Fisica();
            pf.nome = var_nome;
            pf.endereco = var_endereco;

            Console.WriteLine("Informe CPF:");
            pf.cpf = Console.ReadLine();

            Console.WriteLine("Informe RG:");
            pf.rg = Console.ReadLine();

            Console.WriteLine("Informe Valor da Compra:");
            val_pag = float.Parse(Console.ReadLine());
            pf.Pagar_Imposto(val_pag);
            Console.WriteLine("-------- Pessoa Física --------");
            Console.WriteLine("Nome ...............:" + pf.nome);
            Console.WriteLine("Endereço ...........:" + pf.endereco);
            Console.WriteLine("CPF ................:" + pf.cpf);
            Console.WriteLine("RG .................:" + pf.rg);
            Console.WriteLine("Valor Compra .......:" + pf.valor.ToString ("C"));
            Console.WriteLine("Imposto ............:" + pf.valor_imposto.ToString ("C"));
            Console.WriteLine("Total Pagar ........:" + pf.total.ToString("C"));
            }

           
            if (var_tipo == "j")
            {                

            //----Pessoa Jurídica----
            Pessoa_Juridica pj = new Pessoa_Juridica();
            
            
            pj.nome = var_nome;
            pj.endereco = var_endereco;

            Console.WriteLine("Informe CNPJ:");            
            pj.cnpj = Console.ReadLine();

            Console.WriteLine("Informe IE:");            
            pj.ie = Console.ReadLine();

            Console.WriteLine("Informe Valor da Compra:");
            val_pag = float.Parse(Console.ReadLine());
            pj.Pagar_Imposto(val_pag);
            Console.WriteLine("-------- Pessoa Jurídica --------");
            Console.WriteLine("Nome ...............:" + pj.nome);
            Console.WriteLine("Endereço ...........:" + pj.endereco);
            Console.WriteLine("CPF ................:" + pj.cnpj);
            Console.WriteLine("RG .................:" + pj.ie);
            Console.WriteLine("Valor Compra .......:" + pj.valor.ToString ("C"));
            Console.WriteLine("Imposto ............:" + pj.valor_imposto.ToString ("C"));
            Console.WriteLine("Total Pagar ........:" + pj.total.ToString("C"));
            }



        }
    }
}
