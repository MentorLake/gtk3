namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The base object type.
/// </para>
/// <para>
/// `GObject` is the fundamental type providing the common attributes and
/// methods for all object types in GTK, Pango and other libraries
/// based on GObject. The `GObject` class provides methods for object
/// construction and destruction, property access methods, and signal
/// support. Signals are described in detail [here][gobject-Signals].
/// </para>
/// <para>
/// For a tutorial on implementing a new `GObject` class, see [How to define and
/// implement a new GObject](tutorial.html#how-to-define-and-implement-a-new-gobject).
/// For a list of naming conventions for GObjects and their methods, see the
/// [GType conventions](concepts.html#conventions). For the high-level concepts
/// behind GObject, read
/// [Instantiatable classed types: Objects](concepts.html#instantiatable-classed-types-objects).
/// </para>
/// <para>
/// Since GLib 2.72, all `GObject`s are guaranteed to be aligned to at least the
/// alignment of the largest basic GLib type (typically this is `guint64` or
/// `gdouble`). If you need larger alignment for an element in a `GObject`, you
/// should allocate it on the heap (aligned), or arrange for your `GObject` to be
/// appropriately padded. This guarantee applies to the `GObject` (or derived)
/// struct, the `GObjectClass` (or derived) struct, and any private data allocated
/// by `G_ADD_PRIVATE()`.
/// </para>
/// </summary>

public partial class GObjectHandle : GTypeInstanceHandle
{
/// <summary>
/// <para>
/// Creates a new instance of a #GObject subtype and sets its properties.
/// </para>
/// <para>
/// Construction parameters (see %G_PARAM_CONSTRUCT, %G_PARAM_CONSTRUCT_ONLY)
/// which are not explicitly specified are set to their default values. Any
/// private data for the object is guaranteed to be initialized with zeros, as
/// per g_type_create_instance().
/// </para>
/// <para>
/// Note that in C, small integer types in variable argument lists are promoted
/// up to `gint` or `guint` as appropriate, and read back accordingly. `gint` is
/// 32 bits on every platform on which GLib is currently supported. This means that
/// you can use C expressions of type `gint` with g_object_new() and properties of
/// type `gint` or `guint` or smaller. Specifically, you can use integer literals
/// with these property types.
/// </para>
/// <para>
/// When using property types of `gint64` or `guint64`, you must ensure that the
/// value that you provide is 64 bit. This means that you should use a cast or
/// make use of the %G_GINT64_CONSTANT or %G_GUINT64_CONSTANT macros.
/// </para>
/// <para>
/// Similarly, `gfloat` is promoted to `gdouble`, so you must ensure that the value
/// you provide is a `gdouble`, even for a property of type `gfloat`.
/// </para>
/// <para>
/// Since GLib 2.72, all #GObjects are guaranteed to be aligned to at least the
/// alignment of the largest basic GLib type (typically this is `guint64` or
/// `gdouble`). If you need larger alignment for an element in a #GObject, you
/// should allocate it on the heap (aligned), or arrange for your #GObject to be
/// appropriately padded.
/// </para>
/// </summary>

/// <param name="object_type">
/// the type id of the #GObject subtype to instantiate
/// </param>
/// <param name="first_property_name">
/// the name of the first property
/// </param>
/// <param name="@__arglist">
/// the value of the first property, followed optionally by more
///   name/value pairs, followed by %NULL
/// </param>
/// <return>
/// a new instance of
///   @object_type
/// </return>

	public static MentorLake.GObject.GObjectHandle New(MentorLake.GObject.GType object_type, string first_property_name, IntPtr @__arglist)
	{
		return GObjectHandleExterns.g_object_new(object_type, first_property_name, @__arglist);
	}

/// <summary>
/// <para>
/// Creates a new instance of a #GObject subtype and sets its properties.
/// </para>
/// <para>
/// Construction parameters (see %G_PARAM_CONSTRUCT, %G_PARAM_CONSTRUCT_ONLY)
/// which are not explicitly specified are set to their default values.
/// </para>
/// </summary>

/// <param name="object_type">
/// the type id of the #GObject subtype to instantiate
/// </param>
/// <param name="first_property_name">
/// the name of the first property
/// </param>
/// <param name="var_args">
/// the value of the first property, followed optionally by more
///  name/value pairs, followed by %NULL
/// </param>
/// <return>
/// a new instance of @object_type
/// </return>

	public static MentorLake.GObject.GObjectHandle NewValist(MentorLake.GObject.GType object_type, string first_property_name, IntPtr var_args)
	{
		return GObjectHandleExterns.g_object_new_valist(object_type, first_property_name, var_args);
	}

/// <summary>
/// <para>
/// Creates a new instance of a #GObject subtype and sets its properties using
/// the provided arrays. Both arrays must have exactly @n_properties elements,
/// and the names and values correspond by index.
/// </para>
/// <para>
/// Construction parameters (see %G_PARAM_CONSTRUCT, %G_PARAM_CONSTRUCT_ONLY)
/// which are not explicitly specified are set to their default values.
/// </para>
/// </summary>

/// <param name="object_type">
/// the object type to instantiate
/// </param>
/// <param name="n_properties">
/// the number of properties
/// </param>
/// <param name="names">
/// the names of each property to be set
/// </param>
/// <param name="values">
/// the values of each property to be set
/// </param>
/// <return>
/// a new instance of
/// @object_type
/// </return>

	public static MentorLake.GObject.GObjectHandle NewWithProperties(MentorLake.GObject.GType object_type, uint n_properties, string[] names, MentorLake.GObject.GValue[] values)
	{
		return GObjectHandleExterns.g_object_new_with_properties(object_type, n_properties, names, values);
	}

/// <summary>
/// <para>
/// Creates a new instance of a #GObject subtype and sets its properties.
/// </para>
/// <para>
/// Construction parameters (see %G_PARAM_CONSTRUCT, %G_PARAM_CONSTRUCT_ONLY)
/// which are not explicitly specified are set to their default values.
/// </para>
/// </summary>

/// <param name="object_type">
/// the type id of the #GObject subtype to instantiate
/// </param>
/// <param name="n_parameters">
/// the length of the @parameters array
/// </param>
/// <param name="parameters">
/// an array of #GParameter
/// </param>
/// <return>
/// a new instance of
/// @object_type
/// </return>

	public static MentorLake.GObject.GObjectHandle Newv(MentorLake.GObject.GType object_type, uint n_parameters, MentorLake.GObject.GParameter[] parameters)
	{
		return GObjectHandleExterns.g_object_newv(object_type, n_parameters, parameters);
	}


/// <param name="what">
/// </param>
/// <param name="data">
/// </param>

	public static UIntPtr CompatControl(UIntPtr what, IntPtr data)
	{
		return GObjectHandleExterns.g_object_compat_control(what, data);
	}

/// <summary>
/// <para>
/// Find the #GParamSpec with the given name for an
/// interface. Generally, the interface vtable passed in as @g_iface
/// will be the default vtable from g_type_default_interface_ref(), or,
/// if you know the interface has already been loaded,
/// g_type_default_interface_peek().
/// </para>
/// </summary>

/// <param name="g_iface">
/// any interface vtable for the
///  interface, or the default vtable for the interface
/// </param>
/// <param name="property_name">
/// name of a property to look up.
/// </param>
/// <return>
/// the #GParamSpec for the property of the
///          interface with the name @property_name, or %NULL if no
///          such property exists.
/// </return>

