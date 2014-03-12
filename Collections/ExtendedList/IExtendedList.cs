using System.Collections.Generic;

namespace ExtendedList
{
    public interface IExtendedList<T>:IList<T>
    {
        #region Properties
        int Capacity { get; }
        bool IsEmpty { get; }
        int FreePositionsLeft { get; }
        #endregion

        #region Methods
        bool RemoveAll(T element);
        bool Compact();
        #endregion

        #region HelperMethods
        T[] ToArray();
        IEnumerable<T> ToList();

        #endregion

        /*

         * */



    }
}