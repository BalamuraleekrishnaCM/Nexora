using NUnit.Framework;
using UnityEditor;
namespace Nexora.Tests { public class ProjectDoctorTests { [Test] public void EntryPointExists()=>Assert.IsNotNull(typeof(Nexora.ProjectDoctor.ProjectDoctor).GetMethod("Run")); } }
