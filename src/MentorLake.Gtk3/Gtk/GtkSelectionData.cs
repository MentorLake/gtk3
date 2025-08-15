namespace MentorLake.Gtk;


public class GtkSelectionDataHandle : BaseSafeHandle
{
}


public static class GtkSelectionDataExtensions
{
/// <summary>
/// <para>
/// Makes a copy of a #GtkSelectionData-struct and its data.
/// </para>
/// </summary>

/// <param name="data">
/// a pointer to a #GtkSelectionData-struct.
/// </param>
/// <return>
/// a pointer to a copy of @data.
/// </return>

	public static MentorLake.Gtk.GtkSelectionDataHandle Copy(this MentorLake.Gtk.GtkSelectionDataHandle data)
	{
		if (data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_copy(data);
	}

/// <summary>
/// <para>
/// Frees a #GtkSelectionData-struct returned from
/// gtk_selection_data_copy().
/// </para>
/// </summary>

/// <param name="data">
/// a pointer to a #GtkSelectionData-struct.
/// </param>

	public static void Free(this MentorLake.Gtk.GtkSelectionDataHandle data)
	{
		if (data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		GtkSelectionDataExterns.gtk_selection_data_free(data);
	}

/// <summary>
/// <para>
/// Retrieves the raw data of the selection.
/// </para>
/// </summary>

/// <param name="selection_data">
/// a pointer to a
///   #GtkSelectionData-struct.
/// </param>
/// <return>
/// the raw data of the selection.
/// </return>

	public static byte[] GetData(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_data(selection_data);
	}

/// <summary>
/// <para>
/// Retrieves the data type of the selection.
/// </para>
/// </summary>

/// <param name="selection_data">
/// a pointer to a #GtkSelectionData-struct.
/// </param>
/// <return>
/// the data type of the selection.
/// </return>

	public static MentorLake.Gdk.GdkAtom GetDataType(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_data_type(selection_data);
	}

/// <summary>
/// <para>
/// Retrieves the raw data of the selection along with its length.
/// </para>
/// </summary>

/// <param name="selection_data">
/// a pointer to a #GtkSelectionData-struct.
/// </param>
/// <param name="length">
/// return location for length of the data segment
/// </param>
/// <return>
/// the raw data of the selection
/// </return>

	public static byte[] GetDataWithLength(this MentorLake.Gtk.GtkSelectionDataHandle selection_data, out int length)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_data_with_length(selection_data, out length);
	}

/// <summary>
/// <para>
/// Retrieves the display of the selection.
/// </para>
/// </summary>

/// <param name="selection_data">
/// a pointer to a #GtkSelectionData-struct.
/// </param>
/// <return>
/// the display of the selection.
/// </return>

	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_display(selection_data);
	}

/// <summary>
/// <para>
/// Retrieves the format of the selection.
/// </para>
/// </summary>

/// <param name="selection_data">
/// a pointer to a #GtkSelectionData-struct.
/// </param>
/// <return>
/// the format of the selection.
/// </return>

	public static int GetFormat(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_format(selection_data);
	}

/// <summary>
/// <para>
/// Retrieves the length of the raw data of the selection.
/// </para>
/// </summary>

/// <param name="selection_data">
/// a pointer to a #GtkSelectionData-struct.
/// </param>
/// <return>
/// the length of the data of the selection.
/// </return>

	public static int GetLength(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_length(selection_data);
	}

/// <summary>
/// <para>
/// Gets the contents of the selection data as a #GdkPixbuf.
/// </para>
/// </summary>

/// <param name="selection_data">
/// a #GtkSelectionData
/// </param>
/// <return>
/// if the selection data
///   contained a recognized image type and it could be converted to a
///   #GdkPixbuf, a newly allocated pixbuf is returned, otherwise
///   %NULL.  If the result is non-%NULL it must be freed with
///   g_object_unref().
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetPixbuf(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_pixbuf(selection_data);
	}

/// <summary>
/// <para>
/// Retrieves the selection #GdkAtom of the selection data.
/// </para>
/// </summary>

/// <param name="selection_data">
/// a pointer to a #GtkSelectionData-struct.
/// </param>
/// <return>
/// the selection #GdkAtom of the selection data.
/// </return>