	public static MentorLake.GObject.GParamSpecHandle InterfaceFindProperty(MentorLake.GObject.GTypeInterfaceHandle g_iface, string property_name)
	{
		return GObjectHandleExterns.g_object_interface_find_property(g_iface, property_name);
	}

/// <summary>
/// <para>
/// Add a property to an interface; this is only useful for interfaces
/// that are added to GObject-derived types. Adding a property to an
/// interface forces all objects classes with that interface to have a
/// compatible property. The compatible property could be a newly
/// created #GParamSpec, but normally
/// g_object_class_override_property() will be used so that the object
/// class only needs to provide an implementation and inherits the
/// property description, default value, bounds, and so forth from the
/// interface property.
/// </para>
/// <para>
/// This function is meant to be called from the interface's default
/// vtable initialization function (the @class_init member of
/// #GTypeInfo.) It must not be called after after @class_init has
/// been called for any object types implementing this interface.
/// </para>
/// <para>
/// If @pspec is a floating reference, it will be consumed.
/// </para>
/// </summary>

/// <param name="g_iface">
/// any interface vtable for the
///    interface, or the default
///  vtable for the interface.
/// </param>
/// <param name="pspec">
/// the #GParamSpec for the new property
/// </param>

	public static void InterfaceInstallProperty(MentorLake.GObject.GTypeInterfaceHandle g_iface, MentorLake.GObject.GParamSpecHandle pspec)
	{
		GObjectHandleExterns.g_object_interface_install_property(g_iface, pspec);
	}

/// <summary>
/// <para>
/// Lists the properties of an interface.Generally, the interface
/// vtable passed in as @g_iface will be the default vtable from
/// g_type_default_interface_ref(), or, if you know the interface has
/// already been loaded, g_type_default_interface_peek().
/// </para>
/// </summary>

/// <param name="g_iface">
/// any interface vtable for the
///  interface, or the default vtable for the interface
/// </param>
/// <param name="n_properties_p">
/// location to store number of properties returned.
/// </param>
/// <return>
/// a
///   pointer to an array of pointers to #GParamSpec
///   structures. The paramspecs are owned by GLib, but the
///   array should be freed with g_free() when you are done with
///   it.
/// </return>

	public static MentorLake.GObject.GParamSpecHandle[] InterfaceListProperties(MentorLake.GObject.GTypeInterfaceHandle g_iface, out uint n_properties_p)
	{
		return GObjectHandleExterns.g_object_interface_list_properties(g_iface, out n_properties_p);
	}

}
public static class GObjectHandleSignalExtensions
{
/// <summary>
/// <para>
/// The notify signal is emitted on an object when one of its properties has
/// its value set through g_object_set_property(), g_object_set(), et al.
/// </para>
/// <para>
/// Note that getting this signal doesn’t itself guarantee that the value of
/// the property has actually changed. When it is emitted is determined by the
/// derived GObject class. If the implementor did not create the property with
/// %G_PARAM_EXPLICIT_NOTIFY, then any call to g_object_set_property() results
/// in ::notify being emitted, even if the new value is the same as the old.
/// If they did pass %G_PARAM_EXPLICIT_NOTIFY, then this signal is emitted only
/// when they explicitly call g_object_notify() or g_object_notify_by_pspec(),
/// and common practice is to do that only when the value has actually changed.
/// </para>
/// <para>
/// This signal is typically used to obtain change notification for a
/// single property, by specifying the property name as a detail in the
/// g_signal_connect() call, like this:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// g_signal_connect (text_view->buffer, "notify::paste-target-list",
///                   G_CALLBACK (gtk_text_view_target_list_notify),
///                   text_view)
/// ]|
/// </para>
/// <para>
/// It is important to note that you must use
/// [canonical parameter names][class@GObject.ParamSpec#parameter-names] as
/// detail strings for the notify signal.
/// </para>
/// </summary>

