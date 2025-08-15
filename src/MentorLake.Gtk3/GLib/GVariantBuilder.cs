namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A utility type for constructing container-type #GVariant instances.
/// </para>
/// <para>
/// This is an opaque structure and may only be accessed using the
/// following functions.
/// </para>
/// <para>
/// #GVariantBuilder is not threadsafe in any way.  Do not attempt to
/// access it from more than one thread.
/// </para>
/// </summary>

public class GVariantBuilderHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Allocates and initialises a new #GVariantBuilder.
/// </para>
/// <para>
/// You should call g_variant_builder_unref() on the return value when it
/// is no longer needed.  The memory will not be automatically freed by
/// any other call.
/// </para>
/// <para>
/// In most cases it is easier to place a #GVariantBuilder directly on
/// the stack of the calling function and initialise it with
/// g_variant_builder_init_static().
/// </para>
/// </summary>

/// <param name="type">
/// a container type
/// </param>
/// <return>
/// a #GVariantBuilder
/// </return>

	public static MentorLake.GLib.GVariantBuilderHandle New(MentorLake.GLib.GVariantTypeHandle type)
	{
		return GVariantBuilderExterns.g_variant_builder_new(type);
	}

}


public static class GVariantBuilderExtensions
{
/// <summary>
/// <para>
/// Adds to a #GVariantBuilder.
/// </para>
/// <para>
/// This call is a convenience wrapper that is exactly equivalent to
/// calling g_variant_new() followed by g_variant_builder_add_value().
/// </para>
/// <para>
/// Note that the arguments must be of the correct width for their types
/// specified in @format_string. This can be achieved by casting them. See
/// the [GVariant varargs documentation](gvariant-format-strings.html#varargs).
/// </para>
/// <para>
/// This function might be used as follows:
/// </para>
/// <code>
/// GVariant *
/// GVariant *
/// make_pointless_dictionary (void)
/// {
///   GVariantBuilder builder;
///   int i;
/// 
///   g_variant_builder_init_static (&amp;builder, G_VARIANT_TYPE_ARRAY);
///   for (i = 0; i &amp;lt; 16; i++)
///     {
///       gchar buf[3];
/// 
///       sprintf (buf, &quot;%d&quot;, i);
///       g_variant_builder_add (&amp;builder, &quot;{is}&quot;, i, buf);
///     }
/// 
///   return g_variant_builder_end (&amp;builder);
/// }
/// </code>
/// </summary>

/// <param name="builder">
/// a #GVariantBuilder
/// </param>
/// <param name="format_string">
/// a #GVariant varargs format string
/// </param>
/// <param name="@__arglist">
/// arguments, as per @format_string
/// </param>

	public static void Add(this MentorLake.GLib.GVariantBuilderHandle builder, string format_string, IntPtr @__arglist)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GVariantBuilder)");
		GVariantBuilderExterns.g_variant_builder_add(builder, format_string, @__arglist);
	}

/// <summary>
/// <para>
/// Adds to a #GVariantBuilder.
/// </para>
/// <para>
/// This call is a convenience wrapper that is exactly equivalent to
/// calling g_variant_new_parsed() followed by
/// g_variant_builder_add_value().
/// </para>
/// <para>
/// Note that the arguments must be of the correct width for their types
/// specified in @format_string. This can be achieved by casting them. See
/// the [GVariant varargs documentation](gvariant-format-strings.html#varargs).
/// </para>
/// <para>
/// This function might be used as follows:
/// </para>
/// <code>
/// GVariant *
/// GVariant *
/// make_pointless_dictionary (void)
/// {
///   GVariantBuilder builder;
///   int i;
/// 
///   g_variant_builder_init_static (&amp;builder, G_VARIANT_TYPE_ARRAY);
///   g_variant_builder_add_parsed (&amp;builder, &quot;{&apos;width&apos;, &amp;lt;%i&amp;gt;}&quot;, 600);
///   g_variant_builder_add_parsed (&amp;builder, &quot;{&apos;title&apos;, &amp;lt;%s&amp;gt;}&quot;, &quot;foo&quot;);
///   g_variant_builder_add_parsed (&amp;builder, &quot;{&apos;transparency&apos;, &amp;lt;0.5&amp;gt;}&quot;);
///   return g_variant_builder_end (&amp;builder);
/// }
/// </code>
/// </summary>

