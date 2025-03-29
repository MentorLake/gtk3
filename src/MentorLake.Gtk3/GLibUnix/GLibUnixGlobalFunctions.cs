namespace MentorLake.GLibUnix;

public class GLibUnixGlobalFunctions
{
	public static int Closefrom(int lowfd)
	{
		return GLibUnixGlobalFunctionsExterns.g_closefrom(lowfd);
	}

	public static MentorLake.GLib.GQuark ErrorQuark()
	{
		return GLibUnixGlobalFunctionsExterns.g_unix_error_quark();
	}

	public static uint FdAdd(int fd, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GUnixFDSourceFunc function, IntPtr user_data)
	{
		return GLibUnixGlobalFunctionsExterns.g_unix_fd_add(fd, condition, function, user_data);
	}

	public static uint FdAddFull(int priority, int fd, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GUnixFDSourceFunc function, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GLibUnixGlobalFunctionsExterns.g_unix_fd_add_full(priority, fd, condition, function, user_data, notify);
	}

	public static MentorLake.GLib.GSourceHandle FdSourceNew(int fd, MentorLake.GLib.GIOCondition condition)
	{
		return GLibUnixGlobalFunctionsExterns.g_unix_fd_source_new(fd, condition);
	}

	public static int FdwalkSetCloexec(int lowfd)
	{
		return GLibUnixGlobalFunctionsExterns.g_fdwalk_set_cloexec(lowfd);
	}

	public static IntPtr GetPasswdEntry(string user_name, IntPtr error)
	{
		return GLibUnixGlobalFunctionsExterns.g_unix_get_passwd_entry(user_name, error);
	}

	public static bool OpenPipe(int fds, int flags, IntPtr error)
	{
		return GLibUnixGlobalFunctionsExterns.g_unix_open_pipe(fds, flags, error);
	}

	public static bool SetFdNonblocking(int fd, bool nonblock, IntPtr error)
	{
		return GLibUnixGlobalFunctionsExterns.g_unix_set_fd_nonblocking(fd, nonblock, error);
	}

	public static uint SignalAdd(int signum, MentorLake.GLib.GSourceFunc handler, IntPtr user_data)
	{
		return GLibUnixGlobalFunctionsExterns.g_unix_signal_add(signum, handler, user_data);
	}

	public static uint SignalAddFull(int priority, int signum, MentorLake.GLib.GSourceFunc handler, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GLibUnixGlobalFunctionsExterns.g_unix_signal_add_full(priority, signum, handler, user_data, notify);
	}

	public static MentorLake.GLib.GSourceHandle SignalSourceNew(int signum)
	{
		return GLibUnixGlobalFunctionsExterns.g_unix_signal_source_new(signum);
	}

}

internal class GLibUnixGlobalFunctionsExterns
{
	[DllImport(GLibUnixLibrary.Name)]
	internal static extern int g_closefrom(int lowfd);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_unix_error_quark();

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern uint g_unix_fd_add(int fd, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GUnixFDSourceFunc function, IntPtr user_data);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern uint g_unix_fd_add_full(int priority, int fd, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GUnixFDSourceFunc function, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_unix_fd_source_new(int fd, MentorLake.GLib.GIOCondition condition);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern int g_fdwalk_set_cloexec(int lowfd);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern IntPtr g_unix_get_passwd_entry(string user_name, IntPtr error);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern bool g_unix_open_pipe(int fds, int flags, IntPtr error);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern bool g_unix_set_fd_nonblocking(int fd, bool nonblock, IntPtr error);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern uint g_unix_signal_add(int signum, MentorLake.GLib.GSourceFunc handler, IntPtr user_data);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern uint g_unix_signal_add_full(int priority, int signum, MentorLake.GLib.GSourceFunc handler, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_unix_signal_source_new(int signum);

}
