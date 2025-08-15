namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkPageSetup object stores the page size, orientation and margins.
/// The idea is that you can get one of these from the page setup dialog
/// and then pass it to the #GtkPrintOperation when printing.
/// The benefit of splitting this out of the #GtkPrintSettings is that
/// these affect the actual layout of the page, and thus need to be set
/// long before user prints.
/// </para>
/// <para>
/// ## Margins ## {#print-margins}
/// The margins specified in this object are the “print margins”, i.e. the
/// parts of the page that the printer cannot print on. These are different
/// from the layout margins that a word processor uses; they are typically
/// used to determine the minimal size for the layout
/// margins.
/// </para>
/// <para>
/// To obtain a #GtkPageSetup use gtk_page_setup_new() to get the defaults,
/// or use gtk_print_run_page_setup_dialog() to show the page setup dialog
/// and receive the resulting page setup.
/// </para>
/// <para>
/// ## A page setup dialog
/// </para>
/// <code>
/// static GtkPrintSettings *settings = NULL;
/// static GtkPrintSettings *settings = NULL;
/// static GtkPageSetup *page_setup = NULL;
/// 
/// static void
/// do_page_setup (void)
/// {
///   GtkPageSetup *new_page_setup;
/// 
///   if (settings == NULL)
///     settings = gtk_print_settings_new ();
/// 
///   new_page_setup = gtk_print_run_page_setup_dialog (GTK_WINDOW (main_window),
///                                                     page_setup, settings);
/// 
///   if (page_setup)
///     g_object_unref (page_setup);
/// 
///   page_setup = new_page_setup;
/// }
/// </code>
/// <para>
/// Printing support was added in GTK+ 2.10.
/// </para>
/// </summary>

public class GtkPageSetupHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkPageSetup.
/// </para>
/// </summary>

/// <return>
/// a new #GtkPageSetup.
/// </return>

	public static MentorLake.Gtk.GtkPageSetupHandle New()
	{
		return GtkPageSetupHandleExterns.gtk_page_setup_new();
	}

/// <summary>
/// <para>
/// Reads the page setup from the file @file_name. Returns a
/// new #GtkPageSetup object with the restored page setup,
/// or %NULL if an error occurred. See gtk_page_setup_to_file().
/// </para>
/// </summary>

