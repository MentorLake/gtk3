namespace MentorLake.Gtk3.Gtk3;

public class GtkSpinnerHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkSpinnerHandle New()
	{
		return GtkSpinnerExterns.gtk_spinner_new();
	}

}

public static class GtkSpinnerHandleExtensions
{
	public static T Start<T>(this T spinner) where T : GtkSpinnerHandle
	{
		GtkSpinnerExterns.gtk_spinner_start(spinner);
		return spinner;
	}

	public static T Stop<T>(this T spinner) where T : GtkSpinnerHandle
	{
		GtkSpinnerExterns.gtk_spinner_stop(spinner);
		return spinner;
	}

}

internal class GtkSpinnerExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSpinnerHandle gtk_spinner_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_spinner_start(GtkSpinnerHandle spinner);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_spinner_stop(GtkSpinnerHandle spinner);

}
