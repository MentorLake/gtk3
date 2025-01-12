namespace MentorLake.Gtk3.Gtk3;

public interface GtkActivatableHandle
{
}

internal class GtkActivatableHandleImpl : BaseSafeHandle, GtkActivatableHandle
{
}

public static class GtkActivatableHandleExtensions
{
	public static T DoSetRelatedAction<T>(this T activatable, GtkActionHandle action) where T : GtkActivatableHandle
	{
		GtkActivatableExterns.gtk_activatable_do_set_related_action(activatable, action);
		return activatable;
	}

	public static GtkActionHandle GetRelatedAction(this GtkActivatableHandle activatable)
	{
		return GtkActivatableExterns.gtk_activatable_get_related_action(activatable);
	}

	public static bool GetUseActionAppearance(this GtkActivatableHandle activatable)
	{
		return GtkActivatableExterns.gtk_activatable_get_use_action_appearance(activatable);
	}

	public static T SetRelatedAction<T>(this T activatable, GtkActionHandle action) where T : GtkActivatableHandle
	{
		GtkActivatableExterns.gtk_activatable_set_related_action(activatable, action);
		return activatable;
	}

	public static T SetUseActionAppearance<T>(this T activatable, bool use_appearance) where T : GtkActivatableHandle
	{
		GtkActivatableExterns.gtk_activatable_set_use_action_appearance(activatable, use_appearance);
		return activatable;
	}

	public static T SyncActionProperties<T>(this T activatable, GtkActionHandle action) where T : GtkActivatableHandle
	{
		GtkActivatableExterns.gtk_activatable_sync_action_properties(activatable, action);
		return activatable;
	}

}

internal class GtkActivatableExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_activatable_do_set_related_action(GtkActivatableHandle activatable, GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkActionHandle gtk_activatable_get_related_action(GtkActivatableHandle activatable);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_activatable_get_use_action_appearance(GtkActivatableHandle activatable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_activatable_set_related_action(GtkActivatableHandle activatable, GtkActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_activatable_set_use_action_appearance(GtkActivatableHandle activatable, bool use_appearance);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_activatable_sync_action_properties(GtkActivatableHandle activatable, GtkActionHandle action);

}
