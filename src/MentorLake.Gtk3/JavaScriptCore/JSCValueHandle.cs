namespace MentorLake.JavaScriptCore;

/// <summary>
/// <para>
/// JSCValue represents a reference to a value in a #JSCContext. The JSCValue
/// protects the referenced value from being garbage collected.
/// </para>
/// </summary>

public class JSCValueHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Create a new #JSCValue referencing an array with the given items. If @first_item_type
/// is %G_TYPE_NONE an empty array is created.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="first_item_type">
/// #GType of first item, or %G_TYPE_NONE
/// </param>
/// <param name="@__arglist">
/// value of the first item, followed optionally by more type/value pairs, followed by %G_TYPE_NONE.
/// </param>
/// <return>
/// a #JSCValue.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle NewArray(MentorLake.JavaScriptCore.JSCContextHandle context, MentorLake.GObject.GType first_item_type, IntPtr @__arglist)
	{
		return JSCValueHandleExterns.jsc_value_new_array(context, first_item_type, @__arglist);
	}

/// <summary>
/// <para>
/// Creates a new %ArrayBuffer from existing @data in memory.
/// </para>
/// <para>
/// The @data is not copied: while this allows sharing data with JavaScript
/// efficiently, the caller must ensure that the memory region remains valid
/// until the newly created object is released by JSC.
/// </para>
/// <para>
/// Optionally, a @destroy_notify callback can be provided, which will be
/// invoked with @user_data as parameter when the %ArrayBuffer object is
/// released. This is intended to be used for freeing resources related to
/// the memory region which contains the data:
/// </para>
/// <code>
/// GMappedFile *f = g_mapped_file_new (file_path, TRUE, NULL);
/// GMappedFile *f = g_mapped_file_new (file_path, TRUE, NULL);
/// JSCValue *value = jsc_value_new_array_buffer (context,
///     g_mapped_file_get_contents (f), g_mapped_file_get_length (f),
///     (GDestroyNotify) g_mapped_file_unref, f);
/// </code>
/// <para>
/// Note that the @user_data can be the same value as @data:
/// </para>
/// <code>
/// void *bytes = g_malloc0 (100);
/// void *bytes = g_malloc0 (100);
/// JSCValue *value = jsc_value_new_array_buffer (context, bytes, 100, g_free, bytes);
/// </code>
/// </summary>

/// <param name="context">
/// A #JSCContext
/// </param>
/// <param name="data">
/// Pointer to a region of memory.
/// </param>
/// <param name="size">
/// Size in bytes of the memory region.
/// </param>
/// <param name="destroy_notify">
/// destroy notifier for @user_data.
/// </param>
/// <param name="user_data">
/// user data.
/// </param>
/// <return>
/// A #JSCValue, or %NULL in case of exception.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle NewArrayBuffer(MentorLake.JavaScriptCore.JSCContextHandle context, IntPtr data, UIntPtr size, MentorLake.GLib.GDestroyNotify destroy_notify, IntPtr user_data)
	{
		return JSCValueHandleExterns.jsc_value_new_array_buffer(context, data, size, destroy_notify, user_data);
	}

/// <summary>
/// <para>
/// Create a new #JSCValue referencing an array with the items from @array. If @array
/// is %NULL or empty a new empty array will be created. Elements of @array should be
/// pointers to a #JSCValue.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="array">
/// a #GPtrArray
/// </param>
/// <return>
/// a #JSCValue.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle NewArrayFromGarray(MentorLake.JavaScriptCore.JSCContextHandle context, MentorLake.GLib.GPtrArrayHandle array)
	{
		return JSCValueHandleExterns.jsc_value_new_array_from_garray(context, array);
	}

/// <summary>
/// <para>
/// Create a new #JSCValue referencing an array of strings with the items from @strv. If @array
/// is %NULL or empty a new empty array will be created.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="strv">
/// a %NULL-terminated array of strings
/// </param>
/// <return>
/// a #JSCValue.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle NewArrayFromStrv(MentorLake.JavaScriptCore.JSCContextHandle context, string[] strv)
	{
		return JSCValueHandleExterns.jsc_value_new_array_from_strv(context, strv);
	}

/// <summary>
/// <para>
/// Create a new #JSCValue from @value
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="value">
/// a #gboolean
/// </param>
/// <return>
/// a #JSCValue.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle NewBoolean(MentorLake.JavaScriptCore.JSCContextHandle context, bool value)
	{
		return JSCValueHandleExterns.jsc_value_new_boolean(context, value);
	}

/// <summary>
/// <para>
/// Create a new #JSCValue referencing a new value created by parsing @json.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="json">
/// the JSON string to be parsed
/// </param>
/// <return>
/// a #JSCValue.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle NewFromJson(MentorLake.JavaScriptCore.JSCContextHandle context, string json)
	{
		return JSCValueHandleExterns.jsc_value_new_from_json(context, json);
	}