/// <param name="file_name">
/// the filename to read the page setup from
/// </param>
/// <return>
/// the restored #GtkPageSetup
/// </return>

	public static MentorLake.Gtk.GtkPageSetupHandle NewFromFile(string file_name)
	{
		var externCallResult = GtkPageSetupHandleExterns.gtk_page_setup_new_from_file(file_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Desrialize a page setup from an a{sv} variant in
/// the format produced by gtk_page_setup_to_gvariant().
/// </para>
/// </summary>

/// <param name="variant">
/// an a{sv} #GVariant
/// </param>
/// <return>
/// a new #GtkPageSetup object
/// </return>

	public static MentorLake.Gtk.GtkPageSetupHandle NewFromGvariant(MentorLake.GLib.GVariantHandle variant)
	{
		return GtkPageSetupHandleExterns.gtk_page_setup_new_from_gvariant(variant);
	}

/// <summary>
/// <para>
/// Reads the page setup from the group @group_name in the key file
/// @key_file. Returns a new #GtkPageSetup object with the restored
/// page setup, or %NULL if an error occurred.
/// </para>
/// </summary>

/// <param name="key_file">
/// the #GKeyFile to retrieve the page_setup from
/// </param>
/// <param name="group_name">
/// the name of the group in the key_file to read, or %NULL
///              to use the default name “Page Setup”
/// </param>
/// <return>
/// the restored #GtkPageSetup
/// </return>

	public static MentorLake.Gtk.GtkPageSetupHandle NewFromKeyFile(MentorLake.GLib.GKeyFileHandle key_file, string group_name)
	{
		var externCallResult = GtkPageSetupHandleExterns.gtk_page_setup_new_from_key_file(key_file, group_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class GtkPageSetupHandleExtensions
{
/// <summary>
/// <para>
/// Copies a #GtkPageSetup.
/// </para>
/// </summary>

/// <param name="other">
/// the #GtkPageSetup to copy
/// </param>
/// <return>
/// a copy of @other
/// </return>

	public static MentorLake.Gtk.GtkPageSetupHandle Copy(this MentorLake.Gtk.GtkPageSetupHandle other)
	{
		if (other.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_copy(other);
	}

/// <summary>
/// <para>
/// Gets the bottom margin in units of @unit.
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <param name="unit">
/// the unit for the return value
/// </param>
/// <return>
/// the bottom margin
/// </return>

	public static double GetBottomMargin(this MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit)
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_get_bottom_margin(setup, unit);
	}

/// <summary>
/// <para>
/// Gets the left margin in units of @unit.
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <param name="unit">
/// the unit for the return value
/// </param>
/// <return>
/// the left margin
/// </return>

	public static double GetLeftMargin(this MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit)
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_get_left_margin(setup, unit);
	}

/// <summary>
/// <para>
/// Gets the page orientation of the #GtkPageSetup.
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <return>
/// the page orientation
/// </return>

	public static MentorLake.Gtk.GtkPageOrientation GetOrientation(this MentorLake.Gtk.GtkPageSetupHandle setup)
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_get_orientation(setup);
	}

/// <summary>
/// <para>
/// Returns the page height in units of @unit.
/// </para>
/// <para>
/// Note that this function takes orientation and
/// margins into consideration.
/// See gtk_page_setup_get_paper_height().
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <param name="unit">
/// the unit for the return value
/// </param>
/// <return>
/// the page height.
/// </return>

	public static double GetPageHeight(this MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit)
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_get_page_height(setup, unit);
	}

/// <summary>
/// <para>
/// Returns the page width in units of @unit.
/// </para>
/// <para>
/// Note that this function takes orientation and
/// margins into consideration.
/// See gtk_page_setup_get_paper_width().
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <param name="unit">
/// the unit for the return value
/// </param>
/// <return>
/// the page width.
/// </return>

	public static double GetPageWidth(this MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit)
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_get_page_width(setup, unit);
	}

/// <summary>
/// <para>
/// Returns the paper height in units of @unit.
/// </para>
/// <para>
/// Note that this function takes orientation, but
/// not margins into consideration.
/// See gtk_page_setup_get_page_height().
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <param name="unit">
/// the unit for the return value
/// </param>
/// <return>
/// the paper height.
/// </return>

	public static double GetPaperHeight(this MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit)
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_get_paper_height(setup, unit);
	}

/// <summary>
/// <para>
/// Gets the paper size of the #GtkPageSetup.
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <return>
/// the paper size
/// </return>

	public static MentorLake.Gtk.GtkPaperSizeHandle GetPaperSize(this MentorLake.Gtk.GtkPageSetupHandle setup)
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_get_paper_size(setup);
	}

/// <summary>
/// <para>
/// Returns the paper width in units of @unit.
/// </para>
/// <para>
/// Note that this function takes orientation, but
/// not margins into consideration.
/// See gtk_page_setup_get_page_width().
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <param name="unit">
/// the unit for the return value
/// </param>
/// <return>
/// the paper width.
/// </return>

	public static double GetPaperWidth(this MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit)
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_get_paper_width(setup, unit);
	}

/// <summary>
/// <para>
/// Gets the right margin in units of @unit.
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <param name="unit">
/// the unit for the return value
/// </param>
/// <return>
/// the right margin
/// </return>

	public static double GetRightMargin(this MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit)
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_get_right_margin(setup, unit);
	}

