namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The type used for callback functions in structure definitions and function
/// signatures.
/// </para>
/// <para>
/// This doesn&apos;t mean that all callback functions must take no  parameters and
/// return void. The required signature of a callback function is determined by
/// the context in which is used (e.g. the signal to which it is connected).
/// </para>
/// <para>
/// Use G_CALLBACK() to cast the callback function to a #GCallback.
/// </para>
/// </summary>


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GCallback();
