namespace MentorLake.Soup;

/// <summary>
/// <para>
/// The interface implemented by [iface@SessionFeature]s.
/// </para>
/// </summary>

public class SoupSessionFeatureInterfaceHandle : BaseSafeHandle
{
}


public static class SoupSessionFeatureInterfaceExtensions
{

	public static SoupSessionFeatureInterface Dereference(this SoupSessionFeatureInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupSessionFeatureInterface>(x.DangerousGetHandle());
}
internal class SoupSessionFeatureInterfaceExterns
{
}

/// <summary>
/// <para>
/// The interface implemented by [iface@SessionFeature]s.
/// </para>
/// </summary>

public struct SoupSessionFeatureInterface
{
}