/// <summary>
/// <para>
/// Create a function in @context. If @name is %NULL an anonymous function will be created.
/// When the function is called by JavaScript or jsc_value_function_call(), @callback is called
/// receiving the function parameters and then @user_data as last parameter. When the function is
/// cleared in @context, @destroy_notify is called with @user_data as parameter.
/// </para>
/// <para>
/// Note that the value returned by @callback must be fully transferred. In case of boxed types, you could use
/// %G_TYPE_POINTER instead of the actual boxed #GType to ensure that the instance owned by #JSCClass is used.
/// If you really want to return a new copy of the boxed type, use #JSC_TYPE_VALUE and return a #JSCValue created
/// with jsc_value_new_object() that receives the copy as instance parameter.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext:
/// </param>
/// <param name="name">
/// the function name or %NULL
/// </param>
/// <param name="callback">
/// a #GCallback.
/// </param>
/// <param name="user_data">
/// user data to pass to @callback.
/// </param>
/// <param name="destroy_notify">
/// destroy notifier for @user_data
/// </param>
/// <param name="return_type">
/// the #GType of the function return value, or %G_TYPE_NONE if the function is void.
/// </param>
/// <param name="n_params">
/// the number of parameter types to follow or 0 if the function doesn&apos;t receive parameters.
/// </param>
/// <param name="@__arglist">
/// a list of #GType&amp;lt;!-- --&amp;gt;s, one for each parameter.
/// </param>
/// <return>
/// a #JSCValue.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle NewFunction(MentorLake.JavaScriptCore.JSCContextHandle context, string name, MentorLake.GObject.GCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify, MentorLake.GObject.GType return_type, uint n_params, IntPtr @__arglist)
	{
		return JSCValueHandleExterns.jsc_value_new_function(context, name, callback, user_data, destroy_notify, return_type, n_params, @__arglist);
	}

/// <summary>
/// <para>
/// Create a function in @context. If @name is %NULL an anonymous function will be created.
/// When the function is called by JavaScript or jsc_value_function_call(), @callback is called
/// receiving an #GPtrArray of #JSCValue&amp;lt;!-- --&amp;gt;s with the arguments and then @user_data as last parameter.
/// When the function is cleared in @context, @destroy_notify is called with @user_data as parameter.
/// </para>
/// <para>
/// Note that the value returned by @callback must be fully transferred. In case of boxed types, you could use
/// %G_TYPE_POINTER instead of the actual boxed #GType to ensure that the instance owned by #JSCClass is used.
/// If you really want to return a new copy of the boxed type, use #JSC_TYPE_VALUE and return a #JSCValue created
/// with jsc_value_new_object() that receives the copy as instance parameter.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="name">
/// the function name or %NULL
/// </param>
/// <param name="callback">
/// a #GCallback.
/// </param>
/// <param name="user_data">
/// user data to pass to @callback.
/// </param>
/// <param name="destroy_notify">
/// destroy notifier for @user_data
/// </param>
/// <param name="return_type">
/// the #GType of the function return value, or %G_TYPE_NONE if the function is void.
/// </param>
/// <return>
/// a #JSCValue.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle NewFunctionVariadic(MentorLake.JavaScriptCore.JSCContextHandle context, string name, MentorLake.GObject.GCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify, MentorLake.GObject.GType return_type)
	{
		return JSCValueHandleExterns.jsc_value_new_function_variadic(context, name, callback, user_data, destroy_notify, return_type);
	}

/// <summary>
/// <para>
/// Create a function in @context. If @name is %NULL an anonymous function will be created.
/// When the function is called by JavaScript or jsc_value_function_call(), @callback is called
/// receiving the function parameters and then @user_data as last parameter. When the function is
/// cleared in @context, @destroy_notify is called with @user_data as parameter.
/// </para>
/// <para>
/// Note that the value returned by @callback must be fully transferred. In case of boxed types, you could use
/// %G_TYPE_POINTER instead of the actual boxed #GType to ensure that the instance owned by #JSCClass is used.
/// If you really want to return a new copy of the boxed type, use #JSC_TYPE_VALUE and return a #JSCValue created
/// with jsc_value_new_object() that receives the copy as instance parameter.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="name">
/// the function name or %NULL
/// </param>
/// <param name="callback">
/// a #GCallback.
/// </param>
/// <param name="user_data">
/// user data to pass to @callback.
/// </param>
/// <param name="destroy_notify">
/// destroy notifier for @user_data
/// </param>
/// <param name="return_type">
/// the #GType of the function return value, or %G_TYPE_NONE if the function is void.
/// </param>
/// <param name="n_parameters">
/// the number of parameters
/// </param>
/// <param name="parameter_types">
/// a list of #GType&amp;lt;!-- --&amp;gt;s, one for each parameter, or %NULL
/// </param>
/// <return>
/// a #JSCValue.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle NewFunctionv(MentorLake.JavaScriptCore.JSCContextHandle context, string name, MentorLake.GObject.GCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify, MentorLake.GObject.GType return_type, uint n_parameters, MentorLake.GObject.GType[] parameter_types)
	{
		return JSCValueHandleExterns.jsc_value_new_functionv(context, name, callback, user_data, destroy_notify, return_type, n_parameters, parameter_types);
	}

