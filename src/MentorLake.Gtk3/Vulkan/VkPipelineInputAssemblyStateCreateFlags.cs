namespace MentorLake.Vulkan;


public class VkPipelineInputAssemblyStateCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkPipelineInputAssemblyStateCreateFlagsExtensions
{

	public static VkPipelineInputAssemblyStateCreateFlags Dereference(this VkPipelineInputAssemblyStateCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineInputAssemblyStateCreateFlags>(x.DangerousGetHandle());
}
internal class VkPipelineInputAssemblyStateCreateFlagsExterns
{
}


public struct VkPipelineInputAssemblyStateCreateFlags
{
}
