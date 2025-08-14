namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A `GClosure` represents a callback supplied by the programmer.
/// </para>
/// <para>
/// It will generally comprise a function of some kind and a marshaller
/// used to call it. It is the responsibility of the marshaller to
/// convert the arguments for the invocation from #GValues into
/// a suitable form, perform the callback on the converted arguments,
/// and transform the return value back into a #GValue.
/// </para>
/// <para>
/// In the case of C programs, a closure usually just holds a pointer
/// to a function and maybe a data argument, and the marshaller
/// converts between #GValue and native C types. The GObject
/// library provides the #GCClosure type for this purpose. Bindings for
/// other languages need marshallers which convert between #GValues
/// and suitable representations in the runtime of the language in
/// order to use functions written in that language as callbacks. Use
/// g_closure_set_marshal() to set the marshaller on such a custom
/// closure implementation.
/// </para>
/// <para>
/// Within GObject, closures play an important role in the
/// implementation of signals. When a signal is registered, the
/// @c_marshaller argument to g_signal_new() specifies the default C
/// marshaller for any closure which is connected to this
/// signal. GObject provides a number of C marshallers for this
/// purpose, see the g_cclosure_marshal_*() functions. Additional C
/// marshallers can be generated with the [glib-genmarshal][glib-genmarshal]
/// utility.  Closures can be explicitly connected to signals with
/// g_signal_connect_closure(), but it usually more convenient to let
/// GObject create a closure automatically by using one of the
/// g_signal_connect_*() functions which take a callback function/user
/// data pair.
/// </para>
/// <para>
/// Using closures has a number of important advantages over a simple
/// callback function/data pointer combination:
/// </para>
/// <para>
/// - Closures allow the callee to get the types of the callback parameters,
///   which means that language bindings don't have to write individual glue
///   for each callback type.
/// </para>
/// <para>
/// - The reference counting of #GClosure makes it easy to handle reentrancy
///   right; if a callback is removed while it is being invoked, the closure
///   and its parameters won't be freed until the invocation finishes.
/// </para>
/// <para>
/// - g_closure_invalidate() and invalidation notifiers allow callbacks to be
///   automatically removed when the objects they point to go away.
/// </para>
/// </summary>

public class GClosureHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// A variant of g_closure_new_simple() which stores @object in the
/// @data field of the closure and calls g_object_watch_closure() on
/// @object and the created closure. This function is mainly useful
/// when implementing new types of closures.
/// </para>
/// </summary>

/// <param name="sizeof_closure">
/// the size of the structure to allocate, must be at least
///  `sizeof (GClosure)`
/// </param>
/// <param name="@object">
/// a #GObject pointer to store in the @data field of the newly
///  allocated #GClosure
/// </param>
/// <return>
/// a newly allocated #GClosure
/// </return>

	public static MentorLake.GObject.GClosureHandle NewObject(uint sizeof_closure, MentorLake.GObject.GObjectHandle @object)
	{
		return GClosureExterns.g_closure_new_object(sizeof_closure, @object);
	}

/// <summary>
/// <para>
/// Allocates a struct of the given size and initializes the initial
/// part as a #GClosure.
/// </para>
/// <para>
/// This function is mainly useful when implementing new types of closures:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// typedef struct _MyClosure MyClosure;
/// struct _MyClosure
/// {
///   GClosure closure;
///   // extra data goes here
/// };
/// </para>
/// <para>
/// static void
/// my_closure_finalize (gpointer  notify_data,
///                      GClosure *closure)
/// {
///   MyClosure *my_closure = (MyClosure *)closure;
/// </para>
/// <para>
///   // free extra data here
/// }
/// </para>
/// <para>
/// MyClosure *my_closure_new (gpointer data)
/// {
///   GClosure *closure;
///   MyClosure *my_closure;
/// </para>
/// <para>
///   closure = g_closure_new_simple (sizeof (MyClosure), data);
///   my_closure = (MyClosure *) closure;
/// </para>
/// <para>
///   // initialize extra data here
/// </para>
/// <para>
///   g_closure_add_finalize_notifier (closure, notify_data,
///                                    my_closure_finalize);
///   return my_closure;
/// }
/// ]|
/// </para>
/// </summary>

