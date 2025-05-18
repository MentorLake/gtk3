namespace MentorLake.Gtk;

public class GtkSymbolicColorHandle : BaseSafeHandle
{
	public static MentorLake.Gtk.GtkSymbolicColorHandle NewAlpha(MentorLake.Gtk.GtkSymbolicColorHandle color, double factor)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_new_alpha(color, factor);
	}

	public static MentorLake.Gtk.GtkSymbolicColorHandle NewLiteral(MentorLake.Gdk.GdkRGBAHandle color)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_new_literal(color);
	}

	public static MentorLake.Gtk.GtkSymbolicColorHandle NewMix(MentorLake.Gtk.GtkSymbolicColorHandle color1, MentorLake.Gtk.GtkSymbolicColorHandle color2, double factor)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_new_mix(color1, color2, factor);
	}

	public static MentorLake.Gtk.GtkSymbolicColorHandle NewName(string name)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_new_name(name);
	}

	public static MentorLake.Gtk.GtkSymbolicColorHandle NewShade(MentorLake.Gtk.GtkSymbolicColorHandle color, double factor)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_new_shade(color, factor);
	}

	public static MentorLake.Gtk.GtkSymbolicColorHandle NewWin32(string theme_class, int id)
	{
		return GtkSymbolicColorExterns.gtk_symbolic_color_new_win32(theme_class, id);
	}

}


public static class GtkSymbolicColorExtensions
{
	public static MentorLake.Gtk.GtkSymbolicColorHandle Ref(this MentorLake.Gtk.GtkSymbolicColorHandle color)
	{
		if (color.IsInvalid) throw new Exception("Invalid handle (GtkSymbolicColor)");
		return GtkSymbolicColorExterns.gtk_symbolic_color_ref(color);
	}

	public static bool Resolve(this MentorLake.Gtk.GtkSymbolicColorHandle color, MentorLake.Gtk.GtkStylePropertiesHandle props, out MentorLake.Gdk.GdkRGBA resolved_color)
	{
		if (color.IsInvalid) throw new Exception("Invalid handle (GtkSymbolicColor)");
		return GtkSymbolicColorExterns.gtk_symbolic_color_resolve(color, props, out resolved_color);
	}

	public static string ToString(this MentorLake.Gtk.GtkSymbolicColorHandle color)
	{
		if (color.IsInvalid) throw new Exception("Invalid handle (GtkSymbolicColor)");
		return GtkSymbolicColorExterns.gtk_symbolic_color_to_string(color);
	}

	public static void Unref(this MentorLake.Gtk.GtkSymbolicColorHandle color)
	{
		if (color.IsInvalid) throw new Exception("Invalid handle (GtkSymbolicColor)");
		GtkSymbolicColorExterns.gtk_symbolic_color_unref(color);
	}


	public static GtkSymbolicColor Dereference(this GtkSymbolicColorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSymbolicColor>(x.DangerousGetHandle());
}
internal class GtkSymbolicColorExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))]
	internal static extern MentorLake.Gtk.GtkSymbolicColorHandle gtk_symbolic_color_new_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))] MentorLake.Gtk.GtkSymbolicColorHandle color, double factor);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))]
	internal static extern MentorLake.Gtk.GtkSymbolicColorHandle gtk_symbolic_color_new_literal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle color);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))]
	internal static extern MentorLake.Gtk.GtkSymbolicColorHandle gtk_symbolic_color_new_mix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))] MentorLake.Gtk.GtkSymbolicColorHandle color1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))] MentorLake.Gtk.GtkSymbolicColorHandle color2, double factor);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))]
	internal static extern MentorLake.Gtk.GtkSymbolicColorHandle gtk_symbolic_color_new_name(string name);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))]
	internal static extern MentorLake.Gtk.GtkSymbolicColorHandle gtk_symbolic_color_new_shade([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))] MentorLake.Gtk.GtkSymbolicColorHandle color, double factor);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))]
	internal static extern MentorLake.Gtk.GtkSymbolicColorHandle gtk_symbolic_color_new_win32(string theme_class, int id);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))]
	internal static extern MentorLake.Gtk.GtkSymbolicColorHandle gtk_symbolic_color_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))] MentorLake.Gtk.GtkSymbolicColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_symbolic_color_resolve([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))] MentorLake.Gtk.GtkSymbolicColorHandle color, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStylePropertiesHandle>))] MentorLake.Gtk.GtkStylePropertiesHandle props, out MentorLake.Gdk.GdkRGBA resolved_color);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_symbolic_color_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))] MentorLake.Gtk.GtkSymbolicColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_symbolic_color_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSymbolicColorHandle>))] MentorLake.Gtk.GtkSymbolicColorHandle color);

}

public struct GtkSymbolicColor
{
}
