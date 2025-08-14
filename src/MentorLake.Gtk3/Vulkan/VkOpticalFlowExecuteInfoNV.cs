namespace MentorLake.Vulkan;


public class VkOpticalFlowExecuteInfoNVHandle : BaseSafeHandle
{
}


public static class VkOpticalFlowExecuteInfoNVExtensions
{

	public static VkOpticalFlowExecuteInfoNV Dereference(this VkOpticalFlowExecuteInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOpticalFlowExecuteInfoNV>(x.DangerousGetHandle());
}
internal class VkOpticalFlowExecuteInfoNVExterns
{
}


public struct VkOpticalFlowExecuteInfoNV
{
}