	public static IObservable<GObjectHandleSignalStructs.NotifySignal> Signal_Notify(this GObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GObjectHandleSignalStructs.NotifySignal> obs) =>
		{
			GObjectHandleSignalDelegates.notify handler = ( MentorLake.GObject.GObjectHandle self,  MentorLake.GObject.GParamSpecHandle pspec,  IntPtr user_data) =>
			{
				

				var signalStruct = new GObjectHandleSignalStructs.NotifySignal()
				{
					Self = self, Pspec = pspec, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "notify", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GObjectHandleSignalStructs
{

public class NotifySignal
{

	public MentorLake.GObject.GObjectHandle Self;
/// <summary>
/// <para>
/// the #GParamSpec of the property which changed.
/// </para>
/// </summary>

	public MentorLake.GObject.GParamSpecHandle Pspec;

	public IntPtr UserData;
}
}

public static class GObjectHandleSignalDelegates
{

/// <summary>
/// <para>
/// The notify signal is emitted on an object when one of its properties has
/// its value set through g_object_set_property(), g_object_set(), et al.
/// </para>
/// <para>
/// Note that getting this signal doesn’t itself guarantee that the value of
/// the property has actually changed. When it is emitted is determined by the
/// derived GObject class. If the implementor did not create the property with
/// %G_PARAM_EXPLICIT_NOTIFY, then any call to g_object_set_property() results
/// in ::notify being emitted, even if the new value is the same as the old.
/// If they did pass %G_PARAM_EXPLICIT_NOTIFY, then this signal is emitted only
/// when they explicitly call g_object_notify() or g_object_notify_by_pspec(),
/// and common practice is to do that only when the value has actually changed.
/// </para>
/// <para>
/// This signal is typically used to obtain change notification for a
/// single property, by specifying the property name as a detail in the
/// g_signal_connect() call, like this:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// g_signal_connect (text_view->buffer, "notify::paste-target-list",
///                   G_CALLBACK (gtk_text_view_target_list_notify),
///                   text_view)
/// ]|
/// </para>
/// <para>
/// It is important to note that you must use
/// [canonical parameter names][class@GObject.ParamSpec#parameter-names] as
/// detail strings for the notify signal.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="pspec">
/// the #GParamSpec of the property which changed.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, IntPtr user_data);

}


public static class GObjectHandleExtensions
{
/// <summary>
/// <para>
/// Increases the reference count of the object by one and sets a
/// callback to be called when all other references to the object are
/// dropped, or when this is already the last reference to the object
/// and another reference is established.
/// </para>
/// <para>
/// This functionality is intended for binding @object to a proxy
/// object managed by another memory manager. This is done with two
/// paired references: the strong reference added by
/// g_object_add_toggle_ref() and a reverse reference to the proxy
/// object which is either a strong reference or weak reference.
/// </para>
/// <para>
/// The setup is that when there are no other references to @object,
/// only a weak reference is held in the reverse direction from @object
/// to the proxy object, but when there are other references held to
/// @object, a strong reference is held. The @notify callback is called
/// when the reference from @object to the proxy object should be
/// "toggled" from strong to weak (@is_last_ref true) or weak to strong
/// (@is_last_ref false).
/// </para>
/// <para>
/// Since a (normal) reference must be held to the object before
/// calling g_object_add_toggle_ref(), the initial state of the reverse
/// link is always strong.
/// </para>
/// <para>
/// Multiple toggle references may be added to the same gobject,
/// however if there are multiple toggle references to an object, none
/// of them will ever be notified until all but one are removed.  For
/// this reason, you should only ever use a toggle reference if there
/// is important state in the proxy object.
/// </para>
/// <para>
/// Note that if you unref the object on another thread, then @notify might
/// still be invoked after g_object_remove_toggle_ref(), and the object argument
/// might be a dangling pointer. If the object is destroyed on other threads,
/// you must take care of that yourself.
/// </para>
/// <para>
/// A g_object_add_toggle_ref() must be released with g_object_remove_toggle_ref().
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="notify">
/// a function to call when this reference is the
///  last reference to the object, or is no longer
///  the last reference.
/// </param>
/// <param name="data">
/// data to pass to @notify
/// </param>

	public static T AddToggleRef<T>(this T @object, MentorLake.GObject.GToggleNotify notify, IntPtr data) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_add_toggle_ref(@object, notify, data);
		return @object;
	}

/// <summary>
/// <para>
/// Adds a weak reference from weak_pointer to @object to indicate that
/// the pointer located at @weak_pointer_location is only valid during
/// the lifetime of @object. When the @object is finalized,
/// @weak_pointer will be set to %NULL.
/// </para>
/// <para>
/// Note that as with g_object_weak_ref(), the weak references created by
/// this method are not thread-safe: they cannot safely be used in one
/// thread if the object's last g_object_unref() might happen in another
/// thread. Use #GWeakRef if thread-safety is required.
/// </para>
/// </summary>

/// <param name="@object">
/// The object that should be weak referenced.
/// </param>
/// <param name="weak_pointer_location">
/// The memory address
///    of a pointer.
/// </param>

	public static T AddWeakPointer<T>(this T @object, ref IntPtr weak_pointer_location) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_add_weak_pointer(@object, ref weak_pointer_location);
		return @object;
	}

/// <summary>
/// <para>
/// Creates a binding between @source_property on @source and @target_property
/// on @target.
/// </para>
/// <para>
/// Whenever the @source_property is changed the @target_property is
/// updated using the same value. For instance:
/// </para>
/// <para>
/// |[<!-- language="C" -->
///   g_object_bind_property (action, "active", widget, "sensitive", 0);
/// ]|
/// </para>
/// <para>
/// Will result in the "sensitive" property of the widget #GObject instance to be
/// updated with the same value of the "active" property of the action #GObject
/// instance.
/// </para>
/// <para>
/// If @flags contains %G_BINDING_BIDIRECTIONAL then the binding will be mutual:
/// if @target_property on @target changes then the @source_property on @source
/// will be updated as well.
/// </para>
/// <para>
/// The binding will automatically be removed when either the @source or the
/// @target instances are finalized. To remove the binding without affecting the
/// @source and the @target you can just call g_object_unref() on the returned
/// #GBinding instance.
/// </para>
/// <para>
/// Removing the binding by calling g_object_unref() on it must only be done if
/// the binding, @source and @target are only used from a single thread and it
/// is clear that both @source and @target outlive the binding. Especially it
/// is not safe to rely on this if the binding, @source or @target can be
/// finalized from different threads. Keep another reference to the binding and
/// use g_binding_unbind() instead to be on the safe side.
/// </para>
/// <para>
/// A #GObject can have multiple bindings.
/// </para>
/// </summary>

/// <param name="source">
/// the source #GObject
/// </param>
/// <param name="source_property">
/// the property on @source to bind
/// </param>
/// <param name="target">
/// the target #GObject
/// </param>
/// <param name="target_property">
/// the property on @target to bind
/// </param>
/// <param name="flags">
/// flags to pass to #GBinding
/// </param>
/// <return>
/// the #GBinding instance representing the
///     binding between the two #GObject instances. The binding is released
///     whenever the #GBinding reference count reaches zero.
/// </return>

	public static MentorLake.GObject.GBindingHandle BindProperty(this MentorLake.GObject.GObjectHandle source, string source_property, MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_bind_property(source, source_property, target, target_property, flags);
	}

/// <summary>
/// <para>
/// Complete version of g_object_bind_property().
/// </para>
/// <para>
/// Creates a binding between @source_property on @source and @target_property
/// on @target, allowing you to set the transformation functions to be used by
/// the binding.
/// </para>
/// <para>
/// If @flags contains %G_BINDING_BIDIRECTIONAL then the binding will be mutual:
/// if @target_property on @target changes then the @source_property on @source
/// will be updated as well. The @transform_from function is only used in case
/// of bidirectional bindings, otherwise it will be ignored
/// </para>
/// <para>
/// The binding will automatically be removed when either the @source or the
/// @target instances are finalized. This will release the reference that is
/// being held on the #GBinding instance; if you want to hold on to the
/// #GBinding instance, you will need to hold a reference to it.
/// </para>
/// <para>
/// To remove the binding, call g_binding_unbind().
/// </para>
/// <para>
/// A #GObject can have multiple bindings.
/// </para>
/// <para>
/// The same @user_data parameter will be used for both @transform_to
/// and @transform_from transformation functions; the @notify function will
/// be called once, when the binding is removed. If you need different data
/// for each transformation function, please use
/// g_object_bind_property_with_closures() instead.
/// </para>
/// </summary>

/// <param name="source">
/// the source #GObject
/// </param>
/// <param name="source_property">
/// the property on @source to bind
/// </param>
/// <param name="target">
/// the target #GObject
/// </param>
/// <param name="target_property">
/// the property on @target to bind
/// </param>
/// <param name="flags">
/// flags to pass to #GBinding
/// </param>
/// <param name="transform_to">
/// the transformation function
///     from the @source to the @target, or %NULL to use the default
/// </param>
/// <param name="transform_from">
/// the transformation function
///     from the @target to the @source, or %NULL to use the default
/// </param>
/// <param name="user_data">
/// custom data to be passed to the transformation functions,
///     or %NULL
/// </param>
/// <param name="notify">
/// a function to call when disposing the binding, to free
///     resources used by the transformation functions, or %NULL if not required
/// </param>
/// <return>
/// the #GBinding instance representing the
///     binding between the two #GObject instances. The binding is released
///     whenever the #GBinding reference count reaches zero.
/// </return>

	public static MentorLake.GObject.GBindingHandle BindPropertyFull(this MentorLake.GObject.GObjectHandle source, string source_property, MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags, MentorLake.GObject.GBindingTransformFunc transform_to, MentorLake.GObject.GBindingTransformFunc transform_from, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_bind_property_full(source, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
	}

/// <summary>
/// <para>
/// Creates a binding between @source_property on @source and @target_property
/// on @target, allowing you to set the transformation functions to be used by
/// the binding.
/// </para>
/// <para>
/// This function is the language bindings friendly version of
/// g_object_bind_property_full(), using #GClosures instead of
/// function pointers.
/// </para>
/// </summary>

/// <param name="source">
/// the source #GObject
/// </param>
/// <param name="source_property">
/// the property on @source to bind
/// </param>
/// <param name="target">
/// the target #GObject
/// </param>
/// <param name="target_property">
/// the property on @target to bind
/// </param>
/// <param name="flags">
/// flags to pass to #GBinding
/// </param>
/// <param name="transform_to">
/// a #GClosure wrapping the transformation function
///     from the @source to the @target, or %NULL to use the default
/// </param>
/// <param name="transform_from">
/// a #GClosure wrapping the transformation function
///     from the @target to the @source, or %NULL to use the default
/// </param>
/// <return>
/// the #GBinding instance representing the
///     binding between the two #GObject instances. The binding is released
///     whenever the #GBinding reference count reaches zero.
/// </return>

	public static MentorLake.GObject.GBindingHandle BindPropertyWithClosures(this MentorLake.GObject.GObjectHandle source, string source_property, MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags, MentorLake.GObject.GClosureHandle transform_to, MentorLake.GObject.GClosureHandle transform_from)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_bind_property_with_closures(source, source_property, target, target_property, flags, transform_to, transform_from);
	}

/// <summary>
/// <para>
/// A convenience function to connect multiple signals at once.
/// </para>
/// <para>
/// The signal specs expected by this function have the form
/// `modifier::signal_name`, where `modifier` can be one of the
/// following:
/// </para>
/// <para>
/// - `signal`: equivalent to `g_signal_connect_data (..., NULL, G_CONNECT_DEFAULT)`
/// - `object-signal`, `object_signal`: equivalent to `g_signal_connect_object (..., G_CONNECT_DEFAULT)`
/// - `swapped-signal`, `swapped_signal`: equivalent to `g_signal_connect_data (..., NULL, G_CONNECT_SWAPPED)`
/// - `swapped_object_signal`, `swapped-object-signal`: equivalent to `g_signal_connect_object (..., G_CONNECT_SWAPPED)`
/// - `signal_after`, `signal-after`: equivalent to `g_signal_connect_data (..., NULL, G_CONNECT_AFTER)`
/// - `object_signal_after`, `object-signal-after`: equivalent to `g_signal_connect_object (..., G_CONNECT_AFTER)`
/// - `swapped_signal_after`, `swapped-signal-after`: equivalent to `g_signal_connect_data (..., NULL, G_CONNECT_SWAPPED | G_CONNECT_AFTER)`
/// - `swapped_object_signal_after`, `swapped-object-signal-after`: equivalent to `g_signal_connect_object (..., G_CONNECT_SWAPPED | G_CONNECT_AFTER)`
/// </para>
/// <para>
/// ```c
/// menu->toplevel = g_object_connect (g_object_new (GTK_TYPE_WINDOW,
///                                                  "type", GTK_WINDOW_POPUP,
///                                                  "child", menu,
///                                                  NULL),
///                                    "signal::event", gtk_menu_window_event, menu,
///                                    "signal::size_request", gtk_menu_window_size_request, menu,
///                                    "signal::destroy", gtk_widget_destroyed, &menu->toplevel,
///                                    NULL);
/// ```
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="signal_spec">
/// the spec for the first signal
/// </param>
/// <param name="@__arglist">
/// [type@GObject.Callback] for the first signal, followed by data for the
///   first signal, followed optionally by more signal
///   spec/callback/data triples, followed by `NULL`
/// </param>
/// <return>
/// the object
/// </return>

	public static MentorLake.GObject.GObjectHandle Connect(this MentorLake.GObject.GObjectHandle @object, string signal_spec, IntPtr @__arglist)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_connect(@object, signal_spec, @__arglist);
	}

/// <summary>
/// <para>
/// A convenience function to disconnect multiple signals at once.
/// </para>
/// <para>
/// The signal specs expected by this function have the form
/// "any_signal", which means to disconnect any signal with matching
/// callback and data, or "any_signal::signal_name", which only
/// disconnects the signal named "signal_name".
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="signal_spec">
/// the spec for the first signal
/// </param>
/// <param name="@__arglist">
/// #GCallback for the first signal, followed by data for the first signal,
///  followed optionally by more signal spec/callback/data triples,
///  followed by %NULL
/// </param>

	public static T Disconnect<T>(this T @object, string signal_spec, IntPtr @__arglist) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_disconnect(@object, signal_spec, @__arglist);
		return @object;
	}

/// <summary>
/// <para>
/// This is a variant of g_object_get_data() which returns
/// a 'duplicate' of the value. @dup_func defines the
/// meaning of 'duplicate' in this context, it could e.g.
/// take a reference on a ref-counted object.
/// </para>
/// <para>
/// If the @key is not set on the object then @dup_func
/// will be called with a %NULL argument.
/// </para>
/// <para>
/// Note that @dup_func is called while user data of @object
/// is locked.
/// </para>
/// <para>
/// This function can be useful to avoid races when multiple
/// threads are using object data on the same key on the same
/// object.
/// </para>
/// </summary>

/// <param name="@object">
/// the #GObject to store user data on
/// </param>
/// <param name="key">
/// a string, naming the user data pointer
/// </param>
/// <param name="dup_func">
/// function to dup the value
/// </param>
/// <param name="user_data">
/// passed as user_data to @dup_func
/// </param>
/// <return>
/// the result of calling @dup_func on the value
///     associated with @key on @object, or %NULL if not set.
///     If @dup_func is %NULL, the value is returned
///     unmodified.
/// </return>

