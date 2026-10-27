namespace MentorLake.JavaScriptCore;

/// <summary>
/// <para>
/// A JSSClass represents a custom JavaScript class registered by the user in a #JSCContext.
/// It allows to create new JavaScripts objects whose instances are created by the user using
/// this API.
/// It&apos;s possible to add constructors, properties and methods for a JSSClass by providing
/// #GCallback&amp;lt;!-- --&amp;gt;s to implement them.
/// </para>
/// </summary>

public class JSCClassHandle : GObjectHandle
{
}

public static class JSCClassHandleExtensions
{
/// <summary>
/// <para>
/// Add a constructor to @jsc_class. If @name is %NULL, the class name will be used. When &amp;lt;function&amp;gt;new&amp;lt;/function&amp;gt;
/// is used with the constructor or jsc_value_constructor_call() is called, @callback is invoked receiving the
/// parameters and @user_data as the last parameter. When the constructor object is cleared in the #JSCClass context,
/// @destroy_notify is called with @user_data as parameter.
/// </para>
/// <para>
/// This function creates the constructor, which needs to be added to an object as a property to be able to use it. Use
/// jsc_context_set_value() to make the constructor available in the global object.
/// </para>
/// <para>
/// Note that the value returned by @callback is adopted by @jsc_class, and the #GDestroyNotify passed to
/// jsc_context_register_class() is responsible for disposing of it.
/// </para>
/// </summary>

/// <param name="jsc_class">
/// a #JSCClass
/// </param>
/// <param name="name">
/// the constructor name or %NULL
/// </param>
/// <param name="callback">
/// a #GCallback to be called to create an instance of @jsc_class
/// </param>
/// <param name="user_data">
/// user data to pass to @callback
/// </param>
/// <param name="destroy_notify">
/// destroy notifier for @user_data
/// </param>
/// <param name="return_type">
/// the #GType of the constructor return value
/// </param>
/// <param name="n_params">
/// the number of parameter types to follow or 0 if constructor doesn&apos;t receive parameters.
/// </param>
/// <param name="@__arglist">
/// a list of #GType&amp;lt;!-- --&amp;gt;s, one for each parameter.
/// </param>
/// <return>
/// a #JSCValue representing the class constructor.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle AddConstructor(this MentorLake.JavaScriptCore.JSCClassHandle jsc_class, string name, MentorLake.GObject.GCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify, MentorLake.GObject.GType return_type, uint n_params, IntPtr @__arglist)
	{
		if (jsc_class.IsInvalid) throw new Exception("Invalid handle (JSCClassHandle)");
		return JSCClassHandleExterns.jsc_class_add_constructor(jsc_class, name, callback, user_data, destroy_notify, return_type, n_params, @__arglist);
	}

/// <summary>
/// <para>
/// Add a constructor to @jsc_class. If @name is %NULL, the class name will be used. When &amp;lt;function&amp;gt;new&amp;lt;/function&amp;gt;
/// is used with the constructor or jsc_value_constructor_call() is called, @callback is invoked receiving
/// a #GPtrArray of #JSCValue&amp;lt;!-- --&amp;gt;s as arguments and @user_data as the last parameter. When the constructor object
/// is cleared in the #JSCClass context, @destroy_notify is called with @user_data as parameter.
/// </para>
/// <para>
/// This function creates the constructor, which needs to be added to an object as a property to be able to use it. Use
/// jsc_context_set_value() to make the constructor available in the global object.
/// </para>
/// <para>
/// Note that the value returned by @callback is adopted by @jsc_class, and the #GDestroyNotify passed to
/// jsc_context_register_class() is responsible for disposing of it.
/// </para>
/// </summary>

/// <param name="jsc_class">
/// a #JSCClass
/// </param>
/// <param name="name">
/// the constructor name or %NULL
/// </param>
/// <param name="callback">
/// a #GCallback to be called to create an instance of @jsc_class
/// </param>
/// <param name="user_data">
/// user data to pass to @callback
/// </param>
/// <param name="destroy_notify">
/// destroy notifier for @user_data
/// </param>
/// <param name="return_type">
/// the #GType of the constructor return value
/// </param>
/// <return>
/// a #JSCValue representing the class constructor.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle AddConstructorVariadic(this MentorLake.JavaScriptCore.JSCClassHandle jsc_class, string name, MentorLake.GObject.GCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify, MentorLake.GObject.GType return_type)
	{
		if (jsc_class.IsInvalid) throw new Exception("Invalid handle (JSCClassHandle)");
		return JSCClassHandleExterns.jsc_class_add_constructor_variadic(jsc_class, name, callback, user_data, destroy_notify, return_type);
	}

/// <summary>
/// <para>
/// Add a constructor to @jsc_class. If @name is %NULL, the class name will be used. When &amp;lt;function&amp;gt;new&amp;lt;/function&amp;gt;
/// is used with the constructor or jsc_value_constructor_call() is called, @callback is invoked receiving the
/// parameters and @user_data as the last parameter. When the constructor object is cleared in the #JSCClass context,
/// @destroy_notify is called with @user_data as parameter.
/// </para>
/// <para>
/// This function creates the constructor, which needs to be added to an object as a property to be able to use it. Use
/// jsc_context_set_value() to make the constructor available in the global object.
/// </para>
/// <para>
/// Note that the value returned by @callback is adopted by @jsc_class, and the #GDestroyNotify passed to
/// jsc_context_register_class() is responsible for disposing of it.
/// </para>
/// </summary>

/// <param name="jsc_class">
/// a #JSCClass
/// </param>
/// <param name="name">
/// the constructor name or %NULL
/// </param>
/// <param name="callback">
/// a #GCallback to be called to create an instance of @jsc_class
/// </param>
/// <param name="user_data">
/// user data to pass to @callback
/// </param>
/// <param name="destroy_notify">
/// destroy notifier for @user_data
/// </param>
/// <param name="return_type">
/// the #GType of the constructor return value
/// </param>
/// <param name="n_parameters">
/// the number of parameters
/// </param>
/// <param name="parameter_types">
/// a list of #GType&amp;lt;!-- --&amp;gt;s, one for each parameter, or %NULL
/// </param>
/// <return>
/// a #JSCValue representing the class constructor.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle AddConstructorv(this MentorLake.JavaScriptCore.JSCClassHandle jsc_class, string name, MentorLake.GObject.GCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify, MentorLake.GObject.GType return_type, uint n_parameters, MentorLake.GObject.GType[] parameter_types)
	{
		if (jsc_class.IsInvalid) throw new Exception("Invalid handle (JSCClassHandle)");
		return JSCClassHandleExterns.jsc_class_add_constructorv(jsc_class, name, callback, user_data, destroy_notify, return_type, n_parameters, parameter_types);
	}

/// <summary>
/// <para>
/// Add method with @name to @jsc_class. When the method is called by JavaScript or jsc_value_object_invoke_method(),
/// @callback is called receiving the class instance as first parameter, followed by the method parameters and then
/// @user_data as last parameter. When the method is cleared in the #JSCClass context, @destroy_notify is called with
/// @user_data as parameter.
/// </para>
/// <para>
/// Note that the value returned by @callback must be transfer full. In case of non-refcounted boxed types, you should use
/// %G_TYPE_POINTER instead of the actual boxed #GType to ensure that the instance owned by #JSCClass is used.
/// If you really want to return a new copy of the boxed type, use #JSC_TYPE_VALUE and return a #JSCValue created
/// with jsc_value_new_object() that receives the copy as the instance parameter.
/// </para>
/// </summary>

/// <param name="jsc_class">
/// a #JSCClass
/// </param>
/// <param name="name">
/// the method name
/// </param>
/// <param name="callback">
/// a #GCallback to be called to invoke method @name of @jsc_class
/// </param>
/// <param name="user_data">
/// user data to pass to @callback
/// </param>
/// <param name="destroy_notify">
/// destroy notifier for @user_data
/// </param>
/// <param name="return_type">
/// the #GType of the method return value, or %G_TYPE_NONE if the method is void.
/// </param>
/// <param name="n_params">
/// the number of parameter types to follow or 0 if the method doesn&apos;t receive parameters.
/// </param>
/// <param name="@__arglist">
/// a list of #GType&amp;lt;!-- --&amp;gt;s, one for each parameter.
/// </param>

