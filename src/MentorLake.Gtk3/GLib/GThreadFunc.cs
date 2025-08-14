namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of the @func functions passed to g_thread_new()
/// or g_thread_try_new().
/// </para>
/// </summary>

/// <param name="data">
/// data passed to the thread
/// </param>
/// <return>
/// the return value of the thread
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GThreadFunc(IntPtr data);
