namespace MentorLake.Gtk3.Bindings;

public enum GValueType : ulong
{
	Invalid = 0,
	None = 1 << 2,
	Interface = 2 << 2,
	Char = 3 << 2,
	Uchar = 4 << 2,
	Boolean = 5 << 2,
	Int = 6 << 2,
	Uint = 7 << 2,
	Long = 8 << 2,
	Ulong = 9 << 2,
	Int64 = 10 << 2,
	Uint64 = 11 << 2,
	Enum = 12 << 2,
	Flags = 13 << 2,
	Float = 14 << 2,
	Double = 15 << 2,
	String = 16 << 2,
	Pointer = 17 << 2,
	Boxed = 18 << 2,
	Param = 19 << 2,
	Object = 20 << 2,
	Variant = 21 << 2
}

public class GValueHelper
{
	public static GValueHandle Create(string s)
	{
		var handle = CreateEmpty(GValueType.String);
		handle.SetString(s);
		return handle;
	}

	public static GValueHandle Create(GValueType type)
	{
		return CreateEmpty(type);
	}

	private static GValueHandle CreateEmpty(GValueType type)
	{
		var valPtr = Marshal.AllocHGlobal(IntPtr.Size * 3);
		Marshal.WriteInt64(valPtr, 0);
		Marshal.WriteInt64(valPtr, 8, 0);
		Marshal.WriteInt64(valPtr, 16, 0);

		var handle = new GValueHandle();
		Marshal.InitHandle(handle, valPtr);
		handle.Init(new GType() { Value = (nuint) type });

		return handle;
	}
}
