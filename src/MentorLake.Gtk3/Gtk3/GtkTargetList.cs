namespace MentorLake.Gtk3.Gtk3;

public class GtkTargetListHandle : BaseSafeHandle
{
	public static GtkTargetListHandle New(GtkTargetEntry[] targets, uint ntargets)
	{
		return GtkTargetListExterns.gtk_target_list_new(targets, ntargets);
	}

}


public static class GtkTargetListHandleExtensions
{
	public static T Add<T>(this T list, GdkAtom target, uint flags, uint info) where T : GtkTargetListHandle
	{
		GtkTargetListExterns.gtk_target_list_add(list, target, flags, info);
		return list;
	}

	public static T AddImageTargets<T>(this T list, uint info, bool writable) where T : GtkTargetListHandle
	{
		GtkTargetListExterns.gtk_target_list_add_image_targets(list, info, writable);
		return list;
	}

	public static T AddRichTextTargets<T>(this T list, uint info, bool deserializable, GtkTextBufferHandle buffer) where T : GtkTargetListHandle
	{
		GtkTargetListExterns.gtk_target_list_add_rich_text_targets(list, info, deserializable, buffer);
		return list;
	}

	public static T AddTable<T>(this T list, GtkTargetEntry[] targets, uint ntargets) where T : GtkTargetListHandle
	{
		GtkTargetListExterns.gtk_target_list_add_table(list, targets, ntargets);
		return list;
	}

	public static T AddTextTargets<T>(this T list, uint info) where T : GtkTargetListHandle
	{
		GtkTargetListExterns.gtk_target_list_add_text_targets(list, info);
		return list;
	}

	public static T AddUriTargets<T>(this T list, uint info) where T : GtkTargetListHandle
	{
		GtkTargetListExterns.gtk_target_list_add_uri_targets(list, info);
		return list;
	}

	public static bool Find(this GtkTargetListHandle list, GdkAtom target, out uint info)
	{
		return GtkTargetListExterns.gtk_target_list_find(list, target, out info);
	}

	public static GtkTargetListHandle Ref(this GtkTargetListHandle list)
	{
		return GtkTargetListExterns.gtk_target_list_ref(list);
	}

	public static T Remove<T>(this T list, GdkAtom target) where T : GtkTargetListHandle
	{
		GtkTargetListExterns.gtk_target_list_remove(list, target);
		return list;
	}

	public static T Unref<T>(this T list) where T : GtkTargetListHandle
	{
		GtkTargetListExterns.gtk_target_list_unref(list);
		return list;
	}

}
internal class GtkTargetListExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTargetListHandle gtk_target_list_new(GtkTargetEntry[] targets, uint ntargets);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_target_list_add(GtkTargetListHandle list, GdkAtom target, uint flags, uint info);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_target_list_add_image_targets(GtkTargetListHandle list, uint info, bool writable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_target_list_add_rich_text_targets(GtkTargetListHandle list, uint info, bool deserializable, GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_target_list_add_table(GtkTargetListHandle list, GtkTargetEntry[] targets, uint ntargets);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_target_list_add_text_targets(GtkTargetListHandle list, uint info);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_target_list_add_uri_targets(GtkTargetListHandle list, uint info);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_target_list_find(GtkTargetListHandle list, GdkAtom target, out uint info);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTargetListHandle gtk_target_list_ref(GtkTargetListHandle list);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_target_list_remove(GtkTargetListHandle list, GdkAtom target);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_target_list_unref(GtkTargetListHandle list);

}

public struct GtkTargetList
{
}
