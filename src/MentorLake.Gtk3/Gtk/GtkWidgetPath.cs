namespace MentorLake.Gtk;

public class GtkWidgetPathHandle : BaseSafeHandle
{
	public static MentorLake.Gtk.GtkWidgetPathHandle New()
	{
		return GtkWidgetPathExterns.gtk_widget_path_new();
	}

}


public static class GtkWidgetPathExtensions
{
	public static int AppendForWidget(this MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_append_for_widget(path, widget);
	}

	public static int AppendType(this MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.GObject.GType type)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_append_type(path, type);
	}

	public static int AppendWithSiblings(this MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.Gtk.GtkWidgetPathHandle siblings, uint sibling_index)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_append_with_siblings(path, siblings, sibling_index);
	}

	public static MentorLake.Gtk.GtkWidgetPathHandle Copy(this MentorLake.Gtk.GtkWidgetPathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_copy(path);
	}

	public static void Free(this MentorLake.Gtk.GtkWidgetPathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_free(path);
	}

	public static MentorLake.GObject.GType GetObjectType(this MentorLake.Gtk.GtkWidgetPathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_get_object_type(path);
	}

	public static bool HasParent(this MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.GObject.GType type)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_has_parent(path, type);
	}

	public static bool IsType(this MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.GObject.GType type)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_is_type(path, type);
	}

	public static void IterAddClass(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_iter_add_class(path, pos, name);
	}

	public static void IterAddRegion(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name, MentorLake.Gtk.GtkRegionFlags flags)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_iter_add_region(path, pos, name, flags);
	}

	public static void IterClearClasses(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_iter_clear_classes(path, pos);
	}

	public static void IterClearRegions(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_iter_clear_regions(path, pos);
	}

	public static string IterGetName(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_get_name(path, pos);
	}

	public static string IterGetObjectName(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_get_object_name(path, pos);
	}

	public static MentorLake.GObject.GType IterGetObjectType(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_get_object_type(path, pos);
	}

	public static uint IterGetSiblingIndex(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_get_sibling_index(path, pos);
	}

	public static MentorLake.Gtk.GtkWidgetPathHandle IterGetSiblings(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_get_siblings(path, pos);
	}

	public static MentorLake.Gtk.GtkStateFlags IterGetState(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_get_state(path, pos);
	}

	public static bool IterHasClass(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_has_class(path, pos, name);
	}

	public static bool IterHasName(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_has_name(path, pos, name);
	}

	public static bool IterHasQclass(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, MentorLake.GLib.GQuark qname)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_has_qclass(path, pos, qname);
	}

	public static bool IterHasQname(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, MentorLake.GLib.GQuark qname)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_has_qname(path, pos, qname);
	}

	public static bool IterHasQregion(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, MentorLake.GLib.GQuark qname, out MentorLake.Gtk.GtkRegionFlags flags)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_has_qregion(path, pos, qname, out flags);
	}

	public static bool IterHasRegion(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name, out MentorLake.Gtk.GtkRegionFlags flags)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_has_region(path, pos, name, out flags);
	}

	public static MentorLake.GLib.GSListHandle IterListClasses(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_list_classes(path, pos);
	}

	public static MentorLake.GLib.GSListHandle IterListRegions(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_list_regions(path, pos);
	}

	public static void IterRemoveClass(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_iter_remove_class(path, pos, name);
	}

	public static void IterRemoveRegion(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_iter_remove_region(path, pos, name);
	}

	public static void IterSetName(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_iter_set_name(path, pos, name);
	}

	public static void IterSetObjectName(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_iter_set_object_name(path, pos, name);
	}

	public static void IterSetObjectType(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, MentorLake.GObject.GType type)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_iter_set_object_type(path, pos, type);
	}

	public static void IterSetState(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, MentorLake.Gtk.GtkStateFlags state)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_iter_set_state(path, pos, state);
	}

	public static int Length(this MentorLake.Gtk.GtkWidgetPathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_length(path);
	}

	public static void PrependType(this MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.GObject.GType type)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_prepend_type(path, type);
	}

	public static MentorLake.Gtk.GtkWidgetPathHandle Ref(this MentorLake.Gtk.GtkWidgetPathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_ref(path);
	}

	public static string ToString(this MentorLake.Gtk.GtkWidgetPathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_to_string(path);
	}

	public static void Unref(this MentorLake.Gtk.GtkWidgetPathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_unref(path);
	}


	public static GtkWidgetPath Dereference(this GtkWidgetPathHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkWidgetPath>(x.DangerousGetHandle());
}
internal class GtkWidgetPathExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetPathHandle gtk_widget_path_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_path_append_for_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_path_append_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.GObject.GType type);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_path_append_with_siblings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle siblings, uint sibling_index);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetPathHandle gtk_widget_path_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GType gtk_widget_path_get_object_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_path_has_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.GObject.GType type);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_path_is_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.GObject.GType type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_iter_add_class([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_iter_add_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name, MentorLake.Gtk.GtkRegionFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_iter_clear_classes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_iter_clear_regions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_widget_path_iter_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_widget_path_iter_get_object_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GType gtk_widget_path_iter_get_object_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_widget_path_iter_get_sibling_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetPathHandle gtk_widget_path_iter_get_siblings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStateFlags gtk_widget_path_iter_get_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_path_iter_has_class([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_path_iter_has_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_path_iter_has_qclass([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, MentorLake.GLib.GQuark qname);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_path_iter_has_qname([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, MentorLake.GLib.GQuark qname);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_path_iter_has_qregion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, MentorLake.GLib.GQuark qname, out MentorLake.Gtk.GtkRegionFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_path_iter_has_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name, out MentorLake.Gtk.GtkRegionFlags flags);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_widget_path_iter_list_classes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_widget_path_iter_list_regions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_iter_remove_class([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_iter_remove_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_iter_set_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_iter_set_object_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_iter_set_object_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, MentorLake.GObject.GType type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_iter_set_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, MentorLake.Gtk.GtkStateFlags state);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_path_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_prepend_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.GObject.GType type);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetPathHandle gtk_widget_path_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_widget_path_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path);

}

public struct GtkWidgetPath
{
}
