namespace MentorLake.GLib;

/// <summary>
/// <para>
/// An opaque data structure which represents an asynchronous queue.
/// </para>
/// <para>
/// It should only be accessed through the `g_async_queue_*` functions.
/// </para>
/// </summary>

public class GAsyncQueueHandle : BaseSafeHandle
{
}


public static class GAsyncQueueExtensions
{
/// <summary>
/// <para>
/// Returns the length of the queue.
/// </para>
/// <para>
/// Actually this function returns the number of data items in
/// the queue minus the number of waiting threads, so a negative
/// value means waiting threads, and a positive value means available
/// entries in the @queue. A return value of 0 could mean n entries
/// in the queue and n threads waiting. This can happen due to locking
/// of the queue or due to scheduling.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue.
/// </param>
/// <return>
/// the length of the @queue
/// </return>

	public static int Length(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		return GAsyncQueueExterns.g_async_queue_length(queue);
	}

/// <summary>
/// <para>
/// Returns the length of the queue.
/// </para>
/// <para>
/// Actually this function returns the number of data items in
/// the queue minus the number of waiting threads, so a negative
/// value means waiting threads, and a positive value means available
/// entries in the @queue. A return value of 0 could mean n entries
/// in the queue and n threads waiting. This can happen due to locking
/// of the queue or due to scheduling.
/// </para>
/// <para>
/// This function must be called while holding the @queue's lock.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>
/// <return>
/// the length of the @queue.
/// </return>

	public static int LengthUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		return GAsyncQueueExterns.g_async_queue_length_unlocked(queue);
	}

/// <summary>
/// <para>
/// Acquires the @queue's lock. If another thread is already
/// holding the lock, this call will block until the lock
/// becomes available.
/// </para>
/// <para>
/// Call g_async_queue_unlock() to drop the lock again.
/// </para>
/// <para>
/// While holding the lock, you can only call the
/// g_async_queue_*_unlocked() functions on @queue. Otherwise,
/// deadlock may occur.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>

	public static void Lock(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		GAsyncQueueExterns.g_async_queue_lock(queue);
	}

/// <summary>
/// <para>
/// Pops data from the @queue. If @queue is empty, this function
/// blocks until data becomes available.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>
/// <return>
/// data from the queue
/// </return>

	public static IntPtr Pop(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		return GAsyncQueueExterns.g_async_queue_pop(queue);
	}

/// <summary>
/// <para>
/// Pops data from the @queue. If @queue is empty, this function
/// blocks until data becomes available.
/// </para>
/// <para>
/// This function must be called while holding the @queue's lock.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>
/// <return>
/// data from the queue.
/// </return>

	public static IntPtr PopUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		return GAsyncQueueExterns.g_async_queue_pop_unlocked(queue);
	}

/// <summary>
/// <para>
/// Pushes the @data into the @queue.
/// </para>
/// <para>
/// The @data parameter must not be %NULL.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>
/// <param name="data">
/// data to push onto the @queue
/// </param>

	public static void Push(this MentorLake.GLib.GAsyncQueueHandle queue, IntPtr data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		GAsyncQueueExterns.g_async_queue_push(queue, data);
	}

/// <summary>
/// <para>
/// Pushes the @item into the @queue. @item must not be %NULL.
/// In contrast to g_async_queue_push(), this function
/// pushes the new item ahead of the items already in the queue,
/// so that it will be the next one to be popped off the queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>
/// <param name="item">
/// data to push into the @queue
/// </param>

	public static void PushFront(this MentorLake.GLib.GAsyncQueueHandle queue, IntPtr item)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		GAsyncQueueExterns.g_async_queue_push_front(queue, item);
	}

/// <summary>
/// <para>
/// Pushes the @item into the @queue. @item must not be %NULL.
/// In contrast to g_async_queue_push_unlocked(), this function
/// pushes the new item ahead of the items already in the queue,
/// so that it will be the next one to be popped off the queue.
/// </para>
/// <para>
/// This function must be called while holding the @queue's lock.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>
/// <param name="item">
/// data to push into the @queue
/// </param>

	public static void PushFrontUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue, IntPtr item)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		GAsyncQueueExterns.g_async_queue_push_front_unlocked(queue, item);
	}

