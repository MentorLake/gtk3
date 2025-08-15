namespace MentorLake.GObject;

/// <summary>
/// <para>
/// Initializes the value contents by setting the fields of the `value-&amp;gt;data`
/// array.
/// </para>
/// <para>
/// The data array of the #GValue passed into this function was zero-filled
/// with `memset()`, so no care has to be taken to free any old contents.
/// For example, in the case of a string value that may never be %NULL, the
/// implementation might look like:
/// </para>
/// <code>
/// value-&amp;gt;data[0].v_pointer = g_strdup (&quot;&quot;);
/// value-&amp;gt;data[0].v_pointer = g_strdup (&quot;&quot;);
/// </code>
/// </summary>

/// <param name="value">
/// the value to initialize
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTypeValueInitFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);