/// <param name="builder">
/// a #GVariantBuilder
/// </param>
/// <param name="format">
/// a text format #GVariant
/// </param>
/// <param name="@__arglist">
/// arguments as per @format
/// </param>

	public static void AddParsed(this MentorLake.GLib.GVariantBuilderHandle builder, string format, IntPtr @__arglist)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GVariantBuilder)");
		GVariantBuilderExterns.g_variant_builder_add_parsed(builder, format, @__arglist);
	}

/// <summary>
/// <para>
/// Adds @value to @builder.
/// </para>
/// <para>
/// It is an error to call this function in any way that would create an
/// inconsistent value to be constructed.  Some examples of this are
/// putting different types of items into an array, putting the wrong
/// types or number of items in a tuple, putting more than one value into
/// a variant, etc.
/// </para>
/// <para>
/// If @value is a floating reference (see g_variant_ref_sink()),
/// the @builder instance takes ownership of @value.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GVariantBuilder
/// </param>
/// <param name="value">
/// a #GVariant
/// </param>

	public static void AddValue(this MentorLake.GLib.GVariantBuilderHandle builder, MentorLake.GLib.GVariantHandle value)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GVariantBuilder)");
		GVariantBuilderExterns.g_variant_builder_add_value(builder, value);
	}

/// <summary>
/// <para>
/// Releases all memory associated with a #GVariantBuilder without
/// freeing the #GVariantBuilder structure itself.
/// </para>
/// <para>
/// It typically only makes sense to do this on a stack-allocated
/// #GVariantBuilder if you want to abort building the value part-way
/// through.  This function need not be called if you call
/// g_variant_builder_end() and it also doesn&apos;t need to be called on
/// builders allocated with g_variant_builder_new() (see
/// g_variant_builder_unref() for that).
/// </para>
/// <para>
/// This function leaves the #GVariantBuilder structure set to all-zeros.
/// It is valid to call this function on either an initialised
/// #GVariantBuilder or one that is set to all-zeros but it is not valid
/// to call this function on uninitialised memory.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GVariantBuilder
/// </param>

	public static void Clear(this MentorLake.GLib.GVariantBuilderHandle builder)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GVariantBuilder)");
		GVariantBuilderExterns.g_variant_builder_clear(builder);
	}

/// <summary>
/// <para>
/// Closes the subcontainer inside the given @builder that was opened by
/// the most recent call to g_variant_builder_open().
/// </para>
/// <para>
/// It is an error to call this function in any way that would create an
/// inconsistent value to be constructed (ie: too few values added to the
/// subcontainer).
/// </para>
/// </summary>

/// <param name="builder">
/// a #GVariantBuilder
/// </param>

	public static void Close(this MentorLake.GLib.GVariantBuilderHandle builder)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GVariantBuilder)");
		GVariantBuilderExterns.g_variant_builder_close(builder);
	}

/// <summary>
/// <para>
/// Ends the builder process and returns the constructed value.
/// </para>
/// <para>
/// It is not permissible to use @builder in any way after this call
/// except for reference counting operations (in the case of a
/// heap-allocated #GVariantBuilder) or by reinitialising it with
/// g_variant_builder_init() (in the case of stack-allocated). This
/// means that for the stack-allocated builders there is no need to
/// call g_variant_builder_clear() after the call to
/// g_variant_builder_end().
/// </para>
/// <para>
/// It is an error to call this function in any way that would create an
/// inconsistent value to be constructed (ie: insufficient number of
/// items added to a container with a specific number of children
/// required).  It is also an error to call this function if the builder
/// was created with an indefinite array or maybe type and no children
/// have been added; in this case it is impossible to infer the type of
/// the empty array.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GVariantBuilder
/// </param>
/// <return>
/// a new, floating, #GVariant
/// </return>

	public static MentorLake.GLib.GVariantHandle End(this MentorLake.GLib.GVariantBuilderHandle builder)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GVariantBuilder)");
		return GVariantBuilderExterns.g_variant_builder_end(builder);
	}

