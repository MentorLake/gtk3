namespace MentorLake.Vulkan;


public class VkQueryPipelineStatisticFlagBitsHandle : BaseSafeHandle
{
}


public static class VkQueryPipelineStatisticFlagBitsExtensions
{

	public static VkQueryPipelineStatisticFlagBits Dereference(this VkQueryPipelineStatisticFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueryPipelineStatisticFlagBits>(x.DangerousGetHandle());
}
internal class VkQueryPipelineStatisticFlagBitsExterns
{
}


public struct VkQueryPipelineStatisticFlagBits
{
}
