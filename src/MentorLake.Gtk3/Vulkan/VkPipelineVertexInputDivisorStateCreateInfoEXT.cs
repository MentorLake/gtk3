namespace MentorLake.Vulkan;

public class VkPipelineVertexInputDivisorStateCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineVertexInputDivisorStateCreateInfoEXTExtensions
{

	public static VkPipelineVertexInputDivisorStateCreateInfoEXT Dereference(this VkPipelineVertexInputDivisorStateCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineVertexInputDivisorStateCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkPipelineVertexInputDivisorStateCreateInfoEXTExterns
{
}

public struct VkPipelineVertexInputDivisorStateCreateInfoEXT
{
}