/// <param name="sizeof_closure">
/// the size of the structure to allocate, must be at least
///                  `sizeof (GClosure)`
/// </param>
/// <param name="data">
/// data to store in the @data field of the newly allocated #GClosure
/// </param>
/// <return>
/// a floating reference to a new #GClosure
/// </return>

	public static MentorLake.GObject.GClosureHandle NewSimple(uint sizeof_closure, IntPtr data)
	{
		return GClosureExterns.g_closure_new_simple(sizeof_closure, data);
	}

}


public static class GClosureExtensions
{
/// <summary>
/// <para>
/// Registers a finalization notifier which will be called when the
/// reference count of @closure goes down to 0.
/// </para>
/// <para>
/// Multiple finalization notifiers on a single closure are invoked in
/// unspecified order. If a single call to g_closure_unref() results in
/// the closure being both invalidated and finalized, then the invalidate
/// notifiers will be run before the finalize notifiers.
/// </para>
/// </summary>

/// <param name="closure">
/// a #GClosure
/// </param>
/// <param name="notify_data">
/// data to pass to @notify_func
/// </param>
/// <param name="notify_func">
/// the callback function to register
/// </param>

	public static void AddFinalizeNotifier(this MentorLake.GObject.GClosureHandle closure, IntPtr notify_data, MentorLake.GObject.GClosureNotify notify_func)
	{
		if (closure.IsInvalid) throw new Exception("Invalid handle (GClosure)");
		GClosureExterns.g_closure_add_finalize_notifier(closure, notify_data, notify_func);
	}

/// <summary>
/// <para>
/// Registers an invalidation notifier which will be called when the
/// @closure is invalidated with g_closure_invalidate().
/// </para>
/// <para>
/// Invalidation notifiers are invoked before finalization notifiers,
/// in an unspecified order.
/// </para>
/// </summary>

/// <param name="closure">
/// a #GClosure
/// </param>
/// <param name="notify_data">
/// data to pass to @notify_func
/// </param>
/// <param name="notify_func">
/// the callback function to register
/// </param>

	public static void AddInvalidateNotifier(this MentorLake.GObject.GClosureHandle closure, IntPtr notify_data, MentorLake.GObject.GClosureNotify notify_func)
	{
		if (closure.IsInvalid) throw new Exception("Invalid handle (GClosure)");
		GClosureExterns.g_closure_add_invalidate_notifier(closure, notify_data, notify_func);
	}

/// <summary>
/// <para>
/// Adds a pair of notifiers which get invoked before and after the
/// closure callback, respectively.
/// </para>
/// <para>
/// This is typically used to protect the extra arguments for the
/// duration of the callback. See g_object_watch_closure() for an
/// example of marshal guards.
/// </para>
/// </summary>

/// <param name="closure">
/// a #GClosure
/// </param>
/// <param name="pre_marshal_data">
/// data to pass
///  to @pre_marshal_notify
/// </param>
/// <param name="pre_marshal_notify">
/// a function to call before the closure callback
/// </param>
/// <param name="post_marshal_data">
/// data to pass
///  to @post_marshal_notify
/// </param>
/// <param name="post_marshal_notify">
/// a function to call after the closure callback
/// </param>

	public static void AddMarshalGuards(this MentorLake.GObject.GClosureHandle closure, IntPtr pre_marshal_data, MentorLake.GObject.GClosureNotify pre_marshal_notify, IntPtr post_marshal_data, MentorLake.GObject.GClosureNotify post_marshal_notify)
	{
		if (closure.IsInvalid) throw new Exception("Invalid handle (GClosure)");
		GClosureExterns.g_closure_add_marshal_guards(closure, pre_marshal_data, pre_marshal_notify, post_marshal_data, post_marshal_notify);
	}

/// <summary>
/// <para>
/// Sets a flag on the closure to indicate that its calling
/// environment has become invalid, and thus causes any future
/// invocations of g_closure_invoke() on this @closure to be
/// ignored.
/// </para>
/// <para>
/// Also, invalidation notifiers installed on the closure will
/// be called at this point. Note that unless you are holding a
/// reference to the closure yourself, the invalidation notifiers may
/// unref the closure and cause it to be destroyed, so if you need to
/// access the closure after calling g_closure_invalidate(), make sure
/// that you've previously called g_closure_ref().
/// </para>
/// <para>
/// Note that g_closure_invalidate() will also be called when the
/// reference count of a closure drops to zero (unless it has already
/// been invalidated before).
/// </para>
/// </summary>

/// <param name="closure">
/// #GClosure to invalidate
/// </param>

