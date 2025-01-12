namespace MentorLake.Gtk3.Gtk3;

public class GtkBindingEntryHandle : BaseSafeHandle
{
}


public static class GtkBindingEntryHandleExtensions
{
}
internal class GtkBindingEntryExterns
{
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
