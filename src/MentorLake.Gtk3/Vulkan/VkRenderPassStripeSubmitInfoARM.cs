namespace MentorLake.Vulkan;


public class VkRenderPassStripeSubmitInfoARMHandle : BaseSafeHandle
{
}


public static class VkRenderPassStripeSubmitInfoARMExtensions
{

	public static VkRenderPassStripeSubmitInfoARM Dereference(this VkRenderPassStripeSubmitInfoARMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRenderPassStripeSubmitInfoARM>(x.DangerousGetHandle());
}
internal class VkRenderPassStripeSubmitInfoARMExterns
{
}


public struct VkRenderPassStripeSubmitInfoARM
{
}
