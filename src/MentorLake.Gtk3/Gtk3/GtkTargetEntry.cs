namespace MentorLake.Gtk3.Gtk3;

public class GtkTargetEntryHandle : BaseSafeHandle
{
	public static GtkTargetEntryHandle New(string target, uint flags, uint info)
	{
		return GtkTargetEntryExterns.gtk_target_entry_new(target, flags, info);
	}

}


public static class GtkTargetEntryHandleExtensions
{
	public static GtkTargetEntryHandle Copy(this GtkTargetEntryHandle data)
	{
		return GtkTargetEntryExterns.gtk_target_entry_copy(data);
	}

	public static T Free<T>(this T data) where T : GtkTargetEntryHandle
	{
		GtkTargetEntryExterns.gtk_target_entry_free(data);
		return data;
	}

}
internal class GtkTargetEntryExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTargetEntryHandle gtk_target_entry_new(string target, uint flags, uint info);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTargetEntryHandle gtk_target_entry_copy(GtkTargetEntryHandle data);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_target_entry_free(GtkTargetEntryHandle data);

}

public struct GtkTargetEntry
{
	public string target;
	public uint flags;
	public uint info;
}
