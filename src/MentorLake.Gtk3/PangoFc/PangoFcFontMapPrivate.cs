namespace MentorLake.PangoFc;

public class PangoFcFontMapPrivateHandle : BaseSafeHandle
{
}


public static class PangoFcFontMapPrivateExtensions
{

	public static PangoFcFontMapPrivate Dereference(this PangoFcFontMapPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoFcFontMapPrivate>(x.DangerousGetHandle());
}
internal class PangoFcFontMapPrivateExterns
{
}

public struct PangoFcFontMapPrivate
{
}