	public static T AddMethod<T>(this T jsc_class, string name, MentorLake.GObject.GCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify, MentorLake.GObject.GType return_type, uint n_params, IntPtr @__arglist) where T : JSCClassHandle
	{
		if (jsc_class.IsInvalid) throw new Exception("Invalid handle (JSCClassHandle)");
		JSCClassHandleExterns.jsc_class_add_method(jsc_class, name, callback, user_data, destroy_notify, return_type, n_params, @__arglist);
		return jsc_class;
	}

/// <summary>
/// <para>
/// Add method with @name to @jsc_class. When the method is called by JavaScript or jsc_value_object_invoke_method(),
/// @callback is called receiving the class instance as first parameter, followed by a #GPtrArray of #JSCValue&amp;lt;!-- --&amp;gt;s
/// with the method arguments and then @user_data as last parameter. When the method is cleared in the #JSCClass context,
/// @destroy_notify is called with @user_data as parameter.
/// </para>
/// <para>
/// Note that the value returned by @callback must be transfer full. In case of non-refcounted boxed types, you should use
/// %G_TYPE_POINTER instead of the actual boxed #GType to ensure that the instance owned by #JSCClass is used.
/// If you really want to return a new copy of the boxed type, use #JSC_TYPE_VALUE and return a #JSCValue created
/// with jsc_value_new_object() that receives the copy as the instance parameter.
/// </para>
/// </summary>

/// <param name="jsc_class">
/// a #JSCClass
/// </param>
/// <param name="name">
/// the method name
/// </param>
/// <param name="callback">
/// a #GCallback to be called to invoke method @name of @jsc_class
/// </param>
/// <param name="user_data">
/// user data to pass to @callback
/// </param>
/// <param name="destroy_notify">
/// destroy notifier for @user_data
/// </param>
/// <param name="return_type">
/// the #GType of the method return value, or %G_TYPE_NONE if the method is void.
/// </param>

