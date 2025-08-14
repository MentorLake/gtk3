namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A function used by gtk_assistant_set_forward_page_func() to know which
/// is the next page given a current one. It’s called both for computing the
/// next page when the user presses the “forward” button and for handling
/// the behavior of the “last” button.
/// </para>
/// </summary>

/// <param name="current_page">
/// The page number used to calculate the next page.
/// </param>
/// <param name="data">
/// user data.
/// </param>
/// <return>
/// The next page number.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkAssistantPageFunc(int current_page, IntPtr data);
