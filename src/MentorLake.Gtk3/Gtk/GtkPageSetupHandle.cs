namespace MentorLake.Gtk;

public class GtkPageSetupHandle : GObjectHandle
{
	public static MentorLake.Gtk.GtkPageSetupHandle New()
	{
		return GtkPageSetupHandleExterns.gtk_page_setup_new();
	}

	public static MentorLake.Gtk.GtkPageSetupHandle NewFromFile(string file_name)
	{
		var externCallResult = GtkPageSetupHandleExterns.gtk_page_setup_new_from_file(file_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gtk.GtkPageSetupHandle NewFromGvariant(MentorLake.GLib.GVariantHandle variant)
	{
		return GtkPageSetupHandleExterns.gtk_page_setup_new_from_gvariant(variant);
	}

	public static MentorLake.Gtk.GtkPageSetupHandle NewFromKeyFile(MentorLake.GLib.GKeyFileHandle key_file, string group_name)
	{
		var externCallResult = GtkPageSetupHandleExterns.gtk_page_setup_new_from_key_file(key_file, group_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

public static class GtkPageSetupHandleExtensions
{
	public static MentorLake.Gtk.GtkPageSetupHandle Copy(this MentorLake.Gtk.GtkPageSetupHandle other)
	{
		if (other.IsInvalid || other.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_copy(other);
	}

	public static double GetBottomMargin(this MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit)
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_get_bottom_margin(setup, unit);
	}

	public static double GetLeftMargin(this MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit)
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_get_left_margin(setup, unit);
	}

	public static MentorLake.Gtk.GtkPageOrientation GetOrientation(this MentorLake.Gtk.GtkPageSetupHandle setup)
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_get_orientation(setup);
	}

	public static double GetPageHeight(this MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit)
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_get_page_height(setup, unit);
	}

	public static double GetPageWidth(this MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit)
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_get_page_width(setup, unit);
	}

	public static double GetPaperHeight(this MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit)
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_get_paper_height(setup, unit);
	}

	public static MentorLake.Gtk.GtkPaperSizeHandle GetPaperSize(this MentorLake.Gtk.GtkPageSetupHandle setup)
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_get_paper_size(setup);
	}

	public static double GetPaperWidth(this MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit)
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_get_paper_width(setup, unit);
	}

	public static double GetRightMargin(this MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit)
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_get_right_margin(setup, unit);
	}

	public static double GetTopMargin(this MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.Gtk.GtkUnit unit)
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_get_top_margin(setup, unit);
	}

	public static bool LoadFile(this MentorLake.Gtk.GtkPageSetupHandle setup, string file_name)
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		var externCallResult = GtkPageSetupHandleExterns.gtk_page_setup_load_file(setup, file_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool LoadKeyFile(this MentorLake.Gtk.GtkPageSetupHandle setup, MentorLake.GLib.GKeyFileHandle key_file, string group_name)
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		var externCallResult = GtkPageSetupHandleExterns.gtk_page_setup_load_key_file(setup, key_file, group_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T SetBottomMargin<T>(this T setup, double margin, MentorLake.Gtk.GtkUnit unit) where T : GtkPageSetupHandle
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		GtkPageSetupHandleExterns.gtk_page_setup_set_bottom_margin(setup, margin, unit);
		return setup;
	}

	public static T SetLeftMargin<T>(this T setup, double margin, MentorLake.Gtk.GtkUnit unit) where T : GtkPageSetupHandle
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		GtkPageSetupHandleExterns.gtk_page_setup_set_left_margin(setup, margin, unit);
		return setup;
	}

	public static T SetOrientation<T>(this T setup, MentorLake.Gtk.GtkPageOrientation orientation) where T : GtkPageSetupHandle
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		GtkPageSetupHandleExterns.gtk_page_setup_set_orientation(setup, orientation);
		return setup;
	}

	public static T SetPaperSize<T>(this T setup, MentorLake.Gtk.GtkPaperSizeHandle size) where T : GtkPageSetupHandle
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		GtkPageSetupHandleExterns.gtk_page_setup_set_paper_size(setup, size);
		return setup;
	}

	public static T SetPaperSizeAndDefaultMargins<T>(this T setup, MentorLake.Gtk.GtkPaperSizeHandle size) where T : GtkPageSetupHandle
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		GtkPageSetupHandleExterns.gtk_page_setup_set_paper_size_and_default_margins(setup, size);
		return setup;
	}

	public static T SetRightMargin<T>(this T setup, double margin, MentorLake.Gtk.GtkUnit unit) where T : GtkPageSetupHandle
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		GtkPageSetupHandleExterns.gtk_page_setup_set_right_margin(setup, margin, unit);
		return setup;
	}

	public static T SetTopMargin<T>(this T setup, double margin, MentorLake.Gtk.GtkUnit unit) where T : GtkPageSetupHandle
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		GtkPageSetupHandleExterns.gtk_page_setup_set_top_margin(setup, margin, unit);
		return setup;
	}

	public static bool ToFile(this MentorLake.Gtk.GtkPageSetupHandle setup, string file_name)
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		var externCallResult = GtkPageSetupHandleExterns.gtk_page_setup_to_file(setup, file_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GVariantHandle ToGvariant(this MentorLake.Gtk.GtkPageSetupHandle setup)
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		return GtkPageSetupHandleExterns.gtk_page_setup_to_gvariant(setup);
	}

	public static T ToKeyFile<T>(this T setup, MentorLake.GLib.GKeyFileHandle key_file, string group_name) where T : GtkPageSetupHandle
	{
		if (setup.IsInvalid || setup.IsClosed) throw new Exception("Invalid or closed handle (GtkPageSetupHandle)");
		GtkPageSetupHandleExterns.gtk_page_setup_to_key_file(setup, key_file, group_name);
		return setup;
	}

}

internal class GtkPageSetupHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPageSetupHandle gtk_page_setup_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPageSetupHandle gtk_page_setup_new_from_file(string file_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPageSetupHandle gtk_page_setup_new_from_gvariant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle variant);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPageSetupHandle gtk_page_setup_new_from_key_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
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
	internal static extern MentorLake.GLib.GVariantHandle gtk_page_setup_to_gvariant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_page_setup_to_key_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name);

}
