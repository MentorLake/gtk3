namespace MentorLake.Vulkan;

public class VkRenderPassStripeBeginInfoARMHandle : BaseSafeHandle
{
}


public static class VkRenderPassStripeBeginInfoARMExtensions
{

	public static VkRenderPassStripeBeginInfoARM Dereference(this VkRenderPassStripeBeginInfoARMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassStripeBeginInfoARM>(x.DangerousGetHandle());
}
internal class VkRenderPassStripeBeginInfoARMExterns
{
}

public struct VkRenderPassStripeBeginInfoARM
{
}
