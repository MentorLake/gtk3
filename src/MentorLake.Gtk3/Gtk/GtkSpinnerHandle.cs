namespace MentorLake.Gtk;

public class GtkSpinnerHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkSpinnerHandle New()
	{
		return GtkSpinnerHandleExterns.gtk_spinner_new();
	}

}

public static class GtkSpinnerHandleExtensions
{
	public static T Start<T>(this T spinner) where T : GtkSpinnerHandle
	{
		if (spinner.IsInvalid) throw new Exception("Invalid handle (GtkSpinnerHandle)");
		GtkSpinnerHandleExterns.gtk_spinner_start(spinner);
		return spinner;
	}

	public static T Stop<T>(this T spinner) where T : GtkSpinnerHandle
	{
		if (spinner.IsInvalid) throw new Exception("Invalid handle (GtkSpinnerHandle)");
		GtkSpinnerHandleExterns.gtk_spinner_stop(spinner);
		return spinner;
	}

}

internal class GtkSpinnerHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkSpinnerHandle>))]
	internal static extern MentorLake.Gtk.GtkSpinnerHandle gtk_spinner_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spinner_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinnerHandle>))] MentorLake.Gtk.GtkSpinnerHandle spinner);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spinner_stop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinnerHandle>))] MentorLake.Gtk.GtkSpinnerHandle spinner);

}
