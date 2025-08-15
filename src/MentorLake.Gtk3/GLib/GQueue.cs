namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Contains the public fields of a
/// [Queue][glib-Double-ended-Queues].
/// </para>
/// </summary>

public class GQueueHandle : BaseSafeHandle
{
}


public static class GQueueExtensions
{
/// <summary>
/// <para>
/// Removes all the elements in @queue. If queue elements contain
/// dynamically-allocated memory, they should be freed first.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>

	public static void Clear(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_clear(queue);
	}

/// <summary>
/// <para>
/// Convenience method, which frees all the memory used by a #GQueue,
/// and calls the provided @free_func on each item in the #GQueue.
/// </para>
/// </summary>

/// <param name="queue">
/// a pointer to a #GQueue
/// </param>
/// <param name="free_func">
/// the function to be called to free memory allocated
/// </param>

	public static void ClearFull(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GDestroyNotify free_func)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_clear_full(queue, free_func);
	}

/// <summary>
/// <para>
/// Copies a @queue. Note that is a shallow copy. If the elements in the
/// queue consist of pointers to data, the pointers are copied, but the
/// actual data is not.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <return>
/// a copy of @queue
/// </return>

	public static MentorLake.GLib.GQueueHandle Copy(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_copy(queue);
	}

/// <summary>
/// <para>
/// Removes @link_ from @queue and frees it.
/// </para>
/// <para>
/// @link_ must be part of @queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="link_">
/// a #GList link that must be part of @queue
/// </param>

	public static void DeleteLink(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GListHandle link_)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_delete_link(queue, link_);
	}

/// <summary>
/// <para>
/// Finds the first link in @queue which contains @data.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="data">
/// data to find
/// </param>
/// <return>
/// the first link in @queue which contains @data
/// </return>

	public static MentorLake.GLib.GListHandle Find(this MentorLake.GLib.GQueueHandle queue, IntPtr data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_find(queue, data);
	}

/// <summary>
/// <para>
/// Finds an element in a #GQueue, using a supplied function to find the
/// desired element. It iterates over the queue, calling the given function
/// which should return 0 when the desired element is found. The function
/// takes two gconstpointer arguments, the #GQueue element&apos;s data as the
/// first argument and the given user data as the second argument.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="data">
/// user data passed to @func
/// </param>
/// <param name="func">
/// a #GCompareFunc to call for each element. It should return 0
///     when the desired element is found
/// </param>
/// <return>
/// the found link, or %NULL if it wasn&apos;t found
/// </return>

	public static MentorLake.GLib.GListHandle FindCustom(this MentorLake.GLib.GQueueHandle queue, IntPtr data, MentorLake.GLib.GCompareFunc func)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_find_custom(queue, data, func);
	}

/// <summary>
/// <para>
/// Calls @func for each element in the queue passing @user_data to the
/// function.
/// </para>
/// <para>
/// It is safe for @func to remove the element from @queue, but it must
/// not modify any part of the queue after that element.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="func">
/// the function to call for each element&apos;s data
/// </param>
/// <param name="user_data">
/// user data to pass to @func
/// </param>

	public static void Foreach(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GFunc func, IntPtr user_data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_foreach(queue, func, user_data);
	}

/// <summary>
/// <para>
/// Frees the memory allocated for the #GQueue. Only call this function
/// if @queue was created with g_queue_new(). If queue elements contain
/// dynamically-allocated memory, they should be freed first.
/// </para>
/// <para>
/// If queue elements contain dynamically-allocated memory, you should
/// either use g_queue_free_full() or free them manually first.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>

	public static void Free(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_free(queue);
	}

/// <summary>
/// <para>
/// Convenience method, which frees all the memory used by a #GQueue,
/// and calls the specified destroy function on every element&apos;s data.
/// </para>
/// <para>
/// @free_func should not modify the queue (eg, by removing the freed
/// element from it).
/// </para>
/// </summary>

/// <param name="queue">
/// a pointer to a #GQueue
/// </param>
/// <param name="free_func">
/// the function to be called to free each element&apos;s data
/// </param>

	public static void FreeFull(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GDestroyNotify free_func)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_free_full(queue, free_func);
	}

