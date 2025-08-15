namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkProgressBar is typically used to display the progress of a long
/// running operation. It provides a visual clue that processing is underway.
/// The GtkProgressBar can be used in two different modes: percentage mode
/// and activity mode.
/// </para>
/// <para>
/// When an application can determine how much work needs to take place
/// (e.g. read a fixed number of bytes from a file) and can monitor its
/// progress, it can use the GtkProgressBar in percentage mode and the
/// user sees a growing bar indicating the percentage of the work that
/// has been completed. In this mode, the application is required to call
/// gtk_progress_bar_set_fraction() periodically to update the progress bar.
/// </para>
/// <para>
/// When an application has no accurate way of knowing the amount of work
/// to do, it can use the #GtkProgressBar in activity mode, which shows
/// activity by a block moving back and forth within the progress area. In
/// this mode, the application is required to call gtk_progress_bar_pulse()
/// periodically to update the progress bar.
/// </para>
/// <para>
/// There is quite a bit of flexibility provided to control the appearance
/// of the #GtkProgressBar. Functions are provided to control the orientation
/// of the bar, optional text can be displayed along with the bar, and the
/// step size used in activity mode can be set.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <code>
/// progressbar[.osd]
/// progressbar[.osd]
/// ├── [text]
/// ╰── trough[.empty][.full]
///     ╰── progress[.pulse]
/// </code>
/// <para>
/// GtkProgressBar has a main CSS node with name progressbar and subnodes with
/// names text and trough, of which the latter has a subnode named progress. The
/// text subnode is only present if text is shown. The progress subnode has the
/// style class .pulse when in activity mode. It gets the style classes .left,
/// .right, .top or .bottom added when the progress &apos;touches&apos; the corresponding
/// end of the GtkProgressBar. The .osd class on the progressbar node is for use
/// in overlays like the one Epiphany has for page loading progress.
/// </para>
/// </summary>

public class GtkProgressBarHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkProgressBar.
/// </para>
/// </summary>

/// <return>
/// a #GtkProgressBar.
/// </return>

	public static MentorLake.Gtk.GtkProgressBarHandle New()
	{
		return GtkProgressBarHandleExterns.gtk_progress_bar_new();
	}

}

public static class GtkProgressBarHandleExtensions
{
/// <summary>
/// <para>
/// Returns the ellipsizing position of the progress bar.
/// See gtk_progress_bar_set_ellipsize().
/// </para>
/// </summary>

/// <param name="pbar">
/// a #GtkProgressBar
/// </param>
/// <return>
/// #PangoEllipsizeMode
/// </return>

	public static MentorLake.Pango.PangoEllipsizeMode GetEllipsize(this MentorLake.Gtk.GtkProgressBarHandle pbar)
	{
		if (pbar.IsInvalid) throw new Exception("Invalid handle (GtkProgressBarHandle)");
		return GtkProgressBarHandleExterns.gtk_progress_bar_get_ellipsize(pbar);
	}

/// <summary>
/// <para>
/// Returns the current fraction of the task that’s been completed.
/// </para>
/// </summary>

/// <param name="pbar">
/// a #GtkProgressBar
/// </param>
/// <return>
/// a fraction from 0.0 to 1.0
/// </return>

