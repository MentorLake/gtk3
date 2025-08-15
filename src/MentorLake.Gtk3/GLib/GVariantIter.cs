namespace MentorLake.GLib;

/// <summary>
/// <para>
/// #GVariantIter is an opaque data structure and can only be accessed
/// using the following functions.
/// </para>
/// </summary>

public class GVariantIterHandle : BaseSafeHandle
{
}


public static class GVariantIterExtensions
{
/// <summary>
/// <para>
/// Creates a new heap-allocated #GVariantIter to iterate over the
/// container that was being iterated over by @iter.  Iteration begins on
/// the new iterator from the current position of the old iterator but
/// the two copies are independent past that point.
/// </para>
/// <para>
/// Use g_variant_iter_free() to free the return value when you no longer
/// need it.
/// </para>
/// <para>
/// A reference is taken to the container that @iter is iterating over
/// and will be related only when g_variant_iter_free() is called.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GVariantIter
/// </param>
/// <return>
/// a new heap-allocated #GVariantIter
/// </return>

	public static MentorLake.GLib.GVariantIterHandle Copy(this MentorLake.GLib.GVariantIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GVariantIter)");
		return GVariantIterExterns.g_variant_iter_copy(iter);
	}

/// <summary>
/// <para>
/// Frees a heap-allocated #GVariantIter.  Only call this function on
/// iterators that were returned by g_variant_iter_new() or
/// g_variant_iter_copy().
/// </para>
/// </summary>

/// <param name="iter">
/// a heap-allocated #GVariantIter
/// </param>

	public static void Free(this MentorLake.GLib.GVariantIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GVariantIter)");
		GVariantIterExterns.g_variant_iter_free(iter);
	}

/// <summary>
/// <para>
/// Initialises (without allocating) a #GVariantIter.  @iter may be
/// completely uninitialised prior to this call; its old value is
/// ignored.
/// </para>
/// <para>
/// The iterator remains valid for as long as @value exists, and need not
/// be freed in any way.
/// </para>
/// </summary>

/// <param name="iter">
/// a pointer to a #GVariantIter
/// </param>
/// <param name="value">
/// a container #GVariant
/// </param>
/// <return>
/// the number of items in @value
/// </return>

	public static UIntPtr Init(this MentorLake.GLib.GVariantIterHandle iter, MentorLake.GLib.GVariantHandle value)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GVariantIter)");
		return GVariantIterExterns.g_variant_iter_init(iter, value);
	}

/// <summary>
/// <para>
/// Gets the next item in the container and unpacks it into the variable
/// argument list according to @format_string, returning %TRUE.
/// </para>
/// <para>
/// If no more items remain then %FALSE is returned.
/// </para>
/// <para>
/// On the first call to this function, the pointers appearing on the
/// variable argument list are assumed to point at uninitialised memory.
/// On the second and later calls, it is assumed that the same pointers
/// will be given and that they will point to the memory as set by the
/// previous call to this function.  This allows the previous values to
/// be freed, as appropriate.
/// </para>
/// <para>
/// This function is intended to be used with a while loop as
/// demonstrated in the following example.  This function can only be
/// used when iterating over an array.  It is only valid to call this
/// function with a string constant for the format string and the same
/// string constant must be used each time.  Mixing calls to this
/// function and g_variant_iter_next() or g_variant_iter_next_value() on
/// the same iterator causes undefined behavior.
/// </para>
/// <para>
/// If you break out of a such a while loop using g_variant_iter_loop() then
/// you must free or unreference all the unpacked values as you would with
/// g_variant_get(). Failure to do so will cause a memory leak.
/// </para>
/// <para>
/// Here is an example for memory management with g_variant_iter_loop():
/// <code>
///   // Iterates a dictionary of type &apos;a{sv}&apos;
///   // Iterates a dictionary of type &apos;a{sv}&apos;
///   void
///   iterate_dictionary (GVariant *dictionary)
///   {
///     GVariantIter iter;
///     GVariant *value;
///     gchar *key;
/// 
///     g_variant_iter_init (&amp;iter, dictionary);
///     while (g_variant_iter_loop (&amp;iter, &quot;{sv}&quot;, &amp;key, &amp;value))
///       {
///         g_print (&quot;Item &apos;%s&apos; has type &apos;%s&apos;\n&quot;, key,
///                  g_variant_get_type_string (value));
/// 
///         // no need to free &apos;key&apos; and &apos;value&apos; here
///         // unless breaking out of this loop
///       }
///   }
/// </code>
/// For most cases you should use g_variant_iter_next().
/// </para>
/// <para>
/// This function is really only useful when unpacking into #GVariant or
/// #GVariantIter in order to allow you to skip the call to
/// g_variant_unref() or g_variant_iter_free().
/// </para>
/// <para>
/// For example, if you are only looping over simple integer and string
/// types, g_variant_iter_next() is definitely preferred.  For string
/// types, use the &apos;&amp;&apos; prefix to avoid allocating any memory at all (and
/// thereby avoiding the need to free anything as well).
/// </para>
/// <para>
/// @format_string determines the C types that are used for unpacking
/// the values and also determines if the values are copied or borrowed.
/// </para>
/// <para>
/// See the section on
/// [`GVariant` format strings](gvariant-format-strings.html#pointers).
/// </para>
/// </summary>

