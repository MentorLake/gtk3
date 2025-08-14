namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of a function used to test two values for
/// equality. The function should return %TRUE if both values are equal
/// and %FALSE otherwise.
/// </para>
/// <para>
/// This is a version of #GEqualFunc which provides a @user_data closure from
/// the caller.
/// </para>
/// </summary>

/// <param name="a">
/// a value
/// </param>
/// <param name="b">
/// a value to compare with
/// </param>
/// <param name="user_data">
/// user data provided by the caller
/// </param>
/// <return>
/// %TRUE if @a = @b; %FALSE otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GEqualFuncFull(IntPtr a, IntPtr b, IntPtr user_data);
