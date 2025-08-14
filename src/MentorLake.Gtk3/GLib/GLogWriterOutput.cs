namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Return values from #GLogWriterFuncs to indicate whether the given log entry
/// was successfully handled by the writer, or whether there was an error in
/// handling it (and hence a fallback writer should be used).
/// </para>
/// <para>
/// If a #GLogWriterFunc ignores a log entry, it should return
/// %G_LOG_WRITER_HANDLED.
/// </para>
/// </summary>

[Flags]
public enum GLogWriterOutput
{
/// <summary>
/// <para>
/// Log writer has handled the log entry.
/// </para>
/// </summary>

	G_LOG_WRITER_HANDLED = 1,
/// <summary>
/// <para>
/// Log writer could not handle the log entry.
/// </para>
/// </summary>

	G_LOG_WRITER_UNHANDLED = 0
}