	public static void Invalidate(this MentorLake.GObject.GClosureHandle closure)
	{
		if (closure.IsInvalid) throw new Exception("Invalid handle (GClosure)");
		GClosureExterns.g_closure_invalidate(closure);
	}

/// <summary>
/// <para>
/// Invokes the closure, i.e. executes the callback represented by the @closure.
/// </para>
/// </summary>

/// <param name="closure">
/// a #GClosure
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///                value. May be %NULL if the callback of @closure
///                doesn't return a value.
/// </param>
/// <param name="n_param_values">
/// the length of the @param_values array
/// </param>
/// <param name="param_values">
/// an array of
///                #GValues holding the arguments on which to
///                invoke the callback of @closure
/// </param>
/// <param name="invocation_hint">
/// a context-dependent invocation hint
/// </param>

	public static void Invoke(this MentorLake.GObject.GClosureHandle closure, out MentorLake.GObject.GValue return_value, uint n_param_values, MentorLake.GObject.GValue[] param_values, IntPtr invocation_hint)
	{
		if (closure.IsInvalid) throw new Exception("Invalid handle (GClosure)");
		GClosureExterns.g_closure_invoke(closure, out return_value, n_param_values, param_values, invocation_hint);
	}

/// <summary>
/// <para>
/// Increments the reference count on a closure to force it staying
/// alive while the caller holds a pointer to it.
/// </para>
/// </summary>

/// <param name="closure">
/// #GClosure to increment the reference count on
/// </param>
/// <return>
/// The @closure passed in, for convenience
/// </return>

	public static MentorLake.GObject.GClosureHandle Ref(this MentorLake.GObject.GClosureHandle closure)
	{
		if (closure.IsInvalid) throw new Exception("Invalid handle (GClosure)");
		return GClosureExterns.g_closure_ref(closure);
	}

/// <summary>
/// <para>
/// Removes a finalization notifier.
/// </para>
/// <para>
/// Notice that notifiers are automatically removed after they are run.
/// </para>
/// </summary>

/// <param name="closure">
/// a #GClosure
/// </param>
/// <param name="notify_data">
/// data which was passed to g_closure_add_finalize_notifier()
///  when registering @notify_func
/// </param>
/// <param name="notify_func">
/// the callback function to remove
/// </param>

	public static void RemoveFinalizeNotifier(this MentorLake.GObject.GClosureHandle closure, IntPtr notify_data, MentorLake.GObject.GClosureNotify notify_func)
	{
		if (closure.IsInvalid) throw new Exception("Invalid handle (GClosure)");
		GClosureExterns.g_closure_remove_finalize_notifier(closure, notify_data, notify_func);
	}

/// <summary>
/// <para>
/// Removes an invalidation notifier.
/// </para>
/// <para>
/// Notice that notifiers are automatically removed after they are run.
/// </para>
/// </summary>

/// <param name="closure">
/// a #GClosure
/// </param>
/// <param name="notify_data">
/// data which was passed to g_closure_add_invalidate_notifier()
///               when registering @notify_func
/// </param>
/// <param name="notify_func">
/// the callback function to remove
/// </param>

	public static void RemoveInvalidateNotifier(this MentorLake.GObject.GClosureHandle closure, IntPtr notify_data, MentorLake.GObject.GClosureNotify notify_func)
	{
		if (closure.IsInvalid) throw new Exception("Invalid handle (GClosure)");
		GClosureExterns.g_closure_remove_invalidate_notifier(closure, notify_data, notify_func);
	}

/// <summary>
/// <para>
/// Sets the marshaller of @closure.
/// </para>
/// <para>
/// The `marshal_data` of @marshal provides a way for a meta marshaller to
/// provide additional information to the marshaller.
/// </para>
/// <para>
/// For GObject's C predefined marshallers (the `g_cclosure_marshal_*()`
/// functions), what it provides is a callback function to use instead of
/// @closure->callback.
/// </para>
/// <para>
/// See also: g_closure_set_meta_marshal()
/// </para>
/// </summary>

/// <param name="closure">
/// a #GClosure
/// </param>
/// <param name="marshal">
/// a #GClosureMarshal function
/// </param>

