namespace MentorLake.Gtk3.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GCompletionStrncmpFunc(string s1, string s2, UIntPtr n);