	public static IntPtr DupData(this MentorLake.GObject.GObjectHandle @object, string key, MentorLake.GLib.GDuplicateFunc dup_func, IntPtr user_data)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_dup_data(@object, key, dup_func, user_data);
	}

/// <summary>
/// <para>
/// This is a variant of g_object_get_qdata() which returns
/// a 'duplicate' of the value. @dup_func defines the
/// meaning of 'duplicate' in this context, it could e.g.
/// take a reference on a ref-counted object.
/// </para>
/// <para>
/// If the @quark is not set on the object then @dup_func
/// will be called with a %NULL argument.
/// </para>
/// <para>
/// Note that @dup_func is called while user data of @object
/// is locked.
/// </para>
/// <para>
/// This function can be useful to avoid races when multiple
/// threads are using object data on the same key on the same
/// object.
/// </para>
/// </summary>

/// <param name="@object">
/// the #GObject to store user data on
/// </param>
/// <param name="quark">
/// a #GQuark, naming the user data pointer
/// </param>
/// <param name="dup_func">
/// function to dup the value
/// </param>
/// <param name="user_data">
/// passed as user_data to @dup_func
/// </param>
/// <return>
/// the result of calling @dup_func on the value
///     associated with @quark on @object, or %NULL if not set.
///     If @dup_func is %NULL, the value is returned
///     unmodified.
/// </return>

	public static IntPtr DupQdata(this MentorLake.GObject.GObjectHandle @object, MentorLake.GLib.GQuark quark, MentorLake.GLib.GDuplicateFunc dup_func, IntPtr user_data)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_dup_qdata(@object, quark, dup_func, user_data);
	}

/// <summary>
/// <para>
/// This function is intended for #GObject implementations to re-enforce
/// a [floating][floating-ref] object reference. Doing this is seldom
/// required: all #GInitiallyUnowneds are created with a floating reference
/// which usually just needs to be sunken by calling g_object_ref_sink().
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>

	public static T ForceFloating<T>(this T @object) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_force_floating(@object);
		return @object;
	}

/// <summary>
/// <para>
/// Increases the freeze count on @object. If the freeze count is
/// non-zero, the emission of "notify" signals on @object is
/// stopped. The signals are queued until the freeze count is decreased
/// to zero. Duplicate notifications are squashed so that at most one
/// #GObject::notify signal is emitted for each property modified while the
/// object is frozen.
/// </para>
/// <para>
/// This is necessary for accessors that modify multiple properties to prevent
/// premature notification while the object is still being modified.
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>

	public static T FreezeNotify<T>(this T @object) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_freeze_notify(@object);
		return @object;
	}

