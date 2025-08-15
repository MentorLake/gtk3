namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GMemoryMonitor` will monitor system memory and suggest to the application
/// when to free memory so as to leave more room for other applications.
/// It is implemented on Linux using the
/// [Low Memory Monitor](https://gitlab.freedesktop.org/hadess/low-memory-monitor/)
/// ([API documentation](https://hadess.pages.freedesktop.org/low-memory-monitor/)).
/// </para>
/// <para>
/// There is also an implementation for use inside Flatpak sandboxes.
/// </para>
/// <para>
/// Possible actions to take when the signal is received are:
/// </para>
/// <para>
///  - Free caches
///  - Save files that haven’t been looked at in a while to disk, ready to be reopened when needed
///  - Run a garbage collection cycle
///  - Try and compress fragmented allocations
///  - Exit on idle if the process has no reason to stay around
///  - Call &amp;lt;see href=&quot;man:malloc_trim(3&quot;&amp;gt;malloc_trim(3)&amp;lt;/see&amp;gt;) to return cached heap pages to
///    the kernel (if supported by your libc)
/// </para>
/// <para>
/// Note that some actions may not always improve system performance, and so
/// should be profiled for your application. `malloc_trim()`, for example, may
/// make future heap allocations slower (due to releasing cached heap pages back
/// to the kernel).
/// </para>
/// <para>
/// See [type@Gio.MemoryMonitorWarningLevel] for details on the various warning
/// levels.
/// </para>
/// <para>
/// ```c
/// static void
/// warning_cb (GMemoryMonitor *m, GMemoryMonitorWarningLevel level)
/// {
///   g_debug (&quot;Warning level: %d&quot;, level);
///   if (warning_level &amp;gt; G_MEMORY_MONITOR_WARNING_LEVEL_LOW)
///     drop_caches ();
/// }
/// </para>
/// <para>
/// static GMemoryMonitor *
/// monitor_low_memory (void)
/// {
///   GMemoryMonitor *m;
///   m = g_memory_monitor_dup_default ();
///   g_signal_connect (G_OBJECT (m), &quot;low-memory-warning&quot;,
///                     G_CALLBACK (warning_cb), NULL);
///   return m;
/// }
/// ```
/// </para>
/// <para>
/// Don’t forget to disconnect the [signal@Gio.MemoryMonitor::low-memory-warning]
/// signal, and unref the `GMemoryMonitor` itself when exiting.
/// </para>
/// </summary>

public interface GMemoryMonitorHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GMemoryMonitorHandleImpl : BaseSafeHandle, GMemoryMonitorHandle
{
}

public static class GMemoryMonitorHandleExtensions
{
/// <summary>
/// <para>
/// Gets a reference to the default #GMemoryMonitor for the system.
/// </para>
/// </summary>

/// <return>
/// a new reference to the default #GMemoryMonitor
/// </return>

	public static MentorLake.Gio.GMemoryMonitorHandle DupDefault()
	{
		return GMemoryMonitorHandleExterns.g_memory_monitor_dup_default();
	}

}

internal class GMemoryMonitorHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMemoryMonitorHandleImpl>))]
	internal static extern MentorLake.Gio.GMemoryMonitorHandle g_memory_monitor_dup_default();

}
