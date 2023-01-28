namespace DaanV2.Filters {
    ///DOLATER <summary>add description for class: AsyncFilter</summary>
    public partial class AsyncFilter<TFilter>
        where TFilter : IFilter {
        /// <summary>Creates a new instance of <see cref="AsyncFilter{TFilter}"/></summary>
        /// <param name="filter"></param>
        public AsyncFilter(TFilter filter) {
            this._Lock = new ReaderWriterLock();
            this.Filter = filter;
        }
    }
}
