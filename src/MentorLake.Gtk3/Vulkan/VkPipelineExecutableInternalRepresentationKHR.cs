namespace MentorLake.Vulkan;

public class VkPipelineExecutableInternalRepresentationKHRHandle : BaseSafeHandle
{
}


public static class VkPipelineExecutableInternalRepresentationKHRExtensions
{

	public static VkPipelineExecutableInternalRepresentationKHR Dereference(this VkPipelineExecutableInternalRepresentationKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineExecutableInternalRepresentationKHR>(x.DangerousGetHandle());
}
internal class VkPipelineExecutableInternalRepresentationKHRExterns
{
}

public struct VkPipelineExecutableInternalRepresentationKHR
{
}
