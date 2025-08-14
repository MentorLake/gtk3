namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Declares a type of function which takes no arguments
/// and has no return value. It is used to specify the type
/// function passed to g_atexit().
/// </para>
/// </summary>


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GVoidFunc();
