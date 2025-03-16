namespace MentorLake.Gtk;

public class GtkBindingEntryHandle : BaseSafeHandle
{
}


public static class GtkBindingEntryExtensions
{

	public static GtkBindingEntry Dereference(this GtkBindingEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkBindingEntry>(x.DangerousGetHandle());
}
internal class GtkBindingEntryExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_binding_entry_add_signal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBindingSetHandle>))] MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers, string signal_name, uint n_args, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GTokenType gtk_binding_entry_add_signal_from_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBindingSetHandle>))] MentorLake.Gtk.GtkBindingSetHandle binding_set, string signal_desc);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_binding_entry_add_signall([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBindingSetHandle>))] MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers, string signal_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle binding_args);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_binding_entry_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBindingSetHandle>))] MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_binding_entry_skip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBindingSetHandle>))] MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers);

}

public struct GtkBindingEntry
{
	public uint keyval;
	public GdkModifierType modifiers;
	public IntPtr binding_set;
	public uint destroyed;
	public uint in_emission;
	public uint marks_unbound;
	public IntPtr set_next;
	public IntPtr hash_next;
	public IntPtr signals;
	public static void AddSignal(MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers, string signal_name, uint n_args, IntPtr @__arglist)
	{
		GtkBindingEntryExterns.gtk_binding_entry_add_signal(binding_set, keyval, modifiers, signal_name, n_args, @__arglist);
	}

	public static MentorLake.GLib.GTokenType AddSignalFromString(MentorLake.Gtk.GtkBindingSetHandle binding_set, string signal_desc)
	{
		return GtkBindingEntryExterns.gtk_binding_entry_add_signal_from_string(binding_set, signal_desc);
	}

	public static void AddSignall(MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers, string signal_name, MentorLake.GLib.GSListHandle binding_args)
	{
		GtkBindingEntryExterns.gtk_binding_entry_add_signall(binding_set, keyval, modifiers, signal_name, binding_args);
	}

	public static void Remove(MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers)
	{
		GtkBindingEntryExterns.gtk_binding_entry_remove(binding_set, keyval, modifiers);
	}

	public static void Skip(MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers)
	{
		GtkBindingEntryExterns.gtk_binding_entry_skip(binding_set, keyval, modifiers);
	}

}
