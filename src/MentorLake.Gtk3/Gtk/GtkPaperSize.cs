namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkPaperSize handles paper sizes. It uses the standard called
/// [PWG 5101.1-2002 PWG: Standard for Media Standardized Names](http://www.pwg.org/standards.html)
/// to name the paper sizes (and to get the data for the page sizes).
/// In addition to standard paper sizes, GtkPaperSize allows to
/// construct custom paper sizes with arbitrary dimensions.
/// </para>
/// <para>
/// The #GtkPaperSize object stores not only the dimensions (width
/// and height) of a paper size and its name, it also provides
/// default [print margins][print-margins].
/// </para>
/// <para>
/// Printing support has been added in GTK+ 2.10.
/// </para>
/// </summary>

public class GtkPaperSizeHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkPaperSize object by parsing a
/// [PWG 5101.1-2002](ftp://ftp.pwg.org/pub/pwg/candidates/cs-pwgmsn10-20020226-5101.1.pdf)
/// paper name.
/// </para>
/// <para>
/// If @name is %NULL, the default paper size is returned,
/// see gtk_paper_size_get_default().
/// </para>
/// </summary>

/// <param name="name">
/// a paper size name, or %NULL
/// </param>
/// <return>
/// a new #GtkPaperSize, use gtk_paper_size_free()
/// to free it
/// </return>

	public static MentorLake.Gtk.GtkPaperSizeHandle New(string name)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new(name);
	}

/// <summary>
/// <para>
/// Creates a new #GtkPaperSize object with the
/// given parameters.
/// </para>
/// </summary>

/// <param name="name">
/// the paper name
/// </param>
/// <param name="display_name">
/// the human-readable name
/// </param>
/// <param name="width">
/// the paper width, in units of @unit
/// </param>
/// <param name="height">
/// the paper height, in units of @unit
/// </param>
/// <param name="unit">
/// the unit for @width and @height. not %GTK_UNIT_NONE.
/// </param>
/// <return>
/// a new #GtkPaperSize object, use gtk_paper_size_free()
/// to free it
/// </return>

	public static MentorLake.Gtk.GtkPaperSizeHandle NewCustom(string name, string display_name, double width, double height, MentorLake.Gtk.GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_custom(name, display_name, width, height, unit);
	}

/// <summary>
/// <para>
/// Deserialize a paper size from an a{sv} variant in
/// the format produced by gtk_paper_size_to_gvariant().
/// </para>
/// </summary>

/// <param name="variant">
/// an a{sv} #GVariant
/// </param>
/// <return>
/// a new #GtkPaperSize object
/// </return>

	public static MentorLake.Gtk.GtkPaperSizeHandle NewFromGvariant(MentorLake.GLib.GVariantHandle variant)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_gvariant(variant);
	}

/// <summary>
/// <para>
/// Creates a new #GtkPaperSize object by using
/// IPP information.
/// </para>
/// <para>
/// If @ipp_name is not a recognized paper name,
/// @width and @height are used to
/// construct a custom #GtkPaperSize object.
/// </para>
/// </summary>

/// <param name="ipp_name">
/// an IPP paper name
/// </param>
/// <param name="width">
/// the paper width, in points
/// </param>
/// <param name="height">
/// the paper height in points
/// </param>
/// <return>
/// a new #GtkPaperSize, use gtk_paper_size_free()
/// to free it
/// </return>

	public static MentorLake.Gtk.GtkPaperSizeHandle NewFromIpp(string ipp_name, double width, double height)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_ipp(ipp_name, width, height);
	}

/// <summary>
/// <para>
/// Reads a paper size from the group @group_name in the key file
/// @key_file.
/// </para>
/// </summary>

/// <param name="key_file">
/// the #GKeyFile to retrieve the papersize from
/// </param>
/// <param name="group_name">
/// the name of the group in the key file to read,
///     or %NULL to read the first group
/// </param>
/// <return>
/// a new #GtkPaperSize object with the restored
///     paper size, or %NULL if an error occurred
/// </return>

	public static MentorLake.Gtk.GtkPaperSizeHandle NewFromKeyFile(MentorLake.GLib.GKeyFileHandle key_file, string group_name)
	{
		var externCallResult = GtkPaperSizeExterns.gtk_paper_size_new_from_key_file(key_file, group_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a new #GtkPaperSize object by using
/// PPD information.
/// </para>
/// <para>
/// If @ppd_name is not a recognized PPD paper name,
/// @ppd_display_name, @width and @height are used to
/// construct a custom #GtkPaperSize object.
/// </para>
/// </summary>

/// <param name="ppd_name">
/// a PPD paper name
/// </param>
/// <param name="ppd_display_name">
/// the corresponding human-readable name
/// </param>
/// <param name="width">
/// the paper width, in points
/// </param>
/// <param name="height">
/// the paper height in points
/// </param>
/// <return>
/// a new #GtkPaperSize, use gtk_paper_size_free()
/// to free it
/// </return>

	public static MentorLake.Gtk.GtkPaperSizeHandle NewFromPpd(string ppd_name, string ppd_display_name, double width, double height)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_ppd(ppd_name, ppd_display_name, width, height);
	}

}


