namespace MentorLake.GObject;

/// <summary>
/// <para>
/// If the value contents fit into a pointer, such as objects or strings,
/// return this pointer, so the caller can peek at the current contents.
/// </para>
/// <para>
/// To extend on our above string example:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// return value->data[0].v_pointer;
/// ]|
/// </para>
/// </summary>

/// <param name="value">
/// the value to peek
/// </param>
/// <return>
/// a pointer to the value contents
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GTypeValuePeekPointerFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);
