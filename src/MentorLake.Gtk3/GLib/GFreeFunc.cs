namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Declares a type of function which takes an arbitrary
/// data pointer argument and has no return value. It is
/// not currently used in GLib or GTK.
/// </para>
/// </summary>

/// <param name="data">
/// a data pointer
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GFreeFunc(IntPtr data);
