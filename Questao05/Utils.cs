internal partial class Program
{
    /// <summary>
    /// Inverte a ordem dos caracteres de uma string fornecida.
    /// </summary>
    /// <returns>Uma nova string com os caracteres na ordem inversa.</returns>
    public static string InvertString(string str)
    {
        var chars = str.ToCharArray();
        var left = 0;
        var right = chars.Length - 1;

        while (left < right)
        {
            var temp = chars[left];
            chars[left] = chars[right];
            chars[right] = temp;

            left++;
            right--;
        }

        return new string(chars);
    }
}