	public static double GetFraction(this MentorLake.Gtk.GtkProgressBarHandle pbar)
	{
		if (pbar.IsInvalid) throw new Exception("Invalid handle (GtkProgressBarHandle)");
		return GtkProgressBarHandleExterns.gtk_progress_bar_get_fraction(pbar);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_progress_bar_set_inverted().
/// </para>
/// </summary>

/// <param name="pbar">
/// a #GtkProgressBar
/// </param>
/// <return>
/// %TRUE if the progress bar is inverted
/// </return>

	public static bool GetInverted(this MentorLake.Gtk.GtkProgressBarHandle pbar)
	{
		if (pbar.IsInvalid) throw new Exception("Invalid handle (GtkProgressBarHandle)");
		return GtkProgressBarHandleExterns.gtk_progress_bar_get_inverted(pbar);
	}

/// <summary>
/// <para>
/// Retrieves the pulse step set with gtk_progress_bar_set_pulse_step().
/// </para>
/// </summary>

/// <param name="pbar">
/// a #GtkProgressBar
/// </param>
/// <return>
/// a fraction from 0.0 to 1.0
/// </return>

	public static double GetPulseStep(this MentorLake.Gtk.GtkProgressBarHandle pbar)
	{
		if (pbar.IsInvalid) throw new Exception("Invalid handle (GtkProgressBarHandle)");
		return GtkProgressBarHandleExterns.gtk_progress_bar_get_pulse_step(pbar);
	}

/// <summary>
/// <para>
/// Gets the value of the #GtkProgressBar:show-text property.
/// See gtk_progress_bar_set_show_text().
/// </para>
/// </summary>

/// <param name="pbar">
/// a #GtkProgressBar
/// </param>
/// <return>
/// %TRUE if text is shown in the progress bar
/// </return>

	public static bool GetShowText(this MentorLake.Gtk.GtkProgressBarHandle pbar)
	{
		if (pbar.IsInvalid) throw new Exception("Invalid handle (GtkProgressBarHandle)");
		return GtkProgressBarHandleExterns.gtk_progress_bar_get_show_text(pbar);
	}

/// <summary>
/// <para>
/// Retrieves the text that is displayed with the progress bar,
/// if any, otherwise %NULL. The return value is a reference
/// to the text, not a copy of it, so will become invalid
/// if you change the text in the progress bar.
/// </para>
/// </summary>

/// <param name="pbar">
/// a #GtkProgressBar
/// </param>
/// <return>
/// text, or %NULL; this string is owned by the widget
/// and should not be modified or freed.
/// </return>

	public static string GetText(this MentorLake.Gtk.GtkProgressBarHandle pbar)
	{
		if (pbar.IsInvalid) throw new Exception("Invalid handle (GtkProgressBarHandle)");
		return GtkProgressBarHandleExterns.gtk_progress_bar_get_text(pbar);
	}

/// <summary>
/// <para>
/// Indicates that some progress has been made, but you don’t know how much.
/// Causes the progress bar to enter “activity mode,” where a block
/// bounces back and forth. Each call to gtk_progress_bar_pulse()
/// causes the block to move by a little bit (the amount of movement
/// per pulse is determined by gtk_progress_bar_set_pulse_step()).
/// </para>
/// </summary>

/// <param name="pbar">
/// a #GtkProgressBar
/// </param>

	public static T Pulse<T>(this T pbar) where T : GtkProgressBarHandle
	{
		if (pbar.IsInvalid) throw new Exception("Invalid handle (GtkProgressBarHandle)");
		GtkProgressBarHandleExterns.gtk_progress_bar_pulse(pbar);
		return pbar;
	}

/// <summary>
/// <para>
/// Sets the mode used to ellipsize (add an ellipsis: &quot;...&quot;) the
/// text if there is not enough space to render the entire string.
/// </para>
/// </summary>

/// <param name="pbar">
/// a #GtkProgressBar
/// </param>
/// <param name="mode">
/// a #PangoEllipsizeMode
/// </param>

	public static T SetEllipsize<T>(this T pbar, MentorLake.Pango.PangoEllipsizeMode mode) where T : GtkProgressBarHandle
	{
		if (pbar.IsInvalid) throw new Exception("Invalid handle (GtkProgressBarHandle)");
		GtkProgressBarHandleExterns.gtk_progress_bar_set_ellipsize(pbar, mode);
		return pbar;
	}

/// <summary>
/// <para>
/// Causes the progress bar to “fill in” the given fraction
/// of the bar. The fraction should be between 0.0 and 1.0,
/// inclusive.
/// </para>
/// </summary>

/// <param name="pbar">
/// a #GtkProgressBar
/// </param>
/// <param name="fraction">
/// fraction of the task that’s been completed
/// </param>

	public static T SetFraction<T>(this T pbar, double fraction) where T : GtkProgressBarHandle
	{
		if (pbar.IsInvalid) throw new Exception("Invalid handle (GtkProgressBarHandle)");
		GtkProgressBarHandleExterns.gtk_progress_bar_set_fraction(pbar, fraction);
		return pbar;
	}

/// <summary>
/// <para>
/// Progress bars normally grow from top to bottom or left to right.
/// Inverted progress bars grow in the opposite direction.
/// </para>
/// </summary>

/// <param name="pbar">
/// a #GtkProgressBar
/// </param>
/// <param name="inverted">
/// %TRUE to invert the progress bar
/// </param>

	public static T SetInverted<T>(this T pbar, bool inverted) where T : GtkProgressBarHandle
	{
		if (pbar.IsInvalid) throw new Exception("Invalid handle (GtkProgressBarHandle)");
		GtkProgressBarHandleExterns.gtk_progress_bar_set_inverted(pbar, inverted);
		return pbar;
	}

/// <summary>
/// <para>
/// Sets the fraction of total progress bar length to move the
/// bouncing block for each call to gtk_progress_bar_pulse().
/// </para>
/// </summary>

/// <param name="pbar">
/// a #GtkProgressBar
/// </param>
/// <param name="fraction">
/// fraction between 0.0 and 1.0
/// </param>

	public static T SetPulseStep<T>(this T pbar, double fraction) where T : GtkProgressBarHandle
	{
		if (pbar.IsInvalid) throw new Exception("Invalid handle (GtkProgressBarHandle)");
		GtkProgressBarHandleExterns.gtk_progress_bar_set_pulse_step(pbar, fraction);
		return pbar;
	}

/// <summary>
/// <para>
/// Sets whether the progress bar will show text next to the bar.
/// The shown text is either the value of the #GtkProgressBar:text
/// property or, if that is %NULL, the #GtkProgressBar:fraction value,
/// as a percentage.
/// </para>
/// <para>
/// To make a progress bar that is styled and sized suitably for containing
/// text (even if the actual text is blank), set #GtkProgressBar:show-text to
/// %TRUE and #GtkProgressBar:text to the empty string (not %NULL).
/// </para>
/// </summary>

/// <param name="pbar">
/// a #GtkProgressBar
/// </param>
/// <param name="show_text">
/// whether to show text
/// </param>

	public static T SetShowText<T>(this T pbar, bool show_text) where T : GtkProgressBarHandle
	{
		if (pbar.IsInvalid) throw new Exception("Invalid handle (GtkProgressBarHandle)");
		GtkProgressBarHandleExterns.gtk_progress_bar_set_show_text(pbar, show_text);
		return pbar;
	}

/// <summary>
/// <para>
/// Causes the given @text to appear next to the progress bar.
/// </para>
/// <para>
/// If @text is %NULL and #GtkProgressBar:show-text is %TRUE, the current
/// value of #GtkProgressBar:fraction will be displayed as a percentage.
/// </para>
/// <para>
/// If @text is non-%NULL and #GtkProgressBar:show-text is %TRUE, the text
/// will be displayed. In this case, it will not display the progress
/// percentage. If @text is the empty string, the progress bar will still
/// be styled and sized suitably for containing text, as long as
/// #GtkProgressBar:show-text is %TRUE.
/// </para>
/// </summary>

/// <param name="pbar">
/// a #GtkProgressBar
/// </param>
/// <param name="text">
/// a UTF-8 string, or %NULL
/// </param>

	public static T SetText<T>(this T pbar, string text) where T : GtkProgressBarHandle
	{
		if (pbar.IsInvalid) throw new Exception("Invalid handle (GtkProgressBarHandle)");
		GtkProgressBarHandleExterns.gtk_progress_bar_set_text(pbar, text);
		return pbar;
	}

}

internal class GtkProgressBarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkProgressBarHandle>))]
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
