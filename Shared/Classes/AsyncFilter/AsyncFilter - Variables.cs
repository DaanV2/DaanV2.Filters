namespace DaanV2.Filters {
    public partial class AsyncFilter<TFilter>
        where TFilter : IFilter {

        /// <summary>The lock for the filter</summary>
        private ReaderWriterLock _Lock;
    }
}
