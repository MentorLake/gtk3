namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Flags specifying the level of log messages.
/// </para>
/// <para>
/// It is possible to change how GLib treats messages of the various
/// levels using [func@GLib.log_set_handler] and [func@GLib.log_set_fatal_mask].
/// </para>
/// </summary>

[Flags]
public enum GLogLevelFlags : int
{
/// <summary>
/// <para>
/// internal flag
/// </para>
/// </summary>

	G_LOG_FLAG_RECURSION = 1,
/// <summary>
/// <para>
/// internal flag
/// </para>
/// </summary>

	G_LOG_FLAG_FATAL = 2,
/// <summary>
/// <para>
/// log level for errors, see [func@GLib.error].
///   This level is also used for messages produced by [func@GLib.assert].
/// </para>
/// </summary>

	G_LOG_LEVEL_ERROR = 4,
/// <summary>
/// <para>
/// log level for critical warning messages, see
///   [func@GLib.critical]. This level is also used for messages produced by
///   [func@GLib.return_if_fail] and [func@GLib.return_val_if_fail].
/// </para>
/// </summary>

	G_LOG_LEVEL_CRITICAL = 8,
/// <summary>
/// <para>
/// log level for warnings, see [func@GLib.warning]
/// </para>
/// </summary>

	G_LOG_LEVEL_WARNING = 16,
/// <summary>
/// <para>
/// log level for messages, see [func@GLib.message]
/// </para>
/// </summary>

	G_LOG_LEVEL_MESSAGE = 32,
/// <summary>
/// <para>
/// log level for informational messages, see [func@GLib.info]
/// </para>
/// </summary>

	G_LOG_LEVEL_INFO = 64,
/// <summary>
/// <para>
/// log level for debug messages, see [func@GLib.debug]
/// </para>
/// </summary>

	G_LOG_LEVEL_DEBUG = 128,
/// <summary>
/// <para>
/// a mask including all log levels
/// </para>
/// </summary>

	G_LOG_LEVEL_MASK = -4
}
