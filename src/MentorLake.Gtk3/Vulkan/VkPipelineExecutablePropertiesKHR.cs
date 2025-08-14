namespace MentorLake.Vulkan;


public class VkPipelineExecutablePropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkPipelineExecutablePropertiesKHRExtensions
{

	public static VkPipelineExecutablePropertiesKHR Dereference(this VkPipelineExecutablePropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineExecutablePropertiesKHR>(x.DangerousGetHandle());
}
internal class VkPipelineExecutablePropertiesKHRExterns
{
}


public struct VkPipelineExecutablePropertiesKHR
{
}
