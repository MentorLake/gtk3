namespace MentorLake.GLibUnix;

/// <summary>
/// <para>
/// The type of functions to be called when a UNIX fd watch source
/// triggers.
/// </para>
/// </summary>

/// <param name="fd">
/// the fd that triggered the event
/// </param>
/// <param name="condition">
/// the IO conditions reported on @fd
/// </param>
/// <param name="user_data">
/// user data passed to g_unix_fd_add()
/// </param>
/// <return>
/// %FALSE if the source should be removed
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GUnixFDSourceFunc(int fd, MentorLake.GLib.GIOCondition condition, IntPtr user_data);
