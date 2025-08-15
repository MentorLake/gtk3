namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Each key binding element of a binding sets binding list is
/// represented by a GtkBindingEntry.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// Each key binding element of a binding sets binding list is
/// represented by a GtkBindingEntry.
/// </para>
/// </summary>

public struct GtkBindingEntry
{
	/// <summary>
/// <para>
/// key value to match
/// </para>
/// </summary>

public uint keyval;
	/// <summary>
/// <para>
/// key modifiers to match
/// </para>
/// </summary>

public GdkModifierType modifiers;
	/// <summary>
/// <para>
/// binding set this entry belongs to
/// </para>
/// </summary>

public IntPtr binding_set;
	/// <summary>
/// <para>
/// implementation detail
/// </para>
/// </summary>

public uint destroyed;
	/// <summary>
/// <para>
/// implementation detail
/// </para>
/// </summary>

public uint in_emission;
	/// <summary>
/// <para>
/// implementation detail
/// </para>
/// </summary>

public uint marks_unbound;
	/// <summary>
/// <para>
/// linked list of entries maintained by binding set
/// </para>
/// </summary>

public IntPtr set_next;
	/// <summary>
/// <para>
/// implementation detail
/// </para>
/// </summary>

public IntPtr hash_next;
	/// <summary>
/// <para>
/// action signals of this entry
/// </para>
/// </summary>

public IntPtr signals;
/// <summary>
/// <para>
/// Override or install a new key binding for @keyval with @modifiers on
/// @binding_set. When the binding is activated, @signal_name will be
/// emitted on the target widget, with @n_args @Varargs used as
/// arguments.
/// </para>
/// <para>
/// Each argument to the signal must be passed as a pair of varargs: the
/// #GType of the argument, followed by the argument value (which must
/// be of the given type). There must be @n_args pairs in total.
/// </para>
/// <para>
/// ## Adding a Key Binding
/// </para>
/// <code>
/// GtkBindingSet *binding_set;
/// GtkBindingSet *binding_set;
/// GdkModifierType modmask = GDK_CONTROL_MASK;
/// int count = 1;
/// gtk_binding_entry_add_signal (binding_set,
///                               GDK_KEY_space,
///                               modmask,
///                               &quot;move-cursor&quot;, 2,
///                               GTK_TYPE_MOVEMENT_STEP, GTK_MOVEMENT_PAGES,
///                               G_TYPE_INT, count,
///                               G_TYPE_BOOLEAN, FALSE);
/// </code>
/// </summary>

/// <param name="binding_set">
/// a #GtkBindingSet to install an entry for
/// </param>
/// <param name="keyval">
/// key value of binding to install
/// </param>
/// <param name="modifiers">
/// key modifier of binding to install
/// </param>
/// <param name="signal_name">
/// signal to execute upon activation
/// </param>
/// <param name="n_args">
/// number of arguments to @signal_name
/// </param>
/// <param name="@__arglist">
/// arguments to @signal_name
/// </param>

	public static void AddSignal(MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers, string signal_name, uint n_args, IntPtr @__arglist)
	{
		GtkBindingEntryExterns.gtk_binding_entry_add_signal(binding_set, keyval, modifiers, signal_name, n_args, @__arglist);
	}

/// <summary>
/// <para>
/// Parses a signal description from @signal_desc and incorporates
/// it into @binding_set.
/// </para>
/// <para>
/// Signal descriptions may either bind a key combination to
/// one or more signals:
/// <code>
///   bind &quot;key&quot; {
///   bind &quot;key&quot; {
///     &quot;signalname&quot; (param, ...)
///     ...
///   }
/// </code>
/// Or they may also unbind a key combination:
/// <code>
///   unbind &quot;key&quot;
///   unbind &quot;key&quot;
/// </code>
/// Key combinations must be in a format that can be parsed by
/// gtk_accelerator_parse().
/// </para>
/// </summary>

/// <param name="binding_set">
/// a #GtkBindingSet
/// </param>
/// <param name="signal_desc">
/// a signal description
/// </param>
/// <return>
/// %G_TOKEN_NONE if the signal was successfully parsed and added,
///     the expected token otherwise
/// </return>

	public static MentorLake.GLib.GTokenType AddSignalFromString(MentorLake.Gtk.GtkBindingSetHandle binding_set, string signal_desc)
	{
		return GtkBindingEntryExterns.gtk_binding_entry_add_signal_from_string(binding_set, signal_desc);
	}

/// <summary>
/// <para>
/// Override or install a new key binding for @keyval with @modifiers on
/// @binding_set.
/// </para>
/// </summary>

/// <param name="binding_set">
/// a #GtkBindingSet to add a signal to
/// </param>
/// <param name="keyval">
/// key value
/// </param>
/// <param name="modifiers">
/// key modifier
/// </param>
/// <param name="signal_name">
/// signal name to be bound
/// </param>
/// <param name="binding_args">
/// 
///     list of #GtkBindingArg signal arguments
/// </param>

	public static void AddSignall(MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers, string signal_name, MentorLake.GLib.GSListHandle binding_args)
	{
		GtkBindingEntryExterns.gtk_binding_entry_add_signall(binding_set, keyval, modifiers, signal_name, binding_args);
	}

/// <summary>
/// <para>
/// Remove a binding previously installed via
/// gtk_binding_entry_add_signal() on @binding_set.
/// </para>
/// </summary>

/// <param name="binding_set">
/// a #GtkBindingSet to remove an entry of
/// </param>
/// <param name="keyval">
/// key value of binding to remove
/// </param>
/// <param name="modifiers">
/// key modifier of binding to remove
/// </param>

	public static void Remove(MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers)
	{
		GtkBindingEntryExterns.gtk_binding_entry_remove(binding_set, keyval, modifiers);
	}

/// <summary>
/// <para>
/// Install a binding on @binding_set which causes key lookups
/// to be aborted, to prevent bindings from lower priority sets
/// to be activated.
/// </para>
/// </summary>

/// <param name="binding_set">
/// a #GtkBindingSet to skip an entry of
/// </param>
/// <param name="keyval">
/// key value of binding to skip
/// </param>
/// <param name="modifiers">
/// key modifier of binding to skip
/// </param>

	public static void Skip(MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers)
	{
		GtkBindingEntryExterns.gtk_binding_entry_skip(binding_set, keyval, modifiers);
	}

}
