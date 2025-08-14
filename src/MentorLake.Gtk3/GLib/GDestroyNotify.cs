namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of function which is called when a data element
/// is destroyed. It is passed the pointer to the data element and
/// should free any memory and resources allocated for it.
/// </para>
/// </summary>

/// <param name="data">
/// the data element.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GDestroyNotify(IntPtr data);
