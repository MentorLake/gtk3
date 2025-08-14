namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A struct that specifies a border around a rectangular area
/// that can be of different width on each side.
/// </para>
/// </summary>

public class GtkBorderHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Allocates a new #GtkBorder-struct and initializes its elements to zero.
/// </para>
/// </summary>

/// <return>
/// a newly allocated #GtkBorder-struct.
///  Free with gtk_border_free()
/// </return>

	public static MentorLake.Gtk.GtkBorderHandle New()
	{
		return GtkBorderExterns.gtk_border_new();
	}

}


public static class GtkBorderExtensions
{
/// <summary>
/// <para>
/// Copies a #GtkBorder-struct.
/// </para>
/// </summary>

/// <param name="border_">
/// a #GtkBorder-struct
/// </param>
/// <return>
/// a copy of @border_.
/// </return>

	public static MentorLake.Gtk.GtkBorderHandle Copy(this MentorLake.Gtk.GtkBorderHandle border_)
	{
		if (border_.IsInvalid) throw new Exception("Invalid handle (GtkBorder)");
		return GtkBorderExterns.gtk_border_copy(border_);
	}

/// <summary>
/// <para>
/// Frees a #GtkBorder-struct.
/// </para>
/// </summary>

/// <param name="border_">
/// a #GtkBorder-struct
/// </param>

	public static void Free(this MentorLake.Gtk.GtkBorderHandle border_)
	{
		if (border_.IsInvalid) throw new Exception("Invalid handle (GtkBorder)");
		GtkBorderExterns.gtk_border_free(border_);
	}


	public static GtkBorder Dereference(this GtkBorderHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkBorder>(x.DangerousGetHandle());
}
internal class GtkBorderExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBorderHandle>))]
	internal static extern MentorLake.Gtk.GtkBorderHandle gtk_border_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBorderHandle>))]
	internal static extern MentorLake.Gtk.GtkBorderHandle gtk_border_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBorderHandle>))] MentorLake.Gtk.GtkBorderHandle border_);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_border_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBorderHandle>))] MentorLake.Gtk.GtkBorderHandle border_);

}

/// <summary>
/// <para>
/// A struct that specifies a border around a rectangular area
/// that can be of different width on each side.
/// </para>
/// </summary>

public struct GtkBorder
{
	/// <summary>
/// <para>
/// The width of the left border
/// </para>
/// </summary>

public short left;
	/// <summary>
/// <para>
/// The width of the right border
/// </para>
/// </summary>

public short right;
	/// <summary>
/// <para>
/// The width of the top border
/// </para>
/// </summary>

public short top;
	/// <summary>
/// <para>
/// The width of the bottom border
/// </para>
/// </summary>

public short bottom;
}