/// <summary>
/// <para>
/// Gets properties of an object.
/// </para>
/// <para>
/// In general, a copy is made of the property contents and the caller
/// is responsible for freeing the memory in the appropriate manner for
/// the type, for instance by calling g_free() or g_object_unref().
/// </para>
/// <para>
/// Here is an example of using g_object_get() to get the contents
/// of three properties: an integer, a string and an object:
/// |[<!-- language="C" -->
///  gint intval;
///  guint64 uint64val;
///  gchar *strval;
///  GObject *objval;
/// </para>
/// <para>
///  g_object_get (my_object,
///                "int-property", &intval,
///                "uint64-property", &uint64val,
///                "str-property", &strval,
///                "obj-property", &objval,
///                NULL);
/// </para>
/// <para>
///  // Do something with intval, uint64val, strval, objval
/// </para>
/// <para>
///  g_free (strval);
///  g_object_unref (objval);
/// ]|
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="first_property_name">
/// name of the first property to get
/// </param>
/// <param name="@__arglist">
/// return location for the first property, followed optionally by more
///  name/return location pairs, followed by %NULL
/// </param>

	public static T Get<T>(this T @object, string first_property_name, IntPtr @__arglist) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_get(@object, first_property_name, @__arglist);
		return @object;
	}

/// <summary>
/// <para>
/// Gets a named field from the objects table of associations (see g_object_set_data()).
/// </para>
/// </summary>

/// <param name="@object">
/// #GObject containing the associations
/// </param>
/// <param name="key">
/// name of the key for that association
/// </param>
/// <return>
/// the data if found,
///          or %NULL if no such data exists.
/// </return>

	public static IntPtr GetData(this MentorLake.GObject.GObjectHandle @object, string key)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_get_data(@object, key);
	}

/// <summary>
/// <para>
/// Gets a property of an object.
/// </para>
/// <para>
/// The @value can be:
/// </para>
/// <para>
///  - an empty #GValue initialized by %G_VALUE_INIT, which will be
///    automatically initialized with the expected type of the property
///    (since GLib 2.60)
///  - a #GValue initialized with the expected type of the property
///  - a #GValue initialized with a type to which the expected type
///    of the property can be transformed
/// </para>
/// <para>
/// In general, a copy is made of the property contents and the caller is
/// responsible for freeing the memory by calling g_value_unset().
/// </para>
/// <para>
/// Note that g_object_get_property() is really intended for language
/// bindings, g_object_get() is much more convenient for C programming.
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="property_name">
/// the name of the property to get
/// </param>
/// <param name="value">
/// return location for the property value
/// </param>

	public static T GetProperty<T>(this T @object, string property_name, MentorLake.GObject.GValueHandle value) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_get_property(@object, property_name, value);
		return @object;
	}

/// <summary>
/// <para>
/// This function gets back user data pointers stored via
/// g_object_set_qdata().
/// </para>
/// </summary>

/// <param name="@object">
/// The GObject to get a stored user data pointer from
/// </param>
/// <param name="quark">
/// A #GQuark, naming the user data pointer
/// </param>
/// <return>
/// The user data pointer set, or %NULL
/// </return>

	public static IntPtr GetQdata(this MentorLake.GObject.GObjectHandle @object, MentorLake.GLib.GQuark quark)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_get_qdata(@object, quark);
	}

/// <summary>
/// <para>
/// Gets properties of an object.
/// </para>
/// <para>
/// In general, a copy is made of the property contents and the caller
/// is responsible for freeing the memory in the appropriate manner for
/// the type, for instance by calling g_free() or g_object_unref().
/// </para>
/// <para>
/// See g_object_get().
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="first_property_name">
/// name of the first property to get
/// </param>
/// <param name="var_args">
/// return location for the first property, followed optionally by more
///  name/return location pairs, followed by %NULL
/// </param>

	public static T GetValist<T>(this T @object, string first_property_name, IntPtr var_args) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_get_valist(@object, first_property_name, var_args);
		return @object;
	}

/// <summary>
/// <para>
/// Gets @n_properties properties for an @object.
/// Obtained properties will be set to @values. All properties must be valid.
/// Warnings will be emitted and undefined behaviour may result if invalid
/// properties are passed in.
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="n_properties">
/// the number of properties
/// </param>
/// <param name="names">
/// the names of each property to get
/// </param>
/// <param name="values">
/// the values of each property to get
/// </param>

	public static T Getv<T>(this T @object, uint n_properties, string[] names, MentorLake.GObject.GValue[] values) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_getv(@object, n_properties, names, values);
		return @object;
	}

/// <summary>
/// <para>
/// Checks whether @object has a [floating][floating-ref] reference.
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>
/// <return>
/// %TRUE if @object has a floating reference
/// </return>

	public static bool IsFloating(this MentorLake.GObject.GObjectHandle @object)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_is_floating(@object);
	}

/// <summary>
/// <para>
/// Emits a "notify" signal for the property @property_name on @object.
/// </para>
/// <para>
/// When possible, eg. when signaling a property change from within the class
/// that registered the property, you should use g_object_notify_by_pspec()
/// instead.
/// </para>
/// <para>
/// Note that emission of the notify signal may be blocked with
/// g_object_freeze_notify(). In this case, the signal emissions are queued
/// and will be emitted (in reverse order) when g_object_thaw_notify() is
/// called.
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="property_name">
/// the name of a property installed on the class of @object.
/// </param>

	public static T Notify<T>(this T @object, string property_name) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_notify(@object, property_name);
		return @object;
	}

/// <summary>
/// <para>
/// Emits a "notify" signal for the property specified by @pspec on @object.
/// </para>
/// <para>
/// This function omits the property name lookup, hence it is faster than
/// g_object_notify().
/// </para>
/// <para>
/// One way to avoid using g_object_notify() from within the
/// class that registered the properties, and using g_object_notify_by_pspec()
/// instead, is to store the GParamSpec used with
/// g_object_class_install_property() inside a static array, e.g.:
/// </para>
/// <para>
/// |[<!-- language="C" -->
///   typedef enum
///   {
///     PROP_FOO = 1,
///     PROP_LAST
///   } MyObjectProperty;
/// </para>
/// <para>
///   static GParamSpec *properties[PROP_LAST];
/// </para>
/// <para>
///   static void
///   my_object_class_init (MyObjectClass *klass)
///   {
///     properties[PROP_FOO] = g_param_spec_int ("foo", NULL, NULL,
///                                              0, 100,
///                                              50,
///                                              G_PARAM_READWRITE | G_PARAM_STATIC_STRINGS);
///     g_object_class_install_property (gobject_class,
///                                      PROP_FOO,
///                                      properties[PROP_FOO]);
///   }
/// ]|
/// </para>
/// <para>
/// and then notify a change on the "foo" property with:
/// </para>
/// <para>
/// |[<!-- language="C" -->
///   g_object_notify_by_pspec (self, properties[PROP_FOO]);
/// ]|
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="pspec">
/// the #GParamSpec of a property installed on the class of @object.
/// </param>

	public static T NotifyByPspec<T>(this T @object, MentorLake.GObject.GParamSpecHandle pspec) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_notify_by_pspec(@object, pspec);
		return @object;
	}

/// <summary>
/// <para>
/// Increases the reference count of @object.
/// </para>
/// <para>
/// Since GLib 2.56, if `GLIB_VERSION_MAX_ALLOWED` is 2.56 or greater, the type
/// of @object will be propagated to the return type (using the GCC typeof()
/// extension), so any casting the caller needs to do on the return type must be
/// explicit.
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>
/// <return>
/// the same @object
/// </return>

	public static MentorLake.GObject.GObjectHandle Ref(this MentorLake.GObject.GObjectHandle @object)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_ref(@object);
	}

