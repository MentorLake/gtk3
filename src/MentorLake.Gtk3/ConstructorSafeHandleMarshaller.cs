namespace MentorLake.Gtk3;

public sealed class ConstructorSafeHandleMarshaller<T> : ICustomMarshaler where T : BaseSafeHandle, new()
{
	private static readonly ConstructorSafeHandleMarshaller<T> s_instance = new();
	public static ICustomMarshaler GetInstance(string s) => s_instance;

	public void CleanUpManagedData(object o) { }
	public void CleanUpNativeData(IntPtr ptr) { }
	public int GetNativeDataSize() => IntPtr.Size;

	public IntPtr MarshalManagedToNative(object o)
	{
		var p = (SafeHandle)o;
		return p.DangerousGetHandle();
	}

	public object MarshalNativeToManaged(IntPtr ptr)
	{
		var safeHandle = new T();
		Marshal.InitHandle(safeHandle, ptr);
		if (safeHandle is GObjectHandle gObjectHandle) gObjectHandle.Init(false);
		return safeHandle;
	}
}
