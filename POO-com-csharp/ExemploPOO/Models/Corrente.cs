namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            base.saldo = valor; //base referencia ao atributo da classe pai, porém o this também funciona
        }
    }
}