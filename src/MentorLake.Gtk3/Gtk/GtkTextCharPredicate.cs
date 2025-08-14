namespace MentorLake.Gtk;


/// <param name="ch">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GtkTextCharPredicate(char ch, IntPtr user_data);
