namespace MentorLake.Gtk3.Gtk3;

public class GtkWidgetPathHandle : BaseSafeHandle
{
	public static GtkWidgetPathHandle New()
	{
		return GtkWidgetPathExterns.gtk_widget_path_new();
	}

}


public static class GtkWidgetPathHandleExtensions
{
	public static int AppendForWidget(this GtkWidgetPathHandle path, GtkWidgetHandle widget)
	{
		return GtkWidgetPathExterns.gtk_widget_path_append_for_widget(path, widget);
	}

	public static int AppendType(this GtkWidgetPathHandle path, GType type)
	{
		return GtkWidgetPathExterns.gtk_widget_path_append_type(path, type);
	}

	public static int AppendWithSiblings(this GtkWidgetPathHandle path, GtkWidgetPathHandle siblings, uint sibling_index)
	{
		return GtkWidgetPathExterns.gtk_widget_path_append_with_siblings(path, siblings, sibling_index);
	}

	public static GtkWidgetPathHandle Copy(this GtkWidgetPathHandle path)
	{
		return GtkWidgetPathExterns.gtk_widget_path_copy(path);
	}

	public static T Free<T>(this T path) where T : GtkWidgetPathHandle
	{
		GtkWidgetPathExterns.gtk_widget_path_free(path);
		return path;
	}

	public static GType GetObjectType(this GtkWidgetPathHandle path)
	{
		return GtkWidgetPathExterns.gtk_widget_path_get_object_type(path);
	}

	public static bool HasParent(this GtkWidgetPathHandle path, GType type)
	{
		return GtkWidgetPathExterns.gtk_widget_path_has_parent(path, type);
	}

	public static bool IsType(this GtkWidgetPathHandle path, GType type)
	{
		return GtkWidgetPathExterns.gtk_widget_path_is_type(path, type);
	}

	public static T IterAddClass<T>(this T path, int pos, string name) where T : GtkWidgetPathHandle
	{
		GtkWidgetPathExterns.gtk_widget_path_iter_add_class(path, pos, name);
		return path;
	}

	public static T IterAddRegion<T>(this T path, int pos, string name, GtkRegionFlags flags) where T : GtkWidgetPathHandle
	{
		GtkWidgetPathExterns.gtk_widget_path_iter_add_region(path, pos, name, flags);
		return path;
	}

	public static T IterClearClasses<T>(this T path, int pos) where T : GtkWidgetPathHandle
	{
		GtkWidgetPathExterns.gtk_widget_path_iter_clear_classes(path, pos);
		return path;
	}

	public static T IterClearRegions<T>(this T path, int pos) where T : GtkWidgetPathHandle
	{
		GtkWidgetPathExterns.gtk_widget_path_iter_clear_regions(path, pos);
		return path;
	}

	public static string IterGetName(this GtkWidgetPathHandle path, int pos)
	{
		return GtkWidgetPathExterns.gtk_widget_path_iter_get_name(path, pos);
	}

	public static string IterGetObjectName(this GtkWidgetPathHandle path, int pos)
	{
		return GtkWidgetPathExterns.gtk_widget_path_iter_get_object_name(path, pos);
	}

	public static GType IterGetObjectType(this GtkWidgetPathHandle path, int pos)
	{
		return GtkWidgetPathExterns.gtk_widget_path_iter_get_object_type(path, pos);
	}

	public static uint IterGetSiblingIndex(this GtkWidgetPathHandle path, int pos)
	{
		return GtkWidgetPathExterns.gtk_widget_path_iter_get_sibling_index(path, pos);
	}

	public static GtkWidgetPathHandle IterGetSiblings(this GtkWidgetPathHandle path, int pos)
	{
		return GtkWidgetPathExterns.gtk_widget_path_iter_get_siblings(path, pos);
	}

	public static GtkStateFlags IterGetState(this GtkWidgetPathHandle path, int pos)
	{
		return GtkWidgetPathExterns.gtk_widget_path_iter_get_state(path, pos);
	}

	public static bool IterHasClass(this GtkWidgetPathHandle path, int pos, string name)
	{
		return GtkWidgetPathExterns.gtk_widget_path_iter_has_class(path, pos, name);
	}

	public static bool IterHasName(this GtkWidgetPathHandle path, int pos, string name)
	{
		return GtkWidgetPathExterns.gtk_widget_path_iter_has_name(path, pos, name);
	}

	public static bool IterHasQclass(this GtkWidgetPathHandle path, int pos, GQuark qname)
	{
		return GtkWidgetPathExterns.gtk_widget_path_iter_has_qclass(path, pos, qname);
	}

	public static bool IterHasQname(this GtkWidgetPathHandle path, int pos, GQuark qname)
	{
		return GtkWidgetPathExterns.gtk_widget_path_iter_has_qname(path, pos, qname);
	}

	public static bool IterHasQregion(this GtkWidgetPathHandle path, int pos, GQuark qname, out GtkRegionFlags flags)
	{
		return GtkWidgetPathExterns.gtk_widget_path_iter_has_qregion(path, pos, qname, out flags);
	}

	public static bool IterHasRegion(this GtkWidgetPathHandle path, int pos, string name, out GtkRegionFlags flags)
	{
		return GtkWidgetPathExterns.gtk_widget_path_iter_has_region(path, pos, name, out flags);
	}

	public static GSListHandle IterListClasses(this GtkWidgetPathHandle path, int pos)
	{
		return GtkWidgetPathExterns.gtk_widget_path_iter_list_classes(path, pos);
	}

