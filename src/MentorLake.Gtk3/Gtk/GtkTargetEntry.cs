namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkTargetEntry represents a single type of
/// data than can be supplied for by a widget for a selection
/// or for supplied or received during drag-and-drop.
/// </para>
/// </summary>

public class GtkTargetEntryHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Makes a new #GtkTargetEntry.
/// </para>
/// </summary>

/// <param name="target">
/// String identifier for target
/// </param>
/// <param name="flags">
/// Set of flags, see #GtkTargetFlags
/// </param>
/// <param name="info">
/// an ID that will be passed back to the application
/// </param>
/// <return>
/// a pointer to a new #GtkTargetEntry.
///     Free with gtk_target_entry_free()
/// </return>

	public static MentorLake.Gtk.GtkTargetEntryHandle New(string target, uint flags, uint info)
	{
		return GtkTargetEntryExterns.gtk_target_entry_new(target, flags, info);
	}

}


public static class GtkTargetEntryExtensions
{
/// <summary>
/// <para>
/// Makes a copy of a #GtkTargetEntry and its data.
/// </para>
/// </summary>

/// <param name="data">
/// a pointer to a #GtkTargetEntry
/// </param>
/// <return>
/// a pointer to a copy of @data.
///     Free with gtk_target_entry_free()
/// </return>

	public static MentorLake.Gtk.GtkTargetEntryHandle Copy(this MentorLake.Gtk.GtkTargetEntryHandle data)
	{
		if (data.IsInvalid) throw new Exception("Invalid handle (GtkTargetEntry)");
		return GtkTargetEntryExterns.gtk_target_entry_copy(data);
	}

/// <summary>
/// <para>
/// Frees a #GtkTargetEntry returned from
/// gtk_target_entry_new() or gtk_target_entry_copy().
/// </para>
/// </summary>

/// <param name="data">
/// a pointer to a #GtkTargetEntry.
/// </param>

	public static void Free(this MentorLake.Gtk.GtkTargetEntryHandle data)
	{
		if (data.IsInvalid) throw new Exception("Invalid handle (GtkTargetEntry)");
		GtkTargetEntryExterns.gtk_target_entry_free(data);
	}


	public static GtkTargetEntry Dereference(this GtkTargetEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTargetEntry>(x.DangerousGetHandle());
}
internal class GtkTargetEntryExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetEntryHandle>))]
	internal static extern MentorLake.Gtk.GtkTargetEntryHandle gtk_target_entry_new(string target, uint flags, uint info);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetEntryHandle>))]
	internal static extern MentorLake.Gtk.GtkTargetEntryHandle gtk_target_entry_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetEntryHandle>))] MentorLake.Gtk.GtkTargetEntryHandle data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_target_entry_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetEntryHandle>))] MentorLake.Gtk.GtkTargetEntryHandle data);

}

/// <summary>
/// <para>
/// A #GtkTargetEntry represents a single type of
/// data than can be supplied for by a widget for a selection
/// or for supplied or received during drag-and-drop.
/// </para>
/// </summary>

public struct GtkTargetEntry
{
	/// <summary>
/// <para>
/// a string representation of the target type
/// </para>
/// </summary>

public string target;
	/// <summary>
/// <para>
/// #GtkTargetFlags for DND
/// </para>
/// </summary>

public uint flags;
	/// <summary>
/// <para>
/// an application-assigned integer ID which will
///     get passed as a parameter to e.g the #GtkWidget::selection-get
///     signal. It allows the application to identify the target
///     type without extensive string compares.
/// </para>
/// </summary>

public uint info;
}
