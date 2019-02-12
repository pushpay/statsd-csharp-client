﻿using System.Threading.Tasks;

namespace StatsdClient
{
    /// <summary>
    /// Interface for the statsd.net client
    /// </summary>
    public interface IStatsd
    {
        /// <summary>
        /// Log a count for a metric
        /// </summary>
        Task LogCountAsync(string name, long count = 1);

        /// <summary>
        /// Log a gauge value
        /// </summary>
        Task LogGaugeAsync(string name, long value);

        /// <summary>
        /// Log a gauge value
        /// </summary>
        Task LogGaugeAsync(string name, double value);

        /// <summary>
        /// Log a gauge value
        /// </summary>
        Task LogGaugeAsync(string name, decimal value);

        /// <summary>
        /// Log a latency / Timing
        /// </summary>
        Task LogTimingAsync(string name, long milliseconds);

        /// <summary>
        /// Log the number of unique occurrences of something
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        Task LogSetAsync(string name, long value);

        /// <summary>
        /// Log a calendargram metric
        /// </summary>
        /// <param name="name">The metric namespace</param>
        /// <param name="value">The unique value to be counted in the time period</param>
        /// <param name="period">The time period, can be one of h,d,dow,w,m</param>
        Task LogCalendargramAsync(string name, string value, string period);

        /// <summary>
        /// Log a calendargram metric
        /// </summary>
        /// <param name="name">The metric namespace</param>
        /// <param name="value">The unique value to be counted in the time period</param>
        /// <param name="period">The time period, can be one of h,d,dow,w,m</param>
        Task LogCalendargramAsync(string name, long value, string period);

        /// <summary>
        /// Log a raw metric that will not get aggregated on the server.
        /// </summary>
        /// <param name="name">The metric name.</param>
        /// <param name="value">The metric value.</param>
        /// <param name="epoch">(optional) The epoch timestamp. Leave this blank to have the server assign an epoch for you.</param>
        Task LogRawAsync(string name, long value, long? epoch = null);

        /// <summary>
        /// Log a count for a metric
        /// </summary>
		void LogCount(string name, long count = 1);

        /// <summary>
        /// Log a gauge value
        /// </summary>
		void LogGauge(string name, long value);

        /// <summary>
        /// Log a gauge value
        /// </summary>
        void LogGauge(string name, double value);

        /// <summary>
        /// Log a gauge value
        /// </summary>
        void LogGauge(string name, decimal value);

        /// <summary>
        /// Log a latency / Timing
        /// </summary>
		void LogTiming(string name, long milliseconds);
        
        /// <summary>
        /// Log the number of unique occurrences of something
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        void LogSet(string name, long value);

		/// <summary>
		/// Log a calendargram metric
		/// </summary>
		/// <param name="name">The metric namespace</param>
		/// <param name="value">The unique value to be counted in the time period</param>
		/// <param name="period">The time period, can be one of h,d,dow,w,m</param>
		void LogCalendargram(string name, string value, string period);

		/// <summary>
		/// Log a calendargram metric
		/// </summary>
		/// <param name="name">The metric namespace</param>
		/// <param name="value">The unique value to be counted in the time period</param>
		/// <param name="period">The time period, can be one of h,d,dow,w,m</param>
		void LogCalendargram(string name, long value, string period);

		/// <summary>
		/// Log a raw metric that will not get aggregated on the server.
		/// </summary>
		/// <param name="name">The metric name.</param>
		/// <param name="value">The metric value.</param>
		/// <param name="epoch">(optional) The epoch timestamp. Leave this blank to have the server assign an epoch for you.</param>
		void LogRaw(string name, long value, long? epoch = null);
	}
}