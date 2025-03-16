namespace MentorLake.Vulkan;

public class VkQueryPipelineStatisticFlagsHandle : BaseSafeHandle
{
}


public static class VkQueryPipelineStatisticFlagsExtensions
{

	public static VkQueryPipelineStatisticFlags Dereference(this VkQueryPipelineStatisticFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueryPipelineStatisticFlags>(x.DangerousGetHandle());
}
internal class VkQueryPipelineStatisticFlagsExterns
{
}

public struct VkQueryPipelineStatisticFlags
{
}
