namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A binding set maintains a list of activatable key bindings.
/// A single binding set can match multiple types of widgets.
/// Similar to style contexts, can be matched by any information contained
/// in a widgets #GtkWidgetPath. When a binding within a set is matched upon
/// activation, an action signal is emitted on the target widget to carry out
/// the actual activation.
/// </para>
/// </summary>

public class GtkBindingSetHandle : BaseSafeHandle
{
}


public static class GtkBindingSetExtensions
{
/// <summary>
/// <para>
/// Find a key binding matching @keyval and @modifiers within
/// @binding_set and activate the binding on @object.
/// </para>
/// </summary>

/// <param name="binding_set">
/// a #GtkBindingSet set to activate
/// </param>
/// <param name="keyval">
/// key value of the binding
/// </param>
/// <param name="modifiers">
/// key modifier of the binding
/// </param>
/// <param name="@object">
/// object to activate when binding found
/// </param>
/// <return>
/// %TRUE if a binding was found and activated
/// </return>

	public static bool Activate(this MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers, MentorLake.GObject.GObjectHandle @object)
	{
		if (binding_set.IsInvalid) throw new Exception("Invalid handle (GtkBindingSet)");
		return GtkBindingSetExterns.gtk_binding_set_activate(binding_set, keyval, modifiers, @object);
	}

/// <summary>
/// <para>
/// This function was used internally by the GtkRC parsing mechanism
/// to assign match patterns to #GtkBindingSet structures.
/// </para>
/// <para>
/// In GTK+ 3, these match patterns are unused.
/// </para>
/// </summary>

/// <param name="binding_set">
/// a #GtkBindingSet to add a path to
/// </param>
/// <param name="path_type">
/// path type the pattern applies to
/// </param>
/// <param name="path_pattern">
/// the actual match pattern
/// </param>
/// <param name="priority">
/// binding priority
/// </param>

	public static void AddPath(this MentorLake.Gtk.GtkBindingSetHandle binding_set, MentorLake.Gtk.GtkPathType path_type, string path_pattern, MentorLake.Gtk.GtkPathPriorityType priority)
	{
		if (binding_set.IsInvalid) throw new Exception("Invalid handle (GtkBindingSet)");
		GtkBindingSetExterns.gtk_binding_set_add_path(binding_set, path_type, path_pattern, priority);
	}


	public static GtkBindingSet Dereference(this GtkBindingSetHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkBindingSet>(x.DangerousGetHandle());
}
internal class GtkBindingSetExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_binding_set_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBindingSetHandle>))] MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_binding_set_add_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBindingSetHandle>))] MentorLake.Gtk.GtkBindingSetHandle binding_set, MentorLake.Gtk.GtkPathType path_type, string path_pattern, MentorLake.Gtk.GtkPathPriorityType priority);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBindingSetHandle>))]
	internal static extern MentorLake.Gtk.GtkBindingSetHandle gtk_binding_set_by_class(IntPtr object_class);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBindingSetHandle>))]
	internal static extern MentorLake.Gtk.GtkBindingSetHandle gtk_binding_set_find(string set_name);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBindingSetHandle>))]
	internal static extern MentorLake.Gtk.GtkBindingSetHandle gtk_binding_set_new(string set_name);

}

/// <summary>
/// <para>
/// A binding set maintains a list of activatable key bindings.
/// A single binding set can match multiple types of widgets.
/// Similar to style contexts, can be matched by any information contained
/// in a widgets #GtkWidgetPath. When a binding within a set is matched upon
/// activation, an action signal is emitted on the target widget to carry out
/// the actual activation.
/// </para>
/// </summary>

public struct GtkBindingSet
{
	/// <summary>
/// <para>
/// unique name of this binding set
/// </para>
/// </summary>

public string set_name;
	/// <summary>
/// <para>
/// unused
/// </para>
/// </summary>

public int priority;
	/// <summary>
/// <para>
/// unused
/// </para>
/// </summary>

public IntPtr widget_path_pspecs;
	/// <summary>
/// <para>
/// unused
/// </para>
/// </summary>

public IntPtr widget_class_pspecs;
	/// <summary>
/// <para>
/// unused
/// </para>
/// </summary>

public IntPtr class_branch_pspecs;
	/// <summary>
/// <para>
/// the key binding entries in this binding set
/// </para>
/// </summary>

public IntPtr entries;
	/// <summary>
/// <para>
/// implementation detail
/// </para>
/// </summary>

public IntPtr current;
	/// <summary>
/// <para>
/// whether this binding set stems from a CSS file and is reset upon theme changes
/// </para>
/// </summary>

public uint parsed;
/// <summary>
/// <para>
/// This function returns the binding set named after the type name of
/// the passed in class structure. New binding sets are created on
/// demand by this function.
/// </para>
/// </summary>

/// <param name="object_class">
/// a valid #GObject class
/// </param>
/// <return>
/// the binding set corresponding to
///     @object_class
/// </return>

	public static MentorLake.Gtk.GtkBindingSetHandle ByClass(IntPtr object_class)
	{
		return GtkBindingSetExterns.gtk_binding_set_by_class(object_class);
	}

/// <summary>
/// <para>
/// Find a binding set by its globally unique name.
/// </para>
/// <para>
/// The @set_name can either be a name used for gtk_binding_set_new()
/// or the type name of a class used in gtk_binding_set_by_class().
/// </para>
/// </summary>

/// <param name="set_name">
/// unique binding set name
/// </param>
/// <return>
/// %NULL or the specified binding set
/// </return>

	public static MentorLake.Gtk.GtkBindingSetHandle Find(string set_name)
	{
		return GtkBindingSetExterns.gtk_binding_set_find(set_name);
	}

/// <summary>
/// <para>
/// GTK+ maintains a global list of binding sets. Each binding set has
/// a unique name which needs to be specified upon creation.
/// </para>
/// </summary>

/// <param name="set_name">
/// unique name of this binding set
/// </param>
/// <return>
/// new binding set
/// </return>

	public static MentorLake.Gtk.GtkBindingSetHandle New(string set_name)
	{
		return GtkBindingSetExterns.gtk_binding_set_new(set_name);
	}

}