	public static T AddMethodVariadic<T>(this T jsc_class, string name, MentorLake.GObject.GCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify, MentorLake.GObject.GType return_type) where T : JSCClassHandle
	{
		if (jsc_class.IsInvalid) throw new Exception("Invalid handle (JSCClassHandle)");
		JSCClassHandleExterns.jsc_class_add_method_variadic(jsc_class, name, callback, user_data, destroy_notify, return_type);
		return jsc_class;
	}

/// <summary>
/// <para>
/// Add method with @name to @jsc_class. When the method is called by JavaScript or jsc_value_object_invoke_method(),
/// @callback is called receiving the class instance as first parameter, followed by the method parameters and then
/// @user_data as last parameter. When the method is cleared in the #JSCClass context, @destroy_notify is called with
/// @user_data as parameter.
/// </para>
/// <para>
/// Note that the value returned by @callback must be transfer full. In case of non-refcounted boxed types, you should use
/// %G_TYPE_POINTER instead of the actual boxed #GType to ensure that the instance owned by #JSCClass is used.
/// If you really want to return a new copy of the boxed type, use #JSC_TYPE_VALUE and return a #JSCValue created
/// with jsc_value_new_object() that receives the copy as the instance parameter.
/// </para>
/// </summary>

/// <param name="jsc_class">
/// a #JSCClass
/// </param>
/// <param name="name">
/// the method name
/// </param>
/// <param name="callback">
/// a #GCallback to be called to invoke method @name of @jsc_class
/// </param>
/// <param name="user_data">
/// user data to pass to @callback
/// </param>
/// <param name="destroy_notify">
/// destroy notifier for @user_data
/// </param>
/// <param name="return_type">
/// the #GType of the method return value, or %G_TYPE_NONE if the method is void.
/// </param>
/// <param name="n_parameters">
/// the number of parameter types to follow or 0 if the method doesn&apos;t receive parameters.
/// </param>
/// <param name="parameter_types">
/// a list of #GType&amp;lt;!-- --&amp;gt;s, one for each parameter, or %NULL
/// </param>

	public static T AddMethodv<T>(this T jsc_class, string name, MentorLake.GObject.GCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify, MentorLake.GObject.GType return_type, uint n_parameters, MentorLake.GObject.GType[] parameter_types) where T : JSCClassHandle
	{
		if (jsc_class.IsInvalid) throw new Exception("Invalid handle (JSCClassHandle)");
		JSCClassHandleExterns.jsc_class_add_methodv(jsc_class, name, callback, user_data, destroy_notify, return_type, n_parameters, parameter_types);
		return jsc_class;
	}

/// <summary>
/// <para>
/// Add a property with @name to @jsc_class. When the property value is read, @getter is called
/// receiving the the class instance as first parameter and @user_data as last parameter. When the property
/// value needs to be set, @setter is called receiving the the class instance as first parameter, followed
/// by the value to be set and then @user_data as the last parameter. When the property is cleared in the
/// #JSCClass context, @destroy_notify is called with @user_data as parameter.
/// </para>
/// <para>
/// Note that the value returned by @getter must be transfer full. In case of non-refcounted boxed types, you should use
/// %G_TYPE_POINTER instead of the actual boxed #GType to ensure that the instance owned by #JSCClass is used.
/// If you really want to return a new copy of the boxed type, use #JSC_TYPE_VALUE and return a #JSCValue created
/// with jsc_value_new_object() that receives the copy as the instance parameter.
/// </para>
/// </summary>

/// <param name="jsc_class">
/// a #JSCClass
/// </param>
/// <param name="name">
/// the property name
/// </param>
/// <param name="property_type">
/// the #GType of the property value
/// </param>
/// <param name="getter">
/// a #GCallback to be called to get the property value
/// </param>
/// <param name="setter">
/// a #GCallback to be called to set the property value
/// </param>
/// <param name="user_data">
/// user data to pass to @getter and @setter
/// </param>
/// <param name="destroy_notify">
/// destroy notifier for @user_data
/// </param>

