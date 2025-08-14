namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of a function used to test two values for
/// equality. The function should return %TRUE if both values are equal
/// and %FALSE otherwise.
/// </para>
/// </summary>

/// <param name="a">
/// a value
/// </param>
/// <param name="b">
/// a value to compare with
/// </param>
/// <return>
/// %TRUE if @a = @b; %FALSE otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GEqualFunc(IntPtr a, IntPtr b);