/// <summary>
/// <para>
/// Gets the top margin in units of @unit.
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <param name="unit">
/// the unit for the return value
/// </param>
/// <return>
/// the top margin
/// </return>

	public static double GetTopMargin(this MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit)
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_get_top_margin(setup, unit);
	}

/// <summary>
/// <para>
/// Reads the page setup from the file @file_name.
/// See gtk_page_setup_to_file().
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <param name="file_name">
/// the filename to read the page setup from
/// </param>
/// <return>
/// %TRUE on success
/// </return>

	public static bool LoadFile(this MentorLake.Gtk.GtkPageSetupHandle setup, string file_name)
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		var externCallResult = GtkPageSetupHandleExterns.gtk_page_setup_load_file(setup, file_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Reads the page setup from the group @group_name in the key file
/// @key_file.
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <param name="key_file">
/// the #GKeyFile to retrieve the page_setup from
/// </param>
/// <param name="group_name">
/// the name of the group in the key_file to read, or %NULL
///              to use the default name “Page Setup”
/// </param>
/// <return>
/// %TRUE on success
/// </return>

	public static bool LoadKeyFile(this MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.GLib.GKeyFileHandle key_file, string group_name)
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		var externCallResult = GtkPageSetupHandleExterns.gtk_page_setup_load_key_file(setup, key_file, group_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets the bottom margin of the #GtkPageSetup.
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <param name="margin">
/// the new bottom margin in units of @unit
/// </param>
/// <param name="unit">
/// the units for @margin
/// </param>

	public static T SetBottomMargin<T>(this T setup, double margin, MentorLake.Gtk.GtkUnit unit) where T : GtkPageSetupHandle
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		GtkPageSetupHandleExterns.gtk_page_setup_set_bottom_margin(setup, margin, unit);
		return setup;
	}

/// <summary>
/// <para>
/// Sets the left margin of the #GtkPageSetup.
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <param name="margin">
/// the new left margin in units of @unit
/// </param>
/// <param name="unit">
/// the units for @margin
/// </param>

	public static T SetLeftMargin<T>(this T setup, double margin, MentorLake.Gtk.GtkUnit unit) where T : GtkPageSetupHandle
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		GtkPageSetupHandleExterns.gtk_page_setup_set_left_margin(setup, margin, unit);
		return setup;
	}

/// <summary>
/// <para>
/// Sets the page orientation of the #GtkPageSetup.
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <param name="orientation">
/// a #GtkPageOrientation value
/// </param>

	public static T SetOrientation<T>(this T setup, MentorLake.Gtk.GtkPageOrientation orientation) where T : GtkPageSetupHandle
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		GtkPageSetupHandleExterns.gtk_page_setup_set_orientation(setup, orientation);
		return setup;
	}

/// <summary>
/// <para>
/// Sets the paper size of the #GtkPageSetup without
/// changing the margins. See
/// gtk_page_setup_set_paper_size_and_default_margins().
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <param name="size">
/// a #GtkPaperSize
/// </param>

	public static T SetPaperSize<T>(this T setup, MentorLake.Gtk.GtkPaperSizeHandle size) where T : GtkPageSetupHandle
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		GtkPageSetupHandleExterns.gtk_page_setup_set_paper_size(setup, size);
		return setup;
	}

/// <summary>
/// <para>
/// Sets the paper size of the #GtkPageSetup and modifies
/// the margins according to the new paper size.
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <param name="size">
/// a #GtkPaperSize
/// </param>

	public static T SetPaperSizeAndDefaultMargins<T>(this T setup, MentorLake.Gtk.GtkPaperSizeHandle size) where T : GtkPageSetupHandle
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		GtkPageSetupHandleExterns.gtk_page_setup_set_paper_size_and_default_margins(setup, size);
		return setup;
	}

