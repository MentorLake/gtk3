namespace MentorLake.GLib;

/// <summary>
/// <para>
/// #GVariantDict is a mutable interface to #GVariant dictionaries.
/// </para>
/// <para>
/// It can be used for doing a sequence of dictionary lookups in an
/// efficient way on an existing #GVariant dictionary or it can be used
/// to construct new dictionaries with a hashtable-like interface.  It
/// can also be used for taking existing dictionaries and modifying them
/// in order to create new ones.
/// </para>
/// <para>
/// #GVariantDict can only be used with %G_VARIANT_TYPE_VARDICT
/// dictionaries.
/// </para>
/// <para>
/// It is possible to use #GVariantDict allocated on the stack or on the
/// heap.  When using a stack-allocated #GVariantDict, you begin with a
/// call to g_variant_dict_init() and free the resources with a call to
/// g_variant_dict_clear().
/// </para>
/// <para>
/// Heap-allocated #GVariantDict follows normal refcounting rules: you
/// allocate it with g_variant_dict_new() and use g_variant_dict_ref()
/// and g_variant_dict_unref().
/// </para>
/// <para>
/// g_variant_dict_end() is used to convert the #GVariantDict back into a
/// dictionary-type #GVariant.  When used with stack-allocated instances,
/// this also implicitly frees all associated memory, but for
/// heap-allocated instances, you must still call g_variant_dict_unref()
/// afterwards.
/// </para>
/// <para>
/// You will typically want to use a heap-allocated #GVariantDict when
/// you expose it as part of an API.  For most other uses, the
/// stack-allocated form will be more convenient.
/// </para>
/// <para>
/// Consider the following two examples that do the same thing in each
/// style: take an existing dictionary and look up the &quot;count&quot; uint32
/// key, adding 1 to it if it is found, or returning an error if the
/// key is not found.  Each returns the new dictionary as a floating
/// #GVariant.
/// </para>
/// <para>
/// ## Using a stack-allocated GVariantDict
/// </para>
/// <code>
///   GVariant *
///   GVariant *
///   add_to_count (GVariant  *orig,
///                 GError   **error)
///   {
///     GVariantDict dict;
///     guint32 count;
/// 
///     g_variant_dict_init (&amp;dict, orig);
///     if (!g_variant_dict_lookup (&amp;dict, &quot;count&quot;, &quot;u&quot;, &amp;count))
///       {
///         g_set_error (...);
///         g_variant_dict_clear (&amp;dict);
///         return NULL;
///       }
/// 
///     g_variant_dict_insert (&amp;dict, &quot;count&quot;, &quot;u&quot;, count + 1);
/// 
///     return g_variant_dict_end (&amp;dict);
///   }
/// </code>
/// <para>
/// ## Using heap-allocated GVariantDict
/// </para>
/// <code>
///   GVariant *
///   GVariant *
///   add_to_count (GVariant  *orig,
///                 GError   **error)
///   {
///     GVariantDict *dict;
///     GVariant *result;
///     guint32 count;
/// 
///     dict = g_variant_dict_new (orig);
/// 
///     if (g_variant_dict_lookup (dict, &quot;count&quot;, &quot;u&quot;, &amp;count))
///       {
///         g_variant_dict_insert (dict, &quot;count&quot;, &quot;u&quot;, count + 1);
///         result = g_variant_dict_end (dict);
///       }
///     else
///       {
///         g_set_error (...);
///         result = NULL;
///       }
/// 
///     g_variant_dict_unref (dict);
/// 
///     return result;
///   }
/// </code>
/// </summary>

public class GVariantDictHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Allocates and initialises a new #GVariantDict.
/// </para>
/// <para>
/// You should call g_variant_dict_unref() on the return value when it
/// is no longer needed.  The memory will not be automatically freed by
/// any other call.
/// </para>
/// <para>
/// In some cases it may be easier to place a #GVariantDict directly on
/// the stack of the calling function and initialise it with
/// g_variant_dict_init().  This is particularly useful when you are
/// using #GVariantDict to construct a #GVariant.
/// </para>
/// </summary>

/// <param name="from_asv">
/// the #GVariant with which to initialise the
///   dictionary
/// </param>
/// <return>
/// a #GVariantDict
/// </return>

	public static MentorLake.GLib.GVariantDictHandle New(MentorLake.GLib.GVariantHandle from_asv)
	{
		return GVariantDictExterns.g_variant_dict_new(from_asv);
	}

}


