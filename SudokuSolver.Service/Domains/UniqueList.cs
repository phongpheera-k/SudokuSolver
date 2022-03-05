using System.Collections;

namespace SudokuSolver.Service.Domains;

public class UniqueList<T> : IList<T>
{
    private readonly IList<T> _list = new List<T>();
    public IEnumerator<T> GetEnumerator() => _list.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Add(T item)
    {
        if (_list.Contains(item))
            throw new ArgumentException();

        _list.Add(item);
    }

    public void Clear() => _list.Clear();

    public bool Contains(T item) => _list.Contains(item);

    public void CopyTo(T[] array, int arrayIndex) => _list.CopyTo(array, arrayIndex);

    public bool Remove(T item) => _list.Remove(item);

    public int Count => _list.Count;
    public bool IsReadOnly => _list.IsReadOnly;
    public int IndexOf(T item) => _list.IndexOf(item);

    public void Insert(int index, T item)
    {
        if (_list.Contains(item))
            throw new ArgumentException();

        _list.Insert(index, item);
    }

    public void RemoveAt(int index) => _list.RemoveAt(index);

    public T this[int index]
    {
        get => _list[index];
        set => _list[index] = value;
    }
}