namespace MentorLake.GLib;

/// <summary>
/// <para>
/// `GStrvBuilder` is a helper object to build a %NULL-terminated string arrays.
/// </para>
/// <para>
/// The following example shows how to build a two element array:
/// </para>
/// <para>
/// ```c
///   g_autoptr(GStrvBuilder) builder = g_strv_builder_new ();
///   g_strv_builder_add (builder, &quot;hello&quot;);
///   g_strv_builder_add (builder, &quot;world&quot;);
/// </para>
/// <para>
///   g_auto(GStrv) array = g_strv_builder_end (builder);
/// </para>
/// <para>
///   g_assert_true (g_strv_equal (array, (const char *[]) { &quot;hello&quot;, &quot;world&quot;, NULL }));
/// ```
/// </para>
/// </summary>

public class GStrvBuilderHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new #GStrvBuilder with a reference count of 1.
/// Use g_strv_builder_unref() on the returned value when no longer needed.
/// </para>
/// </summary>

/// <return>
/// the new #GStrvBuilder
/// </return>

	public static MentorLake.GLib.GStrvBuilderHandle New()
	{
		return GStrvBuilderExterns.g_strv_builder_new();
	}

}


public static class GStrvBuilderExtensions
{
/// <summary>
/// <para>
/// Add a string to the end of the array.
/// </para>
/// <para>
/// Since 2.68
/// </para>
/// </summary>

/// <param name="builder">
/// a #GStrvBuilder
/// </param>
/// <param name="value">
/// a string.
/// </param>

	public static void Add(this MentorLake.GLib.GStrvBuilderHandle builder, string value)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GStrvBuilder)");
		GStrvBuilderExterns.g_strv_builder_add(builder, value);
	}

/// <summary>
/// <para>
/// Appends all the given strings to the builder.
/// </para>
/// <para>
/// Since 2.70
/// </para>
/// </summary>

/// <param name="builder">
/// a #GStrvBuilder
/// </param>
/// <param name="@__arglist">
/// one or more strings followed by %NULL
/// </param>

	public static void AddMany(this MentorLake.GLib.GStrvBuilderHandle builder, IntPtr @__arglist)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GStrvBuilder)");
		GStrvBuilderExterns.g_strv_builder_add_many(builder, @__arglist);
	}

/// <summary>
/// <para>
/// Appends all the strings in the given vector to the builder.
/// </para>
/// <para>
/// Since 2.70
/// </para>
/// </summary>

/// <param name="builder">
/// a #GStrvBuilder
/// </param>
/// <param name="value">
/// the vector of strings to add
/// </param>

	public static void Addv(this MentorLake.GLib.GStrvBuilderHandle builder, string[] value)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GStrvBuilder)");
		GStrvBuilderExterns.g_strv_builder_addv(builder, value);
	}

/// <summary>
/// <para>
/// Ends the builder process and returns the constructed NULL-terminated string
/// array. The returned value should be freed with g_strfreev() when no longer
/// needed.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GStrvBuilder
/// </param>
/// <return>
/// the constructed string array.
/// 
/// Since 2.68
/// </return>

	public static string[] End(this MentorLake.GLib.GStrvBuilderHandle builder)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GStrvBuilder)");
		return GStrvBuilderExterns.g_strv_builder_end(builder);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @builder by one.
/// This function is thread-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GStrvBuilder
/// </param>
/// <return>
/// The passed in #GStrvBuilder
/// </return>

	public static MentorLake.GLib.GStrvBuilderHandle Ref(this MentorLake.GLib.GStrvBuilderHandle builder)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GStrvBuilder)");
		return GStrvBuilderExterns.g_strv_builder_ref(builder);
	}

/// <summary>
/// <para>
/// Add a string to the end of the array. After @value belongs to the
/// #GStrvBuilder and may no longer be modified by the caller.
/// </para>
/// <para>
/// Since 2.80
/// </para>
/// </summary>

/// <param name="builder">
/// a #GStrvBuilder
/// </param>
/// <param name="value">
/// a string.
///     Ownership of the string is transferred to the #GStrvBuilder
/// </param>

	public static void Take(this MentorLake.GLib.GStrvBuilderHandle builder, string value)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GStrvBuilder)");
		GStrvBuilderExterns.g_strv_builder_take(builder, value);
	}