public static class GVariantDictExtensions
{
/// <summary>
/// <para>
/// Releases all memory associated with a #GVariantDict without freeing
/// the #GVariantDict structure itself.
/// </para>
/// <para>
/// It typically only makes sense to do this on a stack-allocated
/// #GVariantDict if you want to abort building the value part-way
/// through.  This function need not be called if you call
/// g_variant_dict_end() and it also doesn&apos;t need to be called on dicts
/// allocated with g_variant_dict_new (see g_variant_dict_unref() for
/// that).
/// </para>
/// <para>
/// It is valid to call this function on either an initialised
/// #GVariantDict or one that was previously cleared by an earlier call
/// to g_variant_dict_clear() but it is not valid to call this function
/// on uninitialised memory.
/// </para>
/// </summary>

/// <param name="dict">
/// a #GVariantDict
/// </param>

	public static void Clear(this MentorLake.GLib.GVariantDictHandle dict)
	{
		if (dict.IsInvalid) throw new Exception("Invalid handle (GVariantDict)");
		GVariantDictExterns.g_variant_dict_clear(dict);
	}

/// <summary>
/// <para>
/// Checks if @key exists in @dict.
/// </para>
/// </summary>

/// <param name="dict">
/// a #GVariantDict
/// </param>
/// <param name="key">
/// the key to look up in the dictionary
/// </param>
/// <return>
/// %TRUE if @key is in @dict
/// </return>

	public static bool Contains(this MentorLake.GLib.GVariantDictHandle dict, string key)
	{
		if (dict.IsInvalid) throw new Exception("Invalid handle (GVariantDict)");
		return GVariantDictExterns.g_variant_dict_contains(dict, key);
	}

/// <summary>
/// <para>
/// Returns the current value of @dict as a #GVariant of type
/// %G_VARIANT_TYPE_VARDICT, clearing it in the process.
/// </para>
/// <para>
/// It is not permissible to use @dict in any way after this call except
/// for reference counting operations (in the case of a heap-allocated
/// #GVariantDict) or by reinitialising it with g_variant_dict_init() (in
/// the case of stack-allocated).
/// </para>
/// </summary>

/// <param name="dict">
/// a #GVariantDict
/// </param>
/// <return>
/// a new, floating, #GVariant
/// </return>

	public static MentorLake.GLib.GVariantHandle End(this MentorLake.GLib.GVariantDictHandle dict)
	{
		if (dict.IsInvalid) throw new Exception("Invalid handle (GVariantDict)");
		return GVariantDictExterns.g_variant_dict_end(dict);
	}

/// <summary>
/// <para>
/// Initialises a #GVariantDict structure.
/// </para>
/// <para>
/// If @from_asv is given, it is used to initialise the dictionary.
/// </para>
/// <para>
/// This function completely ignores the previous contents of @dict.  On
/// one hand this means that it is valid to pass in completely
/// uninitialised memory.  On the other hand, this means that if you are
/// initialising over top of an existing #GVariantDict you need to first
/// call g_variant_dict_clear() in order to avoid leaking memory.
/// </para>
/// <para>
/// You must not call g_variant_dict_ref() or g_variant_dict_unref() on a
/// #GVariantDict that was initialised with this function.  If you ever
/// pass a reference to a #GVariantDict outside of the control of your
/// own code then you should assume that the person receiving that
/// reference may try to use reference counting; you should use
/// g_variant_dict_new() instead of this function.
/// </para>
/// </summary>

/// <param name="dict">
/// a #GVariantDict
/// </param>
/// <param name="from_asv">
/// the initial value for @dict
/// </param>

	public static void Init(this MentorLake.GLib.GVariantDictHandle dict, MentorLake.GLib.GVariantHandle from_asv)
	{
		if (dict.IsInvalid) throw new Exception("Invalid handle (GVariantDict)");
		GVariantDictExterns.g_variant_dict_init(dict, from_asv);
	}

/// <summary>
/// <para>
/// Inserts a value into a #GVariantDict.
/// </para>
/// <para>
/// This call is a convenience wrapper that is exactly equivalent to
/// calling g_variant_new() followed by g_variant_dict_insert_value().
/// </para>
/// </summary>

/// <param name="dict">
/// a #GVariantDict
/// </param>
/// <param name="key">
/// the key to insert a value for
/// </param>
/// <param name="format_string">
/// a #GVariant varargs format string
/// </param>
/// <param name="@__arglist">
/// arguments, as per @format_string
/// </param>

	public static void Insert(this MentorLake.GLib.GVariantDictHandle dict, string key, string format_string, IntPtr @__arglist)
	{
		if (dict.IsInvalid) throw new Exception("Invalid handle (GVariantDict)");
		GVariantDictExterns.g_variant_dict_insert(dict, key, format_string, @__arglist);
	}

/// <summary>
/// <para>
/// Inserts (or replaces) a key in a #GVariantDict.
/// </para>
/// <para>
/// @value is consumed if it is floating.
/// </para>
/// </summary>

/// <param name="dict">
/// a #GVariantDict
/// </param>
/// <param name="key">
/// the key to insert a value for
/// </param>
/// <param name="value">
/// the value to insert
/// </param>

