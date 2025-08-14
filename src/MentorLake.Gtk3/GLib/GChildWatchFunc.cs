namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Prototype of a #GChildWatchSource callback, called when a child
/// process has exited.
/// </para>
/// <para>
/// To interpret @wait_status, see the documentation for
/// [func@GLib.spawn_check_wait_status]. In particular,
/// on Unix platforms, note that it is usually not equal
/// to the integer passed to `exit()` or returned from `main()`.
/// </para>
/// </summary>

/// <param name="pid">
/// the process id of the child process
/// </param>
/// <param name="wait_status">
/// Status information about the child process, encoded
///               in a platform-specific manner
/// </param>
/// <param name="user_data">
/// user data passed to [func@GLib.child_watch_add]
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GChildWatchFunc(MentorLake.GLib.GPid pid, int wait_status, IntPtr user_data);
