namespace MentorLake.Gtk3.GLib;

public class GCompletionHandle : BaseSafeHandle
{
}


public static class GCompletionHandleExtensions
{
	public static T AddItems<T>(this T cmp, GListHandle items) where T : GCompletionHandle
	{
		GCompletionExterns.g_completion_add_items(cmp, items);
		return cmp;
	}

	public static T ClearItems<T>(this T cmp) where T : GCompletionHandle
	{
		GCompletionExterns.g_completion_clear_items(cmp);
		return cmp;
	}

	public static GListHandle Complete(this GCompletionHandle cmp, string prefix, ref string new_prefix)
	{
		return GCompletionExterns.g_completion_complete(cmp, prefix, ref new_prefix);
	}

	public static GListHandle CompleteUtf8(this GCompletionHandle cmp, string prefix, ref string new_prefix)
	{
		return GCompletionExterns.g_completion_complete_utf8(cmp, prefix, ref new_prefix);
	}

	public static T Free<T>(this T cmp) where T : GCompletionHandle
	{
		GCompletionExterns.g_completion_free(cmp);
		return cmp;
	}

	public static T RemoveItems<T>(this T cmp, GListHandle items) where T : GCompletionHandle
	{
		GCompletionExterns.g_completion_remove_items(cmp, items);
		return cmp;
	}

	public static T SetCompare<T>(this T cmp, GCompletionStrncmpFunc strncmp_func) where T : GCompletionHandle
	{
		GCompletionExterns.g_completion_set_compare(cmp, strncmp_func);
		return cmp;
	}

	public static GCompletionHandle New(GCompletionFunc func)
	{
		return GCompletionExterns.g_completion_new(func);
	}

}
internal class GCompletionExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_completion_add_items(GCompletionHandle cmp, GListHandle items);

	[DllImport(Libraries.GLib)]
	internal static extern void g_completion_clear_items(GCompletionHandle cmp);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_completion_complete(GCompletionHandle cmp, string prefix, ref string new_prefix);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_completion_complete_utf8(GCompletionHandle cmp, string prefix, ref string new_prefix);

	[DllImport(Libraries.GLib)]
	internal static extern void g_completion_free(GCompletionHandle cmp);

	[DllImport(Libraries.GLib)]
	internal static extern void g_completion_remove_items(GCompletionHandle cmp, GListHandle items);

	[DllImport(Libraries.GLib)]
	internal static extern void g_completion_set_compare(GCompletionHandle cmp, GCompletionStrncmpFunc strncmp_func);

	[DllImport(Libraries.GLib)]
	internal static extern GCompletionHandle g_completion_new(GCompletionFunc func);

}

public struct GCompletion
{
	public GListHandle items;
	public GCompletionFunc func;
	public string prefix;
	public GListHandle cache;
	public GCompletionStrncmpFunc strncmp_func;
}
