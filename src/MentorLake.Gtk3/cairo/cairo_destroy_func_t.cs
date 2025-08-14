namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_destroy_func_t the type of function which is called when a
/// data element is destroyed. It is passed the pointer to the data
/// element and should free any memory and resources allocated for it.
/// </para>
/// </summary>

/// <param name="data">
/// The data element being destroyed.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cairo_destroy_func_t(IntPtr data);
