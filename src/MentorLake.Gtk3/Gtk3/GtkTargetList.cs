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
	public static GtkTargetListHandle Add(this GtkTargetListHandle list, GdkAtom target, uint flags, uint info)
	{
		GtkTargetListExterns.gtk_target_list_add(list, target, flags, info);
		return list;
	}

	public static GtkTargetListHandle AddImageTargets(this GtkTargetListHandle list, uint info, bool writable)
	{
		GtkTargetListExterns.gtk_target_list_add_image_targets(list, info, writable);
		return list;
	}

	public static GtkTargetListHandle AddRichTextTargets(this GtkTargetListHandle list, uint info, bool deserializable, GtkTextBufferHandle buffer)
	{
		GtkTargetListExterns.gtk_target_list_add_rich_text_targets(list, info, deserializable, buffer);
		return list;
	}

	public static GtkTargetListHandle AddTable(this GtkTargetListHandle list, GtkTargetEntry[] targets, uint ntargets)
	{
		GtkTargetListExterns.gtk_target_list_add_table(list, targets, ntargets);
		return list;
	}

	public static GtkTargetListHandle AddTextTargets(this GtkTargetListHandle list, uint info)
	{
		GtkTargetListExterns.gtk_target_list_add_text_targets(list, info);
		return list;
	}

	public static GtkTargetListHandle AddUriTargets(this GtkTargetListHandle list, uint info)
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

	public static GtkTargetListHandle Remove(this GtkTargetListHandle list, GdkAtom target)
	{
		GtkTargetListExterns.gtk_target_list_remove(list, target);
		return list;
	}

	public static GtkTargetListHandle Unref(this GtkTargetListHandle list)
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
