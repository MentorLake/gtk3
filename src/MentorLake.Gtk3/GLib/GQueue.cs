namespace MentorLake.Gtk3.GLib;

public class GQueueHandle : BaseSafeHandle
{
}


public static class GQueueHandleExtensions
{
	public static T Clear<T>(this T queue) where T : GQueueHandle
	{
		GQueueExterns.g_queue_clear(queue);
		return queue;
	}

	public static T ClearFull<T>(this T queue, GDestroyNotify free_func) where T : GQueueHandle
	{
		GQueueExterns.g_queue_clear_full(queue, free_func);
		return queue;
	}

	public static GQueueHandle Copy(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_copy(queue);
	}

	public static T DeleteLink<T>(this T queue, GListHandle link_) where T : GQueueHandle
	{
		GQueueExterns.g_queue_delete_link(queue, link_);
		return queue;
	}

	public static GListHandle Find(this GQueueHandle queue, IntPtr data)
	{
		return GQueueExterns.g_queue_find(queue, data);
	}

	public static GListHandle FindCustom(this GQueueHandle queue, IntPtr data, GCompareFunc func)
	{
		return GQueueExterns.g_queue_find_custom(queue, data, func);
	}

	public static T Foreach<T>(this T queue, GFunc func, IntPtr user_data) where T : GQueueHandle
	{
		GQueueExterns.g_queue_foreach(queue, func, user_data);
		return queue;
	}

	public static T Free<T>(this T queue) where T : GQueueHandle
	{
		GQueueExterns.g_queue_free(queue);
		return queue;
	}

	public static T FreeFull<T>(this T queue, GDestroyNotify free_func) where T : GQueueHandle
	{
		GQueueExterns.g_queue_free_full(queue, free_func);
		return queue;
	}

	public static uint GetLength(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_get_length(queue);
	}

	public static int Index(this GQueueHandle queue, IntPtr data)
	{
		return GQueueExterns.g_queue_index(queue, data);
	}

	public static T Init<T>(this T queue) where T : GQueueHandle
	{
		GQueueExterns.g_queue_init(queue);
		return queue;
	}

	public static T InsertAfter<T>(this T queue, GListHandle sibling, IntPtr data) where T : GQueueHandle
	{
		GQueueExterns.g_queue_insert_after(queue, sibling, data);
		return queue;
	}

	public static T InsertAfterLink<T>(this T queue, GListHandle sibling, GListHandle link_) where T : GQueueHandle
	{
		GQueueExterns.g_queue_insert_after_link(queue, sibling, link_);
		return queue;
	}

	public static T InsertBefore<T>(this T queue, GListHandle sibling, IntPtr data) where T : GQueueHandle
	{
		GQueueExterns.g_queue_insert_before(queue, sibling, data);
		return queue;
	}

	public static T InsertBeforeLink<T>(this T queue, GListHandle sibling, GListHandle link_) where T : GQueueHandle
	{
		GQueueExterns.g_queue_insert_before_link(queue, sibling, link_);
		return queue;
	}

	public static T InsertSorted<T>(this T queue, IntPtr data, GCompareDataFunc func, IntPtr user_data) where T : GQueueHandle
	{
		GQueueExterns.g_queue_insert_sorted(queue, data, func, user_data);
		return queue;
	}

	public static bool IsEmpty(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_is_empty(queue);
	}

	public static int LinkIndex(this GQueueHandle queue, GListHandle link_)
	{
		return GQueueExterns.g_queue_link_index(queue, link_);
	}

	public static IntPtr PeekHead(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_peek_head(queue);
	}

	public static GListHandle PeekHeadLink(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_peek_head_link(queue);
	}

	public static IntPtr PeekNth(this GQueueHandle queue, uint n)
	{
		return GQueueExterns.g_queue_peek_nth(queue, n);
	}

	public static GListHandle PeekNthLink(this GQueueHandle queue, uint n)
	{
		return GQueueExterns.g_queue_peek_nth_link(queue, n);
	}

	public static IntPtr PeekTail(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_peek_tail(queue);
	}

	public static GListHandle PeekTailLink(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_peek_tail_link(queue);
	}

	public static IntPtr PopHead(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_pop_head(queue);
	}

	public static GListHandle PopHeadLink(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_pop_head_link(queue);
	}

	public static IntPtr PopNth(this GQueueHandle queue, uint n)
	{
		return GQueueExterns.g_queue_pop_nth(queue, n);
	}

	public static GListHandle PopNthLink(this GQueueHandle queue, uint n)
	{
		return GQueueExterns.g_queue_pop_nth_link(queue, n);
	}

	public static IntPtr PopTail(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_pop_tail(queue);
	}

	public static GListHandle PopTailLink(this GQueueHandle queue)
	{
		return GQueueExterns.g_queue_pop_tail_link(queue);
	}

