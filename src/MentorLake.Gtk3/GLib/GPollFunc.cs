namespace MentorLake.Gtk3.GLib;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GPollFunc(GPollFD[] ufds, uint nfsd, int timeout_);
