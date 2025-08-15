namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GCancellable` allows operations to be cancelled.
/// </para>
/// <para>
/// `GCancellable` is a thread-safe operation cancellation stack used
/// throughout GIO to allow for cancellation of synchronous and
/// asynchronous operations.
/// </para>
/// </summary>

public class GCancellableHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GCancellable object.
/// </para>
/// <para>
/// Applications that want to start one or more operations
/// that should be cancellable should create a #GCancellable
/// and pass it to the operations.
/// </para>
/// <para>
/// One #GCancellable can be used in multiple consecutive
/// operations or in multiple concurrent operations.
/// </para>
/// </summary>

/// <return>
/// a #GCancellable.
/// </return>

	public static MentorLake.Gio.GCancellableHandle New()
	{
		return GCancellableHandleExterns.g_cancellable_new();
	}

/// <summary>
/// <para>
/// Gets the top cancellable from the stack.
/// </para>
/// </summary>

/// <return>
/// a #GCancellable from the top
/// of the stack, or %NULL if the stack is empty.
/// </return>

	public static MentorLake.Gio.GCancellableHandle GetCurrent()
	{
		return GCancellableHandleExterns.g_cancellable_get_current();
	}

}
public static class GCancellableHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when the operation has been cancelled.
/// </para>
/// <para>
/// Can be used by implementations of cancellable operations. If the
/// operation is cancelled from another thread, the signal will be
/// emitted in the thread that cancelled the operation, not the
/// thread that is running the operation.
/// </para>
/// <para>
/// Note that disconnecting from this signal (or any signal) in a
/// multi-threaded program is prone to race conditions. For instance
/// it is possible that a signal handler may be invoked even after
/// a call to g_signal_handler_disconnect() for that handler has
/// already returned.
/// </para>
/// <para>
/// There is also a problem when cancellation happens right before
/// connecting to the signal. If this happens the signal will
/// unexpectedly not be emitted, and checking before connecting to
/// the signal leaves a race condition where this is still happening.
/// </para>
/// <para>
/// In order to make it safe and easy to connect handlers there
/// are two helper functions: g_cancellable_connect() and
/// g_cancellable_disconnect() which protect against problems
/// like this.
/// </para>
/// <para>
/// An example of how to us this:
/// <code>
///     // Make sure we don&apos;t do unnecessary work if already cancelled
///     // Make sure we don&apos;t do unnecessary work if already cancelled
///     if (g_cancellable_set_error_if_cancelled (cancellable, error))
///       return;
/// 
///     // Set up all the data needed to be able to handle cancellation
///     // of the operation
///     my_data = my_data_new (...);
/// 
///     id = 0;
///     if (cancellable)
///       id = g_cancellable_connect (cancellable,
///     			      G_CALLBACK (cancelled_handler)
///     			      data, NULL);
/// 
///     // cancellable operation here...
/// 
///     g_cancellable_disconnect (cancellable, id);
/// 
///     // cancelled_handler is never called after this, it is now safe
///     // to free the data
///     my_data_free (my_data);
/// </code>
/// Note that the cancelled signal is emitted in the thread that
/// the user cancelled from, which may be the main thread. So, the
/// cancellable signal should not do something that can block.
/// </para>
/// </summary>

	public static IObservable<GCancellableHandleSignalStructs.CancelledSignal> Signal_Cancelled(this GCancellableHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GCancellableHandleSignalStructs.CancelledSignal> obs) =>
		{
			GCancellableHandleSignalDelegates.cancelled handler = ( MentorLake.Gio.GCancellableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GCancellableHandleSignalStructs.CancelledSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cancelled", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GCancellableHandleSignalStructs
{

public class CancelledSignal
{

	public MentorLake.Gio.GCancellableHandle Self;

	public IntPtr UserData;
}
}

public static class GCancellableHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when the operation has been cancelled.
/// </para>
/// <para>
/// Can be used by implementations of cancellable operations. If the
/// operation is cancelled from another thread, the signal will be
/// emitted in the thread that cancelled the operation, not the
/// thread that is running the operation.
/// </para>
/// <para>
/// Note that disconnecting from this signal (or any signal) in a
/// multi-threaded program is prone to race conditions. For instance
/// it is possible that a signal handler may be invoked even after
/// a call to g_signal_handler_disconnect() for that handler has
/// already returned.
/// </para>
/// <para>
/// There is also a problem when cancellation happens right before
/// connecting to the signal. If this happens the signal will
/// unexpectedly not be emitted, and checking before connecting to
/// the signal leaves a race condition where this is still happening.
/// </para>
/// <para>
/// In order to make it safe and easy to connect handlers there
/// are two helper functions: g_cancellable_connect() and
/// g_cancellable_disconnect() which protect against problems
/// like this.
/// </para>
/// <para>
/// An example of how to us this:
/// <code>
///     // Make sure we don&apos;t do unnecessary work if already cancelled
///     // Make sure we don&apos;t do unnecessary work if already cancelled
///     if (g_cancellable_set_error_if_cancelled (cancellable, error))
///       return;
/// 
///     // Set up all the data needed to be able to handle cancellation
///     // of the operation
///     my_data = my_data_new (...);
/// 
///     id = 0;
///     if (cancellable)
///       id = g_cancellable_connect (cancellable,
///     			      G_CALLBACK (cancelled_handler)
///     			      data, NULL);
/// 
///     // cancellable operation here...
/// 
///     g_cancellable_disconnect (cancellable, id);
/// 
///     // cancelled_handler is never called after this, it is now safe
///     // to free the data
///     my_data_free (my_data);
/// </code>
/// Note that the cancelled signal is emitted in the thread that
/// the user cancelled from, which may be the main thread. So, the
/// cancellable signal should not do something that can block.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cancelled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle self, IntPtr user_data);

}


public static class GCancellableHandleExtensions
{
/// <summary>
/// <para>
/// Will set @cancellable to cancelled, and will emit the
/// #GCancellable::cancelled signal. (However, see the warning about
/// race conditions in the documentation for that signal if you are
/// planning to connect to it.)
/// </para>
/// <para>
/// This function is thread-safe. In other words, you can safely call
/// it from a thread other than the one running the operation that was
/// passed the @cancellable.
/// </para>
/// <para>
/// If @cancellable is %NULL, this function returns immediately for convenience.
/// </para>
/// <para>
/// The convention within GIO is that cancelling an asynchronous
/// operation causes it to complete asynchronously. That is, if you
/// cancel the operation from the same thread in which it is running,
/// then the operation&apos;s #GAsyncReadyCallback will not be invoked until
/// the application returns to the main loop.
/// </para>
/// </summary>

/// <param name="cancellable">
/// a #GCancellable object.
/// </param>

	public static T Cancel<T>(this T cancellable) where T : GCancellableHandle
	{
		if (cancellable.IsInvalid) throw new Exception("Invalid handle (GCancellableHandle)");
		GCancellableHandleExterns.g_cancellable_cancel(cancellable);
		return cancellable;
	}

/// <summary>
/// <para>
/// Convenience function to connect to the #GCancellable::cancelled
/// signal. Also handles the race condition that may happen
/// if the cancellable is cancelled right before connecting.
/// </para>
/// <para>
/// @callback is called exactly once each time @cancellable is cancelled,
/// either directly at the time of the connect if @cancellable is already
/// cancelled, or when @cancellable is cancelled in some thread.
/// In case the cancellable is reset via [method@Gio.Cancellable.reset]
/// then the callback can be called again if the @cancellable is cancelled.
/// </para>
/// <para>
/// @data_destroy_func will be called when the handler is
/// disconnected, or immediately if the cancellable is already
/// cancelled.
/// </para>
/// <para>
/// See #GCancellable::cancelled for details on how to use this.
/// </para>
/// <para>
/// Since GLib 2.40, the lock protecting @cancellable is not held when
/// @callback is invoked.  This lifts a restriction in place for
/// earlier GLib versions which now makes it easier to write cleanup
/// code that unconditionally invokes e.g. g_cancellable_cancel().
/// </para>
/// </summary>

/// <param name="cancellable">
/// A #GCancellable.
/// </param>
/// <param name="callback">
/// The #GCallback to connect.
/// </param>
/// <param name="data">
/// Data to pass to @callback.
/// </param>
/// <param name="data_destroy_func">
/// Free function for @data or %NULL.
/// </param>
/// <return>
/// The id of the signal handler or 0 if @cancellable has already
///          been cancelled.
/// </return>

	public static ulong Connect(this MentorLake.Gio.GCancellableHandle cancellable, MentorLake.GObject.GCallback callback, IntPtr data, MentorLake.GLib.GDestroyNotify data_destroy_func)
	{
		if (cancellable.IsInvalid) throw new Exception("Invalid handle (GCancellableHandle)");
		return GCancellableHandleExterns.g_cancellable_connect(cancellable, callback, data, data_destroy_func);
	}

/// <summary>
/// <para>
/// Disconnects a handler from a cancellable instance similar to
/// g_signal_handler_disconnect().  Additionally, in the event that a
/// signal handler is currently running, this call will block until the
/// handler has finished.  Calling this function from a
/// #GCancellable::cancelled signal handler will therefore result in a
/// deadlock.
/// </para>
/// <para>
/// This avoids a race condition where a thread cancels at the
/// same time as the cancellable operation is finished and the
/// signal handler is removed. See #GCancellable::cancelled for
/// details on how to use this.
/// </para>
/// <para>
/// If @cancellable is %NULL or @handler_id is `0` this function does
/// nothing.
/// </para>
/// </summary>

/// <param name="cancellable">
/// A #GCancellable or %NULL.
/// </param>
/// <param name="handler_id">
/// Handler id of the handler to be disconnected, or `0`.
/// </param>

	public static T Disconnect<T>(this T cancellable, ulong handler_id) where T : GCancellableHandle
	{
		if (cancellable.IsInvalid) throw new Exception("Invalid handle (GCancellableHandle)");
		GCancellableHandleExterns.g_cancellable_disconnect(cancellable, handler_id);
		return cancellable;
	}

/// <summary>
/// <para>
/// Gets the file descriptor for a cancellable job. This can be used to
/// implement cancellable operations on Unix systems. The returned fd will
/// turn readable when @cancellable is cancelled.
/// </para>
/// <para>
/// You are not supposed to read from the fd yourself, just check for
/// readable status. Reading to unset the readable status is done
/// with g_cancellable_reset().
/// </para>
/// <para>
/// After a successful return from this function, you should use
/// g_cancellable_release_fd() to free up resources allocated for
/// the returned file descriptor.
/// </para>
/// <para>
/// See also g_cancellable_make_pollfd().
/// </para>
/// </summary>

/// <param name="cancellable">
/// a #GCancellable.
/// </param>
/// <return>
/// A valid file descriptor. `-1` if the file descriptor
/// is not supported, or on errors.
/// </return>

	public static int GetFd(this MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (cancellable.IsInvalid) throw new Exception("Invalid handle (GCancellableHandle)");
		return GCancellableHandleExterns.g_cancellable_get_fd(cancellable);
	}

/// <summary>
/// <para>
/// Checks if a cancellable job has been cancelled.
/// </para>
/// </summary>

/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <return>
/// %TRUE if @cancellable is cancelled,
/// FALSE if called with %NULL or if item is not cancelled.
/// </return>

	public static bool IsCancelled(this MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (cancellable.IsInvalid) throw new Exception("Invalid handle (GCancellableHandle)");
		return GCancellableHandleExterns.g_cancellable_is_cancelled(cancellable);
	}

/// <summary>
/// <para>
/// Creates a #GPollFD corresponding to @cancellable; this can be passed
/// to g_poll() and used to poll for cancellation. This is useful both
/// for unix systems without a native poll and for portability to
/// windows.
/// </para>
/// <para>
/// When this function returns %TRUE, you should use
/// g_cancellable_release_fd() to free up resources allocated for the
/// @pollfd. After a %FALSE return, do not call g_cancellable_release_fd().
/// </para>
/// <para>
/// If this function returns %FALSE, either no @cancellable was given or
/// resource limits prevent this function from allocating the necessary
/// structures for polling. (On Linux, you will likely have reached
/// the maximum number of file descriptors.) The suggested way to handle
/// these cases is to ignore the @cancellable.
/// </para>
/// <para>
/// You are not supposed to read from the fd yourself, just check for
/// readable status. Reading to unset the readable status is done
/// with g_cancellable_reset().
/// </para>
/// </summary>

/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <param name="pollfd">
/// a pointer to a #GPollFD
/// </param>
/// <return>
/// %TRUE if @pollfd was successfully initialized, %FALSE on
///          failure to prepare the cancellable.
/// </return>

	public static bool MakePollfd(this MentorLake.Gio.GCancellableHandle cancellable, MentorLake.GLib.GPollFDHandle pollfd)
	{
		if (cancellable.IsInvalid) throw new Exception("Invalid handle (GCancellableHandle)");
		return GCancellableHandleExterns.g_cancellable_make_pollfd(cancellable, pollfd);
	}

/// <summary>
/// <para>
/// Pops @cancellable off the cancellable stack (verifying that @cancellable
/// is on the top of the stack).
/// </para>
/// </summary>

/// <param name="cancellable">
/// a #GCancellable object
/// </param>

	public static T PopCurrent<T>(this T cancellable) where T : GCancellableHandle
	{
		if (cancellable.IsInvalid) throw new Exception("Invalid handle (GCancellableHandle)");
		GCancellableHandleExterns.g_cancellable_pop_current(cancellable);
		return cancellable;
	}

/// <summary>
/// <para>
/// Pushes @cancellable onto the cancellable stack. The current
/// cancellable can then be received using g_cancellable_get_current().
/// </para>
/// <para>
/// This is useful when implementing cancellable operations in
/// code that does not allow you to pass down the cancellable object.
/// </para>
/// <para>
/// This is typically called automatically by e.g. #GFile operations,
/// so you rarely have to call this yourself.
/// </para>
/// </summary>

/// <param name="cancellable">
/// a #GCancellable object
/// </param>

	public static T PushCurrent<T>(this T cancellable) where T : GCancellableHandle
	{
		if (cancellable.IsInvalid) throw new Exception("Invalid handle (GCancellableHandle)");
		GCancellableHandleExterns.g_cancellable_push_current(cancellable);
		return cancellable;
	}

/// <summary>
/// <para>
/// Releases a resources previously allocated by g_cancellable_get_fd()
/// or g_cancellable_make_pollfd().
/// </para>
/// <para>
/// For compatibility reasons with older releases, calling this function
/// is not strictly required, the resources will be automatically freed
/// when the @cancellable is finalized. However, the @cancellable will
/// block scarce file descriptors until it is finalized if this function
/// is not called. This can cause the application to run out of file
/// descriptors when many #GCancellables are used at the same time.
/// </para>
/// </summary>

/// <param name="cancellable">
/// a #GCancellable
/// </param>

	public static T ReleaseFd<T>(this T cancellable) where T : GCancellableHandle
	{
		if (cancellable.IsInvalid) throw new Exception("Invalid handle (GCancellableHandle)");
		GCancellableHandleExterns.g_cancellable_release_fd(cancellable);
		return cancellable;
	}

/// <summary>
/// <para>
/// Resets @cancellable to its uncancelled state.
/// </para>
/// <para>
/// If cancellable is currently in use by any cancellable operation
/// then the behavior of this function is undefined.
/// </para>
/// <para>
/// Note that it is generally not a good idea to reuse an existing
/// cancellable for more operations after it has been cancelled once,
/// as this function might tempt you to do. The recommended practice
/// is to drop the reference to a cancellable after cancelling it,
/// and let it die with the outstanding async operations. You should
/// create a fresh cancellable for further async operations.
/// </para>
/// </summary>

/// <param name="cancellable">
/// a #GCancellable object.
/// </param>

	public static T Reset<T>(this T cancellable) where T : GCancellableHandle
	{
		if (cancellable.IsInvalid) throw new Exception("Invalid handle (GCancellableHandle)");
		GCancellableHandleExterns.g_cancellable_reset(cancellable);
		return cancellable;
	}

/// <summary>
/// <para>
/// If the @cancellable is cancelled, sets the error to notify
/// that the operation was cancelled.
/// </para>
/// </summary>

/// <param name="cancellable">
/// a #GCancellable or %NULL
/// </param>
/// <return>
/// %TRUE if @cancellable was cancelled, %FALSE if it was not
/// </return>

	public static bool SetErrorIfCancelled(this MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (cancellable.IsInvalid) throw new Exception("Invalid handle (GCancellableHandle)");
		var externCallResult = GCancellableHandleExterns.g_cancellable_set_error_if_cancelled(cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Creates a source that triggers if @cancellable is cancelled and
/// calls its callback of type #GCancellableSourceFunc. This is
/// primarily useful for attaching to another (non-cancellable) source
/// with g_source_add_child_source() to add cancellability to it.
/// </para>
/// <para>
/// For convenience, you can call this with a %NULL #GCancellable,
/// in which case the source will never trigger.
/// </para>
/// <para>
/// The new #GSource will hold a reference to the #GCancellable.
/// </para>
/// </summary>

/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// the new #GSource.
/// </return>

	public static MentorLake.GLib.GSourceHandle SourceNew(this MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (cancellable.IsInvalid) throw new Exception("Invalid handle (GCancellableHandle)");
		return GCancellableHandleExterns.g_cancellable_source_new(cancellable);
	}

}

internal class GCancellableHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))]
	internal static extern MentorLake.Gio.GCancellableHandle g_cancellable_new();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_cancellable_cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern ulong g_cancellable_connect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.GObject.GCallback callback, IntPtr data, MentorLake.GLib.GDestroyNotify data_destroy_func);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_cancellable_disconnect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, ulong handler_id);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_cancellable_get_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_cancellable_is_cancelled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_cancellable_make_pollfd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPollFDHandle>))] MentorLake.GLib.GPollFDHandle pollfd);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_cancellable_pop_current([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_cancellable_push_current([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_cancellable_release_fd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_cancellable_reset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_cancellable_set_error_if_cancelled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_cancellable_source_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))]
	internal static extern MentorLake.Gio.GCancellableHandle g_cancellable_get_current();

}
