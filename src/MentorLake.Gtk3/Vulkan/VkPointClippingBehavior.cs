namespace MentorLake.Vulkan;

public class VkPointClippingBehaviorHandle : BaseSafeHandle
{
}


public static class VkPointClippingBehaviorExtensions
{

	public static VkPointClippingBehavior Dereference(this VkPointClippingBehaviorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPointClippingBehavior>(x.DangerousGetHandle());
}
internal class VkPointClippingBehaviorExterns
{
}

public struct VkPointClippingBehavior
{
}
