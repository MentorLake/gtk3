namespace MentorLake.Vulkan;


public class VkPipelineRasterizationLineStateCreateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkPipelineRasterizationLineStateCreateInfoKHRExtensions
{

	public static VkPipelineRasterizationLineStateCreateInfoKHR Dereference(this VkPipelineRasterizationLineStateCreateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineRasterizationLineStateCreateInfoKHR>(x.DangerousGetHandle());
}
internal class VkPipelineRasterizationLineStateCreateInfoKHRExterns
{
}


public struct VkPipelineRasterizationLineStateCreateInfoKHR
{
}
