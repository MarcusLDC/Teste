using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Funcionario
    {
        public int id;
        public string nome;
        public int salario;
        public Funcionario(int id, string nome, int salario){
           this.id = id;
           this.nome = nome;
           this.salario = salario;
        }

        public void AumentarSalario(int porcentagem)
        {
            salario += salario * porcentagem / 100;
        }
        public override string ToString()
        {
            return "\nid = " + id
                    + "\nnome = " + nome
                    + "\nsalario = " + salario + "\n";
        }
    }
}