/// <summary>
/// <para>
/// Create a new #JSCValue referencing &amp;lt;function&amp;gt;null&amp;lt;/function&amp;gt; in @context.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <return>
/// a #JSCValue.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle NewNull(MentorLake.JavaScriptCore.JSCContextHandle context)
	{
		return JSCValueHandleExterns.jsc_value_new_null(context);
	}

/// <summary>
/// <para>
/// Create a new #JSCValue from @number.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="number">
/// a number
/// </param>
/// <return>
/// a #JSCValue.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle NewNumber(MentorLake.JavaScriptCore.JSCContextHandle context, double number)
	{
		return JSCValueHandleExterns.jsc_value_new_number(context, number);
	}

/// <summary>
/// <para>
/// Create a new #JSCValue from @instance. If @instance is %NULL a new empty object is created.
/// When @instance is provided, @jsc_class must be provided too. @jsc_class takes ownership of
/// @instance that will be freed by the #GDestroyNotify passed to jsc_context_register_class().
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="instance">
/// an object instance or %NULL
/// </param>
/// <param name="jsc_class">
/// the #JSCClass of @instance
/// </param>
/// <return>
/// a #JSCValue.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle NewObject(MentorLake.JavaScriptCore.JSCContextHandle context, IntPtr instance, MentorLake.JavaScriptCore.JSCClassHandle jsc_class)
	{
		return JSCValueHandleExterns.jsc_value_new_object(context, instance, jsc_class);
	}

/// <summary>
/// <para>
/// Creates a new Promise. @executor will be invoked during promise initialization
/// and it receives the @resolve and @reject objects than can be called to resolve
/// or reject the promise. It is called like a JavaScript function, so exceptions raised
/// during the executor invocation will not be propagated to the context, but
/// handled by the promise causing a rejection.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="executor">
/// an initialization callback
/// </param>
/// <param name="user_data">
/// user data passed in @executor
/// </param>
/// <return>
/// a deferred promise object
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle NewPromise(MentorLake.JavaScriptCore.JSCContextHandle context, MentorLake.JavaScriptCore.JSCExecutor executor, IntPtr user_data)
	{
		return JSCValueHandleExterns.jsc_value_new_promise(context, executor, user_data);
	}

/// <summary>
/// <para>
/// Create a new #JSCValue from @string. If you need to create a #JSCValue from a
/// string containing null characters, use jsc_value_new_string_from_bytes() instead.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="@string">
/// a null-terminated string
/// </param>
/// <return>
/// a #JSCValue.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle NewString(MentorLake.JavaScriptCore.JSCContextHandle context, string @string)
	{
		return JSCValueHandleExterns.jsc_value_new_string(context, @string);
	}

/// <summary>
/// <para>
/// Create a new #JSCValue from @bytes.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="bytes">
/// a #GBytes
/// </param>
/// <return>
/// a #JSCValue.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle NewStringFromBytes(MentorLake.JavaScriptCore.JSCContextHandle context, MentorLake.GLib.GBytesHandle bytes)
	{
		return JSCValueHandleExterns.jsc_value_new_string_from_bytes(context, bytes);
	}

/// <summary>
/// <para>
/// Create a new typed array containing a given amount of elements.
/// </para>
/// <para>
/// Create a #JSCValue referencing a new typed array with space for @length
/// elements of a given @type. As all typed arrays must have an associated
/// `ArrayBuffer`, a new one of suitable size will be allocated to store
/// the elements, which will be initialized to zero.
/// </para>
/// <para>
/// The @type must *not* be %JSC_TYPED_ARRAY_NONE.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="type">
/// the type of array elements
/// </param>
/// <param name="length">
/// number of elements in the array
/// </param>
/// <return>
/// a #JSCValue
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle NewTypedArray(MentorLake.JavaScriptCore.JSCContextHandle context, MentorLake.JavaScriptCore.JSCTypedArrayType type, UIntPtr length)
	{
		return JSCValueHandleExterns.jsc_value_new_typed_array(context, type, length);
	}

/// <summary>
/// <para>
/// Create a new #JSCValue referencing &amp;lt;function&amp;gt;undefined&amp;lt;/function&amp;gt; in @context.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <return>
/// a #JSCValue.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle NewUndefined(MentorLake.JavaScriptCore.JSCContextHandle context)
	{
		return JSCValueHandleExterns.jsc_value_new_undefined(context);
	}

}

public static class JSCValueHandleExtensions
{
/// <summary>
/// <para>
/// Gets a pointer to memory that contains the array buffer data.
/// </para>
/// <para>
/// Obtains a pointer to the memory region that holds the contents of the
/// %ArrayBuffer; modifications done to the data will be visible to JavaScript
/// code. If @size is not %NULL, the size in bytes of the memory region
/// will also be stored in the pointed location.
/// </para>
/// <para>
/// Note that the pointer returned by this function is not guaranteed to remain
/// the same after calls to other JSC API functions. If you plan to access the
/// data of the %ArrayBuffer later, you can keep a reference to the @value and
/// obtain the data pointer at a later point. Keep in mind that if JavaScript
/// code has a chance to run, for example due to main loop events that result
/// in JSC being called, the contents of the memory region might be modified in
/// the meantime. Consider taking a copy of the data and using the copy instead
/// in asynchronous code.
/// </para>
/// </summary>

/// <param name="value">
/// A #JSCValue
/// </param>
/// <param name="size">
/// location where to store the size of the memory region.
/// </param>
/// <return>
/// 
///   pointer to memory.
/// </return>