/// <summary>
/// <para>
/// Returns the number of items in @queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <return>
/// the number of items in @queue
/// </return>

	public static uint GetLength(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_get_length(queue);
	}

/// <summary>
/// <para>
/// Returns the position of the first element in @queue which contains @data.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="data">
/// the data to find
/// </param>
/// <return>
/// the position of the first element in @queue which
///     contains @data, or -1 if no element in @queue contains @data
/// </return>

	public static int Index(this MentorLake.GLib.GQueueHandle queue, IntPtr data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_index(queue, data);
	}

/// <summary>
/// <para>
/// A statically-allocated #GQueue must be initialized with this function
/// before it can be used. Alternatively you can initialize it with
/// %G_QUEUE_INIT. It is not necessary to initialize queues created with
/// g_queue_new().
/// </para>
/// </summary>

/// <param name="queue">
/// an uninitialized #GQueue
/// </param>

	public static void Init(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_init(queue);
	}

/// <summary>
/// <para>
/// Inserts @data into @queue after @sibling.
/// </para>
/// <para>
/// @sibling must be part of @queue. Since GLib 2.44 a %NULL sibling pushes the
/// data at the head of the queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="sibling">
/// a #GList link that must be part of @queue, or %NULL to
///   push at the head of the queue.
/// </param>
/// <param name="data">
/// the data to insert
/// </param>

	public static void InsertAfter(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GListHandle sibling, IntPtr data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_insert_after(queue, sibling, data);
	}

/// <summary>
/// <para>
/// Inserts @link_ into @queue after @sibling.
/// </para>
/// <para>
/// @sibling must be part of @queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="sibling">
/// a #GList link that must be part of @queue, or %NULL to
///   push at the head of the queue.
/// </param>
/// <param name="link_">
/// a #GList link to insert which must not be part of any other list.
/// </param>

	public static void InsertAfterLink(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GListHandle sibling, MentorLake.GLib.GListHandle link_)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_insert_after_link(queue, sibling, link_);
	}

/// <summary>
/// <para>
/// Inserts @data into @queue before @sibling.
/// </para>
/// <para>
/// @sibling must be part of @queue. Since GLib 2.44 a %NULL sibling pushes the
/// data at the tail of the queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="sibling">
/// a #GList link that must be part of @queue, or %NULL to
///   push at the tail of the queue.
/// </param>
/// <param name="data">
/// the data to insert
/// </param>

	public static void InsertBefore(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GListHandle sibling, IntPtr data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_insert_before(queue, sibling, data);
	}

/// <summary>
/// <para>
/// Inserts @link_ into @queue before @sibling.
/// </para>
/// <para>
/// @sibling must be part of @queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="sibling">
/// a #GList link that must be part of @queue, or %NULL to
///   push at the tail of the queue.
/// </param>
/// <param name="link_">
/// a #GList link to insert which must not be part of any other list.
/// </param>

	public static void InsertBeforeLink(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GListHandle sibling, MentorLake.GLib.GListHandle link_)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_insert_before_link(queue, sibling, link_);
	}

/// <summary>
/// <para>
/// Inserts @data into @queue using @func to determine the new position.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="data">
/// the data to insert
/// </param>
/// <param name="func">
/// the #GCompareDataFunc used to compare elements in the queue. It is
///     called with two elements of the @queue and @user_data. It should
///     return 0 if the elements are equal, a negative value if the first
///     element comes before the second, and a positive value if the second
///     element comes before the first.
/// </param>
/// <param name="user_data">
/// user data passed to @func
/// </param>

	public static void InsertSorted(this MentorLake.GLib.GQueueHandle queue, IntPtr data, MentorLake.GLib.GCompareDataFunc func, IntPtr user_data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_insert_sorted(queue, data, func, user_data);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the queue is empty.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue.
/// </param>
/// <return>
/// %TRUE if the queue is empty
/// </return>

	public static bool IsEmpty(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_is_empty(queue);
	}

/// <summary>
/// <para>
/// Returns the position of @link_ in @queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="link_">
/// a #GList link
/// </param>
/// <return>
/// the position of @link_, or -1 if the link is
///     not part of @queue
/// </return>

	public static int LinkIndex(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GListHandle link_)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_link_index(queue, link_);
	}