/// <param name="iter">
/// a #GVariantIter
/// </param>
/// <param name="format_string">
/// a GVariant format string
/// </param>
/// <param name="@__arglist">
/// the arguments to unpack the value into
/// </param>
/// <return>
/// %TRUE if a value was unpacked, or %FALSE if there was no
///          value
/// </return>

	public static bool Loop(this MentorLake.GLib.GVariantIterHandle iter, string format_string, IntPtr @__arglist)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GVariantIter)");
		return GVariantIterExterns.g_variant_iter_loop(iter, format_string, @__arglist);
	}

/// <summary>
/// <para>
/// Queries the number of child items in the container that we are
/// iterating over.  This is the total number of items -- not the number
/// of items remaining.
/// </para>
/// <para>
/// This function might be useful for preallocation of arrays.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GVariantIter
/// </param>
/// <return>
/// the number of children in the container
/// </return>

	public static UIntPtr NChildren(this MentorLake.GLib.GVariantIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GVariantIter)");
		return GVariantIterExterns.g_variant_iter_n_children(iter);
	}

/// <summary>
/// <para>
/// Gets the next item in the container and unpacks it into the variable
/// argument list according to @format_string, returning %TRUE.
/// </para>
/// <para>
/// If no more items remain then %FALSE is returned.
/// </para>
/// <para>
/// All of the pointers given on the variable arguments list of this
/// function are assumed to point at uninitialised memory.  It is the
/// responsibility of the caller to free all of the values returned by
/// the unpacking process.
/// </para>
/// <para>
/// Here is an example for memory management with g_variant_iter_next():
/// <code>
///   // Iterates a dictionary of type &apos;a{sv}&apos;
///   // Iterates a dictionary of type &apos;a{sv}&apos;
///   void
///   iterate_dictionary (GVariant *dictionary)
///   {
///     GVariantIter iter;
///     GVariant *value;
///     gchar *key;
/// 
///     g_variant_iter_init (&amp;iter, dictionary);
///     while (g_variant_iter_next (&amp;iter, &quot;{sv}&quot;, &amp;key, &amp;value))
///       {
///         g_print (&quot;Item &apos;%s&apos; has type &apos;%s&apos;\n&quot;, key,
///                  g_variant_get_type_string (value));
/// 
///         // must free data for ourselves
///         g_variant_unref (value);
///         g_free (key);
///       }
///   }
/// </code>
/// For a solution that is likely to be more convenient to C programmers
/// when dealing with loops, see g_variant_iter_loop().
/// </para>
/// <para>
/// @format_string determines the C types that are used for unpacking
/// the values and also determines if the values are copied or borrowed.
/// </para>
/// <para>
/// See the section on
/// [`GVariant` format strings](gvariant-format-strings.html#pointers).
/// </para>
/// </summary>

/// <param name="iter">
/// a #GVariantIter
/// </param>
/// <param name="format_string">
/// a GVariant format string
/// </param>
/// <param name="@__arglist">
/// the arguments to unpack the value into
/// </param>
/// <return>
/// %TRUE if a value was unpacked, or %FALSE if there as no value
/// </return>

	public static bool Next(this MentorLake.GLib.GVariantIterHandle iter, string format_string, IntPtr @__arglist)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GVariantIter)");
		return GVariantIterExterns.g_variant_iter_next(iter, format_string, @__arglist);
	}

/// <summary>
/// <para>
/// Gets the next item in the container.  If no more items remain then
/// %NULL is returned.
/// </para>
/// <para>
/// Use g_variant_unref() to drop your reference on the return value when
/// you no longer need it.
/// </para>
/// <para>
/// Here is an example for iterating with g_variant_iter_next_value():
/// <code>
///   // recursively iterate a container
///   // recursively iterate a container
///   void
///   iterate_container_recursive (GVariant *container)
///   {
///     GVariantIter iter;
///     GVariant *child;
/// 
///     g_variant_iter_init (&amp;iter, container);
///     while ((child = g_variant_iter_next_value (&amp;iter)))
///       {
///         g_print (&quot;type &apos;%s&apos;\n&quot;, g_variant_get_type_string (child));
/// 
///         if (g_variant_is_container (child))
///           iterate_container_recursive (child);
/// 
///         g_variant_unref (child);
///       }
///   }
/// </code>
/// </para>
/// </summary>

/// <param name="iter">
/// a #GVariantIter
/// </param>
/// <return>
/// a #GVariant, or %NULL
/// </return>

	public static MentorLake.GLib.GVariantHandle NextValue(this MentorLake.GLib.GVariantIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GVariantIter)");
		return GVariantIterExterns.g_variant_iter_next_value(iter);
	}


	public static GVariantIter Dereference(this GVariantIterHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GVariantIter>(x.DangerousGetHandle());
}
internal class GVariantIterExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantIterHandle>))]
	internal static extern MentorLake.GLib.GVariantIterHandle g_variant_iter_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantIterHandle>))] MentorLake.GLib.GVariantIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_iter_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantIterHandle>))] MentorLake.GLib.GVariantIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_variant_iter_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantIterHandle>))] MentorLake.GLib.GVariantIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_iter_loop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantIterHandle>))] MentorLake.GLib.GVariantIterHandle iter, string format_string, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_variant_iter_n_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantIterHandle>))] MentorLake.GLib.GVariantIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_iter_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantIterHandle>))] MentorLake.GLib.GVariantIterHandle iter, string format_string, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_iter_next_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantIterHandle>))] MentorLake.GLib.GVariantIterHandle iter);

}

/// <summary>
/// <para>
/// #GVariantIter is an opaque data structure and can only be accessed
/// using the following functions.
/// </para>
/// </summary>

public struct GVariantIter
{
}
