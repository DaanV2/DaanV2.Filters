namespace DaanV2.Filters {
    public partial class AsyncFilter<TFilter>
        where TFilter : IFilter {

        /// <summary>
        /// 
        /// </summary>
        public TFilter Filter { get; private set; }
    }
}
