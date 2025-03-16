namespace MentorLake.GLib;

public class GAsyncQueueHandle : BaseSafeHandle
{
}


public static class GAsyncQueueExtensions
{
	public static int Length(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		return GAsyncQueueExterns.g_async_queue_length(queue);
	}

	public static int LengthUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		return GAsyncQueueExterns.g_async_queue_length_unlocked(queue);
	}

	public static void Lock(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		GAsyncQueueExterns.g_async_queue_lock(queue);
	}

	public static IntPtr Pop(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		return GAsyncQueueExterns.g_async_queue_pop(queue);
	}

	public static IntPtr PopUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		return GAsyncQueueExterns.g_async_queue_pop_unlocked(queue);
	}

	public static void Push(this MentorLake.GLib.GAsyncQueueHandle queue, IntPtr data)
	{
		GAsyncQueueExterns.g_async_queue_push(queue, data);
	}

	public static void PushFront(this MentorLake.GLib.GAsyncQueueHandle queue, IntPtr item)
	{
		GAsyncQueueExterns.g_async_queue_push_front(queue, item);
	}

	public static void PushFrontUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue, IntPtr item)
	{
		GAsyncQueueExterns.g_async_queue_push_front_unlocked(queue, item);
	}

	public static void PushSorted(this MentorLake.GLib.GAsyncQueueHandle queue, IntPtr data, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data)
	{
		GAsyncQueueExterns.g_async_queue_push_sorted(queue, data, func, user_data);
	}

	public static void PushSortedUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue, IntPtr data, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data)
	{
		GAsyncQueueExterns.g_async_queue_push_sorted_unlocked(queue, data, func, user_data);
	}

	public static void PushUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue, IntPtr data)
	{
		GAsyncQueueExterns.g_async_queue_push_unlocked(queue, data);
	}

	public static MentorLake.GLib.GAsyncQueueHandle Ref(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		return GAsyncQueueExterns.g_async_queue_ref(queue);
	}

	public static void RefUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		GAsyncQueueExterns.g_async_queue_ref_unlocked(queue);
	}

	public static bool Remove(this MentorLake.GLib.GAsyncQueueHandle queue, IntPtr item)
	{
		return GAsyncQueueExterns.g_async_queue_remove(queue, item);
	}

	public static bool RemoveUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue, IntPtr item)
	{
		return GAsyncQueueExterns.g_async_queue_remove_unlocked(queue, item);
	}

	public static void Sort(this MentorLake.GLib.GAsyncQueueHandle queue, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data)
	{
		GAsyncQueueExterns.g_async_queue_sort(queue, func, user_data);
	}

	public static void SortUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data)
	{
		GAsyncQueueExterns.g_async_queue_sort_unlocked(queue, func, user_data);
	}

	public static IntPtr TimedPop(this MentorLake.GLib.GAsyncQueueHandle queue, MentorLake.GLib.GTimeValHandle end_time)
	{
		return GAsyncQueueExterns.g_async_queue_timed_pop(queue, end_time);
	}

	public static IntPtr TimedPopUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue, MentorLake.GLib.GTimeValHandle end_time)
	{
		return GAsyncQueueExterns.g_async_queue_timed_pop_unlocked(queue, end_time);
	}

	public static IntPtr TimeoutPop(this MentorLake.GLib.GAsyncQueueHandle queue, ulong timeout)
	{
		return GAsyncQueueExterns.g_async_queue_timeout_pop(queue, timeout);
	}

	public static IntPtr TimeoutPopUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue, ulong timeout)
	{
		return GAsyncQueueExterns.g_async_queue_timeout_pop_unlocked(queue, timeout);
	}

	public static IntPtr TryPop(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		return GAsyncQueueExterns.g_async_queue_try_pop(queue);
	}

	public static IntPtr TryPopUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		return GAsyncQueueExterns.g_async_queue_try_pop_unlocked(queue);
	}

	public static void Unlock(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		GAsyncQueueExterns.g_async_queue_unlock(queue);
	}

	public static void Unref(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		GAsyncQueueExterns.g_async_queue_unref(queue);
	}

	public static void UnrefAndUnlock(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		GAsyncQueueExterns.g_async_queue_unref_and_unlock(queue);
	}


	public static GAsyncQueue Dereference(this GAsyncQueueHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GAsyncQueue>(x.DangerousGetHandle());
}
internal class GAsyncQueueExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern int g_async_queue_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_async_queue_length_unlocked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_async_queue_lock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_async_queue_pop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_async_queue_pop_unlocked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_async_queue_push([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_async_queue_push_front([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue, IntPtr item);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_async_queue_push_front_unlocked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue, IntPtr item);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_async_queue_push_sorted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue, IntPtr data, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_async_queue_push_sorted_unlocked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue, IntPtr data, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_async_queue_push_unlocked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GAsyncQueueHandle g_async_queue_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_async_queue_ref_unlocked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_async_queue_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue, IntPtr item);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_async_queue_remove_unlocked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue, IntPtr item);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_async_queue_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_async_queue_sort_unlocked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_async_queue_timed_pop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle end_time);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_async_queue_timed_pop_unlocked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle end_time);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_async_queue_timeout_pop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue, ulong timeout);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_async_queue_timeout_pop_unlocked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue, ulong timeout);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_async_queue_try_pop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_async_queue_try_pop_unlocked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_async_queue_unlock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_async_queue_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_async_queue_unref_and_unlock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))] MentorLake.GLib.GAsyncQueueHandle queue);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GAsyncQueueHandle g_async_queue_new();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GAsyncQueueHandle g_async_queue_new_full(MentorLake.GLib.GDestroyNotify item_free_func);

}

public struct GAsyncQueue
{
	public static MentorLake.GLib.GAsyncQueueHandle New()
	{
		return GAsyncQueueExterns.g_async_queue_new();
	}

	public static MentorLake.GLib.GAsyncQueueHandle NewFull(MentorLake.GLib.GDestroyNotify item_free_func)
	{
		return GAsyncQueueExterns.g_async_queue_new_full(item_free_func);
	}

}
