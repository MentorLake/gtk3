namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of the function passed to
/// g_completion_set_compare(). This is used when you use strings as
/// #GCompletion items.
/// </para>
/// </summary>

/// <param name="s1">
/// string to compare with @s2.
/// </param>
/// <param name="s2">
/// string to compare with @s1.
/// </param>
/// <param name="n">
/// maximal number of bytes to compare.
/// </param>
/// <return>
/// an integer less than, equal to, or greater than zero if
///          the first @n bytes of @s1 is found, respectively, to be
///          less than, to match, or to be greater than the first @n
///          bytes of @s2.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GCompletionStrncmpFunc(string s1, string s2, UIntPtr n);
