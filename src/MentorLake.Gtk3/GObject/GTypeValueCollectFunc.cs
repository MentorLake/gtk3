namespace MentorLake.GObject;

/// <summary>
/// <para>
/// This function is responsible for converting the values collected from
/// a variadic argument list into contents suitable for storage in a #GValue.
/// </para>
/// <para>
/// This function should setup @value similar to #GTypeValueInitFunc; e.g.
/// for a string value that does not allow `NULL` pointers, it needs to either
/// emit an error, or do an implicit conversion by storing an empty string.
/// </para>
/// <para>
/// The @value passed in to this function has a zero-filled data array, so
/// just like for #GTypeValueInitFunc it is guaranteed to not contain any old
/// contents that might need freeing.
/// </para>
/// <para>
/// The @n_collect_values argument is the string length of the `collect_format`
/// field of #GTypeValueTable, and `collect_values` is an array of #GTypeCValue
/// with length of @n_collect_values, containing the collected values according
/// to `collect_format`.
/// </para>
/// <para>
/// The @collect_flags argument provided as a hint by the caller. It may
/// contain the flag %G_VALUE_NOCOPY_CONTENTS indicating that the collected
/// value contents may be considered ‘static’ for the duration of the @value
/// lifetime. Thus an extra copy of the contents stored in @collect_values is
/// not required for assignment to @value.
/// </para>
/// <para>
/// For our above string example, we continue with:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// if (!collect_values[0].v_pointer)
///   value->data[0].v_pointer = g_strdup ("");
/// else if (collect_flags & G_VALUE_NOCOPY_CONTENTS)
///   {
///     value->data[0].v_pointer = collect_values[0].v_pointer;
///     // keep a flag for the value_free() implementation to not free this string
///     value->data[1].v_uint = G_VALUE_NOCOPY_CONTENTS;
///   }
/// else
///   value->data[0].v_pointer = g_strdup (collect_values[0].v_pointer);
/// return NULL;
/// ]|
/// </para>
/// <para>
/// It should be noted, that it is generally a bad idea to follow the
/// %G_VALUE_NOCOPY_CONTENTS hint for reference counted types. Due to
/// reentrancy requirements and reference count assertions performed
/// by the signal emission code, reference counts should always be
/// incremented for reference counted contents stored in the `value->data`
/// array. To deviate from our string example for a moment, and taking
/// a look at an exemplary implementation for `GTypeValueTable.collect_value()`
/// of `GObject`:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// GObject *object = G_OBJECT (collect_values[0].v_pointer);
/// g_return_val_if_fail (object != NULL,
///    g_strdup_printf ("Object %p passed as invalid NULL pointer", object));
/// // never honour G_VALUE_NOCOPY_CONTENTS for ref-counted types
/// value->data[0].v_pointer = g_object_ref (object);
/// return NULL;
/// ]|
/// </para>
/// <para>
/// The reference count for valid objects is always incremented, regardless
/// of `collect_flags`. For invalid objects, the example returns a newly
/// allocated string without altering `value`.
/// </para>
/// <para>
/// Upon success, `collect_value()` needs to return `NULL`. If, however,
/// an error condition occurred, `collect_value()` should return a newly
/// allocated string containing an error diagnostic.
/// </para>
/// <para>
/// The calling code makes no assumptions about the `value` contents being
/// valid upon error returns, `value` is simply thrown away without further
/// freeing. As such, it is a good idea to not allocate `GValue` contents
/// prior to returning an error; however, `collect_values()` is not obliged
/// to return a correctly setup @value for error returns, simply because
/// any non-`NULL` return is considered a fatal programming error, and
/// further program behaviour is undefined.
/// </para>
/// </summary>

/// <param name="value">
/// the value to initialize
/// </param>
/// <param name="n_collect_values">
/// the number of collected values
/// </param>
/// <param name="collect_values">
/// the collected values
/// </param>
/// <param name="collect_flags">
/// optional flags
/// </param>
/// <return>
/// `NULL` on success, otherwise a
///   newly allocated error string on failure
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string GTypeValueCollectFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, uint n_collect_values, MentorLake.GObject.GTypeCValue[] collect_values, uint collect_flags);
