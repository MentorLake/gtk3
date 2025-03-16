namespace MentorLake.Gio;

public class GSettingsPrivateHandle : BaseSafeHandle
{
}


public static class GSettingsPrivateExtensions
{

	public static GSettingsPrivate Dereference(this GSettingsPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSettingsPrivate>(x.DangerousGetHandle());
}
internal class GSettingsPrivateExterns
{
}

public struct GSettingsPrivate
{
}
