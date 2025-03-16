namespace MentorLake.Vulkan;

public class VkRenderPassStripeInfoARMHandle : BaseSafeHandle
{
}


public static class VkRenderPassStripeInfoARMExtensions
{

	public static VkRenderPassStripeInfoARM Dereference(this VkRenderPassStripeInfoARMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassStripeInfoARM>(x.DangerousGetHandle());
}
internal class VkRenderPassStripeInfoARMExterns
{
}

public struct VkRenderPassStripeInfoARM
{
}
