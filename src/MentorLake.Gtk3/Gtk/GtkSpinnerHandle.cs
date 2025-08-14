namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A GtkSpinner widget displays an icon-size spinning animation.
/// It is often used as an alternative to a #GtkProgressBar for
/// displaying indefinite activity, instead of actual progress.
/// </para>
/// <para>
/// To start the animation, use gtk_spinner_start(), to stop it
/// use gtk_spinner_stop().
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkSpinner has a single CSS node with the name spinner. When the animation is
/// active, the :checked pseudoclass is added to this node.
/// </para>
/// </summary>

public class GtkSpinnerHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Returns a new spinner widget. Not yet started.
/// </para>
/// </summary>

/// <return>
/// a new #GtkSpinner
/// </return>

	public static MentorLake.Gtk.GtkSpinnerHandle New()
	{
		return GtkSpinnerHandleExterns.gtk_spinner_new();
	}

}

public static class GtkSpinnerHandleExtensions
{
/// <summary>
/// <para>
/// Starts the animation of the spinner.
/// </para>
/// </summary>

/// <param name="spinner">
/// a #GtkSpinner
/// </param>

	public static T Start<T>(this T spinner) where T : GtkSpinnerHandle
	{
		if (spinner.IsInvalid) throw new Exception("Invalid handle (GtkSpinnerHandle)");
		GtkSpinnerHandleExterns.gtk_spinner_start(spinner);
		return spinner;
	}

/// <summary>
/// <para>
/// Stops the animation of the spinner.
/// </para>
/// </summary>

/// <param name="spinner">
/// a #GtkSpinner
/// </param>

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
