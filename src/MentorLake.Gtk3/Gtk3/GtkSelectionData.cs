namespace MentorLake.Gtk3.Gtk3;

public class GtkSelectionDataHandle : BaseSafeHandle
{
}


public static class GtkSelectionDataHandleExtensions
{
	public static GtkSelectionDataHandle Copy(this GtkSelectionDataHandle data)
	{
		return GtkSelectionDataExterns.gtk_selection_data_copy(data);
	}

	public static T Free<T>(this T data) where T : GtkSelectionDataHandle
	{
		GtkSelectionDataExterns.gtk_selection_data_free(data);
		return data;
	}

	public static IntPtr GetData(this GtkSelectionDataHandle selection_data)
	{
		return GtkSelectionDataExterns.gtk_selection_data_get_data(selection_data);
	}

	public static GdkAtom GetDataType(this GtkSelectionDataHandle selection_data)
	{
		return GtkSelectionDataExterns.gtk_selection_data_get_data_type(selection_data);
	}

	public static IntPtr GetDataWithLength(this GtkSelectionDataHandle selection_data, out int length)
	{
		return GtkSelectionDataExterns.gtk_selection_data_get_data_with_length(selection_data, out length);
	}

	public static GdkDisplayHandle GetDisplay(this GtkSelectionDataHandle selection_data)
	{
		return GtkSelectionDataExterns.gtk_selection_data_get_display(selection_data);
	}

	public static int GetFormat(this GtkSelectionDataHandle selection_data)
	{
		return GtkSelectionDataExterns.gtk_selection_data_get_format(selection_data);
	}

	public static int GetLength(this GtkSelectionDataHandle selection_data)
	{
		return GtkSelectionDataExterns.gtk_selection_data_get_length(selection_data);
	}

	public static GdkPixbufHandle GetPixbuf(this GtkSelectionDataHandle selection_data)
	{
		return GtkSelectionDataExterns.gtk_selection_data_get_pixbuf(selection_data);
	}

	public static GdkAtom GetSelection(this GtkSelectionDataHandle selection_data)
	{
		return GtkSelectionDataExterns.gtk_selection_data_get_selection(selection_data);
	}

	public static GdkAtom GetTarget(this GtkSelectionDataHandle selection_data)
	{
		return GtkSelectionDataExterns.gtk_selection_data_get_target(selection_data);
	}

	public static bool GetTargets(this GtkSelectionDataHandle selection_data, out GdkAtom[] targets, out int n_atoms)
	{
		return GtkSelectionDataExterns.gtk_selection_data_get_targets(selection_data, out targets, out n_atoms);
	}

	public static string GetText(this GtkSelectionDataHandle selection_data)
	{
		return GtkSelectionDataExterns.gtk_selection_data_get_text(selection_data);
	}

	public static IntPtr GetUris(this GtkSelectionDataHandle selection_data)
	{
		return GtkSelectionDataExterns.gtk_selection_data_get_uris(selection_data);
	}

	public static T Set<T>(this T selection_data, GdkAtom type, int format, string data, int length) where T : GtkSelectionDataHandle
	{
		GtkSelectionDataExterns.gtk_selection_data_set(selection_data, type, format, data, length);
		return selection_data;
	}

	public static bool SetPixbuf(this GtkSelectionDataHandle selection_data, GdkPixbufHandle pixbuf)
	{
		return GtkSelectionDataExterns.gtk_selection_data_set_pixbuf(selection_data, pixbuf);
	}

	public static bool SetText(this GtkSelectionDataHandle selection_data, string str, int len)
	{
		return GtkSelectionDataExterns.gtk_selection_data_set_text(selection_data, str, len);
	}

	public static bool SetUris(this GtkSelectionDataHandle selection_data, string[] uris)
	{
		return GtkSelectionDataExterns.gtk_selection_data_set_uris(selection_data, uris);
	}

	public static bool TargetsIncludeImage(this GtkSelectionDataHandle selection_data, bool writable)
	{
		return GtkSelectionDataExterns.gtk_selection_data_targets_include_image(selection_data, writable);
	}

	public static bool TargetsIncludeRichText(this GtkSelectionDataHandle selection_data, GtkTextBufferHandle buffer)
	{
		return GtkSelectionDataExterns.gtk_selection_data_targets_include_rich_text(selection_data, buffer);
	}

	public static bool TargetsIncludeText(this GtkSelectionDataHandle selection_data)
	{
		return GtkSelectionDataExterns.gtk_selection_data_targets_include_text(selection_data);
	}

	public static bool TargetsIncludeUri(this GtkSelectionDataHandle selection_data)
	{
		return GtkSelectionDataExterns.gtk_selection_data_targets_include_uri(selection_data);
	}

}
internal class GtkSelectionDataExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSelectionDataHandle gtk_selection_data_copy(GtkSelectionDataHandle data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_selection_data_free(GtkSelectionDataHandle data);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_selection_data_get_data(GtkSelectionDataHandle selection_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkAtom gtk_selection_data_get_data_type(GtkSelectionDataHandle selection_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_selection_data_get_data_with_length(GtkSelectionDataHandle selection_data, out int length);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkDisplayHandle gtk_selection_data_get_display(GtkSelectionDataHandle selection_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_selection_data_get_format(GtkSelectionDataHandle selection_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_selection_data_get_length(GtkSelectionDataHandle selection_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_selection_data_get_pixbuf(GtkSelectionDataHandle selection_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkAtom gtk_selection_data_get_selection(GtkSelectionDataHandle selection_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkAtom gtk_selection_data_get_target(GtkSelectionDataHandle selection_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_selection_data_get_targets(GtkSelectionDataHandle selection_data, out GdkAtom[] targets, out int n_atoms);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_selection_data_get_text(GtkSelectionDataHandle selection_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_selection_data_get_uris(GtkSelectionDataHandle selection_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_selection_data_set(GtkSelectionDataHandle selection_data, GdkAtom type, int format, string data, int length);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_selection_data_set_pixbuf(GtkSelectionDataHandle selection_data, GdkPixbufHandle pixbuf);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_selection_data_set_text(GtkSelectionDataHandle selection_data, string str, int len);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_selection_data_set_uris(GtkSelectionDataHandle selection_data, string[] uris);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_selection_data_targets_include_image(GtkSelectionDataHandle selection_data, bool writable);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_selection_data_targets_include_rich_text(GtkSelectionDataHandle selection_data, GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_selection_data_targets_include_text(GtkSelectionDataHandle selection_data);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_selection_data_targets_include_uri(GtkSelectionDataHandle selection_data);

}

public struct GtkSelectionData
{
}