	public static T AddProperty<T>(this T jsc_class, string name, MentorLake.GObject.GType property_type, MentorLake.GObject.GCallback getter, MentorLake.GObject.GCallback setter, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify) where T : JSCClassHandle
	{
		if (jsc_class.IsInvalid) throw new Exception("Invalid handle (JSCClassHandle)");
		JSCClassHandleExterns.jsc_class_add_property(jsc_class, name, property_type, getter, setter, user_data, destroy_notify);
		return jsc_class;
	}

/// <summary>
/// <para>
/// Get the class name of @jsc_class
/// </para>
/// </summary>

/// <param name="jsc_class">
/// a @JSCClass
/// </param>
/// <return>
/// the name of @jsc_class
/// </return>

	public static string GetName(this MentorLake.JavaScriptCore.JSCClassHandle jsc_class)
	{
		if (jsc_class.IsInvalid) throw new Exception("Invalid handle (JSCClassHandle)");
		return JSCClassHandleExterns.jsc_class_get_name(jsc_class);
	}

/// <summary>
/// <para>
/// Get the parent class of @jsc_class
/// </para>
/// </summary>

/// <param name="jsc_class">
/// a @JSCClass
/// </param>
/// <return>
/// the parent class of @jsc_class
/// </return>

	public static MentorLake.JavaScriptCore.JSCClassHandle GetParent(this MentorLake.JavaScriptCore.JSCClassHandle jsc_class)
	{
		if (jsc_class.IsInvalid) throw new Exception("Invalid handle (JSCClassHandle)");
		return JSCClassHandleExterns.jsc_class_get_parent(jsc_class);
	}

}

internal class JSCClassHandleExterns
{
	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_class_add_constructor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCClassHandle>))] MentorLake.JavaScriptCore.JSCClassHandle jsc_class, string name, MentorLake.GObject.GCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify, MentorLake.GObject.GType return_type, uint n_params, IntPtr @__arglist);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_class_add_constructor_variadic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCClassHandle>))] MentorLake.JavaScriptCore.JSCClassHandle jsc_class, string name, MentorLake.GObject.GCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify, MentorLake.GObject.GType return_type);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_class_add_constructorv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCClassHandle>))] MentorLake.JavaScriptCore.JSCClassHandle jsc_class, string name, MentorLake.GObject.GCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify, MentorLake.GObject.GType return_type, uint n_parameters, MentorLake.GObject.GType[] parameter_types);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern void jsc_class_add_method([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCClassHandle>))] MentorLake.JavaScriptCore.JSCClassHandle jsc_class, string name, MentorLake.GObject.GCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify, MentorLake.GObject.GType return_type, uint n_params, IntPtr @__arglist);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern void jsc_class_add_method_variadic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCClassHandle>))] MentorLake.JavaScriptCore.JSCClassHandle jsc_class, string name, MentorLake.GObject.GCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify, MentorLake.GObject.GType return_type);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern void jsc_class_add_methodv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCClassHandle>))] MentorLake.JavaScriptCore.JSCClassHandle jsc_class, string name, MentorLake.GObject.GCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify, MentorLake.GObject.GType return_type, uint n_parameters, MentorLake.GObject.GType[] parameter_types);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern void jsc_class_add_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCClassHandle>))] MentorLake.JavaScriptCore.JSCClassHandle jsc_class, string name, MentorLake.GObject.GType property_type, MentorLake.GObject.GCallback getter, MentorLake.GObject.GCallback setter, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string jsc_class_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCClassHandle>))] MentorLake.JavaScriptCore.JSCClassHandle jsc_class);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCClassHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCClassHandle jsc_class_get_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCClassHandle>))] MentorLake.JavaScriptCore.JSCClassHandle jsc_class);

}
