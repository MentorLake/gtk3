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
	public static GtkSpinnerHandle Start(this GtkSpinnerHandle spinner)
	{
		GtkSpinnerExterns.gtk_spinner_start(spinner);
		return spinner;
	}

	public static GtkSpinnerHandle Stop(this GtkSpinnerHandle spinner)
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