/// <summary>
/// <para>
/// Initialises a #GVariantBuilder structure.
/// </para>
/// <para>
/// @type must be non-%NULL.  It specifies the type of container to
/// construct.  It can be an indefinite type such as
/// %G_VARIANT_TYPE_ARRAY or a definite type such as &quot;as&quot; or &quot;(ii)&quot;.
/// Maybe, array, tuple, dictionary entry and variant-typed values may be
/// constructed.
/// </para>
/// <para>
/// If using a static type such as one of the `G_VARIANT_TYPE_*` constants
/// or a `G_VARIANT_TYPE (&quot;(ii)&quot;)` macro, it is more performant to use
/// g_variant_builder_init_static() rather than g_variant_builder_init().
/// </para>
/// <para>
/// After the builder is initialised, values are added using
/// g_variant_builder_add_value() or g_variant_builder_add().
/// </para>
/// <para>
/// After all the child values are added, g_variant_builder_end() frees
/// the memory associated with the builder and returns the #GVariant that
/// was created.
/// </para>
/// <para>
/// This function completely ignores the previous contents of @builder.
/// On one hand this means that it is valid to pass in completely
/// uninitialised memory.  On the other hand, this means that if you are
/// initialising over top of an existing #GVariantBuilder you need to
/// first call g_variant_builder_clear() in order to avoid leaking
/// memory.
/// </para>
/// <para>
/// You must not call g_variant_builder_ref() or
/// g_variant_builder_unref() on a #GVariantBuilder that was initialised
/// with this function.  If you ever pass a reference to a
/// #GVariantBuilder outside of the control of your own code then you
/// should assume that the person receiving that reference may try to use
/// reference counting; you should use g_variant_builder_new() instead of
/// this function.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GVariantBuilder
/// </param>
/// <param name="type">
/// a container type
/// </param>

	public static void Init(this MentorLake.GLib.GVariantBuilderHandle builder, MentorLake.GLib.GVariantTypeHandle type)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GVariantBuilder)");
		GVariantBuilderExterns.g_variant_builder_init(builder, type);
	}

/// <summary>
/// <para>
/// Initialises a #GVariantBuilder structure.
/// </para>
/// <para>
/// This function works exactly like g_variant_builder_init() but does
/// not make a copy of @type. Therefore, @type must remain valid for the
/// lifetime of @builder. This is always true of type constants like
/// `G_VARIANT_TYPE_*` or `G_VARIANT_TYPE (&quot;(ii)&quot;)`.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GVariantBuilder
/// </param>
/// <param name="type">
/// a container type
/// </param>

	public static void InitStatic(this MentorLake.GLib.GVariantBuilderHandle builder, MentorLake.GLib.GVariantTypeHandle type)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GVariantBuilder)");
		GVariantBuilderExterns.g_variant_builder_init_static(builder, type);
	}

