namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The type of functions which are used to translate user-visible
/// strings, for &amp;lt;option&amp;gt;--help&amp;lt;/option&amp;gt; output.
/// </para>
/// </summary>

/// <param name="str">
/// the untranslated string
/// </param>
/// <param name="data">
/// user data specified when installing the function, e.g.
///  in g_option_group_set_translate_func()
/// </param>
/// <return>
/// a translation of the string for the current locale.
///  The returned string is owned by GLib and must not be freed.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string GTranslateFunc(string str, IntPtr data);
