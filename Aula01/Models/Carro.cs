namespace Aula01.Models
{
    public class Carro
    {

        //PROPRIEDADES(ATRIBUTOS/CARACTERISTICAS)
        
        public string Marca { get; set; }
        
        public string Modelo { get; set; }

        public string Cor {  get; set; }

        //MÉTODOS (AÇÕES)

        public string Acelerar()
        {
            return $"O {Modelo} {Marca} está acelerando"
        }
    }
}