	public static byte[] ArrayBufferGetData(this MentorLake.JavaScriptCore.JSCValueHandle value, out UIntPtr size)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_array_buffer_get_data(value, out size);
	}

/// <summary>
/// <para>
/// Gets the size in bytes of the array buffer.
/// </para>
/// <para>
/// Obtains the size in bytes of the memory region that holds the contents of
/// an %ArrayBuffer.
/// </para>
/// </summary>

/// <param name="value">
/// A #JSCValue
/// </param>
/// <return>
/// size, in bytes.
/// </return>

	public static UIntPtr ArrayBufferGetSize(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_array_buffer_get_size(value);
	}

/// <summary>
/// <para>
/// Invoke &amp;lt;function&amp;gt;new&amp;lt;/function&amp;gt; with constructor referenced by @value. If @first_parameter_type
/// is %G_TYPE_NONE no parameters will be passed to the constructor.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <param name="first_parameter_type">
/// #GType of first parameter, or %G_TYPE_NONE
/// </param>
/// <param name="@__arglist">
/// value of the first parameter, followed optionally by more type/value pairs, followed by %G_TYPE_NONE
/// </param>
/// <return>
/// a #JSCValue referencing the newly created object instance.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle ConstructorCall(this MentorLake.JavaScriptCore.JSCValueHandle value, MentorLake.GObject.GType first_parameter_type, IntPtr @__arglist)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_constructor_call(value, first_parameter_type, @__arglist);
	}

/// <summary>
/// <para>
/// Invoke &amp;lt;function&amp;gt;new&amp;lt;/function&amp;gt; with constructor referenced by @value. If @n_parameters
/// is 0 no parameters will be passed to the constructor.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <param name="n_parameters">
/// the number of parameters
/// </param>
/// <param name="parameters">
/// the #JSCValue&amp;lt;!-- --&amp;gt;s to pass as parameters to the constructor, or %NULL
/// </param>
/// <return>
/// a #JSCValue referencing the newly created object instance.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle ConstructorCallv(this MentorLake.JavaScriptCore.JSCValueHandle value, uint n_parameters, MentorLake.JavaScriptCore.JSCValueHandle[] parameters)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_constructor_callv(value, n_parameters, parameters);
	}

/// <summary>
/// <para>
/// Call function referenced by @value, passing the given parameters. If @first_parameter_type
/// is %G_TYPE_NONE no parameters will be passed to the function.
/// </para>
/// <para>
/// This function always returns a #JSCValue, in case of void functions a #JSCValue referencing
/// &amp;lt;function&amp;gt;undefined&amp;lt;/function&amp;gt; is returned
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <param name="first_parameter_type">
/// #GType of first parameter, or %G_TYPE_NONE
/// </param>
/// <param name="@__arglist">
/// value of the first parameter, followed optionally by more type/value pairs, followed by %G_TYPE_NONE
/// </param>
/// <return>
/// a #JSCValue with the return value of the function.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle FunctionCall(this MentorLake.JavaScriptCore.JSCValueHandle value, MentorLake.GObject.GType first_parameter_type, IntPtr @__arglist)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_function_call(value, first_parameter_type, @__arglist);
	}

/// <summary>
/// <para>
/// Call function referenced by @value, passing the given @parameters. If @n_parameters
/// is 0 no parameters will be passed to the function.
/// </para>
/// <para>
/// This function always returns a #JSCValue, in case of void functions a #JSCValue referencing
/// &amp;lt;function&amp;gt;undefined&amp;lt;/function&amp;gt; is returned
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <param name="n_parameters">
/// the number of parameters
/// </param>
/// <param name="parameters">
/// the #JSCValue&amp;lt;!-- --&amp;gt;s to pass as parameters to the function, or %NULL
/// </param>
/// <return>
/// a #JSCValue with the return value of the function.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle FunctionCallv(this MentorLake.JavaScriptCore.JSCValueHandle value, uint n_parameters, MentorLake.JavaScriptCore.JSCValueHandle[] parameters)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_function_callv(value, n_parameters, parameters);
	}

/// <summary>
/// <para>
/// Get the #JSCContext in which @value was created.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// the #JSCValue context.
/// </return>

	public static MentorLake.JavaScriptCore.JSCContextHandle GetContext(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_get_context(value);
	}

/// <summary>
/// <para>
/// Get whether the value referenced by @value is an array.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// whether the value is an array.
/// </return>

	public static bool IsArray(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_is_array(value);
	}

/// <summary>
/// <para>
/// Check whether the @value is an %ArrayBuffer.
/// </para>
/// </summary>