	public static void InsertValue(this MentorLake.GLib.GVariantDictHandle dict, string key, MentorLake.GLib.GVariantHandle value)
	{
		if (dict.IsInvalid) throw new Exception("Invalid handle (GVariantDict)");
		GVariantDictExterns.g_variant_dict_insert_value(dict, key, value);
	}

/// <summary>
/// <para>
/// Looks up a value in a #GVariantDict.
/// </para>
/// <para>
/// This function is a wrapper around g_variant_dict_lookup_value() and
/// g_variant_get().  In the case that %NULL would have been returned,
/// this function returns %FALSE and does not modify the values of the arguments
/// passed in to @....  Otherwise, it unpacks the returned
/// value and returns %TRUE.
/// </para>
/// <para>
/// @format_string determines the C types that are used for unpacking the
/// values and also determines if the values are copied or borrowed, see the
/// section on [`GVariant` format strings](gvariant-format-strings.html#pointers).
/// </para>
/// </summary>

/// <param name="dict">
/// a #GVariantDict
/// </param>
/// <param name="key">
/// the key to look up in the dictionary
/// </param>
/// <param name="format_string">
/// a GVariant format string
/// </param>
/// <param name="@__arglist">
/// the arguments to unpack the value into
/// </param>
/// <return>
/// %TRUE if a value was unpacked
/// </return>

	public static bool Lookup(this MentorLake.GLib.GVariantDictHandle dict, string key, string format_string, IntPtr @__arglist)
	{
		if (dict.IsInvalid) throw new Exception("Invalid handle (GVariantDict)");
		return GVariantDictExterns.g_variant_dict_lookup(dict, key, format_string, @__arglist);
	}

/// <summary>
/// <para>
/// Looks up a value in a #GVariantDict.
/// </para>
/// <para>
/// If @key is not found in @dictionary, %NULL is returned.
/// </para>
/// <para>
/// The @expected_type string specifies what type of value is expected.
/// If the value associated with @key has a different type then %NULL is
/// returned.
/// </para>
/// <para>
/// If the key is found and the value has the correct type, it is
/// returned.  If @expected_type was specified then any non-%NULL return
/// value will have this type.
/// </para>
/// </summary>

/// <param name="dict">
/// a #GVariantDict
/// </param>
/// <param name="key">
/// the key to look up in the dictionary
/// </param>
/// <param name="expected_type">
/// a #GVariantType, or %NULL
/// </param>
/// <return>
/// the value of the dictionary key, or %NULL
/// </return>

	public static MentorLake.GLib.GVariantHandle LookupValue(this MentorLake.GLib.GVariantDictHandle dict, string key, MentorLake.GLib.GVariantTypeHandle expected_type)
	{
		if (dict.IsInvalid) throw new Exception("Invalid handle (GVariantDict)");
		return GVariantDictExterns.g_variant_dict_lookup_value(dict, key, expected_type);
	}

/// <summary>
/// <para>
/// Increases the reference count on @dict.
/// </para>
/// <para>
/// Don&apos;t call this on stack-allocated #GVariantDict instances or bad
/// things will happen.
/// </para>
/// </summary>

/// <param name="dict">
/// a heap-allocated #GVariantDict
/// </param>
/// <return>
/// a new reference to @dict
/// </return>

	public static MentorLake.GLib.GVariantDictHandle Ref(this MentorLake.GLib.GVariantDictHandle dict)
	{
		if (dict.IsInvalid) throw new Exception("Invalid handle (GVariantDict)");
		return GVariantDictExterns.g_variant_dict_ref(dict);
	}

/// <summary>
/// <para>
/// Removes a key and its associated value from a #GVariantDict.
/// </para>
/// </summary>

/// <param name="dict">
/// a #GVariantDict
/// </param>
/// <param name="key">
/// the key to remove
/// </param>
/// <return>
/// %TRUE if the key was found and removed
/// </return>

	public static bool Remove(this MentorLake.GLib.GVariantDictHandle dict, string key)
	{
		if (dict.IsInvalid) throw new Exception("Invalid handle (GVariantDict)");
		return GVariantDictExterns.g_variant_dict_remove(dict, key);
	}

/// <summary>
/// <para>
/// Decreases the reference count on @dict.
/// </para>
/// <para>
/// In the event that there are no more references, releases all memory
/// associated with the #GVariantDict.
/// </para>
/// <para>
/// Don&apos;t call this on stack-allocated #GVariantDict instances or bad
/// things will happen.
/// </para>
/// </summary>

/// <param name="dict">
/// a heap-allocated #GVariantDict
/// </param>

