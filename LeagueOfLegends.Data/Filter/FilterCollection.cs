using System;
using System.Collections;
using System.Collections.Generic;

namespace LeagueOfLegends.Data.Filters
{
    public class FilterCollection : ICollection<Filter>
    {
        #region Private Members

        private List<Filter> _innerCollection;

        private bool _isReadOnly = false;

        #endregion Private Members

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterCollection"/> class.
        /// </summary>
        /// <param name="newList">The new list.</param>
        public FilterCollection(List<Filter> newList)
        {
            this._innerCollection = newList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterCollection"/> class.
        /// </summary>
        public FilterCollection()
        {
            this._innerCollection = new List<Filter>();
        }

        #endregion Constructors

        #region Public Properties

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Filter"/> at the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="Filter"/>.
        /// </value>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public Filter this[int index]
        {
            get { return (Filter)this._innerCollection[index]; }
            set { this._innerCollection[index] = value; }
        }

        #endregion Public Properties

        #region ICollection Implementation

        /// <summary>
        /// Gets the number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1" />.
        /// </summary>
        public int Count
        {
            get { return this._innerCollection.Count; }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is read only.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is read only; otherwise, <c>false</c>.
        /// </value>
        public bool IsReadOnly
        {
            get { return this._isReadOnly; }
        }

        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Add(Filter item)
        {
            this._innerCollection.Add(item);
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear()
        {
            this._innerCollection.Clear();
        }

        /// <summary>
        /// Determines whether the <see cref="T:System.Collections.Generic.ICollection`1" /> contains a specific value.
        /// </summary>
        /// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
        /// <returns>
        /// true if <paramref name="item" /> is found in the <see cref="T:System.Collections.Generic.ICollection`1" />; otherwise, false.
        /// </returns>
        public bool Contains(Filter item)
        {
            foreach (Filter i in this._innerCollection)
            {
                if (i.Equals(item))
                {
                    return true;
                }
            }

            return false;   
        }

        /// <summary>
        /// Copies to.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="arrayIndex">Index of the array.</param>
        public void CopyTo(Filter[] array, int arrayIndex)
        {
            for (int i = 0; i < this._innerCollection.Count; i++)
            {
                array[i] = (Filter)this._innerCollection[i];
            }
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<Filter> GetEnumerator()
        {
            return new FilterCollectionEnumerator(this);
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new FilterCollectionEnumerator(this);
        }

        /// <summary>
        /// Removes the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public bool Remove(Filter item)
        {
            bool result = false;

            // Iterate the inner collection to
            // find the box to be removed.
            for (int i = 0; i < this._innerCollection.Count; i++)
            {
                Filter curFilter = (Filter)this._innerCollection[i];

                if (new FilterEqualityComparer().Equals(curFilter, item))
                {
                    this._innerCollection.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }

        #endregion ICollection Implementation
    }
}