/// <param name="value">
/// A #JSCValue.
/// </param>
/// <return>
/// whether the value is an %ArrayBuffer
/// </return>

	public static bool IsArrayBuffer(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_is_array_buffer(value);
	}

/// <summary>
/// <para>
/// Get whether the value referenced by @value is a boolean.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// whether the value is a boolean.
/// </return>

	public static bool IsBoolean(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_is_boolean(value);
	}

/// <summary>
/// <para>
/// Get whether the value referenced by @value is a constructor.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// whether the value is a constructor.
/// </return>

	public static bool IsConstructor(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_is_constructor(value);
	}

/// <summary>
/// <para>
/// Get whether the value referenced by @value is a function
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// whether the value is a function.
/// </return>

	public static bool IsFunction(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_is_function(value);
	}

/// <summary>
/// <para>
/// Get whether the value referenced by @value is &amp;lt;function&amp;gt;null&amp;lt;/function&amp;gt;.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// whether the value is null.
/// </return>

	public static bool IsNull(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_is_null(value);
	}

/// <summary>
/// <para>
/// Get whether the value referenced by @value is a number.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// whether the value is a number.
/// </return>

	public static bool IsNumber(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_is_number(value);
	}

/// <summary>
/// <para>
/// Get whether the value referenced by @value is an object.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// whether the value is an object.
/// </return>

	public static bool IsObject(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_is_object(value);
	}

/// <summary>
/// <para>
/// Get whether the value referenced by @value is a string
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// whether the value is a string
/// </return>

	public static bool IsString(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_is_string(value);
	}

/// <summary>
/// <para>
/// Determines whether a value is a typed array.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// Whether @value is a typed array.
/// </return>

	public static bool IsTypedArray(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_is_typed_array(value);
	}

/// <summary>
/// <para>
/// Get whether the value referenced by @value is &amp;lt;function&amp;gt;undefined&amp;lt;/function&amp;gt;.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// whether the value is undefined.
/// </return>

	public static bool IsUndefined(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_is_undefined(value);
	}

/// <summary>
/// <para>
/// Create a new typed array value with elements from an array buffer.
/// </para>
/// <para>
/// Create a #JSCValue referencing a new typed array value containing
/// elements of the given @type, where the elements are stored at the memory
/// region represented by the @array_buffer.
/// </para>
/// <para>
/// The @type must *not* be %JSC_TYPED_ARRAY_NONE.
/// </para>
/// <para>
/// The @offset and @length parameters can be used to indicate which part of
/// the array buffer can be accessed through the typed array. If both are
/// omitted (passing zero as @offset, and `-1` as @length), the whole
/// @array_buffer is exposed through the typed array. Omitting the @length
/// with a non-zero @offset will expose the remainder of the @array_buffer
/// starting at the indicated offset.
/// </para>
/// </summary>

/// <param name="array_buffer">
/// a #JSCValue.
/// </param>
/// <param name="type">
/// type of array elements.
/// </param>
/// <param name="offset">
/// offset, in bytes.
/// </param>
/// <param name="length">
/// number of array elements, or `-1`.
/// </param>
/// <return>
/// a #JSCValue
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle NewTypedArrayWithBuffer(this MentorLake.JavaScriptCore.JSCValueHandle array_buffer, MentorLake.JavaScriptCore.JSCTypedArrayType type, UIntPtr offset, UIntPtr length)
	{
		if (array_buffer.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_new_typed_array_with_buffer(array_buffer, type, offset, length);
	}

/// <summary>
/// <para>
/// Define or modify a property with @property_name in object referenced by @value. When the
/// property value is read or set, @getter and @setter callbacks will be called.
/// When the property is cleared in the #JSCClass context, @destroy_notify is called with
/// @user_data as parameter. This is equivalent to JavaScript &amp;lt;function&amp;gt;Object.defineProperty()&amp;lt;/function&amp;gt;
/// when used with an accessor descriptor.
/// </para>
/// <para>
/// Note that the value returned by @getter must be fully transferred. In case of boxed types, you could use
/// %G_TYPE_POINTER instead of the actual boxed #GType to ensure that the instance owned by #JSCClass is used.
/// If you really want to return a new copy of the boxed type, use #JSC_TYPE_VALUE and return a #JSCValue created
/// with jsc_value_new_object() that receives the copy as instance parameter.
/// </para>
/// <para>
/// Note that @getter and @setter are called as functions and not methods, so they don&apos;t receive an instance as
/// first parameter. Use jsc_class_add_property() if you want to add property accessor invoked as a method.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <param name="property_name">
/// the name of the property to define
/// </param>
/// <param name="flags">
/// #JSCValuePropertyFlags
/// </param>
/// <param name="property_type">
/// the #GType of the property
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

	public static T ObjectDefinePropertyAccessor<T>(this T value, string property_name, MentorLake.JavaScriptCore.JSCValuePropertyFlags flags, MentorLake.GObject.GType property_type, MentorLake.GObject.GCallback getter, MentorLake.GObject.GCallback setter, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify) where T : JSCValueHandle
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		JSCValueHandleExterns.jsc_value_object_define_property_accessor(value, property_name, flags, property_type, getter, setter, user_data, destroy_notify);
		return value;
	}

