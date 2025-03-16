namespace MentorLake.Gtk;

public class GtkBindingSetHandle : BaseSafeHandle
{
}


public static class GtkBindingSetExtensions
{
	public static bool Activate(this MentorLake.Gtk.GtkBindingSetHandle binding_set, uint keyval, MentorLake.Gdk.GdkModifierType modifiers, MentorLake.GObject.GObjectHandle @object)
	{
		return GtkBindingSetExterns.gtk_binding_set_activate(binding_set, keyval, modifiers, @object);
	}

	public static void AddPath(this MentorLake.Gtk.GtkBindingSetHandle binding_set, MentorLake.Gtk.GtkPathType path_type, string path_pattern, MentorLake.Gtk.GtkPathPriorityType priority)
	{
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
	internal static extern MentorLake.Gtk.GtkBindingSetHandle gtk_binding_set_by_class(IntPtr object_class);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkBindingSetHandle gtk_binding_set_find(string set_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkBindingSetHandle gtk_binding_set_new(string set_name);

}

public struct GtkBindingSet
{
	public string set_name;
	public int priority;
	public IntPtr widget_path_pspecs;
	public IntPtr widget_class_pspecs;
	public IntPtr class_branch_pspecs;
	public IntPtr entries;
	public IntPtr current;
	public uint parsed;
	public static MentorLake.Gtk.GtkBindingSetHandle ByClass(IntPtr object_class)
	{
		return GtkBindingSetExterns.gtk_binding_set_by_class(object_class);
	}

	public static MentorLake.Gtk.GtkBindingSetHandle Find(string set_name)
	{
		return GtkBindingSetExterns.gtk_binding_set_find(set_name);
	}

	public static MentorLake.Gtk.GtkBindingSetHandle New(string set_name)
	{
		return GtkBindingSetExterns.gtk_binding_set_new(set_name);
	}

}
