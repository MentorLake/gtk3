namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkPrintSettings object represents the settings of a print dialog in
/// a system-independent way. The main use for this object is that once
/// you’ve printed you can get a settings object that represents the settings
/// the user chose, and the next time you print you can pass that object in so
/// that the user doesn’t have to re-set all his settings.
/// </para>
/// <para>
/// Its also possible to enumerate the settings so that you can easily save
/// the settings for the next time your app runs, or even store them in a
/// document. The predefined keys try to use shared values as much as possible
/// so that moving such a document between systems still works.
/// </para>
/// <para>
/// Printing support was added in GTK+ 2.10.
/// </para>
/// </summary>

public class GtkPrintSettingsHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkPrintSettings object.
/// </para>
/// </summary>

/// <return>
/// a new #GtkPrintSettings object
/// </return>

	public static MentorLake.Gtk.GtkPrintSettingsHandle New()
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_new();
	}

/// <summary>
/// <para>
/// Reads the print settings from @file_name. Returns a new #GtkPrintSettings
/// object with the restored settings, or %NULL if an error occurred. If the
/// file could not be loaded then error is set to either a #GFileError or
/// #GKeyFileError.  See gtk_print_settings_to_file().
/// </para>
/// </summary>

/// <param name="file_name">
/// the filename to read the settings from
/// </param>
/// <return>
/// the restored #GtkPrintSettings
/// </return>

	public static MentorLake.Gtk.GtkPrintSettingsHandle NewFromFile(string file_name)
	{
		var externCallResult = GtkPrintSettingsHandleExterns.gtk_print_settings_new_from_file(file_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Deserialize print settings from an a{sv} variant in
/// the format produced by gtk_print_settings_to_gvariant().
/// </para>
/// </summary>

/// <param name="variant">
/// an a{sv} #GVariant
/// </param>
/// <return>
/// a new #GtkPrintSettings object
/// </return>

	public static MentorLake.Gtk.GtkPrintSettingsHandle NewFromGvariant(MentorLake.GLib.GVariantHandle variant)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_new_from_gvariant(variant);
	}

/// <summary>
/// <para>
/// Reads the print settings from the group @group_name in @key_file.  Returns a
/// new #GtkPrintSettings object with the restored settings, or %NULL if an
/// error occurred. If the file could not be loaded then error is set to either
/// a #GFileError or #GKeyFileError.
/// </para>
/// </summary>

/// <param name="key_file">
/// the #GKeyFile to retrieve the settings from
/// </param>
/// <param name="group_name">
/// the name of the group to use, or %NULL to use
///     the default “Print Settings”
/// </param>
/// <return>
/// the restored #GtkPrintSettings
/// </return>

	public static MentorLake.Gtk.GtkPrintSettingsHandle NewFromKeyFile(MentorLake.GLib.GKeyFileHandle key_file, string group_name)
	{
		var externCallResult = GtkPrintSettingsHandleExterns.gtk_print_settings_new_from_key_file(key_file, group_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class GtkPrintSettingsHandleExtensions
{
/// <summary>
/// <para>
/// Copies a #GtkPrintSettings object.
/// </para>
/// </summary>

/// <param name="other">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// a newly allocated copy of @other
/// </return>

	public static MentorLake.Gtk.GtkPrintSettingsHandle Copy(this MentorLake.Gtk.GtkPrintSettingsHandle other)
	{
		if (other.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_copy(other);
	}

/// <summary>
/// <para>
/// Calls @func for each key-value pair of @settings.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="func">
/// the function to call
/// </param>
/// <param name="user_data">
/// user data for @func
/// </param>

	public static T Foreach<T>(this T settings, MentorLake.Gtk.GtkPrintSettingsFunc func, IntPtr user_data) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_foreach(settings, func, user_data);
		return settings;
	}

/// <summary>
/// <para>
/// Looks up the string value associated with @key.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <return>
/// the string value for @key
/// </return>

	public static string Get(this MentorLake.Gtk.GtkPrintSettingsHandle settings, string key)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get(settings, key);
	}

/// <summary>
/// <para>
/// Returns the boolean represented by the value
/// that is associated with @key.
/// </para>
/// <para>
/// The string “true” represents %TRUE, any other
/// string %FALSE.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <return>
/// %TRUE, if @key maps to a true value.
/// </return>

	public static bool GetBool(this MentorLake.Gtk.GtkPrintSettingsHandle settings, string key)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_bool(settings, key);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_COLLATE.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// whether to collate the printed pages
/// </return>

	public static bool GetCollate(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_collate(settings);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_DEFAULT_SOURCE.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// the default source
/// </return>

	public static string GetDefaultSource(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_default_source(settings);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_DITHER.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// the dithering that is used
/// </return>

	public static string GetDither(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_dither(settings);
	}

/// <summary>
/// <para>
/// Returns the double value associated with @key, or 0.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <return>
/// the double value of @key
/// </return>

	public static double GetDouble(this MentorLake.Gtk.GtkPrintSettingsHandle settings, string key)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_double(settings, key);
	}

/// <summary>
/// <para>
/// Returns the floating point number represented by
/// the value that is associated with @key, or @default_val
/// if the value does not represent a floating point number.
/// </para>
/// <para>
/// Floating point numbers are parsed with g_ascii_strtod().
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="def">
/// the default value
/// </param>
/// <return>
/// the floating point number associated with @key
/// </return>

	public static double GetDoubleWithDefault(this MentorLake.Gtk.GtkPrintSettingsHandle settings, string key, double def)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_double_with_default(settings, key, def);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_DUPLEX.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// whether to print the output in duplex.
/// </return>

	public static MentorLake.Gtk.GtkPrintDuplex GetDuplex(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_duplex(settings);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_FINISHINGS.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// the finishings
/// </return>

	public static string GetFinishings(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_finishings(settings);
	}

/// <summary>
/// <para>
/// Returns the integer value of @key, or 0.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <return>
/// the integer value of @key
/// </return>

	public static int GetInt(this MentorLake.Gtk.GtkPrintSettingsHandle settings, string key)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_int(settings, key);
	}

/// <summary>
/// <para>
/// Returns the value of @key, interpreted as
/// an integer, or the default value.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="def">
/// the default value
/// </param>
/// <return>
/// the integer value of @key
/// </return>

	public static int GetIntWithDefault(this MentorLake.Gtk.GtkPrintSettingsHandle settings, string key, int def)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_int_with_default(settings, key, def);
	}

/// <summary>
/// <para>
/// Returns the value associated with @key, interpreted
/// as a length. The returned value is converted to @units.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="unit">
/// the unit of the return value
/// </param>
/// <return>
/// the length value of @key, converted to @unit
/// </return>

	public static double GetLength(this MentorLake.Gtk.GtkPrintSettingsHandle settings, string key, MentorLake.Gtk.GtkUnit unit)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_length(settings, key, unit);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_MEDIA_TYPE.
/// </para>
/// <para>
/// The set of media types is defined in PWG 5101.1-2002 PWG.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// the media type
/// </return>

	public static string GetMediaType(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_media_type(settings);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_N_COPIES.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// the number of copies to print
/// </return>

	public static int GetNCopies(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_n_copies(settings);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_NUMBER_UP.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// the number of pages per sheet
/// </return>

	public static int GetNumberUp(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_number_up(settings);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_NUMBER_UP_LAYOUT.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// layout of page in number-up mode
/// </return>

	public static MentorLake.Gtk.GtkNumberUpLayout GetNumberUpLayout(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_number_up_layout(settings);
	}

/// <summary>
/// <para>
/// Get the value of %GTK_PRINT_SETTINGS_ORIENTATION,
/// converted to a #GtkPageOrientation.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// the orientation
/// </return>

	public static MentorLake.Gtk.GtkPageOrientation GetOrientation(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_orientation(settings);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_OUTPUT_BIN.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// the output bin
/// </return>

	public static string GetOutputBin(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_output_bin(settings);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_PAGE_RANGES.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="num_ranges">
/// return location for the length of the returned array
/// </param>
/// <return>
/// an array
///     of #GtkPageRanges.  Use g_free() to free the array when
///     it is no longer needed.
/// </return>

	public static MentorLake.Gtk.GtkPageRange[] GetPageRanges(this MentorLake.Gtk.GtkPrintSettingsHandle settings, out int num_ranges)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_page_ranges(settings, out num_ranges);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_PAGE_SET.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// the set of pages to print
/// </return>

	public static MentorLake.Gtk.GtkPageSet GetPageSet(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_page_set(settings);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_PAPER_HEIGHT,
/// converted to @unit.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="unit">
/// the unit for the return value
/// </param>
/// <return>
/// the paper height, in units of @unit
/// </return>

	public static double GetPaperHeight(this MentorLake.Gtk.GtkPrintSettingsHandle settings, MentorLake.Gtk.GtkUnit unit)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_paper_height(settings, unit);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_PAPER_FORMAT,
/// converted to a #GtkPaperSize.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// the paper size
/// </return>

	public static MentorLake.Gtk.GtkPaperSizeHandle GetPaperSize(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_paper_size(settings);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_PAPER_WIDTH,
/// converted to @unit.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="unit">
/// the unit for the return value
/// </param>
/// <return>
/// the paper width, in units of @unit
/// </return>

	public static double GetPaperWidth(this MentorLake.Gtk.GtkPrintSettingsHandle settings, MentorLake.Gtk.GtkUnit unit)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_paper_width(settings, unit);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_PRINT_PAGES.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// which pages to print
/// </return>

	public static MentorLake.Gtk.GtkPrintPages GetPrintPages(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_print_pages(settings);
	}

/// <summary>
/// <para>
/// Convenience function to obtain the value of
/// %GTK_PRINT_SETTINGS_PRINTER.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// the printer name
/// </return>

	public static string GetPrinter(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_printer(settings);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_PRINTER_LPI.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// the resolution in lpi (lines per inch)
/// </return>

	public static double GetPrinterLpi(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_printer_lpi(settings);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_QUALITY.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// the print quality
/// </return>

	public static MentorLake.Gtk.GtkPrintQuality GetQuality(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_quality(settings);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_RESOLUTION.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// the resolution in dpi
/// </return>

	public static int GetResolution(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_resolution(settings);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_RESOLUTION_X.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// the horizontal resolution in dpi
/// </return>

	public static int GetResolutionX(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_resolution_x(settings);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_RESOLUTION_Y.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// the vertical resolution in dpi
/// </return>

	public static int GetResolutionY(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_resolution_y(settings);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_REVERSE.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// whether to reverse the order of the printed pages
/// </return>

	public static bool GetReverse(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_reverse(settings);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_SCALE.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// the scale in percent
/// </return>

	public static double GetScale(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_scale(settings);
	}

/// <summary>
/// <para>
/// Gets the value of %GTK_PRINT_SETTINGS_USE_COLOR.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// whether to use color
/// </return>

	public static bool GetUseColor(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_use_color(settings);
	}

/// <summary>
/// <para>
/// Returns %TRUE, if a value is associated with @key.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <return>
/// %TRUE, if @key has a value
/// </return>

	public static bool HasKey(this MentorLake.Gtk.GtkPrintSettingsHandle settings, string key)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_has_key(settings, key);
	}

/// <summary>
/// <para>
/// Reads the print settings from @file_name. If the file could not be loaded
/// then error is set to either a #GFileError or #GKeyFileError.
/// See gtk_print_settings_to_file().
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="file_name">
/// the filename to read the settings from
/// </param>
/// <return>
/// %TRUE on success
/// </return>

	public static bool LoadFile(this MentorLake.Gtk.GtkPrintSettingsHandle settings, string file_name)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		var externCallResult = GtkPrintSettingsHandleExterns.gtk_print_settings_load_file(settings, file_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Reads the print settings from the group @group_name in @key_file. If the
/// file could not be loaded then error is set to either a #GFileError or
/// #GKeyFileError.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="key_file">
/// the #GKeyFile to retrieve the settings from
/// </param>
/// <param name="group_name">
/// the name of the group to use, or %NULL to use the default
///     “Print Settings”
/// </param>
/// <return>
/// %TRUE on success
/// </return>

	public static bool LoadKeyFile(this MentorLake.Gtk.GtkPrintSettingsHandle settings, MentorLake.GLib.GKeyFileHandle key_file, string group_name)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		var externCallResult = GtkPrintSettingsHandleExterns.gtk_print_settings_load_key_file(settings, key_file, group_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Associates @value with @key.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="value">
/// a string value, or %NULL
/// </param>

	public static T Set<T>(this T settings, string key, string value) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set(settings, key, value);
		return settings;
	}

/// <summary>
/// <para>
/// Sets @key to a boolean value.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="value">
/// a boolean
/// </param>

	public static T SetBool<T>(this T settings, string key, bool value) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_bool(settings, key, value);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_COLLATE.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="collate">
/// whether to collate the output
/// </param>

	public static T SetCollate<T>(this T settings, bool collate) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_collate(settings, collate);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_DEFAULT_SOURCE.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="default_source">
/// the default source
/// </param>

	public static T SetDefaultSource<T>(this T settings, string default_source) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_default_source(settings, default_source);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_DITHER.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="dither">
/// the dithering that is used
/// </param>

	public static T SetDither<T>(this T settings, string dither) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_dither(settings, dither);
		return settings;
	}

/// <summary>
/// <para>
/// Sets @key to a double value.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="value">
/// a double value
/// </param>

	public static T SetDouble<T>(this T settings, string key, double value) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_double(settings, key, value);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_DUPLEX.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="duplex">
/// a #GtkPrintDuplex value
/// </param>

	public static T SetDuplex<T>(this T settings, MentorLake.Gtk.GtkPrintDuplex duplex) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_duplex(settings, duplex);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_FINISHINGS.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="finishings">
/// the finishings
/// </param>

	public static T SetFinishings<T>(this T settings, string finishings) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_finishings(settings, finishings);
		return settings;
	}

/// <summary>
/// <para>
/// Sets @key to an integer value.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="value">
/// an integer
/// </param>

	public static T SetInt<T>(this T settings, string key, int value) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_int(settings, key, value);
		return settings;
	}

/// <summary>
/// <para>
/// Associates a length in units of @unit with @key.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="value">
/// a length
/// </param>
/// <param name="unit">
/// the unit of @length
/// </param>

	public static T SetLength<T>(this T settings, string key, double value, MentorLake.Gtk.GtkUnit unit) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_length(settings, key, value, unit);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_MEDIA_TYPE.
/// </para>
/// <para>
/// The set of media types is defined in PWG 5101.1-2002 PWG.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="media_type">
/// the media type
/// </param>

	public static T SetMediaType<T>(this T settings, string media_type) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_media_type(settings, media_type);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_N_COPIES.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="num_copies">
/// the number of copies
/// </param>

	public static T SetNCopies<T>(this T settings, int num_copies) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_n_copies(settings, num_copies);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_NUMBER_UP.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="number_up">
/// the number of pages per sheet
/// </param>

	public static T SetNumberUp<T>(this T settings, int number_up) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_number_up(settings, number_up);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_NUMBER_UP_LAYOUT.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="number_up_layout">
/// a #GtkNumberUpLayout value
/// </param>

	public static T SetNumberUpLayout<T>(this T settings, MentorLake.Gtk.GtkNumberUpLayout number_up_layout) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_number_up_layout(settings, number_up_layout);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_ORIENTATION.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="orientation">
/// a page orientation
/// </param>

	public static T SetOrientation<T>(this T settings, MentorLake.Gtk.GtkPageOrientation orientation) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_orientation(settings, orientation);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_OUTPUT_BIN.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="output_bin">
/// the output bin
/// </param>

	public static T SetOutputBin<T>(this T settings, string output_bin) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_output_bin(settings, output_bin);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_PAGE_RANGES.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="page_ranges">
/// an array of #GtkPageRanges
/// </param>
/// <param name="num_ranges">
/// the length of @page_ranges
/// </param>

	public static T SetPageRanges<T>(this T settings, MentorLake.Gtk.GtkPageRange[] page_ranges, int num_ranges) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_page_ranges(settings, page_ranges, num_ranges);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_PAGE_SET.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="page_set">
/// a #GtkPageSet value
/// </param>

	public static T SetPageSet<T>(this T settings, MentorLake.Gtk.GtkPageSet page_set) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_page_set(settings, page_set);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_PAPER_HEIGHT.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="height">
/// the paper height
/// </param>
/// <param name="unit">
/// the units of @height
/// </param>

	public static T SetPaperHeight<T>(this T settings, double height, MentorLake.Gtk.GtkUnit unit) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_paper_height(settings, height, unit);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_PAPER_FORMAT,
/// %GTK_PRINT_SETTINGS_PAPER_WIDTH and
/// %GTK_PRINT_SETTINGS_PAPER_HEIGHT.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="paper_size">
/// a paper size
/// </param>

	public static T SetPaperSize<T>(this T settings, MentorLake.Gtk.GtkPaperSizeHandle paper_size) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_paper_size(settings, paper_size);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_PAPER_WIDTH.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="width">
/// the paper width
/// </param>
/// <param name="unit">
/// the units of @width
/// </param>

	public static T SetPaperWidth<T>(this T settings, double width, MentorLake.Gtk.GtkUnit unit) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_paper_width(settings, width, unit);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_PRINT_PAGES.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="pages">
/// a #GtkPrintPages value
/// </param>

	public static T SetPrintPages<T>(this T settings, MentorLake.Gtk.GtkPrintPages pages) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_print_pages(settings, pages);
		return settings;
	}

/// <summary>
/// <para>
/// Convenience function to set %GTK_PRINT_SETTINGS_PRINTER
/// to @printer.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="printer">
/// the printer name
/// </param>

	public static T SetPrinter<T>(this T settings, string printer) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_printer(settings, printer);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_PRINTER_LPI.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="lpi">
/// the resolution in lpi (lines per inch)
/// </param>

	public static T SetPrinterLpi<T>(this T settings, double lpi) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_printer_lpi(settings, lpi);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_QUALITY.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="quality">
/// a #GtkPrintQuality value
/// </param>

	public static T SetQuality<T>(this T settings, MentorLake.Gtk.GtkPrintQuality quality) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_quality(settings, quality);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the values of %GTK_PRINT_SETTINGS_RESOLUTION,
/// %GTK_PRINT_SETTINGS_RESOLUTION_X and
/// %GTK_PRINT_SETTINGS_RESOLUTION_Y.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="resolution">
/// the resolution in dpi
/// </param>

	public static T SetResolution<T>(this T settings, int resolution) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_resolution(settings, resolution);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the values of %GTK_PRINT_SETTINGS_RESOLUTION,
/// %GTK_PRINT_SETTINGS_RESOLUTION_X and
/// %GTK_PRINT_SETTINGS_RESOLUTION_Y.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="resolution_x">
/// the horizontal resolution in dpi
/// </param>
/// <param name="resolution_y">
/// the vertical resolution in dpi
/// </param>

	public static T SetResolutionXy<T>(this T settings, int resolution_x, int resolution_y) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_resolution_xy(settings, resolution_x, resolution_y);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_REVERSE.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="reverse">
/// whether to reverse the output
/// </param>

	public static T SetReverse<T>(this T settings, bool reverse) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_reverse(settings, reverse);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_SCALE.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="scale">
/// the scale in percent
/// </param>

	public static T SetScale<T>(this T settings, double scale) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_scale(settings, scale);
		return settings;
	}

/// <summary>
/// <para>
/// Sets the value of %GTK_PRINT_SETTINGS_USE_COLOR.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="use_color">
/// whether to use color
/// </param>

	public static T SetUseColor<T>(this T settings, bool use_color) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_use_color(settings, use_color);
		return settings;
	}

/// <summary>
/// <para>
/// This function saves the print settings from @settings to @file_name. If the
/// file could not be loaded then error is set to either a #GFileError or
/// #GKeyFileError.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="file_name">
/// the file to save to
/// </param>
/// <return>
/// %TRUE on success
/// </return>

	public static bool ToFile(this MentorLake.Gtk.GtkPrintSettingsHandle settings, string file_name)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		var externCallResult = GtkPrintSettingsHandleExterns.gtk_print_settings_to_file(settings, file_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Serialize print settings to an a{sv} variant.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <return>
/// a new, floating, #GVariant
/// </return>

	public static MentorLake.GLib.GVariantHandle ToGvariant(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		return GtkPrintSettingsHandleExterns.gtk_print_settings_to_gvariant(settings);
	}

/// <summary>
/// <para>
/// This function adds the print settings from @settings to @key_file.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="key_file">
/// the #GKeyFile to save the print settings to
/// </param>
/// <param name="group_name">
/// the group to add the settings to in @key_file, or
///     %NULL to use the default “Print Settings”
/// </param>

	public static T ToKeyFile<T>(this T settings, MentorLake.GLib.GKeyFileHandle key_file, string group_name) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_to_key_file(settings, key_file, group_name);
		return settings;
	}

/// <summary>
/// <para>
/// Removes any value associated with @key.
/// This has the same effect as setting the value to %NULL.
/// </para>
/// </summary>

/// <param name="settings">
/// a #GtkPrintSettings
/// </param>
/// <param name="key">
/// a key
/// </param>

	public static T Unset<T>(this T settings, string key) where T : GtkPrintSettingsHandle
	{
		if (settings.IsInvalid) throw new Exception("Invalid handle (GtkPrintSettingsHandle)");
		GtkPrintSettingsHandleExterns.gtk_print_settings_unset(settings, key);
		return settings;
	}

}

internal class GtkPrintSettingsHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))]
	internal static extern MentorLake.Gtk.GtkPrintSettingsHandle gtk_print_settings_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))]
	internal static extern MentorLake.Gtk.GtkPrintSettingsHandle gtk_print_settings_new_from_file(string file_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))]
	internal static extern MentorLake.Gtk.GtkPrintSettingsHandle gtk_print_settings_new_from_gvariant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle variant);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))]
	internal static extern MentorLake.Gtk.GtkPrintSettingsHandle gtk_print_settings_new_from_key_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))]
	internal static extern MentorLake.Gtk.GtkPrintSettingsHandle gtk_print_settings_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle other);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, MentorLake.Gtk.GtkPrintSettingsFunc func, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string key);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_print_settings_get_bool([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string key);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_print_settings_get_collate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get_default_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get_dither([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_print_settings_get_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string key);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_print_settings_get_double_with_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string key, double def);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPrintDuplex gtk_print_settings_get_duplex([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get_finishings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_print_settings_get_int([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string key);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_print_settings_get_int_with_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string key, int def);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_print_settings_get_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string key, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get_media_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_print_settings_get_n_copies([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_print_settings_get_number_up([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkNumberUpLayout gtk_print_settings_get_number_up_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPageOrientation gtk_print_settings_get_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get_output_bin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPageRange[] gtk_print_settings_get_page_ranges([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, out int num_ranges);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPageSet gtk_print_settings_get_page_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_print_settings_get_paper_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))]
	internal static extern MentorLake.Gtk.GtkPaperSizeHandle gtk_print_settings_get_paper_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_print_settings_get_paper_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPrintPages gtk_print_settings_get_print_pages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get_printer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_print_settings_get_printer_lpi([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPrintQuality gtk_print_settings_get_quality([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_print_settings_get_resolution([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_print_settings_get_resolution_x([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_print_settings_get_resolution_y([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_print_settings_get_reverse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_print_settings_get_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_print_settings_get_use_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_print_settings_has_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string key);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_print_settings_load_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string file_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_print_settings_load_key_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string key, string value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_bool([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string key, bool value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_collate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, bool collate);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_default_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string default_source);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_dither([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string dither);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string key, double value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_duplex([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, MentorLake.Gtk.GtkPrintDuplex duplex);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_finishings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string finishings);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_int([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string key, int value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string key, double value, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_media_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string media_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_n_copies([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, int num_copies);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_number_up([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, int number_up);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_number_up_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, MentorLake.Gtk.GtkNumberUpLayout number_up_layout);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_orientation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, MentorLake.Gtk.GtkPageOrientation orientation);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_output_bin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string output_bin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_page_ranges([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, MentorLake.Gtk.GtkPageRange[] page_ranges, int num_ranges);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_page_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, MentorLake.Gtk.GtkPageSet page_set);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_paper_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, double height, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_paper_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle paper_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_paper_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, double width, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_print_pages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, MentorLake.Gtk.GtkPrintPages pages);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_printer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string printer);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_printer_lpi([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, double lpi);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_quality([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, MentorLake.Gtk.GtkPrintQuality quality);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_resolution([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, int resolution);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_resolution_xy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, int resolution_x, int resolution_y);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_reverse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, bool reverse);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, double scale);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_set_use_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, bool use_color);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_print_settings_to_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string file_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle gtk_print_settings_to_gvariant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_to_key_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_unset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string key);

}
