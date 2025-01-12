namespace MentorLake.Gtk3.Gtk3;

public class GtkProgressBarHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkProgressBarHandle New()
	{
		return GtkProgressBarExterns.gtk_progress_bar_new();
	}

}

public static class GtkProgressBarHandleExtensions
{
	public static PangoEllipsizeMode GetEllipsize(this GtkProgressBarHandle pbar)
	{
		return GtkProgressBarExterns.gtk_progress_bar_get_ellipsize(pbar);
	}

	public static double GetFraction(this GtkProgressBarHandle pbar)
	{
		return GtkProgressBarExterns.gtk_progress_bar_get_fraction(pbar);
	}

	public static bool GetInverted(this GtkProgressBarHandle pbar)
	{
		return GtkProgressBarExterns.gtk_progress_bar_get_inverted(pbar);
	}

	public static double GetPulseStep(this GtkProgressBarHandle pbar)
	{
		return GtkProgressBarExterns.gtk_progress_bar_get_pulse_step(pbar);
	}

	public static bool GetShowText(this GtkProgressBarHandle pbar)
	{
		return GtkProgressBarExterns.gtk_progress_bar_get_show_text(pbar);
	}

	public static string GetText(this GtkProgressBarHandle pbar)
	{
		return GtkProgressBarExterns.gtk_progress_bar_get_text(pbar);
	}

	public static T Pulse<T>(this T pbar) where T : GtkProgressBarHandle
	{
		GtkProgressBarExterns.gtk_progress_bar_pulse(pbar);
		return pbar;
	}

	public static T SetEllipsize<T>(this T pbar, PangoEllipsizeMode mode) where T : GtkProgressBarHandle
	{
		GtkProgressBarExterns.gtk_progress_bar_set_ellipsize(pbar, mode);
		return pbar;
	}

	public static T SetFraction<T>(this T pbar, double fraction) where T : GtkProgressBarHandle
	{
		GtkProgressBarExterns.gtk_progress_bar_set_fraction(pbar, fraction);
		return pbar;
	}

	public static T SetInverted<T>(this T pbar, bool inverted) where T : GtkProgressBarHandle
	{
		GtkProgressBarExterns.gtk_progress_bar_set_inverted(pbar, inverted);
		return pbar;
	}

	public static T SetPulseStep<T>(this T pbar, double fraction) where T : GtkProgressBarHandle
	{
		GtkProgressBarExterns.gtk_progress_bar_set_pulse_step(pbar, fraction);
		return pbar;
	}

	public static T SetShowText<T>(this T pbar, bool show_text) where T : GtkProgressBarHandle
	{
		GtkProgressBarExterns.gtk_progress_bar_set_show_text(pbar, show_text);
		return pbar;
	}

	public static T SetText<T>(this T pbar, string text) where T : GtkProgressBarHandle
	{
		GtkProgressBarExterns.gtk_progress_bar_set_text(pbar, text);
		return pbar;
	}

}

internal class GtkProgressBarExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkProgressBarHandle gtk_progress_bar_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoEllipsizeMode gtk_progress_bar_get_ellipsize(GtkProgressBarHandle pbar);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_progress_bar_get_fraction(GtkProgressBarHandle pbar);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_progress_bar_get_inverted(GtkProgressBarHandle pbar);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_progress_bar_get_pulse_step(GtkProgressBarHandle pbar);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_progress_bar_get_show_text(GtkProgressBarHandle pbar);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_progress_bar_get_text(GtkProgressBarHandle pbar);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_progress_bar_pulse(GtkProgressBarHandle pbar);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_progress_bar_set_ellipsize(GtkProgressBarHandle pbar, PangoEllipsizeMode mode);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_progress_bar_set_fraction(GtkProgressBarHandle pbar, double fraction);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_progress_bar_set_inverted(GtkProgressBarHandle pbar, bool inverted);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_progress_bar_set_pulse_step(GtkProgressBarHandle pbar, double fraction);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_progress_bar_set_show_text(GtkProgressBarHandle pbar, bool show_text);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_progress_bar_set_text(GtkProgressBarHandle pbar, string text);

}
