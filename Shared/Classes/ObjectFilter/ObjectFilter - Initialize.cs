namespace DaanV2.Filters {
    ///DOLATER <summary>add description for class: FilterWrapper</summary>
    public partial class ObjectFilter<TSerializer, TItem, TFilter>
        where TFilter : IFilter
        where TSerializer : IBinarySerializer<TItem> {

        /// <summary>Creates a new instance of <see cref="ObjectFilter{TSerializer, TItem, TFilter}"/></summary>
        /// <param name="Filter"></param>
        /// <param name="Serializer"></param>
        public ObjectFilter(TFilter Filter, TSerializer Serializer) {
            this._Serializer = Serializer;
            this._Filter = Filter;
        }
    }
}
