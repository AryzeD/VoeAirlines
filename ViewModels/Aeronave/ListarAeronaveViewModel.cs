//ID, CODIGO, MODELO
//não precisa do fabricante
using VoeAirlines.Entities.Enums;

public class ListarAeronaveViewModel
{
    public ListarAeronaveViewModel(int id, string modelo, string jatinho ,TipoAeronave tipo)
    {
        Id = id;
        Modelo = modelo;
        /* switch (tipo)
        {
            case 0: Tipo = "Comercial";
            break; 
            case 1: Tipo = "Executivo";
            break;
            case 2: Tipo = "Defesa e Segurança";
            break; 
        }; */
        Jatinho = jatinho;
        Tipo = tipo;   
    }

    public int Id { get; set; }
    public string Modelo { get; set; }
    public string Jatinho { get; set; }    
    public TipoAeronave Tipo { get; set; }
    
}