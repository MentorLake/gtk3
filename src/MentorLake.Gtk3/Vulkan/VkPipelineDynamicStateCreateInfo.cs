namespace MentorLake.Vulkan;


public class VkPipelineDynamicStateCreateInfoHandle : BaseSafeHandle
{
}


public static class VkPipelineDynamicStateCreateInfoExtensions
{

	public static VkPipelineDynamicStateCreateInfo Dereference(this VkPipelineDynamicStateCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineDynamicStateCreateInfo>(x.DangerousGetHandle());
}
internal class VkPipelineDynamicStateCreateInfoExterns
{
}


public struct VkPipelineDynamicStateCreateInfo
{
}
