using System.Collections.Generic;
using UnityEngine.XR;
namespace Nexora.XRCore {
 public static class XRDevices {
  public static bool TryGetTrigger(XRNode node, out float value) {
   value=0f; var device=InputDevices.GetDeviceAtXRNode(node);
   return device.isValid && device.TryGetFeatureValue(CommonUsages.trigger,out value);
  }
  public static void GetConnected(List<InputDevice> devices) { if(devices==null) throw new System.ArgumentNullException(nameof(devices)); devices.Clear(); InputDevices.GetDevices(devices); }
 }
}
