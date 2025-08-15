namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of a comparison function used to compare two
/// values.  The function should return a negative integer if the first
/// value comes before the second, 0 if they are equal, or a positive
/// integer if the first value comes after the second.
/// </para>
/// </summary>

/// <param name="a">
/// a value
/// </param>
/// <param name="b">
/// a value to compare with
/// </param>
/// <param name="user_data">
/// user data
/// </param>
/// <return>
/// negative value if @a &amp;lt; @b; zero if @a = @b; positive
///          value if @a &amp;gt; @b
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GCompareDataFunc(IntPtr a, IntPtr b, IntPtr user_data);
