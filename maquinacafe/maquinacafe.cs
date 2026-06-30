namespace MaquinaCafe
{
    public class MaquinaCafe
    {

        public int Vasos { get; set; } = 10;

        public bool CafeDisponible { get; set; } = true;


        public Cafe PrepararCafe(string tamaño, int azucar)
        {
            Cafe cafe = new Cafe();

            if(Vasos <= 0)
            {
                cafe.Mensaje = "No existen vasos disponibles";
                return cafe;
            }


            if(!CafeDisponible)
            {
                cafe.Mensaje = "No existe cafe disponible";
                return cafe;
            }


            if(tamaño == "Pequeno")
                cafe.Oz = 3;


            if(tamaño == "Mediano")
                cafe.Oz = 5;


            if(tamaño == "Grande")
                cafe.Oz = 7;


            cafe.Azucar = azucar;

            Vasos--;

            cafe.Mensaje = "Cafe preparado correctamente";


            return cafe;
        }
    }
}