namespace MentorLake.xlib;


public struct KeyCode
{
	public byte Value;
}


public class KeyCodeHandle : BaseSafeHandle
{
}

public static class KeyCodeHandleExtensions
{
	public static KeyCode Dereference(this KeyCodeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<KeyCode>(x.DangerousGetHandle());
	public static byte DereferenceValue(this KeyCodeHandle x) => x.Dereference().Value;
}
