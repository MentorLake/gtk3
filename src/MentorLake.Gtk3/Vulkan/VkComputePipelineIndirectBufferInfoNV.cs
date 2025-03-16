namespace MentorLake.Vulkan;

public class VkComputePipelineIndirectBufferInfoNVHandle : BaseSafeHandle
{
}


public static class VkComputePipelineIndirectBufferInfoNVExtensions
{

	public static VkComputePipelineIndirectBufferInfoNV Dereference(this VkComputePipelineIndirectBufferInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkComputePipelineIndirectBufferInfoNV>(x.DangerousGetHandle());
}
internal class VkComputePipelineIndirectBufferInfoNVExterns
{
}

public struct VkComputePipelineIndirectBufferInfoNV
{
}
