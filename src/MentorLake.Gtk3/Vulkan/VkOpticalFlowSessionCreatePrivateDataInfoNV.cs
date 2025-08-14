namespace MentorLake.Vulkan;


public class VkOpticalFlowSessionCreatePrivateDataInfoNVHandle : BaseSafeHandle
{
}


public static class VkOpticalFlowSessionCreatePrivateDataInfoNVExtensions
{

	public static VkOpticalFlowSessionCreatePrivateDataInfoNV Dereference(this VkOpticalFlowSessionCreatePrivateDataInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOpticalFlowSessionCreatePrivateDataInfoNV>(x.DangerousGetHandle());
}
internal class VkOpticalFlowSessionCreatePrivateDataInfoNVExterns
{
}


public struct VkOpticalFlowSessionCreatePrivateDataInfoNV
{
}