	public static void SetMarshal(this MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GClosureMarshal marshal)
	{
		if (closure.IsInvalid) throw new Exception("Invalid handle (GClosure)");
		GClosureExterns.g_closure_set_marshal(closure, marshal);
	}

/// <summary>
/// <para>
/// Sets the meta marshaller of @closure.
/// </para>
/// <para>
/// A meta marshaller wraps the @closure's marshal and modifies the way
/// it is called in some fashion. The most common use of this facility
/// is for C callbacks.
/// </para>
/// <para>
/// The same marshallers (generated by [glib-genmarshal][glib-genmarshal]),
/// are used everywhere, but the way that we get the callback function
/// differs. In most cases we want to use the @closure's callback, but in
/// other cases we want to use some different technique to retrieve the
/// callback function.
/// </para>
/// <para>
/// For example, class closures for signals (see
/// g_signal_type_cclosure_new()) retrieve the callback function from a
/// fixed offset in the class structure.  The meta marshaller retrieves
/// the right callback and passes it to the marshaller as the
/// @marshal_data argument.
/// </para>
/// </summary>

/// <param name="closure">
/// a #GClosure
/// </param>
/// <param name="marshal_data">
/// context-dependent data to pass
///  to @meta_marshal
/// </param>
/// <param name="meta_marshal">
/// a #GClosureMarshal function
/// </param>

	public static void SetMetaMarshal(this MentorLake.GObject.GClosureHandle closure, IntPtr marshal_data, MentorLake.GObject.GClosureMarshal meta_marshal)
	{
		if (closure.IsInvalid) throw new Exception("Invalid handle (GClosure)");
		GClosureExterns.g_closure_set_meta_marshal(closure, marshal_data, meta_marshal);
	}

/// <summary>
/// <para>
/// Takes over the initial ownership of a closure.
/// </para>
/// <para>
/// Each closure is initially created in a "floating" state, which means
/// that the initial reference count is not owned by any caller.
/// </para>
/// <para>
/// This function checks to see if the object is still floating, and if so,
/// unsets the floating state and decreases the reference count. If the
/// closure is not floating, g_closure_sink() does nothing.
/// </para>
/// <para>
/// The reason for the existence of the floating state is to prevent
/// cumbersome code sequences like:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// closure = g_cclosure_new (cb_func, cb_data);
/// g_source_set_closure (source, closure);
/// g_closure_unref (closure); // GObject doesn't really need this
/// ]|
/// </para>
/// <para>
/// Because g_source_set_closure() (and similar functions) take ownership of the
/// initial reference count, if it is unowned, we instead can write:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// g_source_set_closure (source, g_cclosure_new (cb_func, cb_data));
/// ]|
/// </para>
/// <para>
/// Generally, this function is used together with g_closure_ref(). An example
/// of storing a closure for later notification looks like:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// static GClosure *notify_closure = NULL;
/// void
/// foo_notify_set_closure (GClosure *closure)
/// {
///   if (notify_closure)
///     g_closure_unref (notify_closure);
///   notify_closure = closure;
///   if (notify_closure)
///     {
///       g_closure_ref (notify_closure);
///       g_closure_sink (notify_closure);
///     }
/// }
/// ]|
/// </para>
/// <para>
/// Because g_closure_sink() may decrement the reference count of a closure
/// (if it hasn't been called on @closure yet) just like g_closure_unref(),
/// g_closure_ref() should be called prior to this function.
/// </para>
/// </summary>

/// <param name="closure">
/// #GClosure to decrement the initial reference count on, if it's
///           still being held
/// </param>

	public static void Sink(this MentorLake.GObject.GClosureHandle closure)
	{
		if (closure.IsInvalid) throw new Exception("Invalid handle (GClosure)");
		GClosureExterns.g_closure_sink(closure);
	}

/// <summary>
/// <para>
/// Decrements the reference count of a closure after it was previously
/// incremented by the same caller.
/// </para>
/// <para>
/// If no other callers are using the closure, then the closure will be
/// destroyed and freed.
/// </para>
/// </summary>

/// <param name="closure">
/// #GClosure to decrement the reference count on
/// </param>