/// <summary>
/// <para>
/// Define or modify a property with @property_name in object referenced by @value. This is equivalent to
/// JavaScript &amp;lt;function&amp;gt;Object.defineProperty()&amp;lt;/function&amp;gt; when used with a data descriptor.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <param name="property_name">
/// the name of the property to define
/// </param>
/// <param name="flags">
/// #JSCValuePropertyFlags
/// </param>
/// <param name="property_value">
/// the default property value
/// </param>

	public static T ObjectDefinePropertyData<T>(this T value, string property_name, MentorLake.JavaScriptCore.JSCValuePropertyFlags flags, MentorLake.JavaScriptCore.JSCValueHandle property_value) where T : JSCValueHandle
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		JSCValueHandleExterns.jsc_value_object_define_property_data(value, property_name, flags, property_value);
		return value;
	}

/// <summary>
/// <para>
/// Try to delete property with @name from @value. This function will return %FALSE if
/// the property was defined without %JSC_VALUE_PROPERTY_CONFIGURABLE flag.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <param name="name">
/// the property name
/// </param>
/// <return>
/// %TRUE if the property was deleted, or %FALSE otherwise.
/// </return>

	public static bool ObjectDeleteProperty(this MentorLake.JavaScriptCore.JSCValueHandle value, string name)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_object_delete_property(value, name);
	}

/// <summary>
/// <para>
/// Get the list of property names of @value. Only properties defined with %JSC_VALUE_PROPERTY_ENUMERABLE
/// flag will be collected.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// a %NULL-terminated array of strings containing the
///    property names, or %NULL if @value doesn&apos;t have enumerable properties.  Use g_strfreev() to free.
/// </return>

	public static string[] ObjectEnumerateProperties(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_object_enumerate_properties(value);
	}

/// <summary>
/// <para>
/// Get property with @name from @value.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <param name="name">
/// the property name
/// </param>
/// <return>
/// the property #JSCValue.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle ObjectGetProperty(this MentorLake.JavaScriptCore.JSCValueHandle value, string name)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_object_get_property(value, name);
	}

/// <summary>
/// <para>
/// Get property at @index from @value.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <param name="index">
/// the property index
/// </param>
/// <return>
/// the property #JSCValue.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle ObjectGetPropertyAtIndex(this MentorLake.JavaScriptCore.JSCValueHandle value, uint index)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_object_get_property_at_index(value, index);
	}

/// <summary>
/// <para>
/// Get whether @value has property with @name.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <param name="name">
/// the property name
/// </param>
/// <return>
/// %TRUE if @value has a property with @name, or %FALSE otherwise
/// </return>

	public static bool ObjectHasProperty(this MentorLake.JavaScriptCore.JSCValueHandle value, string name)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_object_has_property(value, name);
	}

/// <summary>
/// <para>
/// Invoke method with @name on object referenced by @value, passing the given parameters. If
/// @first_parameter_type is %G_TYPE_NONE no parameters will be passed to the method.
/// The object instance will be handled automatically even when the method is a custom one
/// registered with jsc_class_add_method(), so it should never be passed explicitly as parameter
/// of this function.
/// </para>
/// <para>
/// This function always returns a #JSCValue, in case of void methods a #JSCValue referencing
/// &amp;lt;function&amp;gt;undefined&amp;lt;/function&amp;gt; is returned.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <param name="name">
/// the method name
/// </param>
/// <param name="first_parameter_type">
/// #GType of first parameter, or %G_TYPE_NONE
/// </param>
/// <param name="@__arglist">
/// value of the first parameter, followed optionally by more type/value pairs, followed by %G_TYPE_NONE
/// </param>
/// <return>
/// a #JSCValue with the return value of the method.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle ObjectInvokeMethod(this MentorLake.JavaScriptCore.JSCValueHandle value, string name, MentorLake.GObject.GType first_parameter_type, IntPtr @__arglist)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_object_invoke_method(value, name, first_parameter_type, @__arglist);
	}

/// <summary>
/// <para>
/// Invoke method with @name on object referenced by @value, passing the given @parameters. If
/// @n_parameters is 0 no parameters will be passed to the method.
/// The object instance will be handled automatically even when the method is a custom one
/// registered with jsc_class_add_method(), so it should never be passed explicitly as parameter
/// of this function.
/// </para>
/// <para>
/// This function always returns a #JSCValue, in case of void methods a #JSCValue referencing
/// &amp;lt;function&amp;gt;undefined&amp;lt;/function&amp;gt; is returned.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <param name="name">
/// the method name
/// </param>
/// <param name="n_parameters">
/// the number of parameters
/// </param>
/// <param name="parameters">
/// the #JSCValue&amp;lt;!-- --&amp;gt;s to pass as parameters to the method, or %NULL
/// </param>
/// <return>
/// a #JSCValue with the return value of the method.
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle ObjectInvokeMethodv(this MentorLake.JavaScriptCore.JSCValueHandle value, string name, uint n_parameters, MentorLake.JavaScriptCore.JSCValueHandle[] parameters)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_object_invoke_methodv(value, name, n_parameters, parameters);
	}

