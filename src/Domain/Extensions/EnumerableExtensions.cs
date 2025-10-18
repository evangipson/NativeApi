namespace Domain.Extensions;

/// <summary>
/// An <see langword="extension"/> block for extending <see cref="IEnumerable{T}"/> functionality.
/// </summary>
public static class EnumerableExtensions
{
    extension<T>(IEnumerable<T> enumerable)
    {
        /// <summary>
        /// Gets a random element from an <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <returns>The random element.</returns>
        /// <exception cref="ArgumentNullException"/>
        /// <exception cref="InvalidOperationException"/>
        public T Random()
        {
            ArgumentNullException.ThrowIfNull(enumerable);

            // if the enumerable is already an ICollection<T> (like List<T> or T[]),
            // avoid unnecessary materialization and use the Count property directly.
            if (enumerable is ICollection<T> collection)
            {
                return collection.Count == 0
                    ? throw new InvalidOperationException("Sequence contains no elements.")
                    : collection.ElementAt(System.Random.Shared.Next(collection.Count));
            }

            // materialization for general IEnumerable<T> to ensure single enumeration,
            // O(1) random access, and correct count determination.
            var materialized = enumerable.ToArray();
            return materialized.Length == 0
                ? throw new InvalidOperationException("Sequence contains no elements.")
                : materialized[System.Random.Shared.Next(materialized.Length)];
        }

        /// <summary>
        /// Gets a random element from an enumerable collection, or <see langword="default"/>
        /// if the collection is empty or <see langword="null"/>.
        /// </summary>
        /// <returns>The random element or <see langword="default"/>.</returns>
        public T? RandomOrDefault()
        {
            // if the enumerable is null, no need to materialize at all, return default.
            if (enumerable == null)
            {
                return default;
            }

            // if the enumerable is already an ICollection<T> (like List<T> or T[]),
            // avoid unnecessary materialization and use the Count property directly.
            if (enumerable is ICollection<T> collection)
            {
                return collection.Count == 0
                    ? default
                    : collection.ElementAt(System.Random.Shared.Next(collection.Count));
            }

            // materialization for general IEnumerable<T> to ensure single enumeration,
            // O(1) random access, and correct count determination.
            var materialized = enumerable.ToArray();
            return materialized.Length == 0
                ? default
                : materialized[System.Random.Shared.Next(materialized.Length)];
        }
    }
}