	public static T PushHead<T>(this T queue, IntPtr data) where T : GQueueHandle
	{
		GQueueExterns.g_queue_push_head(queue, data);
		return queue;
	}

	public static T PushHeadLink<T>(this T queue, GListHandle link_) where T : GQueueHandle
	{
		GQueueExterns.g_queue_push_head_link(queue, link_);
		return queue;
	}

	public static T PushNth<T>(this T queue, IntPtr data, int n) where T : GQueueHandle
	{
		GQueueExterns.g_queue_push_nth(queue, data, n);
		return queue;
	}

	public static T PushNthLink<T>(this T queue, int n, GListHandle link_) where T : GQueueHandle
	{
		GQueueExterns.g_queue_push_nth_link(queue, n, link_);
		return queue;
	}

	public static T PushTail<T>(this T queue, IntPtr data) where T : GQueueHandle
	{
		GQueueExterns.g_queue_push_tail(queue, data);
		return queue;
	}

	public static T PushTailLink<T>(this T queue, GListHandle link_) where T : GQueueHandle
	{
		GQueueExterns.g_queue_push_tail_link(queue, link_);
		return queue;
	}

	public static bool Remove(this GQueueHandle queue, IntPtr data)
	{
		return GQueueExterns.g_queue_remove(queue, data);
	}

	public static uint RemoveAll(this GQueueHandle queue, IntPtr data)
	{
		return GQueueExterns.g_queue_remove_all(queue, data);
	}

	public static T Reverse<T>(this T queue) where T : GQueueHandle
	{
		GQueueExterns.g_queue_reverse(queue);
		return queue;
	}

	public static T Sort<T>(this T queue, GCompareDataFunc compare_func, IntPtr user_data) where T : GQueueHandle
	{
		GQueueExterns.g_queue_sort(queue, compare_func, user_data);
		return queue;
	}

	public static T Unlink<T>(this T queue, GListHandle link_) where T : GQueueHandle
	{
		GQueueExterns.g_queue_unlink(queue, link_);
		return queue;
	}

	public static GQueueHandle New()
	{
		return GQueueExterns.g_queue_new();
	}

}
internal class GQueueExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_clear(GQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_clear_full(GQueueHandle queue, GDestroyNotify free_func);

	[DllImport(Libraries.GLib)]
	internal static extern GQueueHandle g_queue_copy(GQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_delete_link(GQueueHandle queue, GListHandle link_);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_queue_find(GQueueHandle queue, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_queue_find_custom(GQueueHandle queue, IntPtr data, GCompareFunc func);

	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_foreach(GQueueHandle queue, GFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_free(GQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_free_full(GQueueHandle queue, GDestroyNotify free_func);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_queue_get_length(GQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern int g_queue_index(GQueueHandle queue, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_init(GQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_insert_after(GQueueHandle queue, GListHandle sibling, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_insert_after_link(GQueueHandle queue, GListHandle sibling, GListHandle link_);

	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_insert_before(GQueueHandle queue, GListHandle sibling, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_insert_before_link(GQueueHandle queue, GListHandle sibling, GListHandle link_);

	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_insert_sorted(GQueueHandle queue, IntPtr data, GCompareDataFunc func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_queue_is_empty(GQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern int g_queue_link_index(GQueueHandle queue, GListHandle link_);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_queue_peek_head(GQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_queue_peek_head_link(GQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_queue_peek_nth(GQueueHandle queue, uint n);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_queue_peek_nth_link(GQueueHandle queue, uint n);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_queue_peek_tail(GQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_queue_peek_tail_link(GQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_queue_pop_head(GQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_queue_pop_head_link(GQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_queue_pop_nth(GQueueHandle queue, uint n);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_queue_pop_nth_link(GQueueHandle queue, uint n);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_queue_pop_tail(GQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern GListHandle g_queue_pop_tail_link(GQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_push_head(GQueueHandle queue, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_push_head_link(GQueueHandle queue, GListHandle link_);

	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_push_nth(GQueueHandle queue, IntPtr data, int n);

	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_push_nth_link(GQueueHandle queue, int n, GListHandle link_);

	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_push_tail(GQueueHandle queue, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_push_tail_link(GQueueHandle queue, GListHandle link_);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_queue_remove(GQueueHandle queue, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_queue_remove_all(GQueueHandle queue, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_reverse(GQueueHandle queue);

	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_sort(GQueueHandle queue, GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern void g_queue_unlink(GQueueHandle queue, GListHandle link_);

	[DllImport(Libraries.GLib)]
	internal static extern GQueueHandle g_queue_new();

}

public struct GQueue
{
	public GListHandle head;
	public GListHandle tail;
	public uint length;
}