/// <summary>
/// <para>
/// Increase the reference count of @object, and possibly remove the
/// [floating][floating-ref] reference, if @object has a floating reference.
/// </para>
/// <para>
/// In other words, if the object is floating, then this call "assumes
/// ownership" of the floating reference, converting it to a normal
/// reference by clearing the floating flag while leaving the reference
/// count unchanged.  If the object is not floating, then this call
/// adds a new normal reference increasing the reference count by one.
/// </para>
/// <para>
/// Since GLib 2.56, the type of @object will be propagated to the return type
/// under the same conditions as for g_object_ref().
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>
/// <return>
/// @object
/// </return>

	public static MentorLake.GObject.GObjectHandle RefSink(this MentorLake.GObject.GObjectHandle @object)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_ref_sink(@object);
	}

/// <summary>
/// <para>
/// Removes a reference added with g_object_add_toggle_ref(). The
/// reference count of the object is decreased by one.
/// </para>
/// <para>
/// Note that if you unref the object on another thread, then @notify might
/// still be invoked after g_object_remove_toggle_ref(), and the object argument
/// might be a dangling pointer. If the object is destroyed on other threads,
/// you must take care of that yourself.
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="notify">
/// a function to call when this reference is the
///  last reference to the object, or is no longer
///  the last reference.
/// </param>
/// <param name="data">
/// data to pass to @notify, or %NULL to
///  match any toggle refs with the @notify argument.
/// </param>

	public static T RemoveToggleRef<T>(this T @object, MentorLake.GObject.GToggleNotify notify, IntPtr data) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_remove_toggle_ref(@object, notify, data);
		return @object;
	}

/// <summary>
/// <para>
/// Removes a weak reference from @object that was previously added
/// using g_object_add_weak_pointer(). The @weak_pointer_location has
/// to match the one used with g_object_add_weak_pointer().
/// </para>
/// </summary>

/// <param name="@object">
/// The object that is weak referenced.
/// </param>
/// <param name="weak_pointer_location">
/// The memory address
///    of a pointer.
/// </param>

	public static T RemoveWeakPointer<T>(this T @object, ref IntPtr weak_pointer_location) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_remove_weak_pointer(@object, ref weak_pointer_location);
		return @object;
	}

/// <summary>
/// <para>
/// Compares the user data for the key @key on @object with
/// @oldval, and if they are the same, replaces @oldval with
/// @newval.
/// </para>
/// <para>
/// This is like a typical atomic compare-and-exchange
/// operation, for user data on an object.
/// </para>
/// <para>
/// If the previous value was replaced then ownership of the
/// old value (@oldval) is passed to the caller, including
/// the registered destroy notify for it (passed out in @old_destroy).
/// It’s up to the caller to free this as needed, which may
/// or may not include using @old_destroy as sometimes replacement
/// should not destroy the object in the normal way.
/// </para>
/// <para>
/// See g_object_set_data() for guidance on using a small, bounded set of values
/// for @key.
/// </para>
/// </summary>

/// <param name="@object">
/// the #GObject to store user data on
/// </param>
/// <param name="key">
/// a string, naming the user data pointer
/// </param>
/// <param name="oldval">
/// the old value to compare against
/// </param>
/// <param name="newval">
/// the new value
/// </param>
/// <param name="destroy">
/// a destroy notify for the new value
/// </param>
/// <param name="old_destroy">
/// destroy notify for the existing value
/// </param>
/// <return>
/// %TRUE if the existing value for @key was replaced
///  by @newval, %FALSE otherwise.
/// </return>

	public static bool ReplaceData(this MentorLake.GObject.GObjectHandle @object, string key, IntPtr oldval, IntPtr newval, MentorLake.GLib.GDestroyNotify destroy, out MentorLake.GLib.GDestroyNotify old_destroy)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_replace_data(@object, key, oldval, newval, destroy, out old_destroy);
	}

/// <summary>
/// <para>
/// Compares the user data for the key @quark on @object with
/// @oldval, and if they are the same, replaces @oldval with
/// @newval.
/// </para>
/// <para>
/// This is like a typical atomic compare-and-exchange
/// operation, for user data on an object.
/// </para>
/// <para>
/// If the previous value was replaced then ownership of the
/// old value (@oldval) is passed to the caller, including
/// the registered destroy notify for it (passed out in @old_destroy).
/// It’s up to the caller to free this as needed, which may
/// or may not include using @old_destroy as sometimes replacement
/// should not destroy the object in the normal way.
/// </para>
/// </summary>

/// <param name="@object">
/// the #GObject to store user data on
/// </param>
/// <param name="quark">
/// a #GQuark, naming the user data pointer
/// </param>
/// <param name="oldval">
/// the old value to compare against
/// </param>
/// <param name="newval">
/// the new value
/// </param>
/// <param name="destroy">
/// a destroy notify for the new value
/// </param>
/// <param name="old_destroy">
/// destroy notify for the existing value
/// </param>
/// <return>
/// %TRUE if the existing value for @quark was replaced
///  by @newval, %FALSE otherwise.
/// </return>

	public static bool ReplaceQdata(this MentorLake.GObject.GObjectHandle @object, MentorLake.GLib.GQuark quark, IntPtr oldval, IntPtr newval, MentorLake.GLib.GDestroyNotify destroy, out MentorLake.GLib.GDestroyNotify old_destroy)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_replace_qdata(@object, quark, oldval, newval, destroy, out old_destroy);
	}

/// <summary>
/// <para>
/// Releases all references to other objects. This can be used to break
/// reference cycles.
/// </para>
/// <para>
/// This function should only be called from object system implementations.
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>

	public static T RunDispose<T>(this T @object) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_run_dispose(@object);
		return @object;
	}

/// <summary>
/// <para>
/// Sets properties on an object.
/// </para>
/// <para>
/// The same caveats about passing integer literals as varargs apply as with
/// g_object_new(). In particular, any integer literals set as the values for
/// properties of type #gint64 or #guint64 must be 64 bits wide, using the
/// %G_GINT64_CONSTANT or %G_GUINT64_CONSTANT macros.
/// </para>
/// <para>
/// Note that the "notify" signals are queued and only emitted (in
/// reverse order) after all properties have been set. See
/// g_object_freeze_notify().
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="first_property_name">
/// name of the first property to set
/// </param>
/// <param name="@__arglist">
/// value for the first property, followed optionally by more
///  name/value pairs, followed by %NULL
/// </param>

	public static T Set<T>(this T @object, string first_property_name, IntPtr @__arglist) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_set(@object, first_property_name, @__arglist);
		return @object;
	}

/// <summary>
/// <para>
/// Each object carries around a table of associations from
/// strings to pointers.  This function lets you set an association.
/// </para>
/// <para>
/// If the object already had an association with that name,
/// the old association will be destroyed.
/// </para>
/// <para>
/// Internally, the @key is converted to a #GQuark using g_quark_from_string().
/// This means a copy of @key is kept permanently (even after @object has been
/// finalized) — so it is recommended to only use a small, bounded set of values
/// for @key in your program, to avoid the #GQuark storage growing unbounded.
/// </para>
/// </summary>

/// <param name="@object">
/// #GObject containing the associations.
/// </param>
/// <param name="key">
/// name of the key
/// </param>
/// <param name="data">
/// data to associate with that key
/// </param>

	public static T SetData<T>(this T @object, string key, IntPtr data) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_set_data(@object, key, data);
		return @object;
	}

