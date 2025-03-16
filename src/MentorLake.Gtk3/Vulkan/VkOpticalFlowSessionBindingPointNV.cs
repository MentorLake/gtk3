namespace MentorLake.Vulkan;

public class VkOpticalFlowSessionBindingPointNVHandle : BaseSafeHandle
{
}


public static class VkOpticalFlowSessionBindingPointNVExtensions
{

	public static VkOpticalFlowSessionBindingPointNV Dereference(this VkOpticalFlowSessionBindingPointNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOpticalFlowSessionBindingPointNV>(x.DangerousGetHandle());
}
internal class VkOpticalFlowSessionBindingPointNVExterns
{
}

public struct VkOpticalFlowSessionBindingPointNV
{
}
