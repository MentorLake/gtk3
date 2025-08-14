namespace MentorLake.Vulkan;


public class VkPipelineMultisampleStateCreateInfoHandle : BaseSafeHandle
{
}


public static class VkPipelineMultisampleStateCreateInfoExtensions
{

	public static VkPipelineMultisampleStateCreateInfo Dereference(this VkPipelineMultisampleStateCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineMultisampleStateCreateInfo>(x.DangerousGetHandle());
}
internal class VkPipelineMultisampleStateCreateInfoExterns
{
}


public struct VkPipelineMultisampleStateCreateInfo
{
}