/// <summary>
/// <para>
/// Like g_object_set_data() except it adds notification
/// for when the association is destroyed, either by setting it
/// to a different value or when the object is destroyed.
/// </para>
/// <para>
/// Note that the @destroy callback is not called if @data is %NULL.
/// </para>
/// </summary>

/// <param name="@object">
/// #GObject containing the associations
/// </param>
/// <param name="key">
/// name of the key
/// </param>
/// <param name="data">
/// data to associate with that key
/// </param>
/// <param name="destroy">
/// function to call when the association is destroyed
/// </param>

	public static T SetDataFull<T>(this T @object, string key, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_set_data_full(@object, key, data, destroy);
		return @object;
	}

/// <summary>
/// <para>
/// Sets a property on an object.
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="property_name">
/// the name of the property to set
/// </param>
/// <param name="value">
/// the value
/// </param>

	public static T SetProperty<T>(this T @object, string property_name, MentorLake.GObject.GValueHandle value) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_set_property(@object, property_name, value);
		return @object;
	}

/// <summary>
/// <para>
/// This sets an opaque, named pointer on an object.
/// The name is specified through a #GQuark (retrieved e.g. via
/// g_quark_from_static_string()), and the pointer
/// can be gotten back from the @object with g_object_get_qdata()
/// until the @object is finalized.
/// Setting a previously set user data pointer, overrides (frees)
/// the old pointer set, using #NULL as pointer essentially
/// removes the data stored.
/// </para>
/// </summary>

/// <param name="@object">
/// The GObject to set store a user data pointer
/// </param>
/// <param name="quark">
/// A #GQuark, naming the user data pointer
/// </param>
/// <param name="data">
/// An opaque user data pointer
/// </param>

	public static T SetQdata<T>(this T @object, MentorLake.GLib.GQuark quark, IntPtr data) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_set_qdata(@object, quark, data);
		return @object;
	}

/// <summary>
/// <para>
/// This function works like g_object_set_qdata(), but in addition,
/// a void (*destroy) (gpointer) function may be specified which is
/// called with @data as argument when the @object is finalized, or
/// the data is being overwritten by a call to g_object_set_qdata()
/// with the same @quark.
/// </para>
/// </summary>

/// <param name="@object">
/// The GObject to set store a user data pointer
/// </param>
/// <param name="quark">
/// A #GQuark, naming the user data pointer
/// </param>
/// <param name="data">
/// An opaque user data pointer
/// </param>
/// <param name="destroy">
/// Function to invoke with @data as argument, when @data
///           needs to be freed
/// </param>

	public static T SetQdataFull<T>(this T @object, MentorLake.GLib.GQuark quark, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_set_qdata_full(@object, quark, data, destroy);
		return @object;
	}

/// <summary>
/// <para>
/// Sets properties on an object.
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="first_property_name">
/// name of the first property to set
/// </param>
/// <param name="var_args">
/// value for the first property, followed optionally by more
///  name/value pairs, followed by %NULL
/// </param>

	public static T SetValist<T>(this T @object, string first_property_name, IntPtr var_args) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_set_valist(@object, first_property_name, var_args);
		return @object;
	}

/// <summary>
/// <para>
/// Sets @n_properties properties for an @object.
/// Properties to be set will be taken from @values. All properties must be
/// valid. Warnings will be emitted and undefined behaviour may result if invalid
/// properties are passed in.
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="n_properties">
/// the number of properties
/// </param>
/// <param name="names">
/// the names of each property to be set
/// </param>
/// <param name="values">
/// the values of each property to be set
/// </param>

	public static T Setv<T>(this T @object, uint n_properties, string[] names, MentorLake.GObject.GValue[] values) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_setv(@object, n_properties, names, values);
		return @object;
	}

/// <summary>
/// <para>
/// Remove a specified datum from the object's data associations,
/// without invoking the association's destroy handler.
/// </para>
/// </summary>

/// <param name="@object">
/// #GObject containing the associations
/// </param>
/// <param name="key">
/// name of the key
/// </param>
/// <return>
/// the data if found, or %NULL
///          if no such data exists.
/// </return>

	public static IntPtr StealData(this MentorLake.GObject.GObjectHandle @object, string key)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_steal_data(@object, key);
	}

/// <summary>
/// <para>
/// This function gets back user data pointers stored via
/// g_object_set_qdata() and removes the @data from object
/// without invoking its destroy() function (if any was
/// set).
/// Usually, calling this function is only required to update
/// user data pointers with a destroy notifier, for example:
/// |[<!-- language="C" -->
/// void
/// object_add_to_user_list (GObject     *object,
///                          const gchar *new_string)
/// {
///   // the quark, naming the object data
///   GQuark quark_string_list = g_quark_from_static_string ("my-string-list");
///   // retrieve the old string list
///   GList *list = g_object_steal_qdata (object, quark_string_list);
/// </para>
/// <para>
///   // prepend new string
///   list = g_list_prepend (list, g_strdup (new_string));
///   // this changed 'list', so we need to set it again
///   g_object_set_qdata_full (object, quark_string_list, list, free_string_list);
/// }
/// static void
/// free_string_list (gpointer data)
/// {
///   GList *node, *list = data;
/// </para>
/// <para>
///   for (node = list; node; node = node->next)
///     g_free (node->data);
///   g_list_free (list);
/// }
/// ]|
/// Using g_object_get_qdata() in the above example, instead of
/// g_object_steal_qdata() would have left the destroy function set,
/// and thus the partial string list would have been freed upon
/// g_object_set_qdata_full().
/// </para>
/// </summary>

/// <param name="@object">
/// The GObject to get a stored user data pointer from
/// </param>
/// <param name="quark">
/// A #GQuark, naming the user data pointer
/// </param>
/// <return>
/// The user data pointer set, or %NULL
/// </return>

	public static IntPtr StealQdata(this MentorLake.GObject.GObjectHandle @object, MentorLake.GLib.GQuark quark)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_steal_qdata(@object, quark);
	}

/// <summary>
/// <para>
/// If @object is floating, sink it.  Otherwise, do nothing.
/// </para>
/// <para>
/// In other words, this function will convert a floating reference (if
/// present) into a full reference.
/// </para>
/// <para>
/// Typically you want to use g_object_ref_sink() in order to
/// automatically do the correct thing with respect to floating or
/// non-floating references, but there is one specific scenario where
/// this function is helpful.
/// </para>
/// <para>
/// The situation where this function is helpful is when creating an API
/// that allows the user to provide a callback function that returns a
/// GObject. We certainly want to allow the user the flexibility to
/// return a non-floating reference from this callback (for the case
/// where the object that is being returned already exists).
/// </para>
/// <para>
/// At the same time, the API style of some popular GObject-based
/// libraries (such as Gtk) make it likely that for newly-created GObject
/// instances, the user can be saved some typing if they are allowed to
/// return a floating reference.
/// </para>
/// <para>
/// Using this function on the return value of the user's callback allows
/// the user to do whichever is more convenient for them. The caller will
/// always receives exactly one full reference to the value: either the
/// one that was returned in the first place, or a floating reference
/// that has been converted to a full reference.
/// </para>
/// <para>
/// This function has an odd interaction when combined with
/// g_object_ref_sink() running at the same time in another thread on
/// the same #GObject instance. If g_object_ref_sink() runs first then
/// the result will be that the floating reference is converted to a hard
/// reference. If g_object_take_ref() runs first then the result will be
/// that the floating reference is converted to a hard reference and an
/// additional reference on top of that one is added. It is best to avoid
/// this situation.
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>
/// <return>
/// @object
/// </return>

	public static MentorLake.GObject.GObjectHandle TakeRef(this MentorLake.GObject.GObjectHandle @object)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_take_ref(@object);
	}

