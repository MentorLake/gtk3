namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The function used to translate messages in e.g. #GtkIconFactory
/// and #GtkActionGroup.
/// </para>
/// </summary>

/// <param name="path">
/// The id of the message. In #GtkActionGroup this will be a label
///   or tooltip from a #GtkActionEntry.
/// </param>
/// <param name="func_data">
/// user data passed in when registering the
///   function
/// </param>
/// <return>
/// the translated message
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string GtkTranslateFunc(string path, IntPtr func_data);
