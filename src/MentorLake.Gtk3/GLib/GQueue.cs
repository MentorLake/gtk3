namespace MentorLake.GLib;

public class GQueueHandle : BaseSafeHandle
{
}


public static class GQueueExtensions
{
	public static void Clear(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_clear(queue);
	}

	public static void ClearFull(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GDestroyNotify free_func)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_clear_full(queue, free_func);
	}

	public static MentorLake.GLib.GQueueHandle Copy(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_copy(queue);
	}

	public static void DeleteLink(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GListHandle link_)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_delete_link(queue, link_);
	}

	public static MentorLake.GLib.GListHandle Find(this MentorLake.GLib.GQueueHandle queue, IntPtr data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_find(queue, data);
	}

	public static MentorLake.GLib.GListHandle FindCustom(this MentorLake.GLib.GQueueHandle queue, IntPtr data, MentorLake.GLib.GCompareFunc func)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_find_custom(queue, data, func);
	}

	public static void Foreach(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GFunc func, IntPtr user_data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_foreach(queue, func, user_data);
	}

	public static void Free(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_free(queue);
	}

	public static void FreeFull(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GDestroyNotify free_func)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_free_full(queue, free_func);
	}

	public static uint GetLength(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_get_length(queue);
	}

	public static int Index(this MentorLake.GLib.GQueueHandle queue, IntPtr data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_index(queue, data);
	}

	public static void Init(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_init(queue);
	}

	public static void InsertAfter(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GListHandle sibling, IntPtr data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_insert_after(queue, sibling, data);
	}

	public static void InsertAfterLink(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GListHandle sibling, MentorLake.GLib.GListHandle link_)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_insert_after_link(queue, sibling, link_);
	}

	public static void InsertBefore(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GListHandle sibling, IntPtr data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_insert_before(queue, sibling, data);
	}

	public static void InsertBeforeLink(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GListHandle sibling, MentorLake.GLib.GListHandle link_)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_insert_before_link(queue, sibling, link_);
	}

	public static void InsertSorted(this MentorLake.GLib.GQueueHandle queue, IntPtr data, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_insert_sorted(queue, data, func, user_data);
	}

	public static bool IsEmpty(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_is_empty(queue);
	}

	public static int LinkIndex(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GListHandle link_)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_link_index(queue, link_);
	}

	public static IntPtr PeekHead(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_peek_head(queue);
	}

	public static MentorLake.GLib.GListHandle PeekHeadLink(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_peek_head_link(queue);
	}

	public static IntPtr PeekNth(this MentorLake.GLib.GQueueHandle queue, uint n)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_peek_nth(queue, n);
	}

	public static MentorLake.GLib.GListHandle PeekNthLink(this MentorLake.GLib.GQueueHandle queue, uint n)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_peek_nth_link(queue, n);
	}

	public static IntPtr PeekTail(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_peek_tail(queue);
	}

	public static MentorLake.GLib.GListHandle PeekTailLink(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_peek_tail_link(queue);
	}

	public static IntPtr PopHead(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_pop_head(queue);
	}

	public static MentorLake.GLib.GListHandle PopHeadLink(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_pop_head_link(queue);
	}

	public static IntPtr PopNth(this MentorLake.GLib.GQueueHandle queue, uint n)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_pop_nth(queue, n);
	}

	public static MentorLake.GLib.GListHandle PopNthLink(this MentorLake.GLib.GQueueHandle queue, uint n)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_pop_nth_link(queue, n);
	}

	public static IntPtr PopTail(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_pop_tail(queue);
	}

	public static MentorLake.GLib.GListHandle PopTailLink(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_pop_tail_link(queue);
	}

	public static void PushHead(this MentorLake.GLib.GQueueHandle queue, IntPtr data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_push_head(queue, data);
	}

	public static void PushHeadLink(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GListHandle link_)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_push_head_link(queue, link_);
	}

	public static void PushNth(this MentorLake.GLib.GQueueHandle queue, IntPtr data, int n)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_push_nth(queue, data, n);
	}

	public static void PushNthLink(this MentorLake.GLib.GQueueHandle queue, int n, MentorLake.GLib.GListHandle link_)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_push_nth_link(queue, n, link_);
	}

	public static void PushTail(this MentorLake.GLib.GQueueHandle queue, IntPtr data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_push_tail(queue, data);
	}

	public static void PushTailLink(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GListHandle link_)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_push_tail_link(queue, link_);
	}

	public static bool Remove(this MentorLake.GLib.GQueueHandle queue, IntPtr data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_remove(queue, data);
	}

	public static uint RemoveAll(this MentorLake.GLib.GQueueHandle queue, IntPtr data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_remove_all(queue, data);
	}

	public static void Reverse(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_reverse(queue);
	}

	public static void Sort(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_sort(queue, compare_func, user_data);
	}

	public static void Unlink(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GListHandle link_)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_unlink(queue, link_);
	}


	public static GQueue Dereference(this GQueueHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GQueue>(x.DangerousGetHandle());
}
internal class GQueueExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_clear_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GDestroyNotify free_func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))]
	internal static extern MentorLake.GLib.GQueueHandle g_queue_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_delete_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle link_);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_queue_find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_queue_find_custom([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, IntPtr data, MentorLake.GLib.GCompareFunc func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_free_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GDestroyNotify free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_queue_get_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_queue_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_insert_after([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle sibling, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_insert_after_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle sibling, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle link_);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_insert_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle sibling, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_insert_before_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle sibling, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle link_);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_insert_sorted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, IntPtr data, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_queue_is_empty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_queue_link_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle link_);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_queue_peek_head([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_queue_peek_head_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_queue_peek_nth([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, uint n);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_queue_peek_nth_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, uint n);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_queue_peek_tail([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_queue_peek_tail_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_queue_pop_head([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_queue_pop_head_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_queue_pop_nth([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, uint n);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_queue_pop_nth_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, uint n);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_queue_pop_tail([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_queue_pop_tail_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_push_head([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_push_head_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle link_);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_push_nth([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, IntPtr data, int n);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_push_nth_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, int n, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle link_);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_push_tail([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_push_tail_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle link_);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_queue_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_queue_remove_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_reverse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_queue_unlink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))] MentorLake.GLib.GQueueHandle queue, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle link_);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQueueHandle>))]
	internal static extern MentorLake.GLib.GQueueHandle g_queue_new();

}

public struct GQueue
{
	public IntPtr head;
	public IntPtr tail;
	public uint length;
	public static MentorLake.GLib.GQueueHandle New()
	{
		return GQueueExterns.g_queue_new();
	}

}
