using NUnit.Framework;
using UnityEngine.XR;
using System.Collections.Generic;
namespace Nexora.Tests { public class XRCoreTests { [Test] public void RejectsNullList()=>Assert.Throws<System.ArgumentNullException>(()=>Nexora.XRCore.XRDevices.GetConnected(null)); [Test] public void DeviceEnumerationAcceptsList()=>Assert.DoesNotThrow(()=>Nexora.XRCore.XRDevices.GetConnected(new List<InputDevice>())); } }
