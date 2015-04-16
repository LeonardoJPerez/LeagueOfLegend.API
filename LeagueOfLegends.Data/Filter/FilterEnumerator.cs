using System;
using System.Collections;
using System.Collections.Generic;

namespace LeagueOfLegends.Data.Filters
{
    public class FilterCollectionEnumerator : IEnumerator<Filter>
    {
        private FilterCollection _collection;
        private Filter curFilter;
        private int curIndex;

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterCollectionEnumerator"/> class.
        /// </summary>
        /// <param name="collection">The collection.</param>
        public FilterCollectionEnumerator(FilterCollection collection)
        {
            _collection = collection;
            curIndex = -1;
            curFilter = default(Filter);
        }

        /// <summary>
        /// Gets the element in the collection at the current position of the enumerator.
        /// </summary>
        public Filter Current
        {
            get { return curFilter; }
        }

        /// <summary>
        /// Gets the element in the collection at the current position of the enumerator.
        /// </summary>
        object IEnumerator.Current
        {
            get { return Current; }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        void IDisposable.Dispose()
        {
        }

        /// <summary>
        /// Advances the enumerator to the next element of the collection.
        /// </summary>
        /// <returns>
        /// true if the enumerator was successfully advanced to the next element; false if the enumerator has passed the end of the collection.
        /// </returns>
        public bool MoveNext()
        {
            //Avoids going beyond the end of the collection.
            if (++curIndex >= _collection.Count)
            {
                return false;
            }
            else
            {
                // Set current box to next item in collection.
                curFilter = _collection[curIndex];
            }
            return true;
        }

        /// <summary>
        /// Sets the enumerator to its initial position, which is before the first element in the collection.
        /// </summary>
        public void Reset()
        {
            curIndex = -1;
        }
    }
}