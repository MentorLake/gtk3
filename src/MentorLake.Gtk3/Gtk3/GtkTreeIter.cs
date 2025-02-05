namespace MentorLake.Gtk3.Gtk3;

public class GtkTreeIterHandle : BaseSafeHandle
{
}


public static class GtkTreeIterHandleExtensions
{
	public static GtkTreeIterHandle Copy(this GtkTreeIterHandle iter)
	{
		return GtkTreeIterExterns.gtk_tree_iter_copy(iter);
	}

	public static T Free<T>(this T iter) where T : GtkTreeIterHandle
	{
		GtkTreeIterExterns.gtk_tree_iter_free(iter);
		return iter;
	}

}
internal class GtkTreeIterExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeIterHandle gtk_tree_iter_copy(GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tree_iter_free(GtkTreeIterHandle iter);

}

public struct GtkTreeIter
{
	public int stamp;
	public IntPtr user_data;
	public IntPtr user_data2;
	public IntPtr user_data3;
}
