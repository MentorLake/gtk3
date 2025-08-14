namespace MentorLake.Vulkan;


public class VkCoarseSampleOrderTypeNVHandle : BaseSafeHandle
{
}


public static class VkCoarseSampleOrderTypeNVExtensions
{

	public static VkCoarseSampleOrderTypeNV Dereference(this VkCoarseSampleOrderTypeNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCoarseSampleOrderTypeNV>(x.DangerousGetHandle());
}
internal class VkCoarseSampleOrderTypeNVExterns
{
}


public struct VkCoarseSampleOrderTypeNV
{
}
