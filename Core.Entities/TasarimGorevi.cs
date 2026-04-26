namespace Core.Entities
{
    public class TasarimGorevi : Gorev
    {
        public override decimal HakedisHesapla()
        {
            return (HourlyRate * WorkedHours) + 200; // Tasarımda ek ücret olsun
        }
    }
}