/// <summary>
/// <para>
/// Inserts @data into @queue using @func to determine the new
/// position.
/// </para>
/// <para>
/// This function requires that the @queue is sorted before pushing on
/// new elements, see g_async_queue_sort().
/// </para>
/// <para>
/// This function will lock @queue before it sorts the queue and unlock
/// it when it is finished.
/// </para>
/// <para>
/// For an example of @func see g_async_queue_sort().
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>
/// <param name="data">
/// the @data to push into the @queue
/// </param>
/// <param name="func">
/// the #GCompareDataFunc is used to sort @queue
/// </param>
/// <param name="user_data">
/// user data passed to @func.
/// </param>

	public static void PushSorted(this MentorLake.GLib.GAsyncQueueHandle queue, IntPtr data, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		GAsyncQueueExterns.g_async_queue_push_sorted(queue, data, func, user_data);
	}

/// <summary>
/// <para>
/// Inserts @data into @queue using @func to determine the new
/// position.
/// </para>
/// <para>
/// The sort function @func is passed two elements of the @queue.
/// It should return 0 if they are equal, a negative value if the
/// first element should be higher in the @queue or a positive value
/// if the first element should be lower in the @queue than the second
/// element.
/// </para>
/// <para>
/// This function requires that the @queue is sorted before pushing on
/// new elements, see g_async_queue_sort().
/// </para>
/// <para>
/// This function must be called while holding the @queue's lock.
/// </para>
/// <para>
/// For an example of @func see g_async_queue_sort().
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>
/// <param name="data">
/// the data to push into the @queue
/// </param>
/// <param name="func">
/// the #GCompareDataFunc is used to sort @queue
/// </param>
/// <param name="user_data">
/// user data passed to @func.
/// </param>

	public static void PushSortedUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue, IntPtr data, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		GAsyncQueueExterns.g_async_queue_push_sorted_unlocked(queue, data, func, user_data);
	}

/// <summary>
/// <para>
/// Pushes the @data into the @queue.
/// </para>
/// <para>
/// The @data parameter must not be %NULL.
/// </para>
/// <para>
/// This function must be called while holding the @queue's lock.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>
/// <param name="data">
/// data to push onto the @queue
/// </param>

	public static void PushUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue, IntPtr data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		GAsyncQueueExterns.g_async_queue_push_unlocked(queue, data);
	}

/// <summary>
/// <para>
/// Increases the reference count of the asynchronous @queue by 1.
/// You do not need to hold the lock to call this function.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>
/// <return>
/// the @queue that was passed in (since 2.6)
/// </return>

	public static MentorLake.GLib.GAsyncQueueHandle Ref(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		return GAsyncQueueExterns.g_async_queue_ref(queue);
	}

/// <summary>
/// <para>
/// Increases the reference count of the asynchronous @queue by 1.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>

	public static void RefUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		GAsyncQueueExterns.g_async_queue_ref_unlocked(queue);
	}

/// <summary>
/// <para>
/// Remove an item from the queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>
/// <param name="item">
/// the data to remove from the @queue
/// </param>
/// <return>
/// %TRUE if the item was removed
/// </return>

	public static bool Remove(this MentorLake.GLib.GAsyncQueueHandle queue, IntPtr item)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		return GAsyncQueueExterns.g_async_queue_remove(queue, item);
	}

/// <summary>
/// <para>
/// Remove an item from the queue.
/// </para>
/// <para>
/// This function must be called while holding the @queue's lock.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>
/// <param name="item">
/// the data to remove from the @queue
/// </param>
/// <return>
/// %TRUE if the item was removed
/// </return>

	public static bool RemoveUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue, IntPtr item)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		return GAsyncQueueExterns.g_async_queue_remove_unlocked(queue, item);
	}

