namespace MentorLake.Vulkan;


public class VkOpticalFlowSessionNVHandle : BaseSafeHandle
{
}


public static class VkOpticalFlowSessionNVExtensions
{

	public static VkOpticalFlowSessionNV Dereference(this VkOpticalFlowSessionNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOpticalFlowSessionNV>(x.DangerousGetHandle());
}
internal class VkOpticalFlowSessionNVExterns
{
}


public struct VkOpticalFlowSessionNV
{
}