	public static void Unref(this MentorLake.GObject.GClosureHandle closure)
	{
		if (closure.IsInvalid) throw new Exception("Invalid handle (GClosure)");
		GClosureExterns.g_closure_unref(closure);
	}


	public static GClosure Dereference(this GClosureHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GClosure>(x.DangerousGetHandle());
}
internal class GClosureExterns
{
	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))]
	internal static extern MentorLake.GObject.GClosureHandle g_closure_new_object(uint sizeof_closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))]
	internal static extern MentorLake.GObject.GClosureHandle g_closure_new_simple(uint sizeof_closure, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_add_finalize_notifier([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, IntPtr notify_data, MentorLake.GObject.GClosureNotify notify_func);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_add_invalidate_notifier([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, IntPtr notify_data, MentorLake.GObject.GClosureNotify notify_func);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_add_marshal_guards([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, IntPtr pre_marshal_data, MentorLake.GObject.GClosureNotify pre_marshal_notify, IntPtr post_marshal_data, MentorLake.GObject.GClosureNotify post_marshal_notify);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_invalidate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_invoke([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, out MentorLake.GObject.GValue return_value, uint n_param_values, MentorLake.GObject.GValue[] param_values, IntPtr invocation_hint);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))]
	internal static extern MentorLake.GObject.GClosureHandle g_closure_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_remove_finalize_notifier([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, IntPtr notify_data, MentorLake.GObject.GClosureNotify notify_func);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_remove_invalidate_notifier([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, IntPtr notify_data, MentorLake.GObject.GClosureNotify notify_func);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_set_marshal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GClosureMarshal marshal);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_set_meta_marshal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, IntPtr marshal_data, MentorLake.GObject.GClosureMarshal meta_marshal);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_sink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure);

}

/// <summary>
/// <para>
/// A `GClosure` represents a callback supplied by the programmer.
/// </para>
/// <para>
/// It will generally comprise a function of some kind and a marshaller
/// used to call it. It is the responsibility of the marshaller to
/// convert the arguments for the invocation from #GValues into
/// a suitable form, perform the callback on the converted arguments,
/// and transform the return value back into a #GValue.
/// </para>
/// <para>
/// In the case of C programs, a closure usually just holds a pointer
/// to a function and maybe a data argument, and the marshaller
/// converts between #GValue and native C types. The GObject
/// library provides the #GCClosure type for this purpose. Bindings for
/// other languages need marshallers which convert between #GValues
/// and suitable representations in the runtime of the language in
/// order to use functions written in that language as callbacks. Use
/// g_closure_set_marshal() to set the marshaller on such a custom
/// closure implementation.
/// </para>
/// <para>
/// Within GObject, closures play an important role in the
/// implementation of signals. When a signal is registered, the
/// @c_marshaller argument to g_signal_new() specifies the default C
/// marshaller for any closure which is connected to this
/// signal. GObject provides a number of C marshallers for this
/// purpose, see the g_cclosure_marshal_*() functions. Additional C
/// marshallers can be generated with the [glib-genmarshal][glib-genmarshal]
/// utility.  Closures can be explicitly connected to signals with
/// g_signal_connect_closure(), but it usually more convenient to let
/// GObject create a closure automatically by using one of the
/// g_signal_connect_*() functions which take a callback function/user
/// data pair.
/// </para>
/// <para>
/// Using closures has a number of important advantages over a simple
/// callback function/data pointer combination:
/// </para>
/// <para>
/// - Closures allow the callee to get the types of the callback parameters,
///   which means that language bindings don't have to write individual glue
///   for each callback type.
/// </para>
/// <para>
/// - The reference counting of #GClosure makes it easy to handle reentrancy
///   right; if a callback is removed while it is being invoked, the closure
///   and its parameters won't be freed until the invocation finishes.
/// </para>
/// <para>
/// - g_closure_invalidate() and invalidation notifiers allow callbacks to be
///   automatically removed when the objects they point to go away.
/// </para>
/// </summary>

public struct GClosure
{
	/// <summary>
/// <para>
/// Indicates whether the closure is currently being invoked with
///   g_closure_invoke()
/// </para>
/// </summary>

public uint in_marshal;
	/// <summary>
/// <para>
/// Indicates whether the closure has been invalidated by
///   g_closure_invalidate()
/// </para>
/// </summary>

public uint is_invalid;
	
public IntPtr marshal;
}