	public static void Unref(this MentorLake.GLib.GVariantDictHandle dict)
	{
		if (dict.IsInvalid) throw new Exception("Invalid handle (GVariantDict)");
		GVariantDictExterns.g_variant_dict_unref(dict);
	}


	public static GVariantDict Dereference(this GVariantDictHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GVariantDict>(x.DangerousGetHandle());
}
internal class GVariantDictExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))]
	internal static extern MentorLake.GLib.GVariantDictHandle g_variant_dict_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle from_asv);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_dict_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_dict_contains([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict, string key);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_dict_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_dict_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle from_asv);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_dict_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict, string key, string format_string, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_dict_insert_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict, string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_dict_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict, string key, string format_string, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_dict_lookup_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict, string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle expected_type);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))]
	internal static extern MentorLake.GLib.GVariantDictHandle g_variant_dict_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_dict_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict, string key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_dict_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))] MentorLake.GLib.GVariantDictHandle dict);

}

/// <summary>
/// <para>
/// #GVariantDict is a mutable interface to #GVariant dictionaries.
/// </para>
/// <para>
/// It can be used for doing a sequence of dictionary lookups in an
/// efficient way on an existing #GVariant dictionary or it can be used
/// to construct new dictionaries with a hashtable-like interface.  It
/// can also be used for taking existing dictionaries and modifying them
/// in order to create new ones.
/// </para>
/// <para>
/// #GVariantDict can only be used with %G_VARIANT_TYPE_VARDICT
/// dictionaries.
/// </para>
/// <para>
/// It is possible to use #GVariantDict allocated on the stack or on the
/// heap.  When using a stack-allocated #GVariantDict, you begin with a
/// call to g_variant_dict_init() and free the resources with a call to
/// g_variant_dict_clear().
/// </para>
/// <para>
/// Heap-allocated #GVariantDict follows normal refcounting rules: you
/// allocate it with g_variant_dict_new() and use g_variant_dict_ref()
/// and g_variant_dict_unref().
/// </para>
/// <para>
/// g_variant_dict_end() is used to convert the #GVariantDict back into a
/// dictionary-type #GVariant.  When used with stack-allocated instances,
/// this also implicitly frees all associated memory, but for
/// heap-allocated instances, you must still call g_variant_dict_unref()
/// afterwards.
/// </para>
/// <para>
/// You will typically want to use a heap-allocated #GVariantDict when
/// you expose it as part of an API.  For most other uses, the
/// stack-allocated form will be more convenient.
/// </para>
/// <para>
/// Consider the following two examples that do the same thing in each
/// style: take an existing dictionary and look up the &quot;count&quot; uint32
/// key, adding 1 to it if it is found, or returning an error if the
/// key is not found.  Each returns the new dictionary as a floating
/// #GVariant.
/// </para>
/// <para>
/// ## Using a stack-allocated GVariantDict
/// </para>
/// <code>
///   GVariant *
///   GVariant *
///   add_to_count (GVariant  *orig,
///                 GError   **error)
///   {
///     GVariantDict dict;
///     guint32 count;
/// 
///     g_variant_dict_init (&amp;dict, orig);
///     if (!g_variant_dict_lookup (&amp;dict, &quot;count&quot;, &quot;u&quot;, &amp;count))
///       {
///         g_set_error (...);
///         g_variant_dict_clear (&amp;dict);
///         return NULL;
///       }
/// 
///     g_variant_dict_insert (&amp;dict, &quot;count&quot;, &quot;u&quot;, count + 1);
/// 
///     return g_variant_dict_end (&amp;dict);
///   }
/// </code>
/// <para>
/// ## Using heap-allocated GVariantDict
/// </para>
/// <code>
///   GVariant *
///   GVariant *
///   add_to_count (GVariant  *orig,
///                 GError   **error)
///   {
///     GVariantDict *dict;
///     GVariant *result;
///     guint32 count;
/// 
///     dict = g_variant_dict_new (orig);
/// 
///     if (g_variant_dict_lookup (dict, &quot;count&quot;, &quot;u&quot;, &amp;count))
///       {
///         g_variant_dict_insert (dict, &quot;count&quot;, &quot;u&quot;, count + 1);
///         result = g_variant_dict_end (dict);
///       }
///     else
///       {
///         g_set_error (...);
///         result = NULL;
///       }
/// 
///     g_variant_dict_unref (dict);
/// 
///     return result;
///   }
/// </code>
/// </summary>

public struct GVariantDict
{
}
