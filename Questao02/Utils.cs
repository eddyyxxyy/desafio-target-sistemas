internal partial class Program
{
    /// <summary>
    /// Verifica se um número é um quadrado perfeito.
    /// </summary>
    static bool IsPerfectSquare(ulong n)
    {
        ulong root = (ulong)Math.Sqrt(n);
        return root * root == n;
    }

    /// <summary>
    /// Determina se um número pertence à sequência de Fibonacci usando a regra dos quadrados perfeitos.
    /// </summary>
    static bool IsFibonacciWithPerfectSquare(ulong num)
    {
        ulong n1 = 5 * num * num + 4;
        ulong n2 = 5 * num * num - 4;

        return IsPerfectSquare(n1) || IsPerfectSquare(n2);
    }
    
    // /// <summary>
    // /// Determina se um número pertence à sequência de Fibonacci usando iterações contínuas.
    // /// </summary>
    // /// <returns>
    // /// <c>true</c> se o número pertence à sequência de Fibonacci ou <c>false</c> se não for.
    // /// </returns>
    // /// <remarks>
    // /// Método que pode ser utilizado em número menores com as limitações do tipo <c>ulong</c>
    // /// e é a que geralmente utilizo em iterações pequenas.
    // /// </remarks>
    // static bool IsFibonacciWithIteration(ulong num)
    // {
    //     ulong a = 0, b = 1;

    //     while (a <= num)
    //     {
    //         if (a == num) return true;

    //         ulong temp = a;
    //         a = b;
    //         b = temp + b;
    //     }

    //     return false;
    // }
}
