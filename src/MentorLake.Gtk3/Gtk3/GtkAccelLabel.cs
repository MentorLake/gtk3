namespace MentorLake.Gtk3.Gtk3;

public class GtkAccelLabelHandle : GtkLabelHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkAccelLabelHandle New(string @string)
	{
		return GtkAccelLabelExterns.gtk_accel_label_new(@string);
	}

}

public static class GtkAccelLabelHandleExtensions
{
	public static T GetAccel<T>(this T accel_label, out uint accelerator_key, out GdkModifierType accelerator_mods) where T : GtkAccelLabelHandle
	{
		GtkAccelLabelExterns.gtk_accel_label_get_accel(accel_label, out accelerator_key, out accelerator_mods);
		return accel_label;
	}

	public static GtkWidgetHandle GetAccelWidget(this GtkAccelLabelHandle accel_label)
	{
		return GtkAccelLabelExterns.gtk_accel_label_get_accel_widget(accel_label);
	}

	public static uint GetAccelWidth(this GtkAccelLabelHandle accel_label)
	{
		return GtkAccelLabelExterns.gtk_accel_label_get_accel_width(accel_label);
	}

	public static bool Refetch(this GtkAccelLabelHandle accel_label)
	{
		return GtkAccelLabelExterns.gtk_accel_label_refetch(accel_label);
	}

	public static T SetAccel<T>(this T accel_label, uint accelerator_key, GdkModifierType accelerator_mods) where T : GtkAccelLabelHandle
	{
		GtkAccelLabelExterns.gtk_accel_label_set_accel(accel_label, accelerator_key, accelerator_mods);
		return accel_label;
	}

	public static T SetAccelClosure<T>(this T accel_label, GClosureHandle accel_closure) where T : GtkAccelLabelHandle
	{
		GtkAccelLabelExterns.gtk_accel_label_set_accel_closure(accel_label, accel_closure);
		return accel_label;
	}

	public static T SetAccelWidget<T>(this T accel_label, GtkWidgetHandle accel_widget) where T : GtkAccelLabelHandle
	{
		GtkAccelLabelExterns.gtk_accel_label_set_accel_widget(accel_label, accel_widget);
		return accel_label;
	}

}

internal class GtkAccelLabelExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAccelLabelHandle gtk_accel_label_new(string @string);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accel_label_get_accel(GtkAccelLabelHandle accel_label, out uint accelerator_key, out GdkModifierType accelerator_mods);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_accel_label_get_accel_widget(GtkAccelLabelHandle accel_label);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_accel_label_get_accel_width(GtkAccelLabelHandle accel_label);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_accel_label_refetch(GtkAccelLabelHandle accel_label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accel_label_set_accel(GtkAccelLabelHandle accel_label, uint accelerator_key, GdkModifierType accelerator_mods);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accel_label_set_accel_closure(GtkAccelLabelHandle accel_label, GClosureHandle accel_closure);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accel_label_set_accel_widget(GtkAccelLabelHandle accel_label, GtkWidgetHandle accel_widget);

}
