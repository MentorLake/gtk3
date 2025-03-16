namespace MentorLake.Vulkan;

public class VkOpticalFlowSessionCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkOpticalFlowSessionCreateInfoNVExtensions
{

	public static VkOpticalFlowSessionCreateInfoNV Dereference(this VkOpticalFlowSessionCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOpticalFlowSessionCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkOpticalFlowSessionCreateInfoNVExterns
{
}

public struct VkOpticalFlowSessionCreateInfoNV
{
}