/// <summary>
/// <para>
/// Get whether the value referenced by @value is an instance of class @name.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <param name="name">
/// a class name
/// </param>
/// <return>
/// whether the value is an object instance of class @name.
/// </return>

	public static bool ObjectIsInstanceOf(this MentorLake.JavaScriptCore.JSCValueHandle value, string name)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_object_is_instance_of(value, name);
	}

/// <summary>
/// <para>
/// Set @property with @name on @value.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <param name="name">
/// the property name
/// </param>
/// <param name="property">
/// the #JSCValue to set
/// </param>

	public static T ObjectSetProperty<T>(this T value, string name, MentorLake.JavaScriptCore.JSCValueHandle property) where T : JSCValueHandle
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		JSCValueHandleExterns.jsc_value_object_set_property(value, name, property);
		return value;
	}

/// <summary>
/// <para>
/// Set @property at @index on @value.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <param name="index">
/// the property index
/// </param>
/// <param name="property">
/// the #JSCValue to set
/// </param>

	public static T ObjectSetPropertyAtIndex<T>(this T value, uint index, MentorLake.JavaScriptCore.JSCValueHandle property) where T : JSCValueHandle
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		JSCValueHandleExterns.jsc_value_object_set_property_at_index(value, index, property);
		return value;
	}

/// <summary>
/// <para>
/// Convert @value to a boolean.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// a #gboolean result of the conversion.
/// </return>

	public static bool ToBoolean(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_to_boolean(value);
	}

/// <summary>
/// <para>
/// Convert @value to a double.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// a #gdouble result of the conversion.
/// </return>

	public static double ToDouble(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_to_double(value);
	}

/// <summary>
/// <para>
/// Convert @value to a #gint32.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// a #gint32 result of the conversion.
/// </return>

	public static int ToInt32(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_to_int32(value);
	}

/// <summary>
/// <para>
/// Create a JSON string of @value serialization. If @indent is 0, the resulting JSON will
/// not contain newlines. The size of the indent is clamped to 10 spaces.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <param name="indent">
/// The number of spaces to indent when nesting.
/// </param>
/// <return>
/// a null-terminated JSON string with serialization of @value
/// </return>

	public static string ToJson(this MentorLake.JavaScriptCore.JSCValueHandle value, uint indent)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_to_json(value, indent);
	}

/// <summary>
/// <para>
/// Convert @value to a string. Use jsc_value_to_string_as_bytes() instead, if you need to
/// handle strings containing null characters.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// a null-terminated string result of the conversion.
/// </return>

	public static string ToString(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_to_string(value);
	}

/// <summary>
/// <para>
/// Convert @value to a string and return the results as #GBytes. This is needed
/// to handle strings with null characters.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// a #GBytes with the result of the conversion.
/// </return>

	public static MentorLake.GLib.GBytesHandle ToStringAsBytes(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_to_string_as_bytes(value);
	}

/// <summary>
/// <para>
/// Obtain the %ArrayBuffer for the memory region of the typed array elements.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// A #JSCValue
/// </return>

	public static MentorLake.JavaScriptCore.JSCValueHandle TypedArrayGetBuffer(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_typed_array_get_buffer(value);
	}

/// <summary>
/// <para>
/// Obtains a pointer to the memory region that holds the elements of the typed
/// array; modifications done to them will be visible to JavaScript code. If
/// @length is not %NULL, the number of elements contained in the typed array
/// are also stored in the pointed location.
/// </para>
/// <para>
/// The returned pointer needs to be casted to the appropriate type (see
/// #JSCTypedArrayType), and has the `offset` over the underlying array
/// buffer data applied—that is, points to the first element of the typed
/// array:
/// </para>
/// <code>
/// if (jsc_value_typed_array_get_type(value) != JSC_TYPED_ARRAY_UINT32)
/// if (jsc_value_typed_array_get_type(value) != JSC_TYPED_ARRAY_UINT32)
///     g_error (&quot;Only arrays of uint32_t are supported&quot;);
/// 
/// gsize count = 0;
/// uint32_t *elements = jsc_value_typed_array_get_contents (value, &amp;count);
/// for (gsize i = 0; i &amp;lt; count; i++)
///      g_print (&quot;index %zu, value %&quot; PRIu32 &quot;\n&quot;, i, elements[i]);
/// </code>
/// <para>
/// Note that the pointer returned by this function is not guaranteed to remain
/// the same after calls to other JSC API functions. See
/// jsc_value_array_buffer_get_data() for details.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <param name="length">
/// location to return the number of elements contained
/// </param>
/// <return>
/// pointer to memory.
/// </return>

	public static IntPtr TypedArrayGetData(this MentorLake.JavaScriptCore.JSCValueHandle value, out UIntPtr length)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_typed_array_get_data(value, out length);
	}

