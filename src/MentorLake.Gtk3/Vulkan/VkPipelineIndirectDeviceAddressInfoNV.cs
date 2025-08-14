namespace MentorLake.Vulkan;


public class VkPipelineIndirectDeviceAddressInfoNVHandle : BaseSafeHandle
{
}


public static class VkPipelineIndirectDeviceAddressInfoNVExtensions
{

	public static VkPipelineIndirectDeviceAddressInfoNV Dereference(this VkPipelineIndirectDeviceAddressInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineIndirectDeviceAddressInfoNV>(x.DangerousGetHandle());
}
internal class VkPipelineIndirectDeviceAddressInfoNVExterns
{
}


public struct VkPipelineIndirectDeviceAddressInfoNV
{
}