public static class GtkPaperSizeExtensions
{
/// <summary>
/// <para>
/// Copies an existing #GtkPaperSize.
/// </para>
/// </summary>

/// <param name="other">
/// a #GtkPaperSize
/// </param>
/// <return>
/// a copy of @other
/// </return>

	public static MentorLake.Gtk.GtkPaperSizeHandle Copy(this MentorLake.Gtk.GtkPaperSizeHandle other)
	{
		if (other.IsInvalid) throw new Exception("Invalid handle (GtkPaperSize)");
		return GtkPaperSizeExterns.gtk_paper_size_copy(other);
	}

/// <summary>
/// <para>
/// Free the given #GtkPaperSize object.
/// </para>
/// </summary>

/// <param name="size">
/// a #GtkPaperSize
/// </param>

	public static void Free(this MentorLake.Gtk.GtkPaperSizeHandle size)
	{
		if (size.IsInvalid) throw new Exception("Invalid handle (GtkPaperSize)");
		GtkPaperSizeExterns.gtk_paper_size_free(size);
	}

/// <summary>
/// <para>
/// Gets the default bottom margin for the #GtkPaperSize.
/// </para>
/// </summary>

/// <param name="size">
/// a #GtkPaperSize object
/// </param>
/// <param name="unit">
/// the unit for the return value, not %GTK_UNIT_NONE
/// </param>
/// <return>
/// the default bottom margin
/// </return>

	public static double GetDefaultBottomMargin(this MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit)
	{
		if (size.IsInvalid) throw new Exception("Invalid handle (GtkPaperSize)");
		return GtkPaperSizeExterns.gtk_paper_size_get_default_bottom_margin(size, unit);
	}

/// <summary>
/// <para>
/// Gets the default left margin for the #GtkPaperSize.
/// </para>
/// </summary>

/// <param name="size">
/// a #GtkPaperSize object
/// </param>
/// <param name="unit">
/// the unit for the return value, not %GTK_UNIT_NONE
/// </param>
/// <return>
/// the default left margin
/// </return>

	public static double GetDefaultLeftMargin(this MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit)
	{
		if (size.IsInvalid) throw new Exception("Invalid handle (GtkPaperSize)");
		return GtkPaperSizeExterns.gtk_paper_size_get_default_left_margin(size, unit);
	}

/// <summary>
/// <para>
/// Gets the default right margin for the #GtkPaperSize.
/// </para>
/// </summary>

/// <param name="size">
/// a #GtkPaperSize object
/// </param>
/// <param name="unit">
/// the unit for the return value, not %GTK_UNIT_NONE
/// </param>
/// <return>
/// the default right margin
/// </return>

	public static double GetDefaultRightMargin(this MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit)
	{
		if (size.IsInvalid) throw new Exception("Invalid handle (GtkPaperSize)");
		return GtkPaperSizeExterns.gtk_paper_size_get_default_right_margin(size, unit);
	}

/// <summary>
/// <para>
/// Gets the default top margin for the #GtkPaperSize.
/// </para>
/// </summary>

/// <param name="size">
/// a #GtkPaperSize object
/// </param>
/// <param name="unit">
/// the unit for the return value, not %GTK_UNIT_NONE
/// </param>
/// <return>
/// the default top margin
/// </return>

	public static double GetDefaultTopMargin(this MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit)
	{
		if (size.IsInvalid) throw new Exception("Invalid handle (GtkPaperSize)");
		return GtkPaperSizeExterns.gtk_paper_size_get_default_top_margin(size, unit);
	}

/// <summary>
/// <para>
/// Gets the human-readable name of the #GtkPaperSize.
/// </para>
/// </summary>

/// <param name="size">
/// a #GtkPaperSize object
/// </param>
/// <return>
/// the human-readable name of @size
/// </return>

	public static string GetDisplayName(this MentorLake.Gtk.GtkPaperSizeHandle size)
	{
		if (size.IsInvalid) throw new Exception("Invalid handle (GtkPaperSize)");
		return GtkPaperSizeExterns.gtk_paper_size_get_display_name(size);
	}

/// <summary>
/// <para>
/// Gets the paper height of the #GtkPaperSize, in
/// units of @unit.
/// </para>
/// </summary>

/// <param name="size">
/// a #GtkPaperSize object
/// </param>
/// <param name="unit">
/// the unit for the return value, not %GTK_UNIT_NONE
/// </param>
/// <return>
/// the paper height
/// </return>

