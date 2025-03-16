namespace MentorLake.Vulkan;

public class VkPipelineColorWriteCreateInfoEXTHandle : BaseSafeHandle
{
}


public static class VkPipelineColorWriteCreateInfoEXTExtensions
{

	public static VkPipelineColorWriteCreateInfoEXT Dereference(this VkPipelineColorWriteCreateInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineColorWriteCreateInfoEXT>(x.DangerousGetHandle());
}
internal class VkPipelineColorWriteCreateInfoEXTExterns
{
}

public struct VkPipelineColorWriteCreateInfoEXT
{
}
