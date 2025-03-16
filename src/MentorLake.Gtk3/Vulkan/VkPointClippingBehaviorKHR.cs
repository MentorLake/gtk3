namespace MentorLake.Vulkan;

public class VkPointClippingBehaviorKHRHandle : BaseSafeHandle
{
}


public static class VkPointClippingBehaviorKHRExtensions
{

	public static VkPointClippingBehaviorKHR Dereference(this VkPointClippingBehaviorKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPointClippingBehaviorKHR>(x.DangerousGetHandle());
}
internal class VkPointClippingBehaviorKHRExterns
{
}

public struct VkPointClippingBehaviorKHR
{
}
