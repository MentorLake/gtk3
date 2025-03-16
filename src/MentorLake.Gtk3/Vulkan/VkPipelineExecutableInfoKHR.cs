namespace MentorLake.Vulkan;

public class VkPipelineExecutableInfoKHRHandle : BaseSafeHandle
{
}


public static class VkPipelineExecutableInfoKHRExtensions
{

	public static VkPipelineExecutableInfoKHR Dereference(this VkPipelineExecutableInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineExecutableInfoKHR>(x.DangerousGetHandle());
}
internal class VkPipelineExecutableInfoKHRExterns
{
}

public struct VkPipelineExecutableInfoKHR
{
}
