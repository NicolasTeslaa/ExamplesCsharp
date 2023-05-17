namespace LINQ
{
    public class Convert
    {

        // TO LIST - Converte um IEnumerable<T> para um List<T>
        List<int> lista = new[] { 1, 2, 3, 4, 5 }.ToList();


        // TO ARRAY - Converte um IEnumerable<T> para um Array<T>
        int[] array = new List<int> { 1, 2, 3, 4, 5 }.ToArray();
    }
}