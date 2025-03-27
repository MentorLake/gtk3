namespace MentorLake.Gtk3;

public sealed class ReadNullTerminatedArrayMarshaller<TMarshaller, TItem> : ICustomMarshaler where TMarshaller : ICustomMarshaler, new()
{
	private readonly TMarshaller _arrayItemMarshaller = new();
	private static readonly ReadNullTerminatedArrayMarshaller<TMarshaller, TItem> s_instance = new();

	public void CleanUpManagedData(object o)
	{

	}

	public void CleanUpNativeData(IntPtr ptr)
	{
	}

	public int GetNativeDataSize()
	{
		return IntPtr.Size;
	}

	public IntPtr MarshalManagedToNative(object o)
	{
		throw new NotImplementedException();
	}

	public object MarshalNativeToManaged(IntPtr arrayPtr)
	{
		var list = new List<TItem>();

		int offset = 0;
		while (true)
		{
			IntPtr ptr = Marshal.ReadIntPtr(arrayPtr, offset * IntPtr.Size);
			if (ptr == IntPtr.Zero) break;
			_arrayItemMarshaller.MarshalNativeToManaged(ptr);
			list.Add((TItem) _arrayItemMarshaller.MarshalNativeToManaged(ptr));
			offset++;
		}

		return list.ToArray();
	}

	public static ICustomMarshaler GetInstance(string s)
	{
		return s_instance;
	}
}
