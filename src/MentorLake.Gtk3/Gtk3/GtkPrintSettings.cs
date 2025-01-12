namespace MentorLake.Gtk3.Gtk3;

public class GtkPrintSettingsHandle : GObjectHandle
{
	public static GtkPrintSettingsHandle New()
	{
		return GtkPrintSettingsExterns.gtk_print_settings_new();
	}

	public static GtkPrintSettingsHandle NewFromFile(string file_name, out GErrorHandle error)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_new_from_file(file_name, out error);
	}

	public static GtkPrintSettingsHandle NewFromGvariant(GVariantHandle variant)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_new_from_gvariant(variant);
	}

	public static GtkPrintSettingsHandle NewFromKeyFile(GKeyFileHandle key_file, string group_name, out GErrorHandle error)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_new_from_key_file(key_file, group_name, out error);
	}

}

public static class GtkPrintSettingsHandleExtensions
{
	public static GtkPrintSettingsHandle Copy(this GtkPrintSettingsHandle other)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_copy(other);
	}

	public static T Foreach<T>(this T settings, GtkPrintSettingsFunc func, IntPtr user_data) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_foreach(settings, func, user_data);
		return settings;
	}

	public static string Get(this GtkPrintSettingsHandle settings, string key)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get(settings, key);
	}

	public static bool GetBool(this GtkPrintSettingsHandle settings, string key)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_bool(settings, key);
	}

	public static bool GetCollate(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_collate(settings);
	}

	public static string GetDefaultSource(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_default_source(settings);
	}

	public static string GetDither(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_dither(settings);
	}

	public static double GetDouble(this GtkPrintSettingsHandle settings, string key)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_double(settings, key);
	}

	public static double GetDoubleWithDefault(this GtkPrintSettingsHandle settings, string key, double def)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_double_with_default(settings, key, def);
	}

	public static GtkPrintDuplex GetDuplex(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_duplex(settings);
	}

	public static string GetFinishings(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_finishings(settings);
	}

	public static int GetInt(this GtkPrintSettingsHandle settings, string key)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_int(settings, key);
	}

	public static int GetIntWithDefault(this GtkPrintSettingsHandle settings, string key, int def)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_int_with_default(settings, key, def);
	}

	public static double GetLength(this GtkPrintSettingsHandle settings, string key, GtkUnit unit)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_length(settings, key, unit);
	}

	public static string GetMediaType(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_media_type(settings);
	}

	public static int GetNCopies(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_n_copies(settings);
	}

	public static int GetNumberUp(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_number_up(settings);
	}

	public static GtkNumberUpLayout GetNumberUpLayout(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_number_up_layout(settings);
	}

	public static GtkPageOrientation GetOrientation(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_orientation(settings);
	}

	public static string GetOutputBin(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_output_bin(settings);
	}

	public static IntPtr GetPageRanges(this GtkPrintSettingsHandle settings, out int num_ranges)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_page_ranges(settings, out num_ranges);
	}

	public static GtkPageSet GetPageSet(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_page_set(settings);
	}

	public static double GetPaperHeight(this GtkPrintSettingsHandle settings, GtkUnit unit)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_paper_height(settings, unit);
	}

	public static GtkPaperSizeHandle GetPaperSize(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_paper_size(settings);
	}

	public static double GetPaperWidth(this GtkPrintSettingsHandle settings, GtkUnit unit)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_paper_width(settings, unit);
	}

	public static GtkPrintPages GetPrintPages(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_print_pages(settings);
	}

	public static string GetPrinter(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_printer(settings);
	}

	public static double GetPrinterLpi(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_printer_lpi(settings);
	}

	public static GtkPrintQuality GetQuality(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_quality(settings);
	}

	public static int GetResolution(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_resolution(settings);
	}

	public static int GetResolutionX(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_resolution_x(settings);
	}

	public static int GetResolutionY(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_resolution_y(settings);
	}

	public static bool GetReverse(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_reverse(settings);
	}

	public static double GetScale(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_scale(settings);
	}

	public static bool GetUseColor(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_use_color(settings);
	}

	public static bool HasKey(this GtkPrintSettingsHandle settings, string key)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_has_key(settings, key);
	}

	public static bool LoadFile(this GtkPrintSettingsHandle settings, string file_name, out GErrorHandle error)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_load_file(settings, file_name, out error);
	}

	public static bool LoadKeyFile(this GtkPrintSettingsHandle settings, GKeyFileHandle key_file, string group_name, out GErrorHandle error)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_load_key_file(settings, key_file, group_name, out error);
	}

	public static T Set<T>(this T settings, string key, string value) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set(settings, key, value);
		return settings;
	}

	public static T SetBool<T>(this T settings, string key, bool value) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_bool(settings, key, value);
		return settings;
	}

	public static T SetCollate<T>(this T settings, bool collate) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_collate(settings, collate);
		return settings;
	}

	public static T SetDefaultSource<T>(this T settings, string default_source) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_default_source(settings, default_source);
		return settings;
	}

	public static T SetDither<T>(this T settings, string dither) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_dither(settings, dither);
		return settings;
	}

	public static T SetDouble<T>(this T settings, string key, double value) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_double(settings, key, value);
		return settings;
	}

	public static T SetDuplex<T>(this T settings, GtkPrintDuplex duplex) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_duplex(settings, duplex);
		return settings;
	}

	public static T SetFinishings<T>(this T settings, string finishings) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_finishings(settings, finishings);
		return settings;
	}

	public static T SetInt<T>(this T settings, string key, int value) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_int(settings, key, value);
		return settings;
	}

	public static T SetLength<T>(this T settings, string key, double value, GtkUnit unit) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_length(settings, key, value, unit);
		return settings;
	}

	public static T SetMediaType<T>(this T settings, string media_type) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_media_type(settings, media_type);
		return settings;
	}

	public static T SetNCopies<T>(this T settings, int num_copies) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_n_copies(settings, num_copies);
		return settings;
	}

	public static T SetNumberUp<T>(this T settings, int number_up) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_number_up(settings, number_up);
		return settings;
	}

	public static T SetNumberUpLayout<T>(this T settings, GtkNumberUpLayout number_up_layout) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_number_up_layout(settings, number_up_layout);
		return settings;
	}

	public static T SetOrientation<T>(this T settings, GtkPageOrientation orientation) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_orientation(settings, orientation);
		return settings;
	}

	public static T SetOutputBin<T>(this T settings, string output_bin) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_output_bin(settings, output_bin);
		return settings;
	}

	public static T SetPageRanges<T>(this T settings, GtkPageRange[] page_ranges, int num_ranges) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_page_ranges(settings, page_ranges, num_ranges);
		return settings;
	}

	public static T SetPageSet<T>(this T settings, GtkPageSet page_set) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_page_set(settings, page_set);
		return settings;
	}

	public static T SetPaperHeight<T>(this T settings, double height, GtkUnit unit) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_paper_height(settings, height, unit);
		return settings;
	}

	public static T SetPaperSize<T>(this T settings, GtkPaperSizeHandle paper_size) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_paper_size(settings, paper_size);
		return settings;
	}

	public static T SetPaperWidth<T>(this T settings, double width, GtkUnit unit) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_paper_width(settings, width, unit);
		return settings;
	}

	public static T SetPrintPages<T>(this T settings, GtkPrintPages pages) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_print_pages(settings, pages);
		return settings;
	}

	public static T SetPrinter<T>(this T settings, string printer) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_printer(settings, printer);
		return settings;
	}

	public static T SetPrinterLpi<T>(this T settings, double lpi) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_printer_lpi(settings, lpi);
		return settings;
	}

	public static T SetQuality<T>(this T settings, GtkPrintQuality quality) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_quality(settings, quality);
		return settings;
	}

	public static T SetResolution<T>(this T settings, int resolution) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_resolution(settings, resolution);
		return settings;
	}

	public static T SetResolutionXy<T>(this T settings, int resolution_x, int resolution_y) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_resolution_xy(settings, resolution_x, resolution_y);
		return settings;
	}

	public static T SetReverse<T>(this T settings, bool reverse) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_reverse(settings, reverse);
		return settings;
	}

	public static T SetScale<T>(this T settings, double scale) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_scale(settings, scale);
		return settings;
	}

	public static T SetUseColor<T>(this T settings, bool use_color) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_use_color(settings, use_color);
		return settings;
	}

	public static bool ToFile(this GtkPrintSettingsHandle settings, string file_name, out GErrorHandle error)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_to_file(settings, file_name, out error);
	}

	public static GVariantHandle ToGvariant(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_to_gvariant(settings);
	}

	public static T ToKeyFile<T>(this T settings, GKeyFileHandle key_file, string group_name) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_to_key_file(settings, key_file, group_name);
		return settings;
	}

	public static T Unset<T>(this T settings, string key) where T : GtkPrintSettingsHandle
	{
		GtkPrintSettingsExterns.gtk_print_settings_unset(settings, key);
		return settings;
	}

}

