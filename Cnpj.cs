namespace Aula6Heranca
{
    public class Cnpj : Pessoa
    {
        public string cnpj;

        /// <summary>
        /// Valida o cnpj 
        /// </summary>
        /// <param name="cnpj"></param>
        /// <returns>CNPJ = true or false</returns>
       public bool ValidarCNPJ(string cnpj){
            if(cnpj != null){
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
                return "cnpj valido";
            }
             return "cnpj invalido";
        }



    }
}