namespace MentorLake.Vulkan;


public class VkPipelineInputAssemblyStateCreateInfoHandle : BaseSafeHandle
{
}


public static class VkPipelineInputAssemblyStateCreateInfoExtensions
{

	public static VkPipelineInputAssemblyStateCreateInfo Dereference(this VkPipelineInputAssemblyStateCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineInputAssemblyStateCreateInfo>(x.DangerousGetHandle());
}
internal class VkPipelineInputAssemblyStateCreateInfoExterns
{
}


public struct VkPipelineInputAssemblyStateCreateInfo
{
}
