namespace MentorLake.Gtk;

public class GtkProgressBarHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkProgressBarHandle New()
	{
		return GtkProgressBarHandleExterns.gtk_progress_bar_new();
	}

}

public static class GtkProgressBarHandleExtensions
{
	public static MentorLake.Pango.PangoEllipsizeMode GetEllipsize(this MentorLake.Gtk.GtkProgressBarHandle pbar)
	{
		if (pbar.IsInvalid || pbar.IsClosed) throw new Exception("Invalid or closed handle (GtkProgressBarHandle)");
		return GtkProgressBarHandleExterns.gtk_progress_bar_get_ellipsize(pbar);
	}

	public static double GetFraction(this MentorLake.Gtk.GtkProgressBarHandle pbar)
	{
		if (pbar.IsInvalid || pbar.IsClosed) throw new Exception("Invalid or closed handle (GtkProgressBarHandle)");
		return GtkProgressBarHandleExterns.gtk_progress_bar_get_fraction(pbar);
	}

	public static bool GetInverted(this MentorLake.Gtk.GtkProgressBarHandle pbar)
	{
		if (pbar.IsInvalid || pbar.IsClosed) throw new Exception("Invalid or closed handle (GtkProgressBarHandle)");
		return GtkProgressBarHandleExterns.gtk_progress_bar_get_inverted(pbar);
	}

	public static double GetPulseStep(this MentorLake.Gtk.GtkProgressBarHandle pbar)
	{
		if (pbar.IsInvalid || pbar.IsClosed) throw new Exception("Invalid or closed handle (GtkProgressBarHandle)");
		return GtkProgressBarHandleExterns.gtk_progress_bar_get_pulse_step(pbar);
	}

	public static bool GetShowText(this MentorLake.Gtk.GtkProgressBarHandle pbar)
	{
		if (pbar.IsInvalid || pbar.IsClosed) throw new Exception("Invalid or closed handle (GtkProgressBarHandle)");
		return GtkProgressBarHandleExterns.gtk_progress_bar_get_show_text(pbar);
	}

	public static string GetText(this MentorLake.Gtk.GtkProgressBarHandle pbar)
	{
		if (pbar.IsInvalid || pbar.IsClosed) throw new Exception("Invalid or closed handle (GtkProgressBarHandle)");
		return GtkProgressBarHandleExterns.gtk_progress_bar_get_text(pbar);
	}

	public static T Pulse<T>(this T pbar) where T : GtkProgressBarHandle
	{
		if (pbar.IsInvalid || pbar.IsClosed) throw new Exception("Invalid or closed handle (GtkProgressBarHandle)");
		GtkProgressBarHandleExterns.gtk_progress_bar_pulse(pbar);
		return pbar;
	}

	public static T SetEllipsize<T>(this T pbar, MentorLake.Pango.PangoEllipsizeMode mode) where T : GtkProgressBarHandle
	{
		if (pbar.IsInvalid || pbar.IsClosed) throw new Exception("Invalid or closed handle (GtkProgressBarHandle)");
		GtkProgressBarHandleExterns.gtk_progress_bar_set_ellipsize(pbar, mode);
		return pbar;
	}

	public static T SetFraction<T>(this T pbar, double fraction) where T : GtkProgressBarHandle
	{
		if (pbar.IsInvalid || pbar.IsClosed) throw new Exception("Invalid or closed handle (GtkProgressBarHandle)");
		GtkProgressBarHandleExterns.gtk_progress_bar_set_fraction(pbar, fraction);
		return pbar;
	}

	public static T SetInverted<T>(this T pbar, bool inverted) where T : GtkProgressBarHandle
	{
		if (pbar.IsInvalid || pbar.IsClosed) throw new Exception("Invalid or closed handle (GtkProgressBarHandle)");
		GtkProgressBarHandleExterns.gtk_progress_bar_set_inverted(pbar, inverted);
		return pbar;
	}

	public static T SetPulseStep<T>(this T pbar, double fraction) where T : GtkProgressBarHandle
	{
		if (pbar.IsInvalid || pbar.IsClosed) throw new Exception("Invalid or closed handle (GtkProgressBarHandle)");
		GtkProgressBarHandleExterns.gtk_progress_bar_set_pulse_step(pbar, fraction);
		return pbar;
	}

	public static T SetShowText<T>(this T pbar, bool show_text) where T : GtkProgressBarHandle
	{
		if (pbar.IsInvalid || pbar.IsClosed) throw new Exception("Invalid or closed handle (GtkProgressBarHandle)");
		GtkProgressBarHandleExterns.gtk_progress_bar_set_show_text(pbar, show_text);
		return pbar;
	}

	public static T SetText<T>(this T pbar, string text) where T : GtkProgressBarHandle
	{
		if (pbar.IsInvalid || pbar.IsClosed) throw new Exception("Invalid or closed handle (GtkProgressBarHandle)");
		GtkProgressBarHandleExterns.gtk_progress_bar_set_text(pbar, text);
		return pbar;
	}

}

internal class GtkProgressBarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkProgressBarHandle gtk_progress_bar_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoEllipsizeMode gtk_progress_bar_get_ellipsize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkProgressBarHandle>))] MentorLake.Gtk.GtkProgressBarHandle pbar);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_progress_bar_get_fraction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkProgressBarHandle>))] MentorLake.Gtk.GtkProgressBarHandle pbar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_progress_bar_get_inverted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkProgressBarHandle>))] MentorLake.Gtk.GtkProgressBarHandle pbar);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_progress_bar_get_pulse_step([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkProgressBarHandle>))] MentorLake.Gtk.GtkProgressBarHandle pbar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_progress_bar_get_show_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkProgressBarHandle>))] MentorLake.Gtk.GtkProgressBarHandle pbar);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_progress_bar_get_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkProgressBarHandle>))] MentorLake.Gtk.GtkProgressBarHandle pbar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_progress_bar_pulse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkProgressBarHandle>))] MentorLake.Gtk.GtkProgressBarHandle pbar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_progress_bar_set_ellipsize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkProgressBarHandle>))] MentorLake.Gtk.GtkProgressBarHandle pbar, MentorLake.Pango.PangoEllipsizeMode mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_progress_bar_set_fraction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkProgressBarHandle>))] MentorLake.Gtk.GtkProgressBarHandle pbar, double fraction);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_progress_bar_set_inverted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkProgressBarHandle>))] MentorLake.Gtk.GtkProgressBarHandle pbar, bool inverted);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_progress_bar_set_pulse_step([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkProgressBarHandle>))] MentorLake.Gtk.GtkProgressBarHandle pbar, double fraction);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_progress_bar_set_show_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkProgressBarHandle>))] MentorLake.Gtk.GtkProgressBarHandle pbar, bool show_text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_progress_bar_set_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkProgressBarHandle>))] MentorLake.Gtk.GtkProgressBarHandle pbar, string text);

}
