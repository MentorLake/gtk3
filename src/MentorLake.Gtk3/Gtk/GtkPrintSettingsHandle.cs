namespace MentorLake.Gtk;

public class GtkPrintSettingsHandle : GObjectHandle
{
	public static MentorLake.Gtk.GtkPrintSettingsHandle New()
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_new();
	}

	public static MentorLake.Gtk.GtkPrintSettingsHandle NewFromFile(string file_name)
	{
		var externCallResult = GtkPrintSettingsHandleExterns.gtk_print_settings_new_from_file(file_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gtk.GtkPrintSettingsHandle NewFromGvariant(MentorLake.GLib.GVariantHandle variant)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_new_from_gvariant(variant);
	}

	public static MentorLake.Gtk.GtkPrintSettingsHandle NewFromKeyFile(MentorLake.GLib.GKeyFileHandle key_file, string group_name)
	{
		var externCallResult = GtkPrintSettingsHandleExterns.gtk_print_settings_new_from_key_file(key_file, group_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class GtkPrintSettingsHandleExtensions
{
	public static MentorLake.Gtk.GtkPrintSettingsHandle Copy(this MentorLake.Gtk.GtkPrintSettingsHandle other)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_copy(other);
	}

	public static T Foreach<T>(this T settings, MentorLake.Gtk.GtkPrintSettingsFunc func, IntPtr user_data) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_foreach(settings, func, user_data);
		return settings;
	}

	public static string Get(this MentorLake.Gtk.GtkPrintSettingsHandle settings, string key)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get(settings, key);
	}

	public static bool GetBool(this MentorLake.Gtk.GtkPrintSettingsHandle settings, string key)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_bool(settings, key);
	}

	public static bool GetCollate(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_collate(settings);
	}

	public static string GetDefaultSource(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_default_source(settings);
	}

	public static string GetDither(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_dither(settings);
	}

	public static double GetDouble(this MentorLake.Gtk.GtkPrintSettingsHandle settings, string key)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_double(settings, key);
	}

	public static double GetDoubleWithDefault(this MentorLake.Gtk.GtkPrintSettingsHandle settings, string key, double def)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_double_with_default(settings, key, def);
	}

	public static MentorLake.Gtk.GtkPrintDuplex GetDuplex(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_duplex(settings);
	}

	public static string GetFinishings(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_finishings(settings);
	}

	public static int GetInt(this MentorLake.Gtk.GtkPrintSettingsHandle settings, string key)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_int(settings, key);
	}

	public static int GetIntWithDefault(this MentorLake.Gtk.GtkPrintSettingsHandle settings, string key, int def)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_int_with_default(settings, key, def);
	}

	public static double GetLength(this MentorLake.Gtk.GtkPrintSettingsHandle settings, string key, MentorLake.Gtk.GtkUnit unit)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_length(settings, key, unit);
	}

	public static string GetMediaType(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_media_type(settings);
	}

	public static int GetNCopies(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_n_copies(settings);
	}

	public static int GetNumberUp(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_number_up(settings);
	}

	public static MentorLake.Gtk.GtkNumberUpLayout GetNumberUpLayout(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_number_up_layout(settings);
	}

	public static MentorLake.Gtk.GtkPageOrientation GetOrientation(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_orientation(settings);
	}

	public static string GetOutputBin(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_output_bin(settings);
	}

	public static MentorLake.Gtk.GtkPageRange[] GetPageRanges(this MentorLake.Gtk.GtkPrintSettingsHandle settings, out int num_ranges)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_page_ranges(settings, out num_ranges);
	}

	public static MentorLake.Gtk.GtkPageSet GetPageSet(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_page_set(settings);
	}

	public static double GetPaperHeight(this MentorLake.Gtk.GtkPrintSettingsHandle settings, MentorLake.Gtk.GtkUnit unit)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_paper_height(settings, unit);
	}

	public static MentorLake.Gtk.GtkPaperSizeHandle GetPaperSize(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_paper_size(settings);
	}

	public static double GetPaperWidth(this MentorLake.Gtk.GtkPrintSettingsHandle settings, MentorLake.Gtk.GtkUnit unit)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_paper_width(settings, unit);
	}

	public static MentorLake.Gtk.GtkPrintPages GetPrintPages(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_print_pages(settings);
	}

	public static string GetPrinter(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_printer(settings);
	}

	public static double GetPrinterLpi(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_printer_lpi(settings);
	}

	public static MentorLake.Gtk.GtkPrintQuality GetQuality(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_quality(settings);
	}

	public static int GetResolution(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_resolution(settings);
	}

	public static int GetResolutionX(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_resolution_x(settings);
	}

	public static int GetResolutionY(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_resolution_y(settings);
	}

	public static bool GetReverse(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_reverse(settings);
	}

	public static double GetScale(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_scale(settings);
	}

	public static bool GetUseColor(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_get_use_color(settings);
	}

	public static bool HasKey(this MentorLake.Gtk.GtkPrintSettingsHandle settings, string key)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_has_key(settings, key);
	}

	public static bool LoadFile(this MentorLake.Gtk.GtkPrintSettingsHandle settings, string file_name)
	{
		var externCallResult = GtkPrintSettingsHandleExterns.gtk_print_settings_load_file(settings, file_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool LoadKeyFile(this MentorLake.Gtk.GtkPrintSettingsHandle settings, MentorLake.GLib.GKeyFileHandle key_file, string group_name)
	{
		var externCallResult = GtkPrintSettingsHandleExterns.gtk_print_settings_load_key_file(settings, key_file, group_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T Set<T>(this T settings, string key, string value) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set(settings, key, value);
		return settings;
	}

	public static T SetBool<T>(this T settings, string key, bool value) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_bool(settings, key, value);
		return settings;
	}

	public static T SetCollate<T>(this T settings, bool collate) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_collate(settings, collate);
		return settings;
	}

	public static T SetDefaultSource<T>(this T settings, string default_source) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_default_source(settings, default_source);
		return settings;
	}

	public static T SetDither<T>(this T settings, string dither) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_dither(settings, dither);
		return settings;
	}

	public static T SetDouble<T>(this T settings, string key, double value) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_double(settings, key, value);
		return settings;
	}

	public static T SetDuplex<T>(this T settings, MentorLake.Gtk.GtkPrintDuplex duplex) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_duplex(settings, duplex);
		return settings;
	}

	public static T SetFinishings<T>(this T settings, string finishings) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_finishings(settings, finishings);
		return settings;
	}

	public static T SetInt<T>(this T settings, string key, int value) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_int(settings, key, value);
		return settings;
	}

	public static T SetLength<T>(this T settings, string key, double value, MentorLake.Gtk.GtkUnit unit) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_length(settings, key, value, unit);
		return settings;
	}

	public static T SetMediaType<T>(this T settings, string media_type) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_media_type(settings, media_type);
		return settings;
	}

	public static T SetNCopies<T>(this T settings, int num_copies) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_n_copies(settings, num_copies);
		return settings;
	}

	public static T SetNumberUp<T>(this T settings, int number_up) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_number_up(settings, number_up);
		return settings;
	}

	public static T SetNumberUpLayout<T>(this T settings, MentorLake.Gtk.GtkNumberUpLayout number_up_layout) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_number_up_layout(settings, number_up_layout);
		return settings;
	}

	public static T SetOrientation<T>(this T settings, MentorLake.Gtk.GtkPageOrientation orientation) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_orientation(settings, orientation);
		return settings;
	}

	public static T SetOutputBin<T>(this T settings, string output_bin) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_output_bin(settings, output_bin);
		return settings;
	}

	public static T SetPageRanges<T>(this T settings, MentorLake.Gtk.GtkPageRange[] page_ranges, int num_ranges) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_page_ranges(settings, page_ranges, num_ranges);
		return settings;
	}

	public static T SetPageSet<T>(this T settings, MentorLake.Gtk.GtkPageSet page_set) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_page_set(settings, page_set);
		return settings;
	}

	public static T SetPaperHeight<T>(this T settings, double height, MentorLake.Gtk.GtkUnit unit) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_paper_height(settings, height, unit);
		return settings;
	}

	public static T SetPaperSize<T>(this T settings, MentorLake.Gtk.GtkPaperSizeHandle paper_size) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_paper_size(settings, paper_size);
		return settings;
	}

	public static T SetPaperWidth<T>(this T settings, double width, MentorLake.Gtk.GtkUnit unit) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_paper_width(settings, width, unit);
		return settings;
	}

	public static T SetPrintPages<T>(this T settings, MentorLake.Gtk.GtkPrintPages pages) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_print_pages(settings, pages);
		return settings;
	}

	public static T SetPrinter<T>(this T settings, string printer) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_printer(settings, printer);
		return settings;
	}

	public static T SetPrinterLpi<T>(this T settings, double lpi) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_printer_lpi(settings, lpi);
		return settings;
	}

	public static T SetQuality<T>(this T settings, MentorLake.Gtk.GtkPrintQuality quality) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_quality(settings, quality);
		return settings;
	}

	public static T SetResolution<T>(this T settings, int resolution) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_resolution(settings, resolution);
		return settings;
	}

	public static T SetResolutionXy<T>(this T settings, int resolution_x, int resolution_y) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_resolution_xy(settings, resolution_x, resolution_y);
		return settings;
	}

	public static T SetReverse<T>(this T settings, bool reverse) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_reverse(settings, reverse);
		return settings;
	}

	public static T SetScale<T>(this T settings, double scale) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_scale(settings, scale);
		return settings;
	}

	public static T SetUseColor<T>(this T settings, bool use_color) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_set_use_color(settings, use_color);
		return settings;
	}

	public static bool ToFile(this MentorLake.Gtk.GtkPrintSettingsHandle settings, string file_name)
	{
		var externCallResult = GtkPrintSettingsHandleExterns.gtk_print_settings_to_file(settings, file_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GVariantHandle ToGvariant(this MentorLake.Gtk.GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsHandleExterns.gtk_print_settings_to_gvariant(settings);
	}

	public static T ToKeyFile<T>(this T settings, MentorLake.GLib.GKeyFileHandle key_file, string group_name) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_to_key_file(settings, key_file, group_name);
		return settings;
	}

	public static T Unset<T>(this T settings, string key) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsHandleExterns.gtk_print_settings_unset(settings, key);
		return settings;
	}

}

internal class GtkPrintSettingsHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPrintSettingsHandle gtk_print_settings_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPrintSettingsHandle gtk_print_settings_new_from_file(string file_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPrintSettingsHandle gtk_print_settings_new_from_gvariant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle variant);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPrintSettingsHandle gtk_print_settings_new_from_key_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
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
	internal static extern MentorLake.GLib.GVariantHandle gtk_print_settings_to_gvariant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_to_key_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_settings_unset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, string key);

}
