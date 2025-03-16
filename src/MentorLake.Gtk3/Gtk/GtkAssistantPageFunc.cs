namespace MentorLake.Gtk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GtkAssistantPageFunc(int current_page, IntPtr data);
