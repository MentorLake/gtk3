namespace MentorLake.GLibUnix;

public class GLibUnixGlobalFunctions
{

/// <param name="lowfd">
/// </param>

	public static int Closefrom(int lowfd)
	{
		return GLibUnixGlobalFunctionsExterns.g_closefrom(lowfd);
	}



	public static MentorLake.GLib.GQuark ErrorQuark()
	{
		return GLibUnixGlobalFunctionsExterns.g_unix_error_quark();
	}


/// <param name="fd">
/// </param>
/// <param name="condition">
/// </param>
/// <param name="function">
/// </param>
/// <param name="user_data">
/// </param>

	public static uint FdAdd(int fd, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GUnixFDSourceFunc function, IntPtr user_data)
	{
		return GLibUnixGlobalFunctionsExterns.g_unix_fd_add(fd, condition, function, user_data);
	}


/// <param name="priority">
/// </param>
/// <param name="fd">
/// </param>
/// <param name="condition">
/// </param>
/// <param name="function">
/// </param>
/// <param name="user_data">
/// </param>
/// <param name="notify">
/// </param>

	public static uint FdAddFull(int priority, int fd, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GUnixFDSourceFunc function, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GLibUnixGlobalFunctionsExterns.g_unix_fd_add_full(priority, fd, condition, function, user_data, notify);
	}


/// <param name="fd">
/// </param>
/// <param name="condition">
/// </param>

	public static MentorLake.GLib.GSourceHandle FdSourceNew(int fd, MentorLake.GLib.GIOCondition condition)
	{
		return GLibUnixGlobalFunctionsExterns.g_unix_fd_source_new(fd, condition);
	}


/// <param name="lowfd">
/// </param>

	public static int FdwalkSetCloexec(int lowfd)
	{
		return GLibUnixGlobalFunctionsExterns.g_fdwalk_set_cloexec(lowfd);
	}


/// <param name="user_name">
/// </param>

	public static IntPtr GetPasswdEntry(string user_name)
	{
		var externCallResult = GLibUnixGlobalFunctionsExterns.g_unix_get_passwd_entry(user_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}


/// <param name="fds">
/// </param>
/// <param name="flags">
/// </param>

	public static bool OpenPipe(int fds, int flags)
	{
		var externCallResult = GLibUnixGlobalFunctionsExterns.g_unix_open_pipe(fds, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}


/// <param name="fd">
/// </param>
/// <param name="nonblock">
/// </param>

	public static bool SetFdNonblocking(int fd, bool nonblock)
	{
		var externCallResult = GLibUnixGlobalFunctionsExterns.g_unix_set_fd_nonblocking(fd, nonblock, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}


/// <param name="signum">
/// </param>
/// <param name="handler">
/// </param>
/// <param name="user_data">
/// </param>

	public static uint SignalAdd(int signum, MentorLake.GLib.GSourceFunc handler, IntPtr user_data)
	{
		return GLibUnixGlobalFunctionsExterns.g_unix_signal_add(signum, handler, user_data);
	}


/// <param name="priority">
/// </param>
/// <param name="signum">
/// </param>
/// <param name="handler">
/// </param>
/// <param name="user_data">
/// </param>
/// <param name="notify">
/// </param>

	public static uint SignalAddFull(int priority, int signum, MentorLake.GLib.GSourceFunc handler, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GLibUnixGlobalFunctionsExterns.g_unix_signal_add_full(priority, signum, handler, user_data, notify);
	}


/// <param name="signum">
/// </param>

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_unix_fd_source_new(int fd, MentorLake.GLib.GIOCondition condition);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern int g_fdwalk_set_cloexec(int lowfd);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern IntPtr g_unix_get_passwd_entry(string user_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern bool g_unix_open_pipe(int fds, int flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern bool g_unix_set_fd_nonblocking(int fd, bool nonblock, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern uint g_unix_signal_add(int signum, MentorLake.GLib.GSourceFunc handler, IntPtr user_data);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern uint g_unix_signal_add_full(int priority, int signum, MentorLake.GLib.GSourceFunc handler, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibUnixLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_unix_signal_source_new(int signum);

}
