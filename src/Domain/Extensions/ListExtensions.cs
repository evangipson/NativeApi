namespace Domain.Extensions;

/// <summary>
/// An <see langword="extension"/> block for extending <see cref="List{T}"/> functionality.
/// </summary>
public static class ListExtensions
{
    extension<T>(IList<T> list)
    {
        /// <summary>
        /// Gets a random element from an <see cref="IList{T}"/>.
        /// </summary>
        /// <returns>The random <see cref="IList{T}"/> element.</returns>
        /// <exception cref="ArgumentNullException"/>
        /// <exception cref="InvalidOperationException"/>
        public T Random()
        {
            ArgumentNullException.ThrowIfNull(list);

            return list.Count > 0
                ? list[System.Random.Shared.Next(list.Count)]
                : throw new InvalidOperationException("Sequence contains no elements.");
        }

        /// <summary>
        /// Gets a random element from a list, or <see langword="default"/> if the list is empty or <see langword="null"/>.
        /// </summary>
        /// <returns>The random <see cref="IList{T}"/> element or <see langword="default"/>.</returns>
        public T? RandomOrDefault() => list == null || list.Count == 0
            ? default
            : list[System.Random.Shared.Next(list.Count)];
    }
}