	public static double GetHeight(this MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit)
	{
		if (size.IsInvalid) throw new Exception("Invalid handle (GtkPaperSize)");
		return GtkPaperSizeExterns.gtk_paper_size_get_height(size, unit);
	}

/// <summary>
/// <para>
/// Gets the name of the #GtkPaperSize.
/// </para>
/// </summary>

/// <param name="size">
/// a #GtkPaperSize object
/// </param>
/// <return>
/// the name of @size
/// </return>

	public static string GetName(this MentorLake.Gtk.GtkPaperSizeHandle size)
	{
		if (size.IsInvalid) throw new Exception("Invalid handle (GtkPaperSize)");
		return GtkPaperSizeExterns.gtk_paper_size_get_name(size);
	}

/// <summary>
/// <para>
/// Gets the PPD name of the #GtkPaperSize, which
/// may be %NULL.
/// </para>
/// </summary>

/// <param name="size">
/// a #GtkPaperSize object
/// </param>
/// <return>
/// the PPD name of @size
/// </return>

	public static string GetPpdName(this MentorLake.Gtk.GtkPaperSizeHandle size)
	{
		if (size.IsInvalid) throw new Exception("Invalid handle (GtkPaperSize)");
		return GtkPaperSizeExterns.gtk_paper_size_get_ppd_name(size);
	}

/// <summary>
/// <para>
/// Gets the paper width of the #GtkPaperSize, in
/// units of @unit.
/// </para>
/// </summary>

/// <param name="size">
/// a #GtkPaperSize object
/// </param>
/// <param name="unit">
/// the unit for the return value, not %GTK_UNIT_NONE
/// </param>
/// <return>
/// the paper width
/// </return>

	public static double GetWidth(this MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit)
	{
		if (size.IsInvalid) throw new Exception("Invalid handle (GtkPaperSize)");
		return GtkPaperSizeExterns.gtk_paper_size_get_width(size, unit);
	}

/// <summary>
/// <para>
/// Returns %TRUE if @size is not a standard paper size.
/// </para>
/// </summary>

/// <param name="size">
/// a #GtkPaperSize object
/// </param>
/// <return>
/// whether @size is a custom paper size.
/// </return>

	public static bool IsCustom(this MentorLake.Gtk.GtkPaperSizeHandle size)
	{
		if (size.IsInvalid) throw new Exception("Invalid handle (GtkPaperSize)");
		return GtkPaperSizeExterns.gtk_paper_size_is_custom(size);
	}

/// <summary>
/// <para>
/// Compares two #GtkPaperSize objects.
/// </para>
/// </summary>

/// <param name="size1">
/// a #GtkPaperSize object
/// </param>
/// <param name="size2">
/// another #GtkPaperSize object
/// </param>
/// <return>
/// %TRUE, if @size1 and @size2
/// represent the same paper size
/// </return>

	public static bool IsEqual(this MentorLake.Gtk.GtkPaperSizeHandle size1, MentorLake.Gtk.GtkPaperSizeHandle size2)
	{
		if (size1.IsInvalid) throw new Exception("Invalid handle (GtkPaperSize)");
		return GtkPaperSizeExterns.gtk_paper_size_is_equal(size1, size2);
	}

/// <summary>
/// <para>
/// Returns %TRUE if @size is an IPP standard paper size.
/// </para>
/// </summary>

/// <param name="size">
/// a #GtkPaperSize object
/// </param>
/// <return>
/// whether @size is not an IPP custom paper size.
/// </return>

	public static bool IsIpp(this MentorLake.Gtk.GtkPaperSizeHandle size)
	{
		if (size.IsInvalid) throw new Exception("Invalid handle (GtkPaperSize)");
		return GtkPaperSizeExterns.gtk_paper_size_is_ipp(size);
	}

/// <summary>
/// <para>
/// Changes the dimensions of a @size to @width x @height.
/// </para>
/// </summary>

/// <param name="size">
/// a custom #GtkPaperSize object
/// </param>
/// <param name="width">
/// the new width in units of @unit
/// </param>
/// <param name="height">
/// the new height in units of @unit
/// </param>
/// <param name="unit">
/// the unit for @width and @height
/// </param>

