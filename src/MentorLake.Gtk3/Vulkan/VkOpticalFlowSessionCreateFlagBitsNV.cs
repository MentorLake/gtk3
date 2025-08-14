namespace MentorLake.Vulkan;


public class VkOpticalFlowSessionCreateFlagBitsNVHandle : BaseSafeHandle
{
}


public static class VkOpticalFlowSessionCreateFlagBitsNVExtensions
{

	public static VkOpticalFlowSessionCreateFlagBitsNV Dereference(this VkOpticalFlowSessionCreateFlagBitsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOpticalFlowSessionCreateFlagBitsNV>(x.DangerousGetHandle());
}
internal class VkOpticalFlowSessionCreateFlagBitsNVExterns
{
}


public struct VkOpticalFlowSessionCreateFlagBitsNV
{
}
