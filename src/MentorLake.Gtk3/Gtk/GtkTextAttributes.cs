namespace MentorLake.Gtk;

public class GtkTextAttributesHandle : BaseSafeHandle
{
	public static MentorLake.Gtk.GtkTextAttributesHandle New()
	{
		return GtkTextAttributesExterns.gtk_text_attributes_new();
	}

}


public static class GtkTextAttributesExtensions
{
	public static MentorLake.Gtk.GtkTextAttributesHandle Copy(this MentorLake.Gtk.GtkTextAttributesHandle src)
	{
		if (src.IsInvalid || src.IsClosed) throw new Exception("Invalid or closed handle (GtkTextAttributes)");
		return GtkTextAttributesExterns.gtk_text_attributes_copy(src);
	}

	public static void CopyValues(this MentorLake.Gtk.GtkTextAttributesHandle src, MentorLake.Gtk.GtkTextAttributesHandle dest)
	{
		if (src.IsInvalid || src.IsClosed) throw new Exception("Invalid or closed handle (GtkTextAttributes)");
		GtkTextAttributesExterns.gtk_text_attributes_copy_values(src, dest);
	}

	public static MentorLake.Gtk.GtkTextAttributesHandle Ref(this MentorLake.Gtk.GtkTextAttributesHandle values)
	{
		if (values.IsInvalid || values.IsClosed) throw new Exception("Invalid or closed handle (GtkTextAttributes)");
		return GtkTextAttributesExterns.gtk_text_attributes_ref(values);
	}

	public static void Unref(this MentorLake.Gtk.GtkTextAttributesHandle values)
	{
		if (values.IsInvalid || values.IsClosed) throw new Exception("Invalid or closed handle (GtkTextAttributes)");
		GtkTextAttributesExterns.gtk_text_attributes_unref(values);
	}


	public static GtkTextAttributes Dereference(this GtkTextAttributesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextAttributes>(x.DangerousGetHandle());
}
internal class GtkTextAttributesExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTextAttributesHandle gtk_text_attributes_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTextAttributesHandle gtk_text_attributes_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextAttributesHandle>))] MentorLake.Gtk.GtkTextAttributesHandle src);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_attributes_copy_values([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextAttributesHandle>))] MentorLake.Gtk.GtkTextAttributesHandle src, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextAttributesHandle>))] MentorLake.Gtk.GtkTextAttributesHandle dest);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTextAttributesHandle gtk_text_attributes_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextAttributesHandle>))] MentorLake.Gtk.GtkTextAttributesHandle values);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_attributes_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextAttributesHandle>))] MentorLake.Gtk.GtkTextAttributesHandle values);

}

public struct GtkTextAttributes
{
	public GtkTextAppearance appearance;
	public GtkJustification justification;
	public GtkTextDirection direction;
	public IntPtr font;
	public double font_scale;
	public int left_margin;
	public int right_margin;
	public int indent;
	public int pixels_above_lines;
	public int pixels_below_lines;
	public int pixels_inside_wrap;
	public IntPtr tabs;
	public GtkWrapMode wrap_mode;
	public IntPtr language;
	public uint invisible;
	public uint bg_full_height;
	public uint editable;
	public uint no_fallback;
	public int letter_spacing;
}
