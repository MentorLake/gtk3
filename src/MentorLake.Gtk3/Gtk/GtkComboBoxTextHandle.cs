namespace MentorLake.Gtk;

public class GtkComboBoxTextHandle : GtkComboBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkCellLayoutHandle
{
	public static MentorLake.Gtk.GtkComboBoxTextHandle New()
	{
		return GtkComboBoxTextHandleExterns.gtk_combo_box_text_new();
	}

	public static MentorLake.Gtk.GtkComboBoxTextHandle NewWithEntry()
	{
		return GtkComboBoxTextHandleExterns.gtk_combo_box_text_new_with_entry();
	}

}

public static class GtkComboBoxTextHandleExtensions
{
	public static T Append<T>(this T combo_box, string id, string text) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_append(combo_box, id, text);
		return combo_box;
	}

	public static T AppendText<T>(this T combo_box, string text) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_append_text(combo_box, text);
		return combo_box;
	}

	public static string GetActiveText(this MentorLake.Gtk.GtkComboBoxTextHandle combo_box)
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxTextHandle)");
		return GtkComboBoxTextHandleExterns.gtk_combo_box_text_get_active_text(combo_box);
	}

	public static T Insert<T>(this T combo_box, int position, string id, string text) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_insert(combo_box, position, id, text);
		return combo_box;
	}

	public static T InsertText<T>(this T combo_box, int position, string text) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_insert_text(combo_box, position, text);
		return combo_box;
	}

	public static T Prepend<T>(this T combo_box, string id, string text) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_prepend(combo_box, id, text);
		return combo_box;
	}

	public static T PrependText<T>(this T combo_box, string text) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_prepend_text(combo_box, text);
		return combo_box;
	}

	public static T Remove<T>(this T combo_box, int position) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_remove(combo_box, position);
		return combo_box;
	}

	public static T RemoveAll<T>(this T combo_box) where T : GtkComboBoxTextHandle
	{
		if (combo_box.IsInvalid || combo_box.IsClosed) throw new Exception("Invalid or closed handle (GtkComboBoxTextHandle)");
		GtkComboBoxTextHandleExterns.gtk_combo_box_text_remove_all(combo_box);
		return combo_box;
	}

}

internal class GtkComboBoxTextHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkComboBoxTextHandle gtk_combo_box_text_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkComboBoxTextHandle gtk_combo_box_text_new_with_entry();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, string id, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_append_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, string text);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_combo_box_text_get_active_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, int position, string id, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_insert_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, int position, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, string id, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_prepend_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_combo_box_text_remove_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkComboBoxTextHandle>))] MentorLake.Gtk.GtkComboBoxTextHandle combo_box);

}
