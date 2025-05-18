namespace MentorLake.Gtk;

public class GtkFixedHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkFixedHandle New()
	{
		return GtkFixedHandleExterns.gtk_fixed_new();
	}

}

public static class GtkFixedHandleExtensions
{
	public static T Move<T>(this T @fixed, MentorLake.Gtk.GtkWidgetHandle widget, int x, int y) where T : GtkFixedHandle
	{
		if (@fixed.IsInvalid) throw new Exception("Invalid handle (GtkFixedHandle)");
		GtkFixedHandleExterns.gtk_fixed_move(@fixed, widget, x, y);
		return @fixed;
	}

	public static T Put<T>(this T @fixed, MentorLake.Gtk.GtkWidgetHandle widget, int x, int y) where T : GtkFixedHandle
	{
		if (@fixed.IsInvalid) throw new Exception("Invalid handle (GtkFixedHandle)");
		GtkFixedHandleExterns.gtk_fixed_put(@fixed, widget, x, y);
		return @fixed;
	}

}

internal class GtkFixedHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkFixedHandle>))]
	internal static extern MentorLake.Gtk.GtkFixedHandle gtk_fixed_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_fixed_move([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFixedHandle>))] MentorLake.Gtk.GtkFixedHandle @fixed, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int x, int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_fixed_put([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFixedHandle>))] MentorLake.Gtk.GtkFixedHandle @fixed, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int x, int y);

}
