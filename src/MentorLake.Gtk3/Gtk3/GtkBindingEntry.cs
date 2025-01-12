namespace MentorLake.Gtk3.Gtk3;

public class GtkBindingEntryHandle : BaseSafeHandle
{
}


public static class GtkBindingEntryHandleExtensions
{
	public static void AddSignal(GtkBindingSetHandle binding_set, uint keyval, GdkModifierType modifiers, string signal_name, uint n_args, IntPtr @__arglist)
	{
		GtkBindingEntryExterns.gtk_binding_entry_add_signal(binding_set, keyval, modifiers, signal_name, n_args, @__arglist);
	}

	public static GTokenType AddSignalFromString(GtkBindingSetHandle binding_set, string signal_desc)
	{
		return GtkBindingEntryExterns.gtk_binding_entry_add_signal_from_string(binding_set, signal_desc);
	}

	public static void AddSignall(GtkBindingSetHandle binding_set, uint keyval, GdkModifierType modifiers, string signal_name, GSListHandle binding_args)
	{
		GtkBindingEntryExterns.gtk_binding_entry_add_signall(binding_set, keyval, modifiers, signal_name, binding_args);
	}

	public static void Remove(GtkBindingSetHandle binding_set, uint keyval, GdkModifierType modifiers)
	{
		GtkBindingEntryExterns.gtk_binding_entry_remove(binding_set, keyval, modifiers);
	}

	public static void Skip(GtkBindingSetHandle binding_set, uint keyval, GdkModifierType modifiers)
	{
		GtkBindingEntryExterns.gtk_binding_entry_skip(binding_set, keyval, modifiers);
	}

}
internal class GtkBindingEntryExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_binding_entry_add_signal(GtkBindingSetHandle binding_set, uint keyval, GdkModifierType modifiers, string signal_name, uint n_args, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern GTokenType gtk_binding_entry_add_signal_from_string(GtkBindingSetHandle binding_set, string signal_desc);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_binding_entry_add_signall(GtkBindingSetHandle binding_set, uint keyval, GdkModifierType modifiers, string signal_name, GSListHandle binding_args);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_binding_entry_remove(GtkBindingSetHandle binding_set, uint keyval, GdkModifierType modifiers);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_binding_entry_skip(GtkBindingSetHandle binding_set, uint keyval, GdkModifierType modifiers);

}

public struct GtkBindingEntry
{
	public uint keyval;
	public GdkModifierType modifiers;
	public GtkBindingSetHandle binding_set;
	public uint destroyed;
	public uint in_emission;
	public uint marks_unbound;
	public GtkBindingEntryHandle set_next;
	public GtkBindingEntryHandle hash_next;
	public GtkBindingSignalHandle signals;
}
