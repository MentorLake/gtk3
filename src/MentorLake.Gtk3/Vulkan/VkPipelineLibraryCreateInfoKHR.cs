namespace MentorLake.Vulkan;


public class VkPipelineLibraryCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkPipelineLibraryCreateInfoKHRExtensions
{

	public static VkPipelineLibraryCreateInfoKHR Dereference(this VkPipelineLibraryCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineLibraryCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkPipelineLibraryCreateInfoKHRExterns
{
}


public struct VkPipelineLibraryCreateInfoKHR
{
}