/// <summary>
/// <para>
/// Gets the number of elements in a typed array.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// number of elements.
/// </return>

	public static UIntPtr TypedArrayGetLength(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_typed_array_get_length(value);
	}

/// <summary>
/// <para>
/// Gets the offset over the underlying array buffer data.
/// </para>
/// </summary>

/// <param name="value">
/// A #JSCValue
/// </param>
/// <return>
/// offset, in bytes.
/// </return>

	public static UIntPtr TypedArrayGetOffset(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_typed_array_get_offset(value);
	}

/// <summary>
/// <para>
/// Gets the size of a typed array.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// size, in bytes.
/// </return>

	public static UIntPtr TypedArrayGetSize(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_typed_array_get_size(value);
	}

/// <summary>
/// <para>
/// Gets the type of elements contained in a typed array.
/// </para>
/// </summary>

/// <param name="value">
/// a #JSCValue
/// </param>
/// <return>
/// type of the elements, or %JSC_TYPED_ARRAY_NONE if @value is not a typed array.
/// </return>

	public static MentorLake.JavaScriptCore.JSCTypedArrayType TypedArrayGetType(this MentorLake.JavaScriptCore.JSCValueHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (JSCValueHandle)");
		return JSCValueHandleExterns.jsc_value_typed_array_get_type(value);
	}

}

internal class JSCValueHandleExterns
{
	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_new_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, MentorLake.GObject.GType first_item_type, IntPtr @__arglist);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_new_array_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, IntPtr data, UIntPtr size, MentorLake.GLib.GDestroyNotify destroy_notify, IntPtr user_data);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_new_array_from_garray([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle array);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_new_array_from_strv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, string[] strv);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_new_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, bool value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_new_from_json([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, string json);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_new_function([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, string name, MentorLake.GObject.GCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify, MentorLake.GObject.GType return_type, uint n_params, IntPtr @__arglist);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_new_function_variadic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, string name, MentorLake.GObject.GCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify, MentorLake.GObject.GType return_type);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_new_functionv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, string name, MentorLake.GObject.GCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify, MentorLake.GObject.GType return_type, uint n_parameters, MentorLake.GObject.GType[] parameter_types);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_new_null([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_new_number([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, double number);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_new_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, IntPtr instance, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCClassHandle>))] MentorLake.JavaScriptCore.JSCClassHandle jsc_class);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_new_promise([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, MentorLake.JavaScriptCore.JSCExecutor executor, IntPtr user_data);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_new_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, string @string);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_new_string_from_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_new_typed_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, MentorLake.JavaScriptCore.JSCTypedArrayType type, UIntPtr length);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_new_undefined([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern byte[] jsc_value_array_buffer_get_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value, out UIntPtr size);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern UIntPtr jsc_value_array_buffer_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_constructor_call([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value, MentorLake.GObject.GType first_parameter_type, IntPtr @__arglist);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_constructor_callv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value, uint n_parameters, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle[] parameters);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_function_call([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value, MentorLake.GObject.GType first_parameter_type, IntPtr @__arglist);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_function_callv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value, uint n_parameters, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle[] parameters);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCContextHandle jsc_value_get_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_value_is_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_value_is_array_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_value_is_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_value_is_constructor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_value_is_function([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_value_is_null([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_value_is_number([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_value_is_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_value_is_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_value_is_typed_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_value_is_undefined([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_new_typed_array_with_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle array_buffer, MentorLake.JavaScriptCore.JSCTypedArrayType type, UIntPtr offset, UIntPtr length);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern void jsc_value_object_define_property_accessor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value, string property_name, MentorLake.JavaScriptCore.JSCValuePropertyFlags flags, MentorLake.GObject.GType property_type, MentorLake.GObject.GCallback getter, MentorLake.GObject.GCallback setter, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy_notify);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern void jsc_value_object_define_property_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value, string property_name, MentorLake.JavaScriptCore.JSCValuePropertyFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle property_value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_value_object_delete_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value, string name);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] jsc_value_object_enumerate_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_object_get_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value, string name);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_object_get_property_at_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value, uint index);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_value_object_has_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value, string name);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_object_invoke_method([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value, string name, MentorLake.GObject.GType first_parameter_type, IntPtr @__arglist);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_object_invoke_methodv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value, string name, uint n_parameters, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle[] parameters);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_value_object_is_instance_of([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value, string name);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern void jsc_value_object_set_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value, string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle property);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern void jsc_value_object_set_property_at_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value, uint index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle property);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern bool jsc_value_to_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern double jsc_value_to_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern int jsc_value_to_int32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string jsc_value_to_json([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value, uint indent);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string jsc_value_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle jsc_value_to_string_as_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCValueHandle jsc_value_typed_array_get_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern IntPtr jsc_value_typed_array_get_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value, out UIntPtr length);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern UIntPtr jsc_value_typed_array_get_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern UIntPtr jsc_value_typed_array_get_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern UIntPtr jsc_value_typed_array_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern MentorLake.JavaScriptCore.JSCTypedArrayType jsc_value_typed_array_get_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle value);

}
