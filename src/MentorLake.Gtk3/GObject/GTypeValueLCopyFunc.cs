namespace MentorLake.GObject;

/// <summary>
/// <para>
/// This function is responsible for storing the `value`
/// contents into arguments passed through a variadic argument list which
/// got collected into `collect_values` according to `lcopy_format`.
/// </para>
/// <para>
/// The `n_collect_values` argument equals the string length of
/// `lcopy_format`, and `collect_flags` may contain %G_VALUE_NOCOPY_CONTENTS.
/// </para>
/// <para>
/// In contrast to #GTypeValueCollectFunc, this function is obliged to always
/// properly support %G_VALUE_NOCOPY_CONTENTS.
/// </para>
/// <para>
/// Similar to #GTypeValueCollectFunc the function may prematurely abort by
/// returning a newly allocated string describing an error condition. To
/// complete the string example:
/// </para>
/// <code>
/// gchar **string_p = collect_values[0].v_pointer;
/// gchar **string_p = collect_values[0].v_pointer;
/// g_return_val_if_fail (string_p != NULL,
///   g_strdup (&quot;string location passed as NULL&quot;));
/// 
/// if (collect_flags &amp; G_VALUE_NOCOPY_CONTENTS)
///   *string_p = value-&amp;gt;data[0].v_pointer;
/// else
///   *string_p = g_strdup (value-&amp;gt;data[0].v_pointer);
/// </code>
/// <para>
/// And an illustrative version of this function for reference-counted
/// types:
/// </para>
/// <code>
/// GObject **object_p = collect_values[0].v_pointer;
/// GObject **object_p = collect_values[0].v_pointer;
/// g_return_val_if_fail (object_p != NULL,
///   g_strdup (&quot;object location passed as NULL&quot;));
/// 
/// if (value-&amp;gt;data[0].v_pointer == NULL)
///   *object_p = NULL;
/// else if (collect_flags &amp; G_VALUE_NOCOPY_CONTENTS) // always honour
///   *object_p = value-&amp;gt;data[0].v_pointer;
/// else
///   *object_p = g_object_ref (value-&amp;gt;data[0].v_pointer);
/// 
/// return NULL;
/// </code>
/// </summary>

/// <param name="value">
/// the value to lcopy
/// </param>
/// <param name="n_collect_values">
/// the number of collected values
/// </param>
/// <param name="collect_values">
/// the collected
///   locations for storage
/// </param>
/// <param name="collect_flags">
/// optional flags
/// </param>
/// <return>
/// `NULL` on success, otherwise
///   a newly allocated error string on failure
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string GTypeValueLCopyFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, uint n_collect_values, MentorLake.GObject.GTypeCValue[] collect_values, uint collect_flags);
