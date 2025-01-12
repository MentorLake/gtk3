namespace MentorLake.Gtk3.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GFileProgressCallback(int current_num_bytes, int total_num_bytes, IntPtr data);