	public static void SetSize(this MentorLake.Gtk.GtkPaperSizeHandle size, double width, double height, MentorLake.Gtk.GtkUnit unit)
	{
		if (size.IsInvalid) throw new Exception("Invalid handle (GtkPaperSize)");
		GtkPaperSizeExterns.gtk_paper_size_set_size(size, width, height, unit);
	}

/// <summary>
/// <para>
/// Serialize a paper size to an a{sv} variant.
/// </para>
/// </summary>

/// <param name="paper_size">
/// a #GtkPaperSize
/// </param>
/// <return>
/// a new, floating, #GVariant
/// </return>

	public static MentorLake.GLib.GVariantHandle ToGvariant(this MentorLake.Gtk.GtkPaperSizeHandle paper_size)
	{
		if (paper_size.IsInvalid) throw new Exception("Invalid handle (GtkPaperSize)");
		return GtkPaperSizeExterns.gtk_paper_size_to_gvariant(paper_size);
	}

/// <summary>
/// <para>
/// This function adds the paper size from @size to @key_file.
/// </para>
/// </summary>

/// <param name="size">
/// a #GtkPaperSize
/// </param>
/// <param name="key_file">
/// the #GKeyFile to save the paper size to
/// </param>
/// <param name="group_name">
/// the group to add the settings to in @key_file
/// </param>

	public static void ToKeyFile(this MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.GLib.GKeyFileHandle key_file, string group_name)
	{
		if (size.IsInvalid) throw new Exception("Invalid handle (GtkPaperSize)");
		GtkPaperSizeExterns.gtk_paper_size_to_key_file(size, key_file, group_name);
	}


	public static GtkPaperSize Dereference(this GtkPaperSizeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPaperSize>(x.DangerousGetHandle());
}
internal class GtkPaperSizeExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))]
	internal static extern MentorLake.Gtk.GtkPaperSizeHandle gtk_paper_size_new(string name);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))]
	internal static extern MentorLake.Gtk.GtkPaperSizeHandle gtk_paper_size_new_custom(string name, string display_name, double width, double height, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))]
	internal static extern MentorLake.Gtk.GtkPaperSizeHandle gtk_paper_size_new_from_gvariant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle variant);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))]
	internal static extern MentorLake.Gtk.GtkPaperSizeHandle gtk_paper_size_new_from_ipp(string ipp_name, double width, double height);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))]
	internal static extern MentorLake.Gtk.GtkPaperSizeHandle gtk_paper_size_new_from_key_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))]
	internal static extern MentorLake.Gtk.GtkPaperSizeHandle gtk_paper_size_new_from_ppd(string ppd_name, string ppd_display_name, double width, double height);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))]
	internal static extern MentorLake.Gtk.GtkPaperSizeHandle gtk_paper_size_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle other);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paper_size_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_paper_size_get_default_bottom_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_paper_size_get_default_left_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_paper_size_get_default_right_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_paper_size_get_default_top_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_paper_size_get_display_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_paper_size_get_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_paper_size_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_paper_size_get_ppd_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_paper_size_get_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_paper_size_is_custom([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_paper_size_is_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size2);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_paper_size_is_ipp([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paper_size_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size, double width, double height, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle gtk_paper_size_to_gvariant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle paper_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paper_size_to_key_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_paper_size_get_default();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_paper_size_get_paper_sizes(bool include_custom);

}

/// <summary>
/// <para>
/// GtkPaperSize handles paper sizes. It uses the standard called
/// [PWG 5101.1-2002 PWG: Standard for Media Standardized Names](http://www.pwg.org/standards.html)
/// to name the paper sizes (and to get the data for the page sizes).
/// In addition to standard paper sizes, GtkPaperSize allows to
/// construct custom paper sizes with arbitrary dimensions.
/// </para>
/// <para>
/// The #GtkPaperSize object stores not only the dimensions (width
/// and height) of a paper size and its name, it also provides
/// default [print margins][print-margins].
/// </para>
/// <para>
/// Printing support has been added in GTK+ 2.10.
/// </para>
/// </summary>

public struct GtkPaperSize
{
/// <summary>
/// <para>
/// Returns the name of the default paper size, which
/// depends on the current locale.
/// </para>
/// </summary>

/// <return>
/// the name of the default paper size. The string
/// is owned by GTK+ and should not be modified.
/// </return>

	public static string GetDefault()
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_default();
	}

/// <summary>
/// <para>
/// Creates a list of known paper sizes.
/// </para>
/// </summary>

/// <param name="include_custom">
/// whether to include custom paper sizes
///     as defined in the page setup dialog
/// </param>
/// <return>
/// a newly allocated list of newly
///    allocated #GtkPaperSize objects
/// </return>

	public static MentorLake.GLib.GListHandle GetPaperSizes(bool include_custom)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_paper_sizes(include_custom);
	}

}
