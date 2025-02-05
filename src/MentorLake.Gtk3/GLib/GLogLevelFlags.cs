namespace MentorLake.Gtk3.GLib;

[Flags]
public enum GLogLevelFlags
{
	G_LOG_FLAG_RECURSION = 0,
	G_LOG_FLAG_FATAL = 1,
	G_LOG_LEVEL_ERROR = 2,
	G_LOG_LEVEL_CRITICAL = 4,
	G_LOG_LEVEL_WARNING = 8,
	G_LOG_LEVEL_MESSAGE = 16,
	G_LOG_LEVEL_INFO = 32,
	G_LOG_LEVEL_DEBUG = 64,
	G_LOG_LEVEL_MASK = 128
}
