namespace DaanV2.Filters {
    public partial class AsyncFilter<TFilter> : IFilter
        where TFilter : IFilter {

        /// <inheritdoc cref="IFilter.Add(ReadOnlySpan{Byte})"/>
        public void Add(ReadOnlySpan<Byte> data) {
            this.Add(data, -1);
        }

        /// <inheritdoc cref="IFilter.Add(ReadOnlySpan{Byte})"/>
        public void Add(ReadOnlySpan<Byte> data, Int32 msTimeout) {
            this._Lock.AcquireWriterLock(msTimeout);

            try {
                this.Filter.Add(data);
            }
            finally {
                this._Lock.ReleaseWriterLock();
            }
        }

        /// <inheritdoc cref="IFilter.Add(ReadOnlySpan{Byte})"/>
        public void Add(ReadOnlySpan<Byte> data, TimeSpan timeout) {
            this._Lock.AcquireWriterLock(timeout);

            try {
                this.Filter.Add(data);
            }
            finally {
                this._Lock.ReleaseWriterLock();
            }
        }

        /// <inheritdoc cref="IFilter.Has(ReadOnlySpan{Byte})"/>
        public Result Has(ReadOnlySpan<Byte> Data) {
            return this.Has(Data, -1);
        }

        /// <inheritdoc cref="IFilter.Has(ReadOnlySpan{Byte})"/>
        public Result Has(ReadOnlySpan<Byte> data, Int32 msTimeout) {
            this._Lock.AcquireReaderLock(msTimeout);

            try {
                return this.Filter.Has(data);
            }
            finally {
                this._Lock.ReleaseWriterLock();
            }
        }

        /// <inheritdoc cref="IFilter.Has(ReadOnlySpan{Byte})"/>
        public Result Has(ReadOnlySpan<Byte> data, TimeSpan timeout) {
            this._Lock.AcquireReaderLock(timeout);

            try {
                return this.Filter.Has(data);
            }
            finally {
                this._Lock.ReleaseWriterLock();
            }
        }
    }
}