/// <summary>
/// <para>
/// Reverts the effect of a previous call to
/// g_object_freeze_notify(). The freeze count is decreased on @object
/// and when it reaches zero, queued "notify" signals are emitted.
/// </para>
/// <para>
/// Duplicate notifications for each property are squashed so that at most one
/// #GObject::notify signal is emitted for each property, in the reverse order
/// in which they have been queued.
/// </para>
/// <para>
/// It is an error to call this function when the freeze count is zero.
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>

	public static T ThawNotify<T>(this T @object) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_thaw_notify(@object);
		return @object;
	}

/// <summary>
/// <para>
/// Decreases the reference count of @object. When its reference count
/// drops to 0, the object is finalized (i.e. its memory is freed).
/// </para>
/// <para>
/// If the pointer to the #GObject may be reused in future (for example, if it is
/// an instance variable of another object), it is recommended to clear the
/// pointer to %NULL rather than retain a dangling pointer to a potentially
/// invalid #GObject instance. Use g_clear_object() for this.
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>

	public static T Unref<T>(this T @object) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_unref(@object);
		return @object;
	}

/// <summary>
/// <para>
/// This function essentially limits the life time of the @closure to
/// the life time of the object. That is, when the object is finalized,
/// the @closure is invalidated by calling g_closure_invalidate() on
/// it, in order to prevent invocations of the closure with a finalized
/// (nonexisting) object. Also, g_object_ref() and g_object_unref() are
/// added as marshal guards to the @closure, to ensure that an extra
/// reference count is held on @object during invocation of the
/// @closure.  Usually, this function will be called on closures that
/// use this @object as closure data.
/// </para>
/// </summary>

/// <param name="@object">
/// #GObject restricting lifetime of @closure
/// </param>
/// <param name="closure">
/// #GClosure to watch
/// </param>

	public static T WatchClosure<T>(this T @object, MentorLake.GObject.GClosureHandle closure) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_watch_closure(@object, closure);
		return @object;
	}

/// <summary>
/// <para>
/// Adds a weak reference callback to an object. Weak references are
/// used for notification when an object is disposed. They are called
/// "weak references" because they allow you to safely hold a pointer
/// to an object without calling g_object_ref() (g_object_ref() adds a
/// strong reference, that is, forces the object to stay alive).
/// </para>
/// <para>
/// Note that the weak references created by this method are not
/// thread-safe: they cannot safely be used in one thread if the
/// object's last g_object_unref() might happen in another thread.
/// Use #GWeakRef if thread-safety is required.
/// </para>
/// </summary>

/// <param name="@object">
/// #GObject to reference weakly
/// </param>
/// <param name="notify">
/// callback to invoke before the object is freed
/// </param>
/// <param name="data">
/// extra data to pass to notify
/// </param>

	public static T WeakRef<T>(this T @object, MentorLake.GObject.GWeakNotify notify, IntPtr data) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_weak_ref(@object, notify, data);
		return @object;
	}

/// <summary>
/// <para>
/// Removes a weak reference callback to an object.
/// </para>
/// </summary>

/// <param name="@object">
/// #GObject to remove a weak reference from
/// </param>
/// <param name="notify">
/// callback to search for
/// </param>
/// <param name="data">
/// data to search for
/// </param>

	public static T WeakUnref<T>(this T @object, MentorLake.GObject.GWeakNotify notify, IntPtr data) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_weak_unref(@object, notify, data);
		return @object;
	}

}

internal class GObjectHandleExterns
{
	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_object_new(MentorLake.GObject.GType object_type, string first_property_name, IntPtr @__arglist);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_object_new_valist(MentorLake.GObject.GType object_type, string first_property_name, IntPtr var_args);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_object_new_with_properties(MentorLake.GObject.GType object_type, uint n_properties, string[] names, MentorLake.GObject.GValue[] values);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_object_newv(MentorLake.GObject.GType object_type, uint n_parameters, MentorLake.GObject.GParameter[] parameters);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_add_toggle_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.GObject.GToggleNotify notify, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_add_weak_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, ref IntPtr weak_pointer_location);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))]
	internal static extern MentorLake.GObject.GBindingHandle g_object_bind_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source, string source_property, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))]
	internal static extern MentorLake.GObject.GBindingHandle g_object_bind_property_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source, string source_property, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags, MentorLake.GObject.GBindingTransformFunc transform_to, MentorLake.GObject.GBindingTransformFunc transform_from, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))]
	internal static extern MentorLake.GObject.GBindingHandle g_object_bind_property_with_closures([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source, string source_property, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle transform_to, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle transform_from);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_object_connect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string signal_spec, IntPtr @__arglist);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_disconnect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string signal_spec, IntPtr @__arglist);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_object_dup_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string key, MentorLake.GLib.GDuplicateFunc dup_func, IntPtr user_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_object_dup_qdata([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.GLib.GQuark quark, MentorLake.GLib.GDuplicateFunc dup_func, IntPtr user_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_force_floating([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_freeze_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string first_property_name, IntPtr @__arglist);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_object_get_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string key);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_get_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_object_get_qdata([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.GLib.GQuark quark);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_get_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string first_property_name, IntPtr var_args);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_getv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, uint n_properties, string[] names, MentorLake.GObject.GValue[] values);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_object_is_floating([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property_name);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_notify_by_pspec([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_object_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_object_ref_sink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_remove_toggle_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.GObject.GToggleNotify notify, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_remove_weak_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, ref IntPtr weak_pointer_location);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_object_replace_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string key, IntPtr oldval, IntPtr newval, MentorLake.GLib.GDestroyNotify destroy, out MentorLake.GLib.GDestroyNotify old_destroy);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_object_replace_qdata([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.GLib.GQuark quark, IntPtr oldval, IntPtr newval, MentorLake.GLib.GDestroyNotify destroy, out MentorLake.GLib.GDestroyNotify old_destroy);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_run_dispose([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string first_property_name, IntPtr @__arglist);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_set_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string key, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_set_data_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string key, IntPtr data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_set_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_set_qdata([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.GLib.GQuark quark, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_set_qdata_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.GLib.GQuark quark, IntPtr data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_set_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string first_property_name, IntPtr var_args);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_setv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, uint n_properties, string[] names, MentorLake.GObject.GValue[] values);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_object_steal_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string key);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_object_steal_qdata([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.GLib.GQuark quark);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_object_take_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_thaw_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_watch_closure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_weak_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.GObject.GWeakNotify notify, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_weak_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.GObject.GWeakNotify notify, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern UIntPtr g_object_compat_control(UIntPtr what, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_object_interface_find_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInterfaceHandle>))] MentorLake.GObject.GTypeInterfaceHandle g_iface, string property_name);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_interface_install_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInterfaceHandle>))] MentorLake.GObject.GTypeInterfaceHandle g_iface, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GParamSpecHandle[] g_object_interface_list_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInterfaceHandle>))] MentorLake.GObject.GTypeInterfaceHandle g_iface, out uint n_properties_p);

}
