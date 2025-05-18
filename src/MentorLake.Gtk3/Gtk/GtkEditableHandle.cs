namespace MentorLake.Gtk;

public interface GtkEditableHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkEditableHandleImpl : BaseSafeHandle, GtkEditableHandle
{
}

public static class GtkEditableHandleExtensions
{
	public static T CopyClipboard<T>(this T editable) where T : GtkEditableHandle
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		GtkEditableHandleExterns.gtk_editable_copy_clipboard(editable);
		return editable;
	}

	public static T CutClipboard<T>(this T editable) where T : GtkEditableHandle
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		GtkEditableHandleExterns.gtk_editable_cut_clipboard(editable);
		return editable;
	}

	public static T DeleteSelection<T>(this T editable) where T : GtkEditableHandle
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		GtkEditableHandleExterns.gtk_editable_delete_selection(editable);
		return editable;
	}

	public static T DeleteText<T>(this T editable, int start_pos, int end_pos) where T : GtkEditableHandle
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		GtkEditableHandleExterns.gtk_editable_delete_text(editable, start_pos, end_pos);
		return editable;
	}

	public static string GetChars(this MentorLake.Gtk.GtkEditableHandle editable, int start_pos, int end_pos)
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		return GtkEditableHandleExterns.gtk_editable_get_chars(editable, start_pos, end_pos);
	}

	public static bool GetEditable(this MentorLake.Gtk.GtkEditableHandle editable)
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		return GtkEditableHandleExterns.gtk_editable_get_editable(editable);
	}

	public static int GetPosition(this MentorLake.Gtk.GtkEditableHandle editable)
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		return GtkEditableHandleExterns.gtk_editable_get_position(editable);
	}

	public static bool GetSelectionBounds(this MentorLake.Gtk.GtkEditableHandle editable, out int start_pos, out int end_pos)
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		return GtkEditableHandleExterns.gtk_editable_get_selection_bounds(editable, out start_pos, out end_pos);
	}

	public static T InsertText<T>(this T editable, string new_text, int new_text_length, ref int position) where T : GtkEditableHandle
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		GtkEditableHandleExterns.gtk_editable_insert_text(editable, new_text, new_text_length, ref position);
		return editable;
	}

	public static T PasteClipboard<T>(this T editable) where T : GtkEditableHandle
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		GtkEditableHandleExterns.gtk_editable_paste_clipboard(editable);
		return editable;
	}

	public static T SelectRegion<T>(this T editable, int start_pos, int end_pos) where T : GtkEditableHandle
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		GtkEditableHandleExterns.gtk_editable_select_region(editable, start_pos, end_pos);
		return editable;
	}

	public static T SetEditable<T>(this T editable, bool is_editable) where T : GtkEditableHandle
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		GtkEditableHandleExterns.gtk_editable_set_editable(editable, is_editable);
		return editable;
	}

	public static T SetPosition<T>(this T editable, int position) where T : GtkEditableHandle
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		GtkEditableHandleExterns.gtk_editable_set_position(editable, position);
		return editable;
	}

}

internal class GtkEditableHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_editable_copy_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_editable_cut_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_editable_delete_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_editable_delete_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable, int start_pos, int end_pos);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_editable_get_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable, int start_pos, int end_pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_editable_get_editable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_editable_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_editable_get_selection_bounds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable, out int start_pos, out int end_pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_editable_insert_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable, string new_text, int new_text_length, ref int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_editable_paste_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_editable_select_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable, int start_pos, int end_pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_editable_set_editable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable, bool is_editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_editable_set_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable, int position);

}
