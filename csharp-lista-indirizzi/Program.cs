using System.Linq.Expressions;

namespace csharp_lista_indirizzi
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Address> addressList = new List<Address>(Path );

            try 
            {
                Address();
                foreach (var address in addressList)
                {
                    Console.WriteLine($"{address.name}, {address.surname}");
                }
            } 
            catch (WrongListingException ex) 
            {
                Console.WriteLine($"Errore nella compilazione della lista {ex.Message}");
            }
            
        }
}