	public static GSListHandle IterListRegions(this GtkWidgetPathHandle path, int pos)
	{
		return GtkWidgetPathExterns.gtk_widget_path_iter_list_regions(path, pos);
	}

	public static T IterRemoveClass<T>(this T path, int pos, string name) where T : GtkWidgetPathHandle
	{
		GtkWidgetPathExterns.gtk_widget_path_iter_remove_class(path, pos, name);
		return path;
	}

	public static T IterRemoveRegion<T>(this T path, int pos, string name) where T : GtkWidgetPathHandle
	{
		GtkWidgetPathExterns.gtk_widget_path_iter_remove_region(path, pos, name);
		return path;
	}

	public static T IterSetName<T>(this T path, int pos, string name) where T : GtkWidgetPathHandle
	{
		GtkWidgetPathExterns.gtk_widget_path_iter_set_name(path, pos, name);
		return path;
	}

	public static T IterSetObjectName<T>(this T path, int pos, string name) where T : GtkWidgetPathHandle
	{
		GtkWidgetPathExterns.gtk_widget_path_iter_set_object_name(path, pos, name);
		return path;
	}

	public static T IterSetObjectType<T>(this T path, int pos, GType type) where T : GtkWidgetPathHandle
	{
		GtkWidgetPathExterns.gtk_widget_path_iter_set_object_type(path, pos, type);
		return path;
	}

	public static T IterSetState<T>(this T path, int pos, GtkStateFlags state) where T : GtkWidgetPathHandle
	{
		GtkWidgetPathExterns.gtk_widget_path_iter_set_state(path, pos, state);
		return path;
	}

	public static int Length(this GtkWidgetPathHandle path)
	{
		return GtkWidgetPathExterns.gtk_widget_path_length(path);
	}

	public static T PrependType<T>(this T path, GType type) where T : GtkWidgetPathHandle
	{
		GtkWidgetPathExterns.gtk_widget_path_prepend_type(path, type);
		return path;
	}

	public static GtkWidgetPathHandle Ref(this GtkWidgetPathHandle path)
	{
		return GtkWidgetPathExterns.gtk_widget_path_ref(path);
	}

	public static string ToString(this GtkWidgetPathHandle path)
	{
		return GtkWidgetPathExterns.gtk_widget_path_to_string(path);
	}

	public static T Unref<T>(this T path) where T : GtkWidgetPathHandle
	{
		GtkWidgetPathExterns.gtk_widget_path_unref(path);
		return path;
	}

}
internal class GtkWidgetPathExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetPathHandle gtk_widget_path_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_widget_path_append_for_widget(GtkWidgetPathHandle path, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_widget_path_append_type(GtkWidgetPathHandle path, GType type);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_widget_path_append_with_siblings(GtkWidgetPathHandle path, GtkWidgetPathHandle siblings, uint sibling_index);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetPathHandle gtk_widget_path_copy(GtkWidgetPathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_path_free(GtkWidgetPathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern GType gtk_widget_path_get_object_type(GtkWidgetPathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_path_has_parent(GtkWidgetPathHandle path, GType type);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_path_is_type(GtkWidgetPathHandle path, GType type);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_path_iter_add_class(GtkWidgetPathHandle path, int pos, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_path_iter_add_region(GtkWidgetPathHandle path, int pos, string name, GtkRegionFlags flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_path_iter_clear_classes(GtkWidgetPathHandle path, int pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_path_iter_clear_regions(GtkWidgetPathHandle path, int pos);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_widget_path_iter_get_name(GtkWidgetPathHandle path, int pos);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_widget_path_iter_get_object_name(GtkWidgetPathHandle path, int pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern GType gtk_widget_path_iter_get_object_type(GtkWidgetPathHandle path, int pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_widget_path_iter_get_sibling_index(GtkWidgetPathHandle path, int pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetPathHandle gtk_widget_path_iter_get_siblings(GtkWidgetPathHandle path, int pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStateFlags gtk_widget_path_iter_get_state(GtkWidgetPathHandle path, int pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_path_iter_has_class(GtkWidgetPathHandle path, int pos, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_path_iter_has_name(GtkWidgetPathHandle path, int pos, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_path_iter_has_qclass(GtkWidgetPathHandle path, int pos, GQuark qname);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_path_iter_has_qname(GtkWidgetPathHandle path, int pos, GQuark qname);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_path_iter_has_qregion(GtkWidgetPathHandle path, int pos, GQuark qname, out GtkRegionFlags flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_path_iter_has_region(GtkWidgetPathHandle path, int pos, string name, out GtkRegionFlags flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern GSListHandle gtk_widget_path_iter_list_classes(GtkWidgetPathHandle path, int pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern GSListHandle gtk_widget_path_iter_list_regions(GtkWidgetPathHandle path, int pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_path_iter_remove_class(GtkWidgetPathHandle path, int pos, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_path_iter_remove_region(GtkWidgetPathHandle path, int pos, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_path_iter_set_name(GtkWidgetPathHandle path, int pos, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_path_iter_set_object_name(GtkWidgetPathHandle path, int pos, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_path_iter_set_object_type(GtkWidgetPathHandle path, int pos, GType type);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_path_iter_set_state(GtkWidgetPathHandle path, int pos, GtkStateFlags state);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_widget_path_length(GtkWidgetPathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_path_prepend_type(GtkWidgetPathHandle path, GType type);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetPathHandle gtk_widget_path_ref(GtkWidgetPathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_widget_path_to_string(GtkWidgetPathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_path_unref(GtkWidgetPathHandle path);

}

public struct GtkWidgetPath
{
}
