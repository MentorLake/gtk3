namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkRequisition-struct represents the desired size of a widget. See
/// [GtkWidget’s geometry management section][geometry-management] for
/// more information.
/// </para>
/// </summary>

public class GtkRequisitionHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Allocates a new #GtkRequisition-struct and initializes its elements to zero.
/// </para>
/// </summary>

/// <return>
/// a new empty #GtkRequisition. The newly allocated #GtkRequisition should
///   be freed with gtk_requisition_free().
/// </return>

	public static MentorLake.Gtk.GtkRequisitionHandle New()
	{
		return GtkRequisitionExterns.gtk_requisition_new();
	}

}


public static class GtkRequisitionExtensions
{
/// <summary>
/// <para>
/// Copies a #GtkRequisition.
/// </para>
/// </summary>

/// <param name="requisition">
/// a #GtkRequisition
/// </param>
/// <return>
/// a copy of @requisition
/// </return>

	public static MentorLake.Gtk.GtkRequisitionHandle Copy(this MentorLake.Gtk.GtkRequisitionHandle requisition)
	{
		if (requisition.IsInvalid) throw new Exception("Invalid handle (GtkRequisition)");
		return GtkRequisitionExterns.gtk_requisition_copy(requisition);
	}

/// <summary>
/// <para>
/// Frees a #GtkRequisition.
/// </para>
/// </summary>

/// <param name="requisition">
/// a #GtkRequisition
/// </param>

	public static void Free(this MentorLake.Gtk.GtkRequisitionHandle requisition)
	{
		if (requisition.IsInvalid) throw new Exception("Invalid handle (GtkRequisition)");
		GtkRequisitionExterns.gtk_requisition_free(requisition);
	}


	public static GtkRequisition Dereference(this GtkRequisitionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRequisition>(x.DangerousGetHandle());
}
internal class GtkRequisitionExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRequisitionHandle>))]
	internal static extern MentorLake.Gtk.GtkRequisitionHandle gtk_requisition_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRequisitionHandle>))]
	internal static extern MentorLake.Gtk.GtkRequisitionHandle gtk_requisition_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRequisitionHandle>))] MentorLake.Gtk.GtkRequisitionHandle requisition);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_requisition_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRequisitionHandle>))] MentorLake.Gtk.GtkRequisitionHandle requisition);

}

/// <summary>
/// <para>
/// A #GtkRequisition-struct represents the desired size of a widget. See
/// [GtkWidget’s geometry management section][geometry-management] for
/// more information.
/// </para>
/// </summary>

public struct GtkRequisition
{
	/// <summary>
/// <para>
/// the widget’s desired width
/// </para>
/// </summary>

public int width;
	/// <summary>
/// <para>
/// the widget’s desired height
/// </para>
/// </summary>

public int height;
}
