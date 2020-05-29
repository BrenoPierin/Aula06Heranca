using System;

namespace Aula6Heranca
{
    public class Cpf : Pessoa
    {
        public string cpf;
        public string rg;

        /// <summary>
        /// Valida o cpf 
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns>Cpf = true or false</returns>
        public  bool ValidarCPF(string cpf){
            if(cpf != null){
                return valido = true;
            }
            return valido = false;
        }
        
        /// <summary>
        /// Pega o valor true ou false da anterior e converte em texto
        /// </summary>
        /// <returns>texto de validação</returns>
        public string validado(){
            if(valido == true){
                return "cpf valido";
            }
             return "cpf invalido";
        }
    }
}