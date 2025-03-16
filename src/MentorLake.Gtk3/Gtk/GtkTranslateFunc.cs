namespace MentorLake.Gtk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string GtkTranslateFunc(string path, IntPtr func_data);