internal class GtkPrintSettingsExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPrintSettingsHandle gtk_print_settings_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPrintSettingsHandle gtk_print_settings_new_from_file(string file_name, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPrintSettingsHandle gtk_print_settings_new_from_gvariant(GVariantHandle variant);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPrintSettingsHandle gtk_print_settings_new_from_key_file(GKeyFileHandle key_file, string group_name, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPrintSettingsHandle gtk_print_settings_copy(GtkPrintSettingsHandle other);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_foreach(GtkPrintSettingsHandle settings, GtkPrintSettingsFunc func, IntPtr user_data);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get(GtkPrintSettingsHandle settings, string key);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_print_settings_get_bool(GtkPrintSettingsHandle settings, string key);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_print_settings_get_collate(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get_default_source(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get_dither(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_print_settings_get_double(GtkPrintSettingsHandle settings, string key);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_print_settings_get_double_with_default(GtkPrintSettingsHandle settings, string key, double def);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPrintDuplex gtk_print_settings_get_duplex(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get_finishings(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_print_settings_get_int(GtkPrintSettingsHandle settings, string key);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_print_settings_get_int_with_default(GtkPrintSettingsHandle settings, string key, int def);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_print_settings_get_length(GtkPrintSettingsHandle settings, string key, GtkUnit unit);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get_media_type(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_print_settings_get_n_copies(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_print_settings_get_number_up(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkNumberUpLayout gtk_print_settings_get_number_up_layout(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPageOrientation gtk_print_settings_get_orientation(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get_output_bin(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_print_settings_get_page_ranges(GtkPrintSettingsHandle settings, out int num_ranges);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPageSet gtk_print_settings_get_page_set(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_print_settings_get_paper_height(GtkPrintSettingsHandle settings, GtkUnit unit);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPaperSizeHandle gtk_print_settings_get_paper_size(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_print_settings_get_paper_width(GtkPrintSettingsHandle settings, GtkUnit unit);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPrintPages gtk_print_settings_get_print_pages(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get_printer(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_print_settings_get_printer_lpi(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPrintQuality gtk_print_settings_get_quality(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_print_settings_get_resolution(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_print_settings_get_resolution_x(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_print_settings_get_resolution_y(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_print_settings_get_reverse(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_print_settings_get_scale(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_print_settings_get_use_color(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_print_settings_has_key(GtkPrintSettingsHandle settings, string key);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_print_settings_load_file(GtkPrintSettingsHandle settings, string file_name, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_print_settings_load_key_file(GtkPrintSettingsHandle settings, GKeyFileHandle key_file, string group_name, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set(GtkPrintSettingsHandle settings, string key, string value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_bool(GtkPrintSettingsHandle settings, string key, bool value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_collate(GtkPrintSettingsHandle settings, bool collate);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_default_source(GtkPrintSettingsHandle settings, string default_source);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_dither(GtkPrintSettingsHandle settings, string dither);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_double(GtkPrintSettingsHandle settings, string key, double value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_duplex(GtkPrintSettingsHandle settings, GtkPrintDuplex duplex);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_finishings(GtkPrintSettingsHandle settings, string finishings);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_int(GtkPrintSettingsHandle settings, string key, int value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_length(GtkPrintSettingsHandle settings, string key, double value, GtkUnit unit);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_media_type(GtkPrintSettingsHandle settings, string media_type);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_n_copies(GtkPrintSettingsHandle settings, int num_copies);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_number_up(GtkPrintSettingsHandle settings, int number_up);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_number_up_layout(GtkPrintSettingsHandle settings, GtkNumberUpLayout number_up_layout);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_orientation(GtkPrintSettingsHandle settings, GtkPageOrientation orientation);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_output_bin(GtkPrintSettingsHandle settings, string output_bin);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_page_ranges(GtkPrintSettingsHandle settings, GtkPageRange[] page_ranges, int num_ranges);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_page_set(GtkPrintSettingsHandle settings, GtkPageSet page_set);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_paper_height(GtkPrintSettingsHandle settings, double height, GtkUnit unit);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_paper_size(GtkPrintSettingsHandle settings, GtkPaperSizeHandle paper_size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_paper_width(GtkPrintSettingsHandle settings, double width, GtkUnit unit);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_print_pages(GtkPrintSettingsHandle settings, GtkPrintPages pages);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_printer(GtkPrintSettingsHandle settings, string printer);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_printer_lpi(GtkPrintSettingsHandle settings, double lpi);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_quality(GtkPrintSettingsHandle settings, GtkPrintQuality quality);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_resolution(GtkPrintSettingsHandle settings, int resolution);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_resolution_xy(GtkPrintSettingsHandle settings, int resolution_x, int resolution_y);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_reverse(GtkPrintSettingsHandle settings, bool reverse);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_scale(GtkPrintSettingsHandle settings, double scale);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_set_use_color(GtkPrintSettingsHandle settings, bool use_color);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_print_settings_to_file(GtkPrintSettingsHandle settings, string file_name, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern GVariantHandle gtk_print_settings_to_gvariant(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_to_key_file(GtkPrintSettingsHandle settings, GKeyFileHandle key_file, string group_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_settings_unset(GtkPrintSettingsHandle settings, string key);

}