/// <summary>
/// <para>
/// Returns the first element of the queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <return>
/// the data of the first element in the queue, or %NULL
///     if the queue is empty
/// </return>

	public static IntPtr PeekHead(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_peek_head(queue);
	}

/// <summary>
/// <para>
/// Returns the first link in @queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <return>
/// the first link in @queue, or %NULL if @queue is empty
/// </return>

	public static MentorLake.GLib.GListHandle PeekHeadLink(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_peek_head_link(queue);
	}

/// <summary>
/// <para>
/// Returns the @n&apos;th element of @queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="n">
/// the position of the element
/// </param>
/// <return>
/// the data for the @n&apos;th element of @queue,
///     or %NULL if @n is off the end of @queue
/// </return>

	public static IntPtr PeekNth(this MentorLake.GLib.GQueueHandle queue, uint n)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_peek_nth(queue, n);
	}

/// <summary>
/// <para>
/// Returns the link at the given position
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="n">
/// the position of the link
/// </param>
/// <return>
/// the link at the @n&apos;th position, or %NULL
///     if @n is off the end of the list
/// </return>

	public static MentorLake.GLib.GListHandle PeekNthLink(this MentorLake.GLib.GQueueHandle queue, uint n)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_peek_nth_link(queue, n);
	}

/// <summary>
/// <para>
/// Returns the last element of the queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <return>
/// the data of the last element in the queue, or %NULL
///     if the queue is empty
/// </return>

	public static IntPtr PeekTail(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_peek_tail(queue);
	}

/// <summary>
/// <para>
/// Returns the last link in @queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <return>
/// the last link in @queue, or %NULL if @queue is empty
/// </return>

	public static MentorLake.GLib.GListHandle PeekTailLink(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_peek_tail_link(queue);
	}

/// <summary>
/// <para>
/// Removes the first element of the queue and returns its data.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <return>
/// the data of the first element in the queue, or %NULL
///     if the queue is empty
/// </return>

	public static IntPtr PopHead(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_pop_head(queue);
	}

/// <summary>
/// <para>
/// Removes and returns the first element of the queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <return>
/// the #GList element at the head of the queue, or %NULL
///     if the queue is empty
/// </return>

	public static MentorLake.GLib.GListHandle PopHeadLink(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_pop_head_link(queue);
	}

/// <summary>
/// <para>
/// Removes the @n&apos;th element of @queue and returns its data.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="n">
/// the position of the element
/// </param>
/// <return>
/// the element&apos;s data, or %NULL if @n is off the end of @queue
/// </return>

	public static IntPtr PopNth(this MentorLake.GLib.GQueueHandle queue, uint n)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_pop_nth(queue, n);
	}

/// <summary>
/// <para>
/// Removes and returns the link at the given position.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="n">
/// the link&apos;s position
/// </param>
/// <return>
/// the @n&apos;th link, or %NULL if @n is off the end of @queue
/// </return>

	public static MentorLake.GLib.GListHandle PopNthLink(this MentorLake.GLib.GQueueHandle queue, uint n)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_pop_nth_link(queue, n);
	}

/// <summary>
/// <para>
/// Removes the last element of the queue and returns its data.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <return>
/// the data of the last element in the queue, or %NULL
///     if the queue is empty
/// </return>

	public static IntPtr PopTail(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_pop_tail(queue);
	}

/// <summary>
/// <para>
/// Removes and returns the last element of the queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <return>
/// the #GList element at the tail of the queue, or %NULL
///     if the queue is empty
/// </return>

	public static MentorLake.GLib.GListHandle PopTailLink(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_pop_tail_link(queue);
	}

/// <summary>
/// <para>
/// Adds a new element at the head of the queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue.
/// </param>
/// <param name="data">
/// the data for the new element.
/// </param>

	public static void PushHead(this MentorLake.GLib.GQueueHandle queue, IntPtr data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_push_head(queue, data);
	}

/// <summary>
/// <para>
/// Adds a new element at the head of the queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="link_">
/// a single #GList element, not a list with more than one element
/// </param>

	public static void PushHeadLink(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GListHandle link_)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_push_head_link(queue, link_);
	}