/// <summary>
/// <para>
/// Sets the right margin of the #GtkPageSetup.
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <param name="margin">
/// the new right margin in units of @unit
/// </param>
/// <param name="unit">
/// the units for @margin
/// </param>

	public static T SetRightMargin<T>(this T setup, double margin, MentorLake.Gtk.GtkUnit unit) where T : GtkPageSetupHandle
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		GtkPageSetupHandleExterns.gtk_page_setup_set_right_margin(setup, margin, unit);
		return setup;
	}

/// <summary>
/// <para>
/// Sets the top margin of the #GtkPageSetup.
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <param name="margin">
/// the new top margin in units of @unit
/// </param>
/// <param name="unit">
/// the units for @margin
/// </param>

	public static T SetTopMargin<T>(this T setup, double margin, MentorLake.Gtk.GtkUnit unit) where T : GtkPageSetupHandle
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		GtkPageSetupHandleExterns.gtk_page_setup_set_top_margin(setup, margin, unit);
		return setup;
	}

/// <summary>
/// <para>
/// This function saves the information from @setup to @file_name.
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <param name="file_name">
/// the file to save to
/// </param>
/// <return>
/// %TRUE on success
/// </return>

	public static bool ToFile(this MentorLake.Gtk.GtkPageSetupHandle setup, string file_name)
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		var externCallResult = GtkPageSetupHandleExterns.gtk_page_setup_to_file(setup, file_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Serialize page setup to an a{sv} variant.
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <return>
/// a new, floating, #GVariant
/// </return>

	public static MentorLake.GLib.GVariantHandle ToGvariant(this MentorLake.Gtk.GtkPageSetupHandle setup)
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_to_gvariant(setup);
	}

/// <summary>
/// <para>
/// This function adds the page setup from @setup to @key_file.
/// </para>
/// </summary>

/// <param name="setup">
/// a #GtkPageSetup
/// </param>
/// <param name="key_file">
/// the #GKeyFile to save the page setup to
/// </param>
/// <param name="group_name">
/// the group to add the settings to in @key_file,
///      or %NULL to use the default name “Page Setup”
/// </param>

	public static T ToKeyFile<T>(this T setup, MentorLake.GLib.GKeyFileHandle key_file, string group_name) where T : GtkPageSetupHandle
	{
		if (setup.IsInvalid) throw new Exception("Invalid handle (GtkPageSetupHandle)");
		GtkPageSetupHandleExterns.gtk_page_setup_to_key_file(setup, key_file, group_name);
		return setup;
	}

}

internal class GtkPageSetupHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))]
	internal static extern MentorLake.Gtk.GtkPageSetupHandle gtk_page_setup_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))]
	internal static extern MentorLake.Gtk.GtkPageSetupHandle gtk_page_setup_new_from_file(string file_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))]
	internal static extern MentorLake.Gtk.GtkPageSetupHandle gtk_page_setup_new_from_gvariant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle variant);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))]
	internal static extern MentorLake.Gtk.GtkPageSetupHandle gtk_page_setup_new_from_key_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))]
	internal static extern MentorLake.Gtk.GtkPageSetupHandle gtk_page_setup_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle other);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_page_setup_get_bottom_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_page_setup_get_left_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPageOrientation gtk_page_setup_get_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_page_setup_get_page_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_page_setup_get_page_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_page_setup_get_paper_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))]
	internal static extern MentorLake.Gtk.GtkPaperSizeHandle gtk_page_setup_get_paper_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_page_setup_get_paper_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_page_setup_get_right_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_page_setup_get_top_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_page_setup_load_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, string file_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_page_setup_load_key_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_page_setup_set_bottom_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, double margin, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_page_setup_set_left_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, double margin, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_page_setup_set_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkPageOrientation orientation);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_page_setup_set_paper_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_page_setup_set_paper_size_and_default_margins([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_page_setup_set_right_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, double margin, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_page_setup_set_top_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, double margin, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_page_setup_to_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, string file_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle gtk_page_setup_to_gvariant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_page_setup_to_key_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name);

}
