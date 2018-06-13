namespace SandDiag
{
    /// <summary>
    /// summary of IFoo
    /// </summary>
    public interface IFoo
    {
        /// <summary>
        /// summary of Bar
        /// </summary>
        /// <param name="someTuple">s/be an int and a string</param>
        void Bar((int, string) someTuple);
        /// <summary>
        /// summary of Qux
        /// </summary>
        /// <returns>s/be a (int, string) or a ValueTuple&lt;int, string></returns>
        (int, string) Qux();
    }
}
