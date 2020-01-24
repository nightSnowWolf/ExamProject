using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CatAlog.Db.Extensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<TEntity> OrEmptyIfNull<TEntity>(this IEnumerable<TEntity> source)
        {
            return source ?? Enumerable.Empty<TEntity>();
        }

        public static ObservableCollection<TEntity> ToObservableCollection<TEntity>(this IEnumerable<TEntity> source)
        {
            return new ObservableCollection<TEntity>(source);
        }
    }
}