	public static MentorLake.Gdk.GdkAtom GetSelection(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_selection(selection_data);
	}

/// <summary>
/// <para>
/// Retrieves the target of the selection.
/// </para>
/// </summary>

/// <param name="selection_data">
/// a pointer to a #GtkSelectionData-struct.
/// </param>
/// <return>
/// the target of the selection.
/// </return>

	public static MentorLake.Gdk.GdkAtom GetTarget(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_target(selection_data);
	}

/// <summary>
/// <para>
/// Gets the contents of @selection_data as an array of targets.
/// This can be used to interpret the results of getting
/// the standard TARGETS target that is always supplied for
/// any selection.
/// </para>
/// </summary>

/// <param name="selection_data">
/// a #GtkSelectionData object
/// </param>
/// <param name="targets">
/// 
///           location to store an array of targets. The result stored
///           here must be freed with g_free().
/// </param>
/// <param name="n_atoms">
/// location to store number of items in @targets.
/// </param>
/// <return>
/// %TRUE if @selection_data contains a valid
///    array of targets, otherwise %FALSE.
/// </return>

	public static bool GetTargets(this MentorLake.Gtk.GtkSelectionDataHandle selection_data, out MentorLake.Gdk.GdkAtom[] targets, out int n_atoms)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_targets(selection_data, out targets, out n_atoms);
	}

/// <summary>
/// <para>
/// Gets the contents of the selection data as a UTF-8 string.
/// </para>
/// </summary>

/// <param name="selection_data">
/// a #GtkSelectionData
/// </param>
/// <return>
/// if the selection data contained a
///   recognized text type and it could be converted to UTF-8, a newly
///   allocated string containing the converted text, otherwise %NULL.
///   If the result is non-%NULL it must be freed with g_free().
/// </return>

	public static string GetText(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_text(selection_data);
	}

/// <summary>
/// <para>
/// Gets the contents of the selection data as array of URIs.
/// </para>
/// <para>
/// Since 3.24.37, this may involve using the FileTransfer
/// portal to send files between sandboxed apps.
/// </para>
/// </summary>

/// <param name="selection_data">
/// a #GtkSelectionData
/// </param>
/// <return>
/// if
///   the selection data contains a list of
///   URIs, a newly allocated %NULL-terminated string array
///   containing the URIs, otherwise %NULL. If the result is
///   non-%NULL it must be freed with g_strfreev().
/// </return>

	public static string[] GetUris(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_get_uris(selection_data);
	}

/// <summary>
/// <para>
/// Stores new data into a #GtkSelectionData object. Should
/// only be called from a selection handler callback.
/// Zero-terminates the stored data.
/// </para>
/// </summary>

/// <param name="selection_data">
/// a pointer to a #GtkSelectionData-struct.
/// </param>
/// <param name="type">
/// the type of selection data
/// </param>
/// <param name="format">
/// format (number of bits in a unit)
/// </param>
/// <param name="data">
/// pointer to the data (will be copied)
/// </param>
/// <param name="length">
/// length of the data
/// </param>

	public static void Set(this MentorLake.Gtk.GtkSelectionDataHandle selection_data, MentorLake.Gdk.GdkAtom type, int format, byte[] data, int length)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		GtkSelectionDataExterns.gtk_selection_data_set(selection_data, type, format, data, length);
	}

/// <summary>
/// <para>
/// Sets the contents of the selection from a #GdkPixbuf
/// The pixbuf is converted to the form determined by
/// @selection_data-&amp;gt;target.
/// </para>
/// </summary>

/// <param name="selection_data">
/// a #GtkSelectionData
/// </param>
/// <param name="pixbuf">
/// a #GdkPixbuf
/// </param>
/// <return>
/// %TRUE if the selection was successfully set,
///   otherwise %FALSE.
/// </return>

	public static bool SetPixbuf(this MentorLake.Gtk.GtkSelectionDataHandle selection_data, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_set_pixbuf(selection_data, pixbuf);
	}

/// <summary>
/// <para>
/// Sets the contents of the selection from a UTF-8 encoded string.
/// The string is converted to the form determined by
/// @selection_data-&amp;gt;target.
/// </para>
/// </summary>

