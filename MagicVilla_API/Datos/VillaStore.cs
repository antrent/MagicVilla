using MagicVilla_API.Modelos.Dto;

namespace MagicVilla_API.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
         {
             new VillaDto {Id=1, Name= "Vista a la piscina"},
             new VillaDto {Id=2, Name= "Vista a la Playa"}
         };
    }
}
