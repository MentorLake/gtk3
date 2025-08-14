namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GInitable` is implemented by objects that can fail during
/// initialization. If an object implements this interface then
/// it must be initialized as the first thing after construction,
/// either via [method@Gio.Initable.init] or [method@Gio.AsyncInitable.init_async]
/// (the latter is only available if it also implements [iface@Gio.AsyncInitable]).
/// </para>
/// <para>
/// If the object is not initialized, or initialization returns with an
/// error, then all operations on the object except `g_object_ref()` and
/// `g_object_unref()` are considered to be invalid, and have undefined
/// behaviour. They will often fail with [func@GLib.critical] or
/// [func@GLib.warning], but this must not be relied on.
/// </para>
/// <para>
/// Users of objects implementing this are not intended to use
/// the interface method directly, instead it will be used automatically
/// in various ways. For C applications you generally just call
/// [func@Gio.Initable.new] directly, or indirectly via a `foo_thing_new()` wrapper.
/// This will call [method@Gio.Initable.init] under the cover, returning `NULL`
/// and setting a `GError` on failure (at which point the instance is
/// unreferenced).
/// </para>
/// <para>
/// For bindings in languages where the native constructor supports
/// exceptions the binding could check for objects implementing `GInitable`
/// during normal construction and automatically initialize them, throwing
/// an exception on failure.
/// </para>
/// </summary>

public interface GInitableHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GInitableHandleImpl : BaseSafeHandle, GInitableHandle
{
}

public static class GInitableHandleExtensions
{
/// <summary>
/// <para>
/// Initializes the object implementing the interface.
/// </para>
/// <para>
/// This method is intended for language bindings. If writing in C,
/// g_initable_new() should typically be used instead.
/// </para>
/// <para>
/// The object must be initialized before any real use after initial
/// construction, either with this function or g_async_initable_init_async().
/// </para>
/// <para>
/// Implementations may also support cancellation. If @cancellable is not %NULL,
/// then initialization can be cancelled by triggering the cancellable object
/// from another thread. If the operation was cancelled, the error
/// %G_IO_ERROR_CANCELLED will be returned. If @cancellable is not %NULL and
/// the object doesn't support cancellable initialization the error
/// %G_IO_ERROR_NOT_SUPPORTED will be returned.
/// </para>
/// <para>
/// If the object is not initialized, or initialization returns with an
/// error, then all operations on the object except g_object_ref() and
/// g_object_unref() are considered to be invalid, and have undefined
/// behaviour. See the [introduction][ginitable] for more details.
/// </para>
/// <para>
/// Callers should not assume that a class which implements #GInitable can be
/// initialized multiple times, unless the class explicitly documents itself as
/// supporting this. Generally, a class’ implementation of init() can assume
/// (and assert) that it will only be called once. Previously, this documentation
/// recommended all #GInitable implementations should be idempotent; that
/// recommendation was relaxed in GLib 2.54.
/// </para>
/// <para>
/// If a class explicitly supports being initialized multiple times, it is
/// recommended that the method is idempotent: multiple calls with the same
/// arguments should return the same results. Only the first call initializes
/// the object; further calls return the result of the first call.
/// </para>
/// <para>
/// One reason why a class might need to support idempotent initialization is if
/// it is designed to be used via the singleton pattern, with a
/// #GObjectClass.constructor that sometimes returns an existing instance.
/// In this pattern, a caller would expect to be able to call g_initable_init()
/// on the result of g_object_new(), regardless of whether it is in fact a new
/// instance.
/// </para>
/// </summary>

/// <param name="initable">
/// a #GInitable.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// %TRUE if successful. If an error has occurred, this function will
///     return %FALSE and set @error appropriately if present.
/// </return>

	public static bool Init(this MentorLake.Gio.GInitableHandle initable, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (initable.IsInvalid) throw new Exception("Invalid handle (GInitableHandle)");
		var externCallResult = GInitableHandleExterns.g_initable_init(initable, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Helper function for constructing #GInitable object. This is
/// similar to g_object_new() but also initializes the object
/// and returns %NULL, setting an error on failure.
/// </para>
/// </summary>

/// <param name="object_type">
/// a #GType supporting #GInitable.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="error">
/// a #GError location to store the error occurring, or %NULL to
///    ignore.
/// </param>
/// <param name="first_property_name">
/// the name of the first property, or %NULL if no
///     properties
/// </param>
/// <param name="@__arglist">
/// the value if the first property, followed by and other property
///    value pairs, and ended by %NULL.
/// </param>
/// <return>
/// a newly allocated
///      #GObject, or %NULL on error
/// </return>

	public static MentorLake.GObject.GObjectHandle New(MentorLake.GObject.GType object_type, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error, string first_property_name, IntPtr @__arglist)
	{
		return GInitableHandleExterns.g_initable_new(object_type, cancellable, error, first_property_name, @__arglist);
	}

/// <summary>
/// <para>
/// Helper function for constructing #GInitable object. This is
/// similar to g_object_new_valist() but also initializes the object
/// and returns %NULL, setting an error on failure.
/// </para>
/// </summary>

/// <param name="object_type">
/// a #GType supporting #GInitable.
/// </param>
/// <param name="first_property_name">
/// the name of the first property, followed by
/// the value, and other property value pairs, and ended by %NULL.
/// </param>
/// <param name="var_args">
/// The var args list generated from @first_property_name.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// a newly allocated
///      #GObject, or %NULL on error
/// </return>

	public static MentorLake.GObject.GObjectHandle NewValist(MentorLake.GObject.GType object_type, string first_property_name, IntPtr var_args, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GInitableHandleExterns.g_initable_new_valist(object_type, first_property_name, var_args, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Helper function for constructing #GInitable object. This is
/// similar to g_object_newv() but also initializes the object
/// and returns %NULL, setting an error on failure.
/// </para>
/// </summary>

/// <param name="object_type">
/// a #GType supporting #GInitable.
/// </param>
/// <param name="n_parameters">
/// the number of parameters in @parameters
/// </param>
/// <param name="parameters">
/// the parameters to use to construct the object
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// a newly allocated
///      #GObject, or %NULL on error
/// </return>

	public static MentorLake.GObject.GObjectHandle Newv(MentorLake.GObject.GType object_type, uint n_parameters, MentorLake.GObject.GParameter[] parameters, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GInitableHandleExterns.g_initable_newv(object_type, n_parameters, parameters, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GInitableHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_initable_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInitableHandleImpl>))] MentorLake.Gio.GInitableHandle initable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_initable_new(MentorLake.GObject.GType object_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error, string first_property_name, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_initable_new_valist(MentorLake.GObject.GType object_type, string first_property_name, IntPtr var_args, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_initable_newv(MentorLake.GObject.GType object_type, uint n_parameters, MentorLake.GObject.GParameter[] parameters, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

}