/// <summary>
/// <para>
/// Sorts @queue using @func.
/// </para>
/// <para>
/// The sort function @func is passed two elements of the @queue.
/// It should return 0 if they are equal, a negative value if the
/// first element should be higher in the @queue or a positive value
/// if the first element should be lower in the @queue than the second
/// element.
/// </para>
/// <para>
/// This function will lock @queue before it sorts the queue and unlock
/// it when it is finished.
/// </para>
/// <para>
/// If you were sorting a list of priority numbers to make sure the
/// lowest priority would be at the top of the queue, you could use:
/// |[<!-- language="C" -->
///  gint32 id1;
///  gint32 id2;
/// </para>
/// <para>
///  id1 = GPOINTER_TO_INT (element1);
///  id2 = GPOINTER_TO_INT (element2);
/// </para>
/// <para>
///  return (id1 > id2 ? +1 : id1 == id2 ? 0 : -1);
/// ]|
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>
/// <param name="func">
/// the #GCompareDataFunc is used to sort @queue
/// </param>
/// <param name="user_data">
/// user data passed to @func
/// </param>

	public static void Sort(this MentorLake.GLib.GAsyncQueueHandle queue, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		GAsyncQueueExterns.g_async_queue_sort(queue, func, user_data);
	}

/// <summary>
/// <para>
/// Sorts @queue using @func.
/// </para>
/// <para>
/// The sort function @func is passed two elements of the @queue.
/// It should return 0 if they are equal, a negative value if the
/// first element should be higher in the @queue or a positive value
/// if the first element should be lower in the @queue than the second
/// element.
/// </para>
/// <para>
/// This function must be called while holding the @queue's lock.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>
/// <param name="func">
/// the #GCompareDataFunc is used to sort @queue
/// </param>
/// <param name="user_data">
/// user data passed to @func
/// </param>

	public static void SortUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		GAsyncQueueExterns.g_async_queue_sort_unlocked(queue, func, user_data);
	}

/// <summary>
/// <para>
/// Pops data from the @queue. If the queue is empty, blocks until
/// @end_time or until data becomes available.
/// </para>
/// <para>
/// If no data is received before @end_time, %NULL is returned.
/// </para>
/// <para>
/// To easily calculate @end_time, a combination of g_get_real_time()
/// and g_time_val_add() can be used.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>
/// <param name="end_time">
/// a #GTimeVal, determining the final time
/// </param>
/// <return>
/// data from the queue or %NULL, when no data is
///   received before @end_time.
/// </return>

	public static IntPtr TimedPop(this MentorLake.GLib.GAsyncQueueHandle queue, MentorLake.GLib.GTimeValHandle end_time)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		return GAsyncQueueExterns.g_async_queue_timed_pop(queue, end_time);
	}

/// <summary>
/// <para>
/// Pops data from the @queue. If the queue is empty, blocks until
/// @end_time or until data becomes available.
/// </para>
/// <para>
/// If no data is received before @end_time, %NULL is returned.
/// </para>
/// <para>
/// To easily calculate @end_time, a combination of g_get_real_time()
/// and g_time_val_add() can be used.
/// </para>
/// <para>
/// This function must be called while holding the @queue's lock.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>
/// <param name="end_time">
/// a #GTimeVal, determining the final time
/// </param>
/// <return>
/// data from the queue or %NULL, when no data is
///   received before @end_time.
/// </return>

	public static IntPtr TimedPopUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue, MentorLake.GLib.GTimeValHandle end_time)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		return GAsyncQueueExterns.g_async_queue_timed_pop_unlocked(queue, end_time);
	}

/// <summary>
/// <para>
/// Pops data from the @queue. If the queue is empty, blocks for
/// @timeout microseconds, or until data becomes available.
/// </para>
/// <para>
/// If no data is received before the timeout, %NULL is returned.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>
/// <param name="timeout">
/// the number of microseconds to wait
/// </param>
/// <return>
/// data from the queue or %NULL, when no data is
///   received before the timeout.
/// </return>

	public static IntPtr TimeoutPop(this MentorLake.GLib.GAsyncQueueHandle queue, ulong timeout)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		return GAsyncQueueExterns.g_async_queue_timeout_pop(queue, timeout);
	}