/// <summary>
/// <para>
/// Opens a subcontainer inside the given @builder.  When done adding
/// items to the subcontainer, g_variant_builder_close() must be called. @type
/// is the type of the container: so to build a tuple of several values, @type
/// must include the tuple itself.
/// </para>
/// <para>
/// It is an error to call this function in any way that would cause an
/// inconsistent value to be constructed (ie: adding too many values or
/// a value of an incorrect type).
/// </para>
/// <para>
/// Example of building a nested variant:
/// <code>
/// GVariantBuilder builder;
/// GVariantBuilder builder;
/// guint32 some_number = get_number ();
/// g_autoptr (GHashTable) some_dict = get_dict ();
/// GHashTableIter iter;
/// const gchar *key;
/// const GVariant *value;
/// g_autoptr (GVariant) output = NULL;
/// 
/// g_variant_builder_init (&amp;builder, G_VARIANT_TYPE (&quot;(ua{sv})&quot;));
/// g_variant_builder_add (&amp;builder, &quot;u&quot;, some_number);
/// g_variant_builder_open (&amp;builder, G_VARIANT_TYPE (&quot;a{sv}&quot;));
/// 
/// g_hash_table_iter_init (&amp;iter, some_dict);
/// while (g_hash_table_iter_next (&amp;iter, (gpointer *) &amp;key, (gpointer *) &amp;value))
///   {
///     g_variant_builder_open (&amp;builder, G_VARIANT_TYPE (&quot;{sv}&quot;));
///     g_variant_builder_add (&amp;builder, &quot;s&quot;, key);
///     g_variant_builder_add (&amp;builder, &quot;v&quot;, value);
///     g_variant_builder_close (&amp;builder);
///   }
/// 
/// g_variant_builder_close (&amp;builder);
/// 
/// output = g_variant_builder_end (&amp;builder);
/// </code>
/// </para>
/// </summary>

/// <param name="builder">
/// a #GVariantBuilder
/// </param>
/// <param name="type">
/// the #GVariantType of the container
/// </param>

	public static void Open(this MentorLake.GLib.GVariantBuilderHandle builder, MentorLake.GLib.GVariantTypeHandle type)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GVariantBuilder)");
		GVariantBuilderExterns.g_variant_builder_open(builder, type);
	}

/// <summary>
/// <para>
/// Increases the reference count on @builder.
/// </para>
/// <para>
/// Don&apos;t call this on stack-allocated #GVariantBuilder instances or bad
/// things will happen.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GVariantBuilder allocated by g_variant_builder_new()
/// </param>
/// <return>
/// a new reference to @builder
/// </return>

	public static MentorLake.GLib.GVariantBuilderHandle Ref(this MentorLake.GLib.GVariantBuilderHandle builder)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GVariantBuilder)");
		return GVariantBuilderExterns.g_variant_builder_ref(builder);
	}

/// <summary>
/// <para>
/// Decreases the reference count on @builder.
/// </para>
/// <para>
/// In the event that there are no more references, releases all memory
/// associated with the #GVariantBuilder.
/// </para>
/// <para>
/// Don&apos;t call this on stack-allocated #GVariantBuilder instances or bad
/// things will happen.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GVariantBuilder allocated by g_variant_builder_new()
/// </param>

	public static void Unref(this MentorLake.GLib.GVariantBuilderHandle builder)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GVariantBuilder)");
		GVariantBuilderExterns.g_variant_builder_unref(builder);
	}


	public static GVariantBuilder Dereference(this GVariantBuilderHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GVariantBuilder>(x.DangerousGetHandle());
}
internal class GVariantBuilderExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))]
	internal static extern MentorLake.GLib.GVariantBuilderHandle g_variant_builder_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_builder_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder, string format_string, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_builder_add_parsed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_builder_add_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_builder_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_builder_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_builder_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_builder_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_builder_init_static([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_builder_open([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))]
	internal static extern MentorLake.GLib.GVariantBuilderHandle g_variant_builder_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_builder_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantBuilderHandle>))] MentorLake.GLib.GVariantBuilderHandle builder);

}

/// <summary>
/// <para>
/// A utility type for constructing container-type #GVariant instances.
/// </para>
/// <para>
/// This is an opaque structure and may only be accessed using the
/// following functions.
/// </para>
/// <para>
/// #GVariantBuilder is not threadsafe in any way.  Do not attempt to
/// access it from more than one thread.
/// </para>
/// </summary>

public struct GVariantBuilder
{
}
