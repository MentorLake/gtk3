namespace MentorLake.Gtk3.Gtk3;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GtkClipboardTargetsReceivedFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkClipboardHandle>))] GtkClipboardHandle clipboard, GdkAtom[] atoms, int n_atoms, IntPtr data);
