namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A source function that is only called once before being removed from the main
/// context automatically.
/// </para>
/// <para>
/// See: [func@GLib.idle_add_once], [func@GLib.timeout_add_once]
/// </para>
/// </summary>

/// <param name="user_data">
/// data passed to the function, set when the source was
///   created
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GSourceOnceFunc(IntPtr user_data);