/// <param name="selection_data">
/// a #GtkSelectionData
/// </param>
/// <param name="str">
/// a UTF-8 string
/// </param>
/// <param name="len">
/// the length of @str, or -1 if @str is nul-terminated.
/// </param>
/// <return>
/// %TRUE if the selection was successfully set,
///   otherwise %FALSE.
/// </return>

	public static bool SetText(this MentorLake.Gtk.GtkSelectionDataHandle selection_data, string str, int len)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_set_text(selection_data, str, len);
	}

/// <summary>
/// <para>
/// Sets the contents of the selection from a list of URIs.
/// The string is converted to the form determined by
/// @selection_data-&amp;gt;target.
/// </para>
/// <para>
/// Since 3.24.37, this may involve using the FileTransfer
/// portal to send files between sandboxed apps.
/// </para>
/// </summary>

/// <param name="selection_data">
/// a #GtkSelectionData
/// </param>
/// <param name="uris">
/// a %NULL-terminated array of
///     strings holding URIs
/// </param>
/// <return>
/// %TRUE if the selection was successfully set,
///   otherwise %FALSE.
/// </return>

	public static bool SetUris(this MentorLake.Gtk.GtkSelectionDataHandle selection_data, string[] uris)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_set_uris(selection_data, uris);
	}

/// <summary>
/// <para>
/// Given a #GtkSelectionData object holding a list of targets,
/// determines if any of the targets in @targets can be used to
/// provide a #GdkPixbuf.
/// </para>
/// </summary>

/// <param name="selection_data">
/// a #GtkSelectionData object
/// </param>
/// <param name="writable">
/// whether to accept only targets for which GTK+ knows
///   how to convert a pixbuf into the format
/// </param>
/// <return>
/// %TRUE if @selection_data holds a list of targets,
///   and a suitable target for images is included, otherwise %FALSE.
/// </return>

	public static bool TargetsIncludeImage(this MentorLake.Gtk.GtkSelectionDataHandle selection_data, bool writable)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_targets_include_image(selection_data, writable);
	}

/// <summary>
/// <para>
/// Given a #GtkSelectionData object holding a list of targets,
/// determines if any of the targets in @targets can be used to
/// provide rich text.
/// </para>
/// </summary>

/// <param name="selection_data">
/// a #GtkSelectionData object
/// </param>
/// <param name="buffer">
/// a #GtkTextBuffer
/// </param>
/// <return>
/// %TRUE if @selection_data holds a list of targets,
///               and a suitable target for rich text is included,
///               otherwise %FALSE.
/// </return>

	public static bool TargetsIncludeRichText(this MentorLake.Gtk.GtkSelectionDataHandle selection_data, MentorLake.Gtk.GtkTextBufferHandle buffer)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_targets_include_rich_text(selection_data, buffer);
	}

/// <summary>
/// <para>
/// Given a #GtkSelectionData object holding a list of targets,
/// determines if any of the targets in @targets can be used to
/// provide text.
/// </para>
/// </summary>

/// <param name="selection_data">
/// a #GtkSelectionData object
/// </param>
/// <return>
/// %TRUE if @selection_data holds a list of targets,
///   and a suitable target for text is included, otherwise %FALSE.
/// </return>

	public static bool TargetsIncludeText(this MentorLake.Gtk.GtkSelectionDataHandle selection_data)
	{
		if (selection_data.IsInvalid) throw new Exception("Invalid handle (GtkSelectionData)");
		return GtkSelectionDataExterns.gtk_selection_data_targets_include_text(selection_data);
	}

/// <summary>
/// <para>
/// Given a #GtkSelectionData object holding a list of targets,
/// determines if any of the targets in @targets can be used to
/// provide a list or URIs.
/// </para>
/// </summary>

/// <param name="selection_data">
/// a #GtkSelectionData object
/// </param>
/// <return>
/// %TRUE if @selection_data holds a list of targets,
///   and a suitable target for URI lists is included, otherwise %FALSE.
/// </return>

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
	internal static extern byte[] gtk_selection_data_get_data_with_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data, out int length);

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
	internal static extern void gtk_selection_data_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle selection_data, MentorLake.Gdk.GdkAtom type, int format, byte[] data, int length);

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
