namespace DaanV2.Filters {
    public partial class ObjectFilter<TSerializer, TItem, TFilter>
        where TFilter : IFilter
        where TSerializer : IBinarySerializer<TItem> {

        private readonly TSerializer _Serializer;
        private readonly TFilter _Filter;
    }
}
