namespace MentorLake.Gtk;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkModuleInitFunc(int argc, string[] argv);
