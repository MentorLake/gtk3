namespace MentorLake.Gtk3.Gtk3;

public interface GtkActionableHandle
{
}

internal class GtkActionableHandleImpl : BaseSafeHandle, GtkActionableHandle
{
}

public static class GtkActionableHandleExtensions
{
	public static string GetActionName(this GtkActionableHandle actionable)
	{
		return GtkActionableExterns.gtk_actionable_get_action_name(actionable);
	}

	public static GVariantHandle GetActionTargetValue(this GtkActionableHandle actionable)
	{
		return GtkActionableExterns.gtk_actionable_get_action_target_value(actionable);
	}

	public static T SetActionName<T>(this T actionable, string action_name) where T : GtkActionableHandle
	{
		GtkActionableExterns.gtk_actionable_set_action_name(actionable, action_name);
		return actionable;
	}

	public static T SetActionTarget<T>(this T actionable, string format_string, IntPtr @__arglist) where T : GtkActionableHandle
	{
		GtkActionableExterns.gtk_actionable_set_action_target(actionable, format_string, @__arglist);
		return actionable;
	}

	public static T SetActionTargetValue<T>(this T actionable, GVariantHandle target_value) where T : GtkActionableHandle
	{
		GtkActionableExterns.gtk_actionable_set_action_target_value(actionable, target_value);
		return actionable;
	}

	public static T SetDetailedActionName<T>(this T actionable, string detailed_action_name) where T : GtkActionableHandle
	{
		GtkActionableExterns.gtk_actionable_set_detailed_action_name(actionable, detailed_action_name);
		return actionable;
	}

}

internal class GtkActionableExterns
{
	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_actionable_get_action_name(GtkActionableHandle actionable);

	[DllImport(Libraries.Gtk3)]
	internal static extern GVariantHandle gtk_actionable_get_action_target_value(GtkActionableHandle actionable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_actionable_set_action_name(GtkActionableHandle actionable, string action_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_actionable_set_action_target(GtkActionableHandle actionable, string format_string, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_actionable_set_action_target_value(GtkActionableHandle actionable, GVariantHandle target_value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_actionable_set_detailed_action_name(GtkActionableHandle actionable, string detailed_action_name);

}