/// <summary>
/// <para>
/// Pops data from the @queue. If the queue is empty, blocks for
/// @timeout microseconds, or until data becomes available.
/// </para>
/// <para>
/// If no data is received before the timeout, %NULL is returned.
/// </para>
/// <para>
/// This function must be called while holding the @queue's lock.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>
/// <param name="timeout">
/// the number of microseconds to wait
/// </param>
/// <return>
/// data from the queue or %NULL, when no data is
///   received before the timeout.
/// </return>

	public static IntPtr TimeoutPopUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue, ulong timeout)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		return GAsyncQueueExterns.g_async_queue_timeout_pop_unlocked(queue, timeout);
	}

/// <summary>
/// <para>
/// Tries to pop data from the @queue. If no data is available,
/// %NULL is returned.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>
/// <return>
/// data from the queue or %NULL, when no data is
///   available immediately.
/// </return>

	public static IntPtr TryPop(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		return GAsyncQueueExterns.g_async_queue_try_pop(queue);
	}

/// <summary>
/// <para>
/// Tries to pop data from the @queue. If no data is available,
/// %NULL is returned.
/// </para>
/// <para>
/// This function must be called while holding the @queue's lock.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>
/// <return>
/// data from the queue or %NULL, when no data is
///   available immediately.
/// </return>

	public static IntPtr TryPopUnlocked(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		return GAsyncQueueExterns.g_async_queue_try_pop_unlocked(queue);
	}

/// <summary>
/// <para>
/// Releases the queue's lock.
/// </para>
/// <para>
/// Calling this function when you have not acquired
/// the with g_async_queue_lock() leads to undefined
/// behaviour.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>

	public static void Unlock(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		GAsyncQueueExterns.g_async_queue_unlock(queue);
	}

/// <summary>
/// <para>
/// Decreases the reference count of the asynchronous @queue by 1.
/// </para>
/// <para>
/// If the reference count went to 0, the @queue will be destroyed
/// and the memory allocated will be freed. So you are not allowed
/// to use the @queue afterwards, as it might have disappeared.
/// You do not need to hold the lock to call this function.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue.
/// </param>

	public static void Unref(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
		GAsyncQueueExterns.g_async_queue_unref(queue);
	}

/// <summary>
/// <para>
/// Decreases the reference count of the asynchronous @queue by 1
/// and releases the lock. This function must be called while holding
/// the @queue's lock. If the reference count went to 0, the @queue
/// will be destroyed and the memory allocated will be freed.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GAsyncQueue
/// </param>

	public static void UnrefAndUnlock(this MentorLake.GLib.GAsyncQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GAsyncQueue)");
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))]
	internal static extern MentorLake.GLib.GAsyncQueueHandle g_async_queue_new();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))]
	internal static extern MentorLake.GLib.GAsyncQueueHandle g_async_queue_new_full(MentorLake.GLib.GDestroyNotify item_free_func);

}

/// <summary>
/// <para>
/// An opaque data structure which represents an asynchronous queue.
/// </para>
/// <para>
/// It should only be accessed through the `g_async_queue_*` functions.
/// </para>
/// </summary>

public struct GAsyncQueue
{
/// <summary>
/// <para>
/// Creates a new asynchronous queue.
/// </para>
/// </summary>

/// <return>
/// a new #GAsyncQueue. Free with g_async_queue_unref()
/// </return>

	public static MentorLake.GLib.GAsyncQueueHandle New()
	{
		return GAsyncQueueExterns.g_async_queue_new();
	}

/// <summary>
/// <para>
/// Creates a new asynchronous queue and sets up a destroy notify
/// function that is used to free any remaining queue items when
/// the queue is destroyed after the final unref.
/// </para>
/// </summary>

/// <param name="item_free_func">
/// function to free queue elements
/// </param>
/// <return>
/// a new #GAsyncQueue. Free with g_async_queue_unref()
/// </return>

	public static MentorLake.GLib.GAsyncQueueHandle NewFull(MentorLake.GLib.GDestroyNotify item_free_func)
	{
		return GAsyncQueueExterns.g_async_queue_new_full(item_free_func);
	}

}
