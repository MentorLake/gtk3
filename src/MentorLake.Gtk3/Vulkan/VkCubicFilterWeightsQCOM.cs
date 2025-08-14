namespace MentorLake.Vulkan;


public class VkCubicFilterWeightsQCOMHandle : BaseSafeHandle
{
}


public static class VkCubicFilterWeightsQCOMExtensions
{

	public static VkCubicFilterWeightsQCOM Dereference(this VkCubicFilterWeightsQCOMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCubicFilterWeightsQCOM>(x.DangerousGetHandle());
}
internal class VkCubicFilterWeightsQCOMExterns
{
}


public struct VkCubicFilterWeightsQCOM
{
}