/// <summary>
/// <para>
/// Decreases the reference count on @builder.
/// </para>
/// <para>
/// In the event that there are no more references, releases all memory
/// associated with the #GStrvBuilder.
/// </para>
/// </summary>

/// <param name="builder">
/// a #GStrvBuilder allocated by g_strv_builder_new()
/// </param>

	public static void Unref(this MentorLake.GLib.GStrvBuilderHandle builder)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GStrvBuilder)");
		GStrvBuilderExterns.g_strv_builder_unref(builder);
	}

/// <summary>
/// <para>
/// Decreases the reference count on the string vector builder, and returns
/// its contents as a `NULL`-terminated string array.
/// </para>
/// <para>
/// This function is especially useful for cases where it&apos;s not possible
/// to use `g_autoptr()`.
/// </para>
/// <para>
/// ```c
/// GStrvBuilder *builder = g_strv_builder_new ();
/// g_strv_builder_add (builder, &quot;hello&quot;);
/// g_strv_builder_add (builder, &quot;world&quot;);
/// </para>
/// <para>
/// GStrv array = g_strv_builder_unref_to_strv (builder);
/// </para>
/// <para>
/// g_assert_true (g_strv_equal (array, (const char *[]) { &quot;hello&quot;, &quot;world&quot;, NULL }));
/// </para>
/// <para>
/// g_strfreev (array);
/// ```
/// </para>
/// </summary>

/// <param name="builder">
/// a #GStrvBuilder
/// </param>
/// <return>
/// the constructed string
///   array
/// </return>

	public static string[] UnrefToStrv(this MentorLake.GLib.GStrvBuilderHandle builder)
	{
		if (builder.IsInvalid) throw new Exception("Invalid handle (GStrvBuilder)");
		return GStrvBuilderExterns.g_strv_builder_unref_to_strv(builder);
	}


	public static GStrvBuilder Dereference(this GStrvBuilderHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GStrvBuilder>(x.DangerousGetHandle());
}
internal class GStrvBuilderExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStrvBuilderHandle>))]
	internal static extern MentorLake.GLib.GStrvBuilderHandle g_strv_builder_new();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_strv_builder_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStrvBuilderHandle>))] MentorLake.GLib.GStrvBuilderHandle builder, string value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_strv_builder_add_many([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStrvBuilderHandle>))] MentorLake.GLib.GStrvBuilderHandle builder, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_strv_builder_addv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStrvBuilderHandle>))] MentorLake.GLib.GStrvBuilderHandle builder, string[] value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_strv_builder_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStrvBuilderHandle>))] MentorLake.GLib.GStrvBuilderHandle builder);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStrvBuilderHandle>))]
	internal static extern MentorLake.GLib.GStrvBuilderHandle g_strv_builder_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStrvBuilderHandle>))] MentorLake.GLib.GStrvBuilderHandle builder);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_strv_builder_take([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStrvBuilderHandle>))] MentorLake.GLib.GStrvBuilderHandle builder, string value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_strv_builder_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStrvBuilderHandle>))] MentorLake.GLib.GStrvBuilderHandle builder);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_strv_builder_unref_to_strv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStrvBuilderHandle>))] MentorLake.GLib.GStrvBuilderHandle builder);

}

/// <summary>
/// <para>
/// `GStrvBuilder` is a helper object to build a %NULL-terminated string arrays.
/// </para>
/// <para>
/// The following example shows how to build a two element array:
/// </para>
/// <para>
/// ```c
///   g_autoptr(GStrvBuilder) builder = g_strv_builder_new ();
///   g_strv_builder_add (builder, &quot;hello&quot;);
///   g_strv_builder_add (builder, &quot;world&quot;);
/// </para>
/// <para>
///   g_auto(GStrv) array = g_strv_builder_end (builder);
/// </para>
/// <para>
///   g_assert_true (g_strv_equal (array, (const char *[]) { &quot;hello&quot;, &quot;world&quot;, NULL }));
/// ```
/// </para>
/// </summary>

public struct GStrvBuilder
{
}
