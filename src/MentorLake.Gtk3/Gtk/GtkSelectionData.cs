namespace MentorLake.Gtk;

public class GtkSelectionDataHandle : BaseSafeHandle
{
}


public static class GtkSelectionDataExtensions
{
	public static MentorLake.Gtk.GtkSelectionDataHandle Copy(this MentorLake.Gtk.GtkSelectionDataHandle data)
	{
		if (data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_copy(data);
	}

	public static void Free(this MentorLake.Gtk.GtkSelectionDataHandle data)
	{
		if (data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		GtkSelectionDataExterns.gtk_selection_data_free(data);
	}

	public static byte[] GetData(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_data(selection_data);
	}

	public static MentorLake.Gdk.GdkAtom GetDataType(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_data_type(selection_data);
	}

	public static char[] GetDataWithLength(this MentorLake.Gtk.GtkSelectionDataHandle selection_data, out int length)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_data_with_length(selection_data, out length);
	}

	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_display(selection_data);
	}

	public static int GetFormat(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_format(selection_data);
	}

	public static int GetLength(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_length(selection_data);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetPixbuf(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_pixbuf(selection_data);
	}

	public static MentorLake.Gdk.GdkAtom GetSelection(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_selection(selection_data);
	}

	public static MentorLake.Gdk.GdkAtom GetTarget(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_target(selection_data);
	}

	public static bool GetTargets(this MentorLake.Gtk.GtkSelectionDataHandle selection_data, out MentorLake.Gdk.GdkAtom[] targets, out int n_atoms)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_targets(selection_data, out targets, out n_atoms);
	}

	public static string GetText(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_text(selection_data);
	}

	public static string[] GetUris(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_uris(selection_data);
	}

	public static void Set(this MentorLake.Gtk.GtkSelectionDataHandle selection_data, MentorLake.Gdk.GdkAtom type, int format, char[] data, int length)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		GtkSelectionDataExterns.gtk_selection_data_set(selection_data, type, format, data, length);
	}

	public static bool SetPixbuf(this MentorLake.Gtk.GtkSelectionDataHandle selection_data, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_set_pixbuf(selection_data, pixbuf);
	}

	public static bool SetText(this MentorLake.Gtk.GtkSelectionDataHandle selection_data, string str, int len)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_set_text(selection_data, str, len);
	}

	public static bool SetUris(this MentorLake.Gtk.GtkSelectionDataHandle selection_data, string[] uris)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_set_uris(selection_data, uris);
	}

	public static bool TargetsIncludeImage(this MentorLake.Gtk.GtkSelectionDataHandle selection_data, bool writable)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_targets_include_image(selection_data, writable);
	}

	public static bool TargetsIncludeRichText(this MentorLake.Gtk.GtkSelectionDataHandle selection_data, MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_targets_include_rich_text(selection_data, buffer);
	}

	public static bool TargetsIncludeText(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_targets_include_text(selection_data);
	}

	public static bool TargetsIncludeUri(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_targets_include_uri(selection_data);
	}


	public static GtkSelectionData Dereference(this GtkSelectionDataHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSelectionData>(x.DangerousGetHandle());
}
internal class GtkSelectionDataExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))]
	internal static extern MentorLake.Gtk.GtkSelectionDataHandle gtk_selection_data_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_selection_data_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle data);

	[DllImport(GtkLibrary.Name)]
	internal static extern byte[] gtk_selection_data_get_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAtom gtk_selection_data_get_data_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern char[] gtk_selection_data_get_data_with_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data, out int length);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gtk_selection_data_get_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_selection_data_get_format([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_selection_data_get_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_selection_data_get_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAtom gtk_selection_data_get_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAtom gtk_selection_data_get_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_selection_data_get_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out MentorLake.Gdk.GdkAtom[] targets, out int n_atoms);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_selection_data_get_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] gtk_selection_data_get_uris([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_selection_data_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data, MentorLake.Gdk.GdkAtom type, int format, char[] data, int length);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_selection_data_set_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_selection_data_set_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data, string str, int len);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_selection_data_set_uris([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data, string[] uris);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_selection_data_targets_include_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data, bool writable);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_selection_data_targets_include_rich_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))] MentorLake.Gtk.GtkTextBufferHandle buffer);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_selection_data_targets_include_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_selection_data_targets_include_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data);

}

public struct GtkSelectionData
{
}
