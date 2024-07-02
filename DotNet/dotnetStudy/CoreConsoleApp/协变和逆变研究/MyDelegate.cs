namespace CoreConsoleApp.协变和逆变研究
{
    /// <summary>
    /// 非泛型委托
    /// </summary>
    /// <param name="input"></param>
    public delegate void MyActionNo(string input);

    /// <summary>
    /// 不支持协变逆变的泛型委托
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="param"></param>
    public delegate void MyActionCommon<T>(T param);//不支持逆变与协变

    /// <summary>
    /// 支持逆变的泛型委托
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="param"></param>
    public delegate void MyActionIn<in T>(T param);

    /// <summary>
    /// 支持协变的泛型委托
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public delegate T MyActionOut<out T>();

    /// <summary>
    /// 同时支持协变和逆变的泛型委托
    /// </summary>
    /// <typeparam name="P"></typeparam>
    /// <typeparam name="T"></typeparam>
    /// <param name="input"></param>
    /// <returns></returns>
    public delegate T MyActionInOut<in P, out T>(P input);
}
