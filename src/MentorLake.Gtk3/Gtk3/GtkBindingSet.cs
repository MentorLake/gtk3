namespace MentorLake.Gtk3.Gtk3;

public class GtkBindingSetHandle : BaseSafeHandle
{
}


public static class GtkBindingSetHandleExtensions
{
	public static bool Activate(this GtkBindingSetHandle binding_set, uint keyval, GdkModifierType modifiers, GObjectHandle @object)
	{
		return GtkBindingSetExterns.gtk_binding_set_activate(binding_set, keyval, modifiers, @object);
	}

	public static T AddPath<T>(this T binding_set, GtkPathType path_type, string path_pattern, GtkPathPriorityType priority) where T : GtkBindingSetHandle
	{
		GtkBindingSetExterns.gtk_binding_set_add_path(binding_set, path_type, path_pattern, priority);
		return binding_set;
	}

	public static GtkBindingSetHandle ByClass(IntPtr object_class)
	{
		return GtkBindingSetExterns.gtk_binding_set_by_class(object_class);
	}

	public static GtkBindingSetHandle Find(string set_name)
	{
		return GtkBindingSetExterns.gtk_binding_set_find(set_name);
	}

	public static GtkBindingSetHandle New(string set_name)
	{
		return GtkBindingSetExterns.gtk_binding_set_new(set_name);
	}

}
internal class GtkBindingSetExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_binding_set_activate(GtkBindingSetHandle binding_set, uint keyval, GdkModifierType modifiers, GObjectHandle @object);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_binding_set_add_path(GtkBindingSetHandle binding_set, GtkPathType path_type, string path_pattern, GtkPathPriorityType priority);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkBindingSetHandle gtk_binding_set_by_class(IntPtr object_class);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkBindingSetHandle gtk_binding_set_find(string set_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkBindingSetHandle gtk_binding_set_new(string set_name);

}

public struct GtkBindingSet
{
	public string set_name;
	public int priority;
	public GSListHandle widget_path_pspecs;
	public GSListHandle widget_class_pspecs;
	public GSListHandle class_branch_pspecs;
	public GtkBindingEntryHandle entries;
	public GtkBindingEntryHandle current;
	public uint parsed;
}