/// <summary>
/// <para>
/// Inserts a new element into @queue at the given position.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="data">
/// the data for the new element
/// </param>
/// <param name="n">
/// the position to insert the new element. If @n is negative or
///     larger than the number of elements in the @queue, the element is
///     added to the end of the queue.
/// </param>

	public static void PushNth(this MentorLake.GLib.GQueueHandle queue, IntPtr data, int n)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_push_nth(queue, data, n);
	}

/// <summary>
/// <para>
/// Inserts @link into @queue at the given position.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="n">
/// the position to insert the link. If this is negative or larger than
///     the number of elements in @queue, the link is added to the end of
///     @queue.
/// </param>
/// <param name="link_">
/// the link to add to @queue
/// </param>

	public static void PushNthLink(this MentorLake.GLib.GQueueHandle queue, int n, MentorLake.GLib.GListHandle link_)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_push_nth_link(queue, n, link_);
	}

/// <summary>
/// <para>
/// Adds a new element at the tail of the queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="data">
/// the data for the new element
/// </param>

	public static void PushTail(this MentorLake.GLib.GQueueHandle queue, IntPtr data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_push_tail(queue, data);
	}

/// <summary>
/// <para>
/// Adds a new element at the tail of the queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="link_">
/// a single #GList element, not a list with more than one element
/// </param>

	public static void PushTailLink(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GListHandle link_)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_push_tail_link(queue, link_);
	}

/// <summary>
/// <para>
/// Removes the first element in @queue that contains @data.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="data">
/// the data to remove
/// </param>
/// <return>
/// %TRUE if @data was found and removed from @queue
/// </return>

	public static bool Remove(this MentorLake.GLib.GQueueHandle queue, IntPtr data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_remove(queue, data);
	}

/// <summary>
/// <para>
/// Remove all elements whose data equals @data from @queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="data">
/// the data to remove
/// </param>
/// <return>
/// the number of elements removed from @queue
/// </return>

	public static uint RemoveAll(this MentorLake.GLib.GQueueHandle queue, IntPtr data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		return GQueueExterns.g_queue_remove_all(queue, data);
	}

/// <summary>
/// <para>
/// Reverses the order of the items in @queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>

	public static void Reverse(this MentorLake.GLib.GQueueHandle queue)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_reverse(queue);
	}

/// <summary>
/// <para>
/// Sorts @queue using @compare_func.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="compare_func">
/// the #GCompareDataFunc used to sort @queue. This function
///     is passed two elements of the queue and should return 0 if they are
///     equal, a negative value if the first comes before the second, and
///     a positive value if the second comes before the first.
/// </param>
/// <param name="user_data">
/// user data passed to @compare_func
/// </param>

	public static void Sort(this MentorLake.GLib.GQueueHandle queue, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		if (queue.IsInvalid) throw new Exception("Invalid handle (GQueue)");
		GQueueExterns.g_queue_sort(queue, compare_func, user_data);
	}

/// <summary>
/// <para>
/// Unlinks @link_ so that it will no longer be part of @queue.
/// The link is not freed.
/// </para>
/// <para>
/// @link_ must be part of @queue.
/// </para>
/// </summary>

/// <param name="queue">
/// a #GQueue
/// </param>
/// <param name="link_">
/// a #GList link that must be part of @queue
/// </param>

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

/// <summary>
/// <para>
/// Contains the public fields of a
/// [Queue][glib-Double-ended-Queues].
/// </para>
/// </summary>

public struct GQueue
{
	/// <summary>
/// <para>
/// a pointer to the first element of the queue
/// </para>
/// </summary>

public IntPtr head;
	/// <summary>
/// <para>
/// a pointer to the last element of the queue
/// </para>
/// </summary>

public IntPtr tail;
	/// <summary>
/// <para>
/// the number of elements in the queue
/// </para>
/// </summary>

public uint length;
/// <summary>
/// <para>
/// Creates a new #GQueue.
/// </para>
/// </summary>

/// <return>
/// a newly allocated #GQueue
/// </return>

	public static MentorLake.GLib.GQueueHandle New()
	{
		return GQueueExterns.g_queue_new();
	}

}
