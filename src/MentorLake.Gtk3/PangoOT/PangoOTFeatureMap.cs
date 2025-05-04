namespace MentorLake.PangoOT;

public class PangoOTFeatureMapHandle : BaseSafeHandle
{
}


public static class PangoOTFeatureMapExtensions
{

	public static PangoOTFeatureMap Dereference(this PangoOTFeatureMapHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoOTFeatureMap>(x.DangerousGetHandle());
}
internal class PangoOTFeatureMapExterns
{
}

public struct PangoOTFeatureMap
{
	[MarshalAs(UnmanagedType.ByValArray)] public char[] feature_name;
	public ulong property_bit;
}
