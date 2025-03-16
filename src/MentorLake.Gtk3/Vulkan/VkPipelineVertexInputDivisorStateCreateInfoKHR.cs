namespace MentorLake.Vulkan;

public class VkPipelineVertexInputDivisorStateCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkPipelineVertexInputDivisorStateCreateInfoKHRExtensions
{

	public static VkPipelineVertexInputDivisorStateCreateInfoKHR Dereference(this VkPipelineVertexInputDivisorStateCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineVertexInputDivisorStateCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkPipelineVertexInputDivisorStateCreateInfoKHRExterns
{
}

public struct VkPipelineVertexInputDivisorStateCreateInfoKHR
{